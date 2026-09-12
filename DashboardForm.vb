Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Text.RegularExpressions

Public Class DashboardForm
    Private CurrentUserRole As String
    Private CurrentFullName As String
    Private CurrentUserID As Integer

    Public Sub New(userID As Integer, role As String, name As String)
        InitializeComponent()

        CurrentUserID = userID
        CurrentUserRole = role
        CurrentFullName = name

        rolelabel.Text = role
    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        homebtn_Click(sender, e)
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
        requestbtn.BaseColor = Color.FromArgb(100, 151, 177)
        requestbtn.ForeColor = Color.White
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
    End Sub

    '_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
    'SEARCH PAGE SEARCH PAGE SEARCH PAGE SEARCH PAGE SEARCH PAGE SEARCH PAGE SEARCH PAGE SEARCH PAGE
    '_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-
    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        ResetAllPanels()
        ResetAllButtons()
        RefreshEveryGrid()
        searchpanel.Visible = True
        searchbtn.BaseColor = Color.FromArgb(100, 151, 177)
        searchbtn.ForeColor = Color.White
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