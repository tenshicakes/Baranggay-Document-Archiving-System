
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class EditForm
    ' Track the unique identifier and original values
    Private _targetUserID As Integer
    Private _originalFullName As String
    Private _originalUsername As String
    Private _originalRole As String

    ' Constructor catching the passed variables from DashboardForm
    Public Sub New(userID As Integer, fullName As String, username As String, role As String)
        InitializeComponent()

        _targetUserID = userID
        _originalFullName = fullName
        _originalUsername = username
        _originalRole = role

        ' Initialize and lock the Role combobox
        rolecomboedit.DropDownStyle = ComboBoxStyle.DropDownList
        rolecomboedit.Items.Clear()
        rolecomboedit.Items.AddRange(New Object() {"Administrator", "Chairman", "Staff"})

        ' Populate the UI Controls (Passwords remain blank intentionally)
        fullnamedit.Text = fullName
        usernameedit.Text = username
        rolecomboedit.SelectedItem = role
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Dim newFullName As String = fullnamedit.Text.Trim()
        Dim newUsername As String = usernameedit.Text.Trim()
        Dim newRole As String = If(rolecomboedit.SelectedItem IsNot Nothing, rolecomboedit.SelectedItem.ToString(), "")

        Dim newPassword As String = passwordedit.Text.Trim()
        Dim confirmPass As String = confirmpassedit.Text.Trim()

        ' 1. Basic Validation (Name, Username, Role cannot be empty)
        If String.IsNullOrEmpty(newFullName) OrElse String.IsNullOrEmpty(newUsername) OrElse String.IsNullOrEmpty(newRole) Then
            MessageBox.Show("Full Name, Username, and Role cannot be empty.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Determine if the user is trying to change the password
        Dim isChangingPassword As Boolean = False
        If Not String.IsNullOrEmpty(newPassword) OrElse Not String.IsNullOrEmpty(confirmPass) Then
            If newPassword.Length < 8 Then
                MessageBox.Show("The new password must be at least 8 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If newPassword <> confirmPass Then
                MessageBox.Show("The new passwords do not match. Please re-type them carefully.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            isChangingPassword = True
        End If

        ' 3. Efficiency Check: Did they actually change anything?
        If newFullName = _originalFullName AndAlso newUsername = _originalUsername AndAlso newRole = _originalRole AndAlso Not isChangingPassword Then
            Me.DialogResult = DialogResult.Cancel ' Silently close without hitting the DB
            Me.Close()
            Return
        End If

        Try
            ' 4. Check for Duplicate Usernames (ignoring their own current username)
            If newUsername <> _originalUsername Then
                Dim checkQuery As String = "SELECT COUNT(*) FROM Users_tbl WHERE Username = @Username AND UserID != @UserID"
                Dim checkParams As SqlParameter() = {
                    New SqlParameter("@Username", newUsername),
                    New SqlParameter("@UserID", _targetUserID)
                }

                Dim count As Integer = Convert.ToInt32(GlobalDatabase.ExecuteScalar(checkQuery, checkParams))
                If count > 0 Then
                    MessageBox.Show("This username is already taken by another account.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End If

            ' 5. Build Dynamic UPDATE Query based on whether the password is being changed
            Dim updateQuery As String
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@FullName", newFullName),
                New SqlParameter("@Username", newUsername),
                New SqlParameter("@Role", newRole),
                New SqlParameter("@UserID", _targetUserID)
            }

            If isChangingPassword Then
                updateQuery = "UPDATE Users_tbl SET FullName = @FullName, Username = @Username, Role = @Role, PasswordHash = @PasswordHash WHERE UserID = @UserID"
                parameters.Add(New SqlParameter("@PasswordHash", HashPassword(newPassword)))
            Else
                updateQuery = "UPDATE Users_tbl SET FullName = @FullName, Username = @Username, Role = @Role WHERE UserID = @UserID"
            End If

            ' 6. Execute Update
            Dim rowsAffected As Integer = GlobalDatabase.ExecuteQuery(updateQuery, parameters.ToArray())

            If rowsAffected > 0 Then
                MessageBox.Show("Account information successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Failed to update account. The record may have been deleted.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub EditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
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