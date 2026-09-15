Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class AddForm
    Private Sub AddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Lock the combobox so the Admin cannot type custom roles that might break the system
        rolecombo.DropDownStyle = ComboBoxStyle.DropDownList
        rolecombo.Items.Clear()
        rolecombo.Items.AddRange(New Object() {"Administrator", "Chairman", "Staff"})
    End Sub
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        ' Sanitize inputs by stripping out accidental trailing spaces
        Dim fullName As String = fullnametxt.Text.Trim()
        Dim username As String = usernametxt.Text.Trim()
        Dim password As String = passwordtxt.Text.Trim()
        Dim confirmPass As String = confirmpasstxt.Text.Trim()
        Dim role As String = If(rolecombo.SelectedItem IsNot Nothing, rolecombo.SelectedItem.ToString(), "")

        ' 1. Validation: Prevent Blanks
        If String.IsNullOrEmpty(fullName) OrElse String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(confirmPass) OrElse String.IsNullOrEmpty(role) Then
            MessageBox.Show("All fields must be completely filled out.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Validation: Password Length
        If password.Length < 8 Then
            MessageBox.Show("For security purposes, the password must be at least 8 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 3. Validation: Password Match
        If password <> confirmPass Then
            MessageBox.Show("The passwords do not match. Please re-type them carefully.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' 4. Validation: Check for Duplicate Usernames
            Dim checkQuery As String = "SELECT COUNT(*) FROM Users_tbl WHERE Username = @Username"
            Dim checkParams As SqlParameter() = {
                New SqlParameter("@Username", username)
            }

            Dim count As Integer = Convert.ToInt32(GlobalDatabase.ExecuteScalar(checkQuery, checkParams))
            If count > 0 Then
                MessageBox.Show("This username is already taken by another account. Please choose a different one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' 5. Security: Hash the password before saving
            Dim hashedPassword As String = HashPassword(password)

            ' 6. Execution: Insert the new user (IsActive defaults to 1 for new active accounts)
            Dim insertQuery As String = "INSERT INTO Users_tbl (Username, PasswordHash, FullName, Role, IsActive) VALUES (@Username, @PasswordHash, @FullName, @Role, 1)"
            Dim insertParams As SqlParameter() = {
                New SqlParameter("@Username", username),
                New SqlParameter("@PasswordHash", hashedPassword),
                New SqlParameter("@FullName", fullName),
                New SqlParameter("@Role", role)
            }

            Dim rowsAffected As Integer = GlobalDatabase.ExecuteQuery(insertQuery, insertParams)

            If rowsAffected > 0 Then
                MessageBox.Show("New user account successfully created!", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK ' Signals the Dashboard to refresh the grid
                Me.Close()
            Else
                MessageBox.Show("Failed to create the new user account. Please try again.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    ' ==========================================
    ' SHA256 PASSWORD HASHING UTILITY
    ' ==========================================
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)

            Dim sb As New StringBuilder()
            For Each b As Byte In hashBytes
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function
End Class