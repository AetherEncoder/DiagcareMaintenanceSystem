Imports MySql.Data.MySqlClient

Public Partial Class frmSettings
    Private ReadOnly _connectionString As String
    Private _currentUsername As String

    Public ReadOnly Property UpdatedUsername As String
        Get
            Return _currentUsername
        End Get
    End Property

    Public Property AccountDeleted As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(connectionString As String, currentUsername As String)
        _connectionString = connectionString
        _currentUsername = currentUsername
        InitializeComponent()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = _currentUsername
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnSaveUsername_Click(sender As Object, e As EventArgs) Handles btnSaveUsername.Click
        Dim newUsername As String = txtUsername.Text.Trim()
        If String.IsNullOrWhiteSpace(newUsername) Then
            MessageBox.Show("Username is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return
        End If

        If String.Equals(newUsername, _currentUsername, StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("No username changes detected.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Using conn As New MySqlConnection(_connectionString)
                conn.Open()

                Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM USER WHERE username = @username", conn)
                    checkCmd.Parameters.AddWithValue("@username", newUsername)
                    If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                        MessageBox.Show("Username is already taken.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtUsername.Focus()
                        Return
                    End If
                End Using

                Using updateCmd As New MySqlCommand("UPDATE USER SET username = @newUsername WHERE username = @currentUsername", conn)
                    updateCmd.Parameters.AddWithValue("@newUsername", newUsername)
                    updateCmd.Parameters.AddWithValue("@currentUsername", _currentUsername)

                    If updateCmd.ExecuteNonQuery() = 0 Then
                        MessageBox.Show("Account was not found.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using
            End Using

            _currentUsername = newUsername
            MessageBox.Show("Username updated successfully.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Unable to update username: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSavePassword_Click(sender As Object, e As EventArgs) Handles btnSavePassword.Click
        Dim password As String = txtNewPassword.Text
        Dim retypePassword As String = txtRetypePassword.Text

        If String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Password is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNewPassword.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(retypePassword) Then
            MessageBox.Show("Retype password is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRetypePassword.Focus()
            Return
        End If

        If password <> retypePassword Then
            MessageBox.Show("Passwords do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRetypePassword.Focus()
            Return
        End If

        Try
            Using conn As New MySqlConnection(_connectionString)
                conn.Open()

                Using cmd As New MySqlCommand("UPDATE USER SET password = @password WHERE username = @username", conn)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.Parameters.AddWithValue("@username", _currentUsername)

                    If cmd.ExecuteNonQuery() = 0 Then
                        MessageBox.Show("Account was not found.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using
            End Using

            txtNewPassword.Text = ""
            txtRetypePassword.Text = ""
            MessageBox.Show("Password updated successfully.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Unable to update password: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click
        Dim confirm As DialogResult = MessageBox.Show("This will permanently delete your account. Continue?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm <> DialogResult.Yes Then
            Return
        End If

        Try
            Using conn As New MySqlConnection(_connectionString)
                conn.Open()

                Using cmd As New MySqlCommand("DELETE FROM USER WHERE username = @username", conn)
                    cmd.Parameters.AddWithValue("@username", _currentUsername)
                    If cmd.ExecuteNonQuery() = 0 Then
                        MessageBox.Show("Account was not found.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using
            End Using

            AccountDeleted = True
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to delete account: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class