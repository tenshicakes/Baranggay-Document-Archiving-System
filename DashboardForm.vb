Imports System.Drawing
Imports System.Data.SqlClient

Public Class DashboardForm
    Private CurrentUserRole As String
    Private CurrentFullName As String

    Public Sub New(role As String, name As String)
        InitializeComponent()

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
        residentspanel.Visible = True
        residentsbtn.BaseColor = Color.FromArgb(100, 151, 177)
        residentsbtn.ForeColor = Color.White
    End Sub

    Public Sub DisplayResidentsData(Optional searchTerm As String = "")
        Try
            Dim query As String
            Dim dt As DataTable

            If String.IsNullOrWhiteSpace(searchTerm) Then
                query = "SELECT ResidentID, FirstName, LastName, MiddleName, BirthDate FROM Resident_Master_tbl"
                dt = GlobalDatabase.GetTable(query)
            Else
                query = "SELECT ResidentID, FirstName, LastName, MiddleName, BirthDate FROM Resident_Master_tbl " &
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