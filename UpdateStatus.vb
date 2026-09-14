Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading.Tasks
Public Class UpdateStatus
    Private TargetRecordID As Integer
    Private OriginalStatus As String
    Private TargetFilePath As String

    ' Constructor catching the passed variables
    Public Sub New(recordID As Integer, currentStatus As String, filePath As String)
        InitializeComponent()

        TargetRecordID = recordID
        OriginalStatus = currentStatus
        TargetFilePath = filePath

        ' Populate combobox and set current status
        statuscombo.Items.Clear()
        statuscombo.Items.AddRange(New Object() {"Active", "Resolved"})
        statuscombo.SelectedItem = OriginalStatus
    End Sub

    Private Async Sub UpdateStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Failsafe: Check if someone deleted the file from the C: drive
            If Not File.Exists(TargetFilePath) Then
                recordpreview.Visible = False
                lblMissingWarning.Text = "The physical document is missing."
                lblMissingWarning.ForeColor = Color.Red
                lblMissingWarning.Visible = True
                Return
            End If

            ' Initialize WebView2 asynchronously and load the PDF
            Await recordpreview.EnsureCoreWebView2Async(Nothing)
            recordpreview.CoreWebView2.Navigate(TargetFilePath)

        Catch ex As Exception
            MessageBox.Show("Error loading PDF previewer: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Me.Close()
    End Sub

    Private Async Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        If statuscombo.SelectedIndex = -1 Then
            MessageBox.Show("Please select a status (Active or Resolved).", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim newStatus As String = statuscombo.SelectedItem.ToString()

        ' Efficiency Check: Don't hit the database if nothing changed
        If newStatus = OriginalStatus Then
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
            Return
        End If

        ' Important: Sever WebView2 file lock if we ever need to move/delete it later
        If recordpreview.CoreWebView2 IsNot Nothing Then
            recordpreview.CoreWebView2.Navigate("about:blank")
            Await Task.Delay(300)
        End If

        Try
            Dim query As String = "UPDATE Derogatory_Records_tbl SET Status = @Status WHERE RecordID = @RecordID"
            Dim parameters As SqlParameter() = {
                New SqlParameter("@Status", newStatus),
                New SqlParameter("@RecordID", TargetRecordID)
            }

            Dim rowsAffected As Integer = GlobalDatabase.ExecuteQuery(query, parameters)

            If rowsAffected > 0 Then
                MessageBox.Show("Derogatory record status successfully updated to " & newStatus & "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Failed to update record. It may have been deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class