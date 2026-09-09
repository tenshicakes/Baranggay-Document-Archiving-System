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

    End Sub
    Private Sub DashboardForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

End Class