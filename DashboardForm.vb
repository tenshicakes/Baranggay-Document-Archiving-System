Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Threading.Tasks


Public Class DashboardForm
    Private CurrentUserRole As String
    Private CurrentFullName As String
    Private CurrentUserID As Integer
    Private SelectedArchiveDocID As Integer
    Private SelectedScannedFilePath As String = ""
    Private SelectedArchiveCategory As String = ""

    Public Sub New(userID As Integer, role As String, name As String)
        InitializeComponent()

        CurrentUserID = userID
        CurrentUserRole = role
        CurrentFullName = name

        rolelabel.Text = role
    End Sub

    Private Async Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        homebtn_Click(sender, e)
        SetupRequestPage()
        SetupArchiveExplorer()

        Try
            Await pdfpreview_webview.EnsureCoreWebView2Async(Nothing)
        Catch ex As Exception
            MessageBox.Show("Failed to initialize the PDF Viewer. Please ensure Microsoft Edge WebView2 Runtime is installed on this PC.", "Viewer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DashboardForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    '_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_ RESET ALL -_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
    Private Sub ResetAllPanels()
        homepanel.Visible = False
        residentspanel.Visible = False
        requestpanel.Visible = False
        archivepanel.Visible = False
        searchpanel.Visible = False
        reportspanel.Visible = False
        accountspanel.Visible = False
        adminformpanel.Visible = False
    End Sub

    Private Sub ResetAllButtons()
        Dim defaultBase As Color = Color.White
        Dim defaultFore As Color = Color.Black

        homebtn.BaseColor = defaultBase
        homebtn.ForeColor = defaultFore

        residentsbtn.BaseColor = defaultBase
        residentsbtn.ForeColor = defaultFore

        requestbtn.BaseColor = defaultBase
        requestbtn.ForeColor = defaultFore

        archivebtn.BaseColor = defaultBase
        archivebtn.ForeColor = defaultFore

        searchbtn.BaseColor = defaultBase
        searchbtn.ForeColor = defaultFore

        reportsbtn.BaseColor = defaultBase
        reportsbtn.ForeColor = defaultFore

        accountsbtn.BaseColor = defaultBase
        accountsbtn.ForeColor = defaultFore
    End Sub

    '_-_-_-_-_-_-_-_-_-_-_-_-_-_-_- REFRESH EVERY GRID _-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
    Public Sub RefreshEveryGrid()
        DisplayResidentsData()
        ResidentsGridDesign()
        derogatorygrid.Refresh()

        DisplayRequestData()
        ApplyRequestGridDesign()
        ApplyDerogatoryGridDesign()

        DisplayApprovedRequestData()
        ApplyApprovedRequestDesign()

        LoadArchivedData()
        ApplyArchivedDesign()
    End Sub



    '_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
    'HOME PAGE HOME PAGE HOME PAGE HOME PAGE HOME PAGE HOME PAGE HOME PAGE HOME PAGE HOME PAGE 
    '_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        ResetAllPanels()
        ResetAllButtons()
        RefreshEveryGrid()
        homepanel.Visible = True
        homebtn.BaseColor = Color.FromArgb(100, 151, 177)
        homebtn.ForeColor = Color.White
    End Sub


    '_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
    'RESIDENTS PAGE RESIDENTS PAGE RESIDENTS PAGE RESIDENTS PAGE RESIDENTS PAGE RESIDENTS PAGE 
    '_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
    Private Sub residentsbtn_Click(sender As Object, e As EventArgs) Handles residentsbtn.Click
        ResetAllPanels()
        ResetAllButtons()
        RefreshEveryGrid()
        RegisterFormCharLimit()
        residentspanel.Visible = True
        residentsbtn.BaseColor = Color.FromArgb(100, 151, 177)
        residentsbtn.ForeColor = Color.White
    End Sub

    Public Sub DisplayResidentsData(Optional searchTerm As String = "")
        Try
            Dim query As String
            Dim dt As DataTable

            If String.IsNullOrWhiteSpace(searchTerm) Then
                query = "SELECT ResidentID, FirstName, LastName, MiddleName, Address, ContactNumber, BirthDate FROM Resident_Master_tbl"
                dt = GlobalDatabase.GetTable(query)
            Else
                query = "SELECT ResidentID, FirstName, LastName, MiddleName, Address, ContactNumber, BirthDate FROM Resident_Master_tbl " &
                    "WHERE FirstName LIKE @Search OR LastName LIKE @Search OR MiddleName LIKE @Search OR Address LIKE @Search"
                Dim parameters As SqlParameter() = {
                New SqlParameter("@Search", "%" & searchTerm.Trim() & "%")
            }
                dt = GlobalDatabase.GetTable(query, parameters)
            End If

            residentsdgv.DataSource = dt
            ResidentsGridDesign()

            ' Set Header Titles
            If residentsdgv.Columns.Count > 0 Then

                residentsdgv.Columns("ResidentID").Visible = False
                residentsdgv.Columns("Address").Visible = False
                residentsdgv.Columns("ContactNumber").Visible = False
                residentsdgv.Columns("FirstName").HeaderText = "First Name"
                residentsdgv.Columns("LastName").HeaderText = "Last Name"
                residentsdgv.Columns("MiddleName").HeaderText = "Middle Name"
                residentsdgv.Columns("BirthDate").HeaderText = "Birth Date"
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading resident records: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ResidentsGridDesign()
        ' Grid Fonts and Base Properties
        residentsdgv.EnableHeadersVisualStyles = False
        residentsdgv.Font = New Font("Nirmala UI", 12.0!, FontStyle.Regular)
        residentsdgv.RowTemplate.Height = 30

        ' Header Customization 
        residentsdgv.ColumnHeadersDefaultCellStyle.Font = New Font("Nirmala UI", 12.0!, FontStyle.Bold)
        residentsdgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 57, 108)
        residentsdgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        residentsdgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(3, 57, 108)
        residentsdgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White

        ' Row Selection Styling
        residentsdgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(3, 57, 108)
        residentsdgv.DefaultCellStyle.SelectionForeColor = Color.White

        ' Layout & Safety Rules
        residentsdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        residentsdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        residentsdgv.MultiSelect = False
        residentsdgv.ReadOnly = True
        residentsdgv.AllowUserToAddRows = False
    End Sub

    Private Sub residents_searchbtn_Click(sender As Object, e As EventArgs) Handles residents_searchbtn.Click

        If residents_searchbtn.Text = "Clear" Then
            residents_searchbar.Text = ""
            DisplayResidentsData()

            ' Default inactive state
            residents_searchbtn.Text = "Search"
            residents_searchbtn.BaseColor = Color.White
            residents_searchbtn.ForeColor = Color.Black
            Return
        End If


        Dim searchText As String = residents_searchbar.Text.Trim()

        If String.IsNullOrEmpty(searchText) Then
            MessageBox.Show("Please enter a name or address to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        DisplayResidentsData(searchText)

        ' Change button to active "Clear" state
        residents_searchbtn.Text = "Clear"
        residents_searchbtn.BaseColor = Color.Gray
        residents_searchbtn.ForeColor = Color.White
    End Sub

    Private Sub registerbtn_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        ' 1. Cleaning text inputs
        Dim firstName As String = firstnametxtbox.Text.Trim()
        Dim lastName As String = lastnametxtbox.Text.Trim()
        Dim midName As String = midnametxtbox.Text.Trim()
        Dim address As String = addresstxtbox.Text.Trim()
        Dim contactNo As String = numbertxtbox.Text.Trim()
        Dim mmStr As String = mmtxtbox.Text.Trim()
        Dim ddStr As String = ddtxtbox.Text.Trim()
        Dim yyyyStr As String = yyyytxtbox.Text.Trim()

        ' 2. Mandatory fields
        If String.IsNullOrEmpty(firstName) OrElse String.IsNullOrEmpty(lastName) OrElse String.IsNullOrEmpty(address) Then
            MessageBox.Show("Please fill in all mandatory fields (First Name, Last Name, and Address).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 3. Birthdate textboxes check
        If String.IsNullOrEmpty(mmStr) OrElse String.IsNullOrEmpty(ddStr) OrElse String.IsNullOrEmpty(yyyyStr) Then
            MessageBox.Show("Please complete all Birth Date fields (MM, DD, YYYY).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' YYYY-MM-DD date string and calendar logic
        Dim dateString As String = $"{yyyyStr.PadLeft(4, "0"c)}-{mmStr.PadLeft(2, "0"c)}-{ddStr.PadLeft(2, "0"c)}"
        Dim parsedBirthDate As Date

        If Not Date.TryParseExact(dateString, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, parsedBirthDate) Then
            MessageBox.Show("Please enter a valid calendar date (MM: 01-12, DD: 01-31, YYYY: 4 digits).", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Prevent impossible/future birth dates
        If parsedBirthDate > Date.Today OrElse parsedBirthDate.Year < 1900 Then
            MessageBox.Show("Please enter a valid historical Birth Date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' 4. Check for duplicate records before inserting
            Dim checkQuery As String = "SELECT COUNT(*) FROM Resident_Master_tbl WHERE FirstName = @FirstName AND LastName = @LastName AND BirthDate = @BirthDate"
            Dim checkParams As SqlParameter() = {
            New SqlParameter("@FirstName", firstName),
            New SqlParameter("@LastName", lastName),
            New SqlParameter("@BirthDate", parsedBirthDate)
        }

            Dim duplicateCount As Integer = Convert.ToInt32(GlobalDatabase.ExecuteScalar(checkQuery, checkParams))
            If duplicateCount > 0 Then
                Dim confirmDuplicate As DialogResult = MessageBox.Show("A resident with the exact same Name and Birth Date is already registered. Proceed anyway?", "Duplicate Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirmDuplicate = DialogResult.No Then Return
            End If

            ' 5. Execute INSERT query into Resident_Master_tbl
            Dim insertQuery As String = "INSERT INTO Resident_Master_tbl (FirstName, LastName, MiddleName, Address, ContactNumber, BirthDate) " &
                                    "VALUES (@FirstName, @LastName, @MiddleName, @Address, @ContactNumber, @BirthDate)"

            Dim insertParams As SqlParameter() = {
            New SqlParameter("@FirstName", firstName),
            New SqlParameter("@LastName", lastName),
            New SqlParameter("@MiddleName", If(String.IsNullOrEmpty(midName), DBNull.Value, CObj(midName))),
            New SqlParameter("@Address", address),
            New SqlParameter("@ContactNumber", If(String.IsNullOrEmpty(contactNo), DBNull.Value, CObj(contactNo))),
            New SqlParameter("@BirthDate", parsedBirthDate)
        }

            Dim rowsAffected As Integer = GlobalDatabase.ExecuteQuery(insertQuery, insertParams)

            If rowsAffected > 0 Then
                MessageBox.Show("Resident successfully registered!", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Clear the textboxes and refresh the dgv
                ClearRegistrationForm()
                DisplayResidentsData()
            Else
                MessageBox.Show("Failed to register resident. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Database error during registration: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RegisterFormCharLimit() Handles MyBase.Load
        mmtxtbox.MaxLength = 2
        ddtxtbox.MaxLength = 2
        yyyytxtbox.MaxLength = 4
    End Sub

    Private Sub RegistrationInputs_TextChanged(sender As Object, e As EventArgs) Handles _
    firstnametxtbox.TextChanged, lastnametxtbox.TextChanged, midnametxtbox.TextChanged,
    numbertxtbox.TextChanged, mmtxtbox.TextChanged, ddtxtbox.TextChanged, yyyytxtbox.TextChanged

        Dim txtBox = TryCast(sender, Control)
        If txtBox Is Nothing OrElse String.IsNullOrEmpty(txtBox.Text) Then Return

        '  Numbers-only for numbers/dates; Unicode letters, Ñ/ñ, spaces, hyphens, and apostrophes for names
        Dim isNumeric As Boolean = (txtBox Is numbertxtbox OrElse txtBox Is mmtxtbox OrElse txtBox Is ddtxtbox OrElse txtBox Is yyyytxtbox)
        Dim pattern As String = If(isNumeric, "[^0-9]", "[^\p{L} \-']")

        ' Dont allow copy pasting into the textbox, only type
        Dim cleanText As String = Regex.Replace(txtBox.Text, pattern, "")

        If txtBox.Text <> cleanText Then
            txtBox.Text = cleanText
            Try
                ' Always putting cursor at the end of the text 
                CType(txtBox, Object).SelectionStart = cleanText.Length
            Catch

            End Try
        End If
    End Sub
    Private Sub ClearRegistrationForm()
        firstnametxtbox.Text = ""
        lastnametxtbox.Text = ""
        midnametxtbox.Text = ""
        addresstxtbox.Text = ""
        numbertxtbox.Text = ""
        mmtxtbox.Text = ""
        ddtxtbox.Text = ""
        yyyytxtbox.Text = ""
    End Sub

    Private Sub newrequestbtn_Click(sender As Object, e As EventArgs) Handles newrequestbtn.Click
        ' Validate row selection
        If residentsdgv.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a resident from the list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Extract data from highlighted row
        Dim selectedRow As DataGridViewRow = residentsdgv.SelectedRows(0)
        Dim resID As Integer = Convert.ToInt32(selectedRow.Cells("ResidentID").Value)
        Dim fName As String = selectedRow.Cells("FirstName").Value.ToString()
        Dim mName As String = If(selectedRow.Cells("MiddleName").Value Is DBNull.Value, "", selectedRow.Cells("MiddleName").Value.ToString())
        Dim lName As String = selectedRow.Cells("LastName").Value.ToString()
        Dim fullName As String = $"{fName} {If(String.IsNullOrWhiteSpace(mName), "", mName & " ")}{lName}"
        Dim address As String = selectedRow.Cells("Address").Value.ToString()
        Dim bDate As String = Convert.ToDateTime(selectedRow.Cells("BirthDate").Value).ToString("yyyy-MM-dd")
        Dim contactNo As String = If(selectedRow.Cells("ContactNumber").Value Is DBNull.Value, "N/A", selectedRow.Cells("ContactNumber").Value.ToString())

        ' Open RequestForm modally and pass parameters
        Using reqForm As New RequestForm(resID, fullName, address, bDate, contactNo, CurrentFullName, CurrentUserID)
            reqForm.ShowDialog()
        End Using
    End Sub
    '_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
    'REQUEST PAGE REQUEST PAGE REQUEST PAGE REQUEST PAGE REQUEST PAGE REQUEST PAGE REQUEST PAGE
    '_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
    Private Sub requestbtn_Click(sender As Object, e As EventArgs) Handles requestbtn.Click
        ResetAllPanels()
        ResetAllButtons()
        RefreshEveryGrid()
        requestpanel.Visible = True
        adminformpanel.Visible = False
        requestbtn.BaseColor = Color.FromArgb(100, 151, 177)
        requestbtn.ForeColor = Color.White
    End Sub

    Private Sub SetupRequestPage()
        request_filtercombo.Items.Clear()
        request_filtercombo.Items.AddRange(New Object() {"Pending", "Approved", "Denied", "All"})
        request_filtercombo.SelectedItem = "Pending" ' Default view for a clean desk

        DisplayRequestData()
    End Sub

    Private Sub DisplayRequestData()
        Try
            ' 1. Determine active filters
            Dim searchTerm As String = request_searchbar.Text.Trim()
            Dim statusFilter As String = If(request_filtercombo.SelectedItem IsNot Nothing, request_filtercombo.SelectedItem.ToString(), "Pending")

            ' 2. Construct the INNER JOIN query to retrieve the Resident's Full Name alongside Document data
            Dim query As String = "SELECT d.DocumentID, d.ResidentID, " &
                              "(r.FirstName + ' ' + ISNULL(r.MiddleName + ' ', '') + r.LastName) AS FullName, " &
                              "d.DocumentType, d.Category, d.Status, d.RequestDate " &
                              "FROM Documents_tbl d " &
                              "INNER JOIN Resident_Master_tbl r ON d.ResidentID = r.ResidentID " &
                              "WHERE 1=1"

            Dim parameters As New List(Of SqlParameter)()

            ' Apply Search Filter
            If Not String.IsNullOrEmpty(searchTerm) Then
                query &= " AND (r.FirstName LIKE @Search OR r.LastName LIKE @Search)"
                parameters.Add(New SqlParameter("@Search", "%" & searchTerm & "%"))
            End If

            ' Apply Status Filter
            If statusFilter <> "All" Then
                query &= " AND d.Status = @Status"
                parameters.Add(New SqlParameter("@Status", statusFilter))
            End If

            ' Order by oldest pending requests first
            query &= " ORDER BY d.RequestDate ASC"

            ' 3. Execute and Bind
            Dim dt As DataTable = GlobalDatabase.GetTable(query, parameters.ToArray())
            requestrecorddgv.DataSource = dt

            ' 4. Apply Columns and Nirmala UI Styling
            If requestrecorddgv.Columns.Count > 0 Then
                requestrecorddgv.Columns("DocumentID").Visible = False
                requestrecorddgv.Columns("ResidentID").Visible = False

                requestrecorddgv.Columns("FullName").HeaderText = "Resident Name"
                requestrecorddgv.Columns("DocumentType").HeaderText = "Document Type"
                requestrecorddgv.Columns("Category").HeaderText = "Category"
                requestrecorddgv.Columns("Status").HeaderText = "Status"
                requestrecorddgv.Columns("RequestDate").HeaderText = "Date Requested"
            End If

            ApplyRequestGridDesign()

        Catch ex As Exception
            MessageBox.Show("Error loading request records: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ApplyRequestGridDesign()
        requestrecorddgv.EnableHeadersVisualStyles = False
        requestrecorddgv.Font = New Font("Nirmala UI", 12.0!, FontStyle.Regular)
        requestrecorddgv.RowTemplate.Height = 30


        requestrecorddgv.ColumnHeadersDefaultCellStyle.Font = New Font("Nirmala UI", 12.0!, FontStyle.Bold)
        requestrecorddgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 57, 108)
        requestrecorddgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        requestrecorddgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(3, 57, 108)
        requestrecorddgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White

        requestrecorddgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(3, 57, 108)
        requestrecorddgv.DefaultCellStyle.SelectionForeColor = Color.White

        requestrecorddgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        requestrecorddgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        requestrecorddgv.MultiSelect = False
        requestrecorddgv.ReadOnly = True
        requestrecorddgv.AllowUserToAddRows = False
    End Sub

    Private Sub request_searchbtn_Click(sender As Object, e As EventArgs) Handles request_searchbtn.Click
        If request_searchbtn.Text = "Clear" Then
            request_searchbar.Text = ""
            request_searchbtn.Text = "Search"
            request_searchbtn.BaseColor = Color.White
            request_searchbtn.ForeColor = Color.Black
            DisplayRequestData()
            Return
        End If

        If String.IsNullOrWhiteSpace(request_searchbar.Text) Then
            MessageBox.Show("Please enter a name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        request_searchbtn.Text = "Clear"
        request_searchbtn.BaseColor = Color.Gray
        request_searchbtn.ForeColor = Color.White
        DisplayRequestData()
    End Sub

    Private Sub request_filterbtn_Click(sender As Object, e As EventArgs) Handles request_filterbtn.Click
        If request_filterbtn.Text = "Clear" Then
            request_filtercombo.SelectedItem = "Pending" ' Revert to clean desk default
            request_filterbtn.Text = "Filter"
            request_filterbtn.BaseColor = Color.White
            request_filterbtn.ForeColor = Color.Black
            DisplayRequestData()
            Return
        End If

        request_filterbtn.Text = "Clear"
        request_filterbtn.BaseColor = Color.Gray
        request_filterbtn.ForeColor = Color.White
        DisplayRequestData()
    End Sub

    Private Sub approvebtn_Click(sender As Object, e As EventArgs) Handles approvebtn.Click
        ExecuteRequestAction("Approved", "approve")
    End Sub

    Private Sub denybtn_Click(sender As Object, e As EventArgs) Handles denybtn.Click
        ExecuteRequestAction("Denied", "deny")
    End Sub


    Private Sub ExecuteRequestAction(newStatus As String, actionName As String)
        If requestrecorddgv.SelectedRows.Count = 0 Then
            MessageBox.Show($"Please select a request to {actionName}.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = requestrecorddgv.SelectedRows(0)
        Dim currentStatus As String = selectedRow.Cells("Status").Value.ToString()

        ' Prevent double-processing
        If currentStatus <> "Pending" Then
            MessageBox.Show($"This request is already marked as {currentStatus} and cannot be {actionName}d again.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim docID As Integer = Convert.ToInt32(selectedRow.Cells("DocumentID").Value)
        Dim residentName As String = selectedRow.Cells("FullName").Value.ToString()
        Dim docType As String = selectedRow.Cells("DocumentType").Value.ToString()

        Dim confirm As DialogResult = MessageBox.Show($"Are you sure you want to {actionName} the {docType} for {residentName}?", $"Confirm {newStatus}", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.No Then Return

        Try
            Dim query As String = "UPDATE Documents_tbl SET Status = @Status WHERE DocumentID = @DocumentID"
            Dim parameters As SqlParameter() = {
            New SqlParameter("@Status", newStatus),
            New SqlParameter("@DocumentID", docID)
        }

            Dim rowsAffected As Integer = GlobalDatabase.ExecuteQuery(query, parameters)

            If rowsAffected > 0 Then
                MessageBox.Show($"Request successfully {newStatus}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DisplayRequestData() ' Instantly removes the row from the 'Pending' view
            Else
                MessageBox.Show($"Failed to {actionName} request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show($"Database error updating status: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub requestrecorddgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles requestrecorddgv.CellDoubleClick
        ' 1. Guardrails
        If e.RowIndex < 0 Then Return ' Prevent crash if the user double-clicks the header row
        If CurrentUserRole <> "Administrator" Then Return ' Strict RBAC: Staff clicks are ignored

        ' 2. Extract anchor data from the clicked row
        Dim selectedRow As DataGridViewRow = requestrecorddgv.Rows(e.RowIndex)
        Dim residentID As Integer = Convert.ToInt32(selectedRow.Cells("ResidentID").Value)
        Dim fullName As String = selectedRow.Cells("FullName").Value.ToString()

        ' 3. Unhide the Verification Panel
        adminformpanel.Visible = True

        Try
            ' 4. Fetch the Resident's personal details for the labels
            Dim resQuery As String = "SELECT Address, BirthDate, ContactNumber FROM Resident_Master_tbl WHERE ResidentID = @ResidentID"
            Dim resParams As SqlParameter() = {New SqlParameter("@ResidentID", residentID)}
            Dim resDt As DataTable = GlobalDatabase.GetTable(resQuery, resParams)

            If resDt.Rows.Count > 0 Then
                Dim row As DataRow = resDt.Rows(0)
                residentnamelbl.Text = fullName
                addresslbl.Text = row("Address").ToString()
                birthdatelbl.Text = Convert.ToDateTime(row("BirthDate")).ToString("yyyy-MM-dd")
                phonenumlbl.Text = If(row("ContactNumber") Is DBNull.Value, "N/A", row("ContactNumber").ToString())
            End If

            ' 5. Fetch the Derogatory Records
            Dim derQuery As String = "SELECT RecordID, DateLogged, Status FROM Derogatory_Records_tbl WHERE ResidentID = @ResidentID ORDER BY DateLogged DESC"
            Dim derParams As SqlParameter() = {New SqlParameter("@ResidentID", residentID)}
            Dim derDt As DataTable = GlobalDatabase.GetTable(derQuery, derParams)

            derogatorygrid.DataSource = derDt

            ' 6. Apply Nirmala UI Styling and Headers
            If derogatorygrid.Columns.Count > 0 Then
                derogatorygrid.Columns("DateLogged").HeaderText = "Date"
                derogatorygrid.Columns("Status").HeaderText = "Status"
                derogatorygrid.Columns("RecordID").HeaderText = "Record ID"

            End If
            ApplyDerogatoryGridDesign()



        Catch ex As Exception
            MessageBox.Show("Error loading verification details: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ApplyDerogatoryGridDesign()
        derogatorygrid.EnableHeadersVisualStyles = False
        derogatorygrid.Font = New Font("Nirmala UI", 12.0!, FontStyle.Regular)
        derogatorygrid.RowTemplate.Height = 30

        derogatorygrid.ColumnHeadersDefaultCellStyle.Font = New Font("Nirmala UI", 12.0!, FontStyle.Bold)
        derogatorygrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 57, 108)
        derogatorygrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        derogatorygrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(3, 57, 108)
        derogatorygrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White

        derogatorygrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(3, 57, 108)
        derogatorygrid.DefaultCellStyle.SelectionForeColor = Color.White

        derogatorygrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        derogatorygrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        derogatorygrid.MultiSelect = False
        derogatorygrid.ReadOnly = True
        derogatorygrid.AllowUserToAddRows = False
    End Sub

    Private Sub closeadminformbtn_Click(sender As Object, e As EventArgs) Handles closeadminformbtn.Click
        adminformpanel.Visible = False
    End Sub



    '_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
    'ARCHIVE PAGE ARCHIVE PAGE ARCHIVE PAGE ARCHIVE PAGE ARCHIVE PAGE ARCHIVE PAGE ARCHIVE PAGE
    '_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
    Private Sub archivebtn_Click(sender As Object, e As EventArgs) Handles archivebtn.Click
        ResetAllPanels()
        ResetAllButtons()
        RefreshEveryGrid()
        archivepanel.Visible = True
        archivebtn.BaseColor = Color.FromArgb(100, 151, 177)
        archivebtn.ForeColor = Color.White
        archive_residentnamelbl.Text = "NO USER SELECTED"
    End Sub

    Public Sub DisplayApprovedRequestData(Optional searchTerm As String = "")
        Try
            ' Strict filter: Only show 'Approved' requests, ignoring 'Archived' history
            Dim query As String = "SELECT d.DocumentID, d.ResidentID, " &
                              "(r.FirstName + ' ' + ISNULL(r.MiddleName + ' ', '') + r.LastName) AS FullName, " &
                              "d.DocumentType, d.Category, d.RequestDate " &
                              "FROM Documents_tbl d " &
                              "INNER JOIN Resident_Master_tbl r ON d.ResidentID = r.ResidentID " &
                              "WHERE d.Status = 'Approved'"

            Dim parameters As New List(Of SqlParameter)()

            If Not String.IsNullOrWhiteSpace(searchTerm) Then
                query &= " AND (r.FirstName LIKE @Search OR r.LastName LIKE @Search)"
                parameters.Add(New SqlParameter("@Search", "%" & searchTerm.Trim() & "%"))
            End If

            query &= " ORDER BY d.RequestDate ASC"

            Dim dt As DataTable = GlobalDatabase.GetTable(query, parameters.ToArray())
            approvedreqgrid.DataSource = dt

            ' Format Columns
            If approvedreqgrid.Columns.Count > 0 Then
                approvedreqgrid.Columns("DocumentID").Visible = False
                approvedreqgrid.Columns("ResidentID").Visible = False
                approvedreqgrid.Columns("FullName").HeaderText = "Resident Name"
                approvedreqgrid.Columns("DocumentType").HeaderText = "Document Type"
                approvedreqgrid.Columns("Category").HeaderText = "Category"
                approvedreqgrid.Columns("RequestDate").HeaderText = "Date Approved"
            End If

            ApplyApprovedRequestDesign()

        Catch ex As Exception
            MessageBox.Show("Error loading approved requests: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ApplyApprovedRequestDesign()
        approvedreqgrid.EnableHeadersVisualStyles = False
        approvedreqgrid.Font = New Font("Nirmala UI", 12.0!, FontStyle.Regular)
        approvedreqgrid.RowTemplate.Height = 30
        approvedreqgrid.ColumnHeadersDefaultCellStyle.Font = New Font("Nirmala UI", 12.0!, FontStyle.Bold)
        approvedreqgrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 57, 108)
        approvedreqgrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        approvedreqgrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(3, 57, 108)
        approvedreqgrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White
        approvedreqgrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(3, 57, 108)
        approvedreqgrid.DefaultCellStyle.SelectionForeColor = Color.White
        approvedreqgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        approvedreqgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        approvedreqgrid.MultiSelect = False
        approvedreqgrid.ReadOnly = True
        approvedreqgrid.AllowUserToAddRows = False
    End Sub

    Private Sub archive_searchbtn_Click(sender As Object, e As EventArgs) Handles archive_searchbtn.Click

        If archive_searchbtn.Text = "Clear" Then
            archive_searchbar.Text = ""
            DisplayApprovedRequestData()
            archive_searchbtn.Text = "Search"
            archive_searchbtn.BaseColor = Color.White
            archive_searchbtn.ForeColor = Color.Black
            Return
        End If

        Dim searchText As String = archive_searchbar.Text.Trim()
        If String.IsNullOrEmpty(searchText) Then
            MessageBox.Show("Please enter a resident's name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        DisplayApprovedRequestData(searchText)

        archive_searchbtn.Text = "Clear"
        archive_searchbtn.BaseColor = Color.Gray
        archive_searchbtn.ForeColor = Color.White
    End Sub

    Private Sub newarchivebtn_Click(sender As Object, e As EventArgs) Handles newarchivebtn.Click
        If approvedreqgrid.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an approved request from the list.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = approvedreqgrid.SelectedRows(0)
        SelectedArchiveCategory = selectedRow.Cells("Category").Value.ToString()

        SelectedArchiveDocID = Convert.ToInt32(selectedRow.Cells("DocumentID").Value)

        archive_residentnamelbl.Text = selectedRow.Cells("FullName").Value.ToString()

    End Sub

    Private Sub attachfilebtn_Click(sender As Object, e As EventArgs) Handles attachfilebtn.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Title = "Select Scanned Document"
            ' Strictly filter for PDFs and standard image types
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"

            ' Optional: Force it to open directly to the scanner's default output folder
            ' openFileDialog.InitialDirectory = "C:\Users\Secretary\Documents\Scans\"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' 1. Store the exact file path for the final Archive logic
                SelectedScannedFilePath = openFileDialog.FileName

                ' 2. Guardrail: Ensure WebView2 has finished booting up
                If pdfpreview_webview.CoreWebView2 IsNot Nothing Then
                    ' Load the file into the previewer
                    pdfpreview_webview.CoreWebView2.Navigate(SelectedScannedFilePath)
                Else
                    MessageBox.Show("The PDF Viewer is still booting up. Please wait a few seconds and try again.", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End Using
    End Sub

    Private Sub archive_removebtn_Click(sender As Object, e As EventArgs) Handles archive_removebtn.Click
        If pdfpreview_webview.CoreWebView2 IsNot Nothing Then
            ' Navigate to a blank page to release the Windows file lock!
            pdfpreview_webview.CoreWebView2.Navigate("about:blank")
        End If

        SelectedScannedFilePath = ""

    End Sub

    Private Async Sub archive_archivebtn_Click(sender As Object, e As EventArgs) Handles archive_archivebtn.Click
        ' 1. Guardrails & Validation
        If SelectedArchiveDocID = 0 Then
            MessageBox.Show("No valid document selected. Please select a row from the queue.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim orNumber As String = ornumber_txtbox.Text.Trim()
        If String.IsNullOrEmpty(orNumber) Then
            MessageBox.Show("Please enter the Official Receipt (OR) Number to verify payment.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrEmpty(SelectedScannedFilePath) OrElse Not File.Exists(SelectedScannedFilePath) Then
            MessageBox.Show("Please attach a valid scanned document before archiving.", "Attachment Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Release WebView2 File Lock (CRITICAL)
        If pdfpreview_webview.CoreWebView2 IsNot Nothing Then
            pdfpreview_webview.CoreWebView2.Navigate("about:blank")
            ' Give Windows 500 milliseconds to sever the connection to the PDF
            Await Task.Delay(500)
        End If

        Try
            ' 3. Generate Reference Number & Prepare File Paths
            Dim referenceNumber As String = "REF-" & DateTime.Now.ToString("yyyyMMddHHmmss")
            Dim fileExtension As String = Path.GetExtension(SelectedScannedFilePath)
            Dim newFileName As String = referenceNumber & fileExtension

            Dim vaultDir As String
            If SelectedArchiveCategory = "Justice & Incident Records" Then
                vaultDir = "C:\BarangayArchivingVault\DerogatoryRecords\"
            Else
                vaultDir = "C:\BarangayArchivingVault\GeneralRecords\"
            End If

            Dim finalFilePath As String = Path.Combine(vaultDir, newFileName)

            ' Fail-safe: Auto-build the folder if someone deleted it
            If Not Directory.Exists(vaultDir) Then
                Directory.CreateDirectory(vaultDir)
            End If

            ' 4. Copy the file into the secure vault and rename it
            File.Copy(SelectedScannedFilePath, finalFilePath, overwrite:=False)

            ' ==========================================
            ' NEW LOGIC: DEROGATORY RECORD INSERTION
            ' ==========================================
            If SelectedArchiveCategory = "Justice & Incident Records" Then
                ' Grab the ResidentID tied to this specific Document request
                Dim getResQuery As String = "SELECT ResidentID FROM Documents_tbl WHERE DocumentID = @DocID"
                Dim resParams As SqlParameter() = {New SqlParameter("@DocID", SelectedArchiveDocID)}
                Dim activeResID As Integer = Convert.ToInt32(GlobalDatabase.ExecuteScalar(getResQuery, resParams))

                ' Insert into the Derogatory table using the new FilePath column
                Dim derQuery As String = "INSERT INTO Derogatory_Records_tbl (ResidentID, FilePath, DateLogged, Status) VALUES (@ResID, @FilePath, GETDATE(), 'Active')"
                Dim derParams As SqlParameter() = {
                    New SqlParameter("@ResID", activeResID),
                    New SqlParameter("@FilePath", finalFilePath)
                }
                GlobalDatabase.ExecuteQuery(derQuery, derParams)
            End If
            ' ==========================================

            ' 5. Execute Database UPDATE for the Main Document
            Dim query As String = "UPDATE Documents_tbl SET Status = 'Archived', ORNumber = @ORNum, ReferenceNumber = @RefNum, FilePath = @FilePath, ProcessedBy = @ProcessedBy WHERE DocumentID = @DocumentID"

            Dim parameters As SqlParameter() = {
                New SqlParameter("@ORNum", orNumber),
                New SqlParameter("@RefNum", referenceNumber),
                New SqlParameter("@FilePath", finalFilePath),
                New SqlParameter("@ProcessedBy", CurrentUserID),
                New SqlParameter("@DocumentID", SelectedArchiveDocID)
            }

            Dim rowsAffected As Integer = GlobalDatabase.ExecuteQuery(query, parameters)

            If rowsAffected > 0 Then
                MessageBox.Show($"Document successfully archived!" & vbCrLf & $"Reference Number: {referenceNumber}", "Archiving Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' 6. UI Reset: Clear the form and refresh the To-Do list
                SelectedArchiveDocID = 0
                SelectedArchiveCategory = ""
                SelectedScannedFilePath = ""
                ornumber_txtbox.Text = ""
                archive_residentnamelbl.Text = "NO USER SELECTED"

                DisplayApprovedRequestData()
            Else
                MessageBox.Show("Database update failed. The file was copied, but the record was not updated.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("A critical error occurred during archiving: " & ex.Message, "Archiving Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
    'SEARCH PAGE SEARCH PAGE SEARCH PAGE SEARCH PAGE SEARCH PAGE SEARCH PAGE SEARCH PAGE SEARCH PAGE
    '_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        ResetAllPanels()
        ResetAllButtons()
        RefreshEveryGrid()
        SetupArchiveExplorer()
        searchpanel.Visible = True
        searchbtn.BaseColor = Color.FromArgb(100, 151, 177)
        searchbtn.ForeColor = Color.White
    End Sub

    Private Sub SetupArchiveExplorer()
        ' Document Type Combobox
        search_filtercombo.Items.Clear()
        search_filtercombo.Items.AddRange(New Object() {"Barangay Clearance", "Certificate of Residency", "Certificate of Indigency", "Business Permit Record", "Barangay ID Record"})
        search_filtercombo.SelectedIndex = -1

        ' DatePickers start unchecked (disabled until the user specifically wants to filter by date)
        search_FromDate.Checked = False
        search_ToDate.Checked = False

        LoadArchivedData()
    End Sub

    Private Sub LoadArchivedData()
        Try
            ' 1. The Base Query (Strictly 'Archived' status + LEFT JOIN for Staff Name)
            Dim query As String = "SELECT d.DocumentID, d.ResidentID, r.FirstName, r.LastName, r.MiddleName, " &
                              "(r.FirstName + ' ' + ISNULL(r.MiddleName + ' ', '') + r.LastName) AS FullName, " &
                              "d.Category, d.DocumentType, d.ORNumber, d.ReferenceNumber, d.RequestDate, " &
                              "d.ProcessedBy, u.FullName AS ProcessedByName, d.FilePath " &
                              "FROM Documents_tbl d " &
                              "INNER JOIN Resident_Master_tbl r ON d.ResidentID = r.ResidentID " &
                              "LEFT JOIN Users_tbl u ON d.ProcessedBy = u.UserID " &
                              "WHERE d.Status = 'Archived'"

            Dim parameters As New List(Of SqlParameter)()

            ' 2. Apply Text Search Filter (Matches Resident Name OR Reference Number)
            Dim searchTerm As String = search_searchbar.Text.Trim()
            If Not String.IsNullOrEmpty(searchTerm) AndAlso search_searchbtn.Text = "Clear" Then
                query &= " AND (r.FirstName LIKE @Search OR r.LastName LIKE @Search OR d.ReferenceNumber LIKE @Search)"
                parameters.Add(New SqlParameter("@Search", "%" & searchTerm & "%"))
            End If

            ' 3. Apply Document Type Filter
            If search_filtercombo.SelectedIndex <> -1 AndAlso search_filterbtn.Text = "Clear" Then
                query &= " AND d.DocumentType = @DocType"
                parameters.Add(New SqlParameter("@DocType", search_filtercombo.SelectedItem.ToString()))
            End If

            ' 4. Apply Date Range Filters (Only if the internal checkbox is checked)
            If search_FromDate.Checked Then
                query &= " AND d.RequestDate >= @FromDate"
                ' Set time to 00:00:00 of the selected day
                parameters.Add(New SqlParameter("@FromDate", search_FromDate.Value.Date))
            End If

            If search_ToDate.Checked Then
                query &= " AND d.RequestDate <= @ToDate"
                ' Set time to 23:59:59 to include the entire end day
                parameters.Add(New SqlParameter("@ToDate", search_ToDate.Value.Date.AddDays(1).AddTicks(-1)))
            End If

            query &= " ORDER BY d.RequestDate DESC"
            Dim dt As DataTable = GlobalDatabase.GetTable(query, parameters.ToArray())
            archiveddgv.DataSource = dt

            If archiveddgv.Columns.Count > 0 Then
                ' Hidden columns 
                archiveddgv.Columns("DocumentID").Visible = False
                archiveddgv.Columns("ResidentID").Visible = False
                archiveddgv.Columns("Category").Visible = False
                archiveddgv.Columns("ORNumber").Visible = False
                archiveddgv.Columns("ProcessedBy").Visible = False
                archiveddgv.Columns("FullName").Visible = False
                archiveddgv.Columns("FilePath").Visible = False
                archiveddgv.Columns("ProcessedByName").Visible = False

                ' Displayed columns
                archiveddgv.Columns("ReferenceNumber").HeaderText = "Ref Number"
                archiveddgv.Columns("FirstName").HeaderText = "First Name"
                archiveddgv.Columns("LastName").HeaderText = "Last Name"
                archiveddgv.Columns("MiddleName").HeaderText = "M.I."
                archiveddgv.Columns("DocumentType").HeaderText = "Document Type"
                archiveddgv.Columns("RequestDate").HeaderText = "Date Archived"
            End If

            ApplyArchivedDesign()

        Catch ex As Exception
            MessageBox.Show("Error loading archive records: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ApplyArchivedDesign()
        archiveddgv.EnableHeadersVisualStyles = False
        archiveddgv.Font = New Font("Nirmala UI", 11.0!, FontStyle.Regular)
        archiveddgv.RowTemplate.Height = 30
        archiveddgv.ColumnHeadersDefaultCellStyle.Font = New Font("Nirmala UI", 11.0!, FontStyle.Bold)
        archiveddgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(3, 57, 108)
        archiveddgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        archiveddgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(3, 57, 108)
        archiveddgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(3, 57, 108)
        archiveddgv.DefaultCellStyle.SelectionForeColor = Color.White
        archiveddgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        archiveddgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        archiveddgv.MultiSelect = False
        archiveddgv.ReadOnly = True
        archiveddgv.AllowUserToAddRows = False
    End Sub

    Private Sub search_searchbtn_Click(sender As Object, e As EventArgs) Handles search_searchbtn.Click
        If search_searchbtn.Text = "Clear" Then
            ' Reset
            search_searchbar.Text = ""
            search_searchbtn.Text = "Search"
            search_searchbtn.BaseColor = Color.FromArgb(100, 151, 177)
            search_searchbtn.ForeColor = Color.White
        Else
            ' Validate and apply
            If String.IsNullOrWhiteSpace(search_searchbar.Text) Then
                MessageBox.Show("Please enter a name or reference number to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            search_searchbtn.Text = "Clear"
            search_searchbtn.BaseColor = Color.Gray
            search_searchbtn.ForeColor = Color.White
        End If
        LoadArchivedData()
    End Sub

    Private Sub search_filterbtn_Click(sender As Object, e As EventArgs) Handles search_filterbtn.Click
        If search_filterbtn.Text = "Clear" Then
            ' Reset
            search_filtercombo.SelectedIndex = -1
            search_filterbtn.Text = "Filter"
            search_filterbtn.BaseColor = Color.FromArgb(100, 151, 177)
            search_filterbtn.ForeColor = Color.White
        Else
            ' Validate and apply
            If search_filtercombo.SelectedIndex = -1 Then
                MessageBox.Show("Please select a document type to filter.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            search_filterbtn.Text = "Clear"
            search_filterbtn.BaseColor = Color.Gray
            search_filterbtn.ForeColor = Color.White
        End If
        LoadArchivedData()
    End Sub

    Private Sub DateFilters_ValueChanged(sender As Object, e As EventArgs) Handles search_FromDate.ValueChanged, search_ToDate.ValueChanged
        LoadArchivedData()
    End Sub


    '_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
    'REPORTS PAGE REPORTS PAGE REPORTS PAGE REPORTS PAGE REPORTS PAGE REPORTS PAGE REPORTS PAGE
    '_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
    Private Sub reportsbtn_Click(sender As Object, e As EventArgs) Handles reportsbtn.Click
        ResetAllPanels()
        ResetAllButtons()
        RefreshEveryGrid()
        reportspanel.Visible = True
        reportsbtn.BaseColor = Color.FromArgb(100, 151, 177)
        reportsbtn.ForeColor = Color.White
    End Sub


    ''_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
    ' ACCOUNTS PAGE ACCOUNTS PAGE ACCOUNTS PAGE ACCOUNTS PAGE ACCOUNTS PAGE ACCOUNTS PAGE ACCOUNTS PAGE
    '_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_- 

    Private Sub accountsbtn_Click(sender As Object, e As EventArgs) Handles accountsbtn.Click
        ResetAllPanels()
        ResetAllButtons()
        RefreshEveryGrid()
        accountspanel.Visible = True
        accountsbtn.BaseColor = Color.FromArgb(100, 151, 177)
        accountsbtn.ForeColor = Color.White
    End Sub
End Class