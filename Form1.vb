Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class login


    ' ________________LOGIN FUNCTION____________________
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim inputUsername As String = usertxtbox.Text.Trim()
        Dim plainPassword As String = passtxtbox.Text.Trim()

        ' 1. Prevent Empty Submissions
        If String.IsNullOrEmpty(inputUsername) OrElse String.IsNullOrEmpty(plainPassword) Then
            MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' 2. THE FIX: Hash the input password to match the cryptographic string in the database
            Dim hashedInputPassword As String = HashPassword(plainPassword)

            ' 3. Query the user and check if they are active (IsActive = 1)
            Dim query As String = "SELECT UserID, FullName, Role, IsActive FROM Users_tbl WHERE Username = @Username AND PasswordHash = @PasswordHash"
            Dim parameters As SqlParameter() = {
                New SqlParameter("@Username", inputUsername),
                New SqlParameter("@PasswordHash", hashedInputPassword)
            }

            Dim dtUser As DataTable = GlobalDatabase.GetTable(query, parameters)

            ' 4. Login Validation
            If dtUser.Rows.Count > 0 Then
                Dim isActive As Boolean = Convert.ToBoolean(dtUser.Rows(0)("IsActive"))

                ' Soft-Delete Guardrail
                If Not isActive Then
                    MessageBox.Show("This account has been deactivated. Please contact the administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Extract the logged-in user's details to pass to the dashboard
                Dim userID As Integer = Convert.ToInt32(dtUser.Rows(0)("UserID"))
                Dim role As String = dtUser.Rows(0)("Role").ToString()
                Dim fullName As String = dtUser.Rows(0)("FullName").ToString()

                MessageBox.Show($"Welcome, {fullName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' 5. Open the Dashboard and hide the Login form
                Dim dash As New DashboardForm(userID, role, fullName)
                dash.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Database connection error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ==========================================
    ' SHA256 PASSWORD HASHING UTILITY
    ' ==========================================
    ' This replicates the exact hashing mechanism used in your Accounts Page
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)

            Dim sb As New StringBuilder()
            For Each b As Byte In hashBytes
                sb.Append(b.ToString("x2")) ' Convert byte to hex string
            Next
            Return sb.ToString()
        End Using
    End Function











    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


End Class
