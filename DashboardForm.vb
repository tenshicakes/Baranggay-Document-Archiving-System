Imports System.Drawing


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

    'Reset All 
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

    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        ResetAllPanels()
        ResetAllButtons()
        homepanel.Visible = True
        homebtn.BaseColor = Color.FromArgb(100, 151, 177)
        homebtn.ForeColor = Color.White
    End Sub

    Private Sub residentsbtn_Click(sender As Object, e As EventArgs) Handles residentsbtn.Click
        ResetAllPanels()
        ResetAllButtons()
        residentspanel.Visible = True
        residentsbtn.BaseColor = Color.FromArgb(100, 151, 177)
        residentsbtn.ForeColor = Color.White
    End Sub

    Private Sub requestbtn_Click(sender As Object, e As EventArgs) Handles requestbtn.Click
        ResetAllPanels()
        ResetAllButtons()
        requestpanel.Visible = True
        requestbtn.BaseColor = Color.FromArgb(100, 151, 177)
        requestbtn.ForeColor = Color.White
    End Sub

    Private Sub archivebtn_Click(sender As Object, e As EventArgs) Handles archivebtn.Click
        ResetAllPanels()
        ResetAllButtons()
        archivepanel.Visible = True
        archivebtn.BaseColor = Color.FromArgb(100, 151, 177)
        archivebtn.ForeColor = Color.White
    End Sub

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        ResetAllPanels()
        ResetAllButtons()
        searchpanel.Visible = True
        searchbtn.BaseColor = Color.FromArgb(100, 151, 177)
        searchbtn.ForeColor = Color.White
    End Sub

    Private Sub reportsbtn_Click(sender As Object, e As EventArgs) Handles reportsbtn.Click
        ResetAllPanels()
        ResetAllButtons()
        reportspanel.Visible = True
        reportsbtn.BaseColor = Color.FromArgb(100, 151, 177)
        reportsbtn.ForeColor = Color.White
    End Sub

    Private Sub accountsbtn_Click(sender As Object, e As EventArgs) Handles accountsbtn.Click
        ResetAllPanels()
        ResetAllButtons()
        accountspanel.Visible = True
        accountsbtn.BaseColor = Color.FromArgb(100, 151, 177)
        accountsbtn.ForeColor = Color.White
    End Sub
End Class