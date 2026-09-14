Imports System.Data.SqlClient
Public Class RequestForm
    Private SelectedResidentID As Integer
    Private LoggedInUserID As String

    ' Constructor accepting parameters passed from DashboardForm
    Public Sub New(residentID As Integer, fullName As String, address As String, birthDate As String, contactNo As String, currentUser As String, currentUserID As Integer)
        InitializeComponent()

        SelectedResidentID = residentID
        LoggedInUserID = currentUserID

        ' Populate labels
        fullnamelbl.Text = fullName
        addresslbl.Text = address
        birthdatelbl.Text = birthDate
        numberlbl.Text = contactNo
    End Sub

    Private Sub RequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Document Categories
        documentcat_combo.Items.Clear()
        documentcat_combo.Items.Add("General Certifications")
        documentcat_combo.Items.Add("Business & Livelihood")
        documentcat_combo.Items.Add("Identity Documents")
        documentcat_combo.SelectedIndex = -1
        documenttype_combo.Items.Clear()
    End Sub
    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Me.Close()
    End Sub

    Private Sub documentcat_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles documentcat_combo.SelectedIndexChanged
        documenttype_combo.Items.Clear()

        If documentcat_combo.SelectedItem Is Nothing Then Return

        Select Case documentcat_combo.SelectedItem.ToString()
            Case "General Certifications"
                documenttype_combo.Items.AddRange(New Object() {"Barangay Clearance", "Certificate of Residency", "Certificate of Indigency"})
            Case "Business & Livelihood"
                documenttype_combo.Items.AddRange(New Object() {"Business Permit Record"})
            Case "Identity Documents"
                documenttype_combo.Items.AddRange(New Object() {"Barangay ID Record"})
            Case "Justice & Incident Records"
                documenttype_combo.Items.AddRange(New Object() {"Blotter Report", "Others"})
        End Select

        documenttype_combo.SelectedIndex = -1
    End Sub

    Private Sub submitreqbtn_Click(sender As Object, e As EventArgs) Handles submitreqbtn.Click
        If documentcat_combo.SelectedIndex = -1 OrElse documenttype_combo.SelectedIndex = -1 Then
            MessageBox.Show("Please select both a Document Category and Document Type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedDocType As String = documenttype_combo.SelectedItem.ToString()

        Try
            ' Block duplicate 'Pending' requests if it is the same document type for the same resident
            Dim checkQuery As String = "SELECT COUNT(*) FROM Documents_tbl WHERE ResidentID = @ResidentID AND DocumentType = @DocumentType AND Status = 'Pending'"
            Dim checkParams As SqlParameter() = {
                New SqlParameter("@ResidentID", SelectedResidentID),
                New SqlParameter("@DocumentType", selectedDocType)
            }

            Dim pendingCount As Integer = Convert.ToInt32(GlobalDatabase.ExecuteScalar(checkQuery, checkParams))

            If pendingCount > 0 Then
                MessageBox.Show($"This resident already has an active 'Pending' request for a {selectedDocType}. Please wait for the Chairman to resolve the current request.", "Duplicate Request Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Execute INSERT query into Documents_tbl
            Dim insertQuery As String = "INSERT INTO Documents_tbl (ResidentID, DocumentType, Category, Status, ORNumber, ReferenceNumber, FilePath, RequestDate, ProcessedBy) " &
                                        "VALUES (@ResidentID, @DocumentType, @Category, 'Pending', NULL, NULL, NULL, GETDATE(), @ProcessedBy)"

            Dim insertParams As SqlParameter() = {
                New SqlParameter("@ResidentID", SelectedResidentID),
                New SqlParameter("@DocumentType", selectedDocType),
                New SqlParameter("@Category", documentcat_combo.SelectedItem.ToString()),
                New SqlParameter("@ProcessedBy", LoggedInUserID)
            }

            Dim rowsAffected As Integer = GlobalDatabase.ExecuteQuery(insertQuery, insertParams)

            If rowsAffected > 0 Then
                MessageBox.Show("Document request successfully submitted as Pending!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Failed to submit document request. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Database error submitting request: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class