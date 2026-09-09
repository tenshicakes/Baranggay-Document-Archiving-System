Imports System.Data.SqlClient
Public Class login


    ' ________________LOGIN FUNCTION____________________
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim inputUsername As String = usertxtbox.Text.Trim()
        Dim inputPassword As String = passtxtbox.Text.Trim()

        ' 1. Prevent Empty Submissions
        If String.IsNullOrEmpty(inputUsername) OrElse String.IsNullOrEmpty(inputPassword) Then
            MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' 2. Query the user and check if they are active (IsActive = 1)
            Dim query As String = "SELECT UserID, FullName, Role, IsActive FROM Users_tbl WHERE Username = @Username AND PasswordHash = @Password"
            Dim parameters As SqlParameter() = {
                New SqlParameter("@Username", inputUsername),
                New SqlParameter("@Password", inputPassword)
            }

            Dim dtUser As DataTable = GlobalDatabase.GetTable(query, parameters)

            ' 3. Login Validation
            If dtUser.Rows.Count > 0 Then
                Dim isActive As Boolean = Convert.ToBoolean(dtUser.Rows(0)("IsActive"))

                If Not isActive Then
                    MessageBox.Show("This account has been deactivated. Please contact the administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Optional: Store the logged-in user's details to pass to the dashboard
                Dim role As String = dtUser.Rows(0)("Role").ToString()
                Dim fullName As String = dtUser.Rows(0)("FullName").ToString()

                MessageBox.Show($"Welcome, {fullName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' 4. Open the Dashboard and hide the Login form
                Dim dash As New DashboardForm(role, fullName)
                dash.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Database connection error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub











    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


End Class
