Imports MySql.Data.MySqlClient

Public Class frmDashboard
    'Create connection variable/object named "MyConnection" 
    Dim MyConnection As Common.DbConnection

    'Create a Data Adapter variable/object
    '---A Data Adapter is the go-between for the connection object (MyConnection)
    'and the Dataset (borrowerDA)
    Dim adminDA As New MySqlDataAdapter

    'Create a Dataset variable/object
    '---A Data Set is a place holder for the table in your database
    '---There should be one data set for each table in your database
    Dim adminDS As New DataSet()

    'Declare the connection string and query variables/objects
    Dim MyConnectionString As String
    Dim adminSQLQuery As String

    'Store the logged-in username
    Dim loggedInUsername As String

    'We will use this later in the update and delete modules
    Dim row As Integer
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form initialization

        MyConnectionString = "datasource=localhost;username=root;password=;database=trustmed"

        ClearErrorMessages()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Clear previous error messages
        ClearErrorMessages()

        ' Validate input
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            lblUsernameError.Text = "Username is required"
            lblUsernameError.Visible = True
            txtUsername.Focus()
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            lblPasswordError.Text = "Password is required"
            lblPasswordError.Visible = True
            If isValid Then
                txtPassword.Focus()
            End If
            isValid = False
        End If

        If isValid Then
            adminSQLQuery = "SELECT * FROM admin WHERE username = @username AND password = @password"
            MyConnection = New MySqlConnection(MyConnectionString)

            Try
                MyConnection.Open()
                Dim cmd As New MySqlCommand(adminSQLQuery, MyConnection)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Close()
                    loggedInUsername = txtUsername.Text ' Store the logged-in username
                    ShowDashboard()
                Else
                    lblLoginError.Text = "Invalid username or password."
                    lblLoginError.Visible = True
                End If

                reader.Close()

            Catch ex As MySqlException
                lblLoginError.Text = "Database error: " & ex.Message
                lblLoginError.Visible = True
            Catch ex As Exception
                lblLoginError.Text = "An unexpected error occurred: " & ex.Message
                lblLoginError.Visible = True
            Finally
                If MyConnection.State = ConnectionState.Open Then
                    MyConnection.Close()
                End If
            End Try

        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ShowLoginPage()
    End Sub

    Private Sub ShowDashboard()
        ' Hide login panel and show dashboard
        pnlLoginContainer.Visible = False
        pnlDashboard.Visible = True

        ' Display logged-in user information
        lblLoggedInUser.Text = "Logged in as " & loggedInUsername

        ' Clear login fields
        txtUsername.Text = ""
        txtPassword.Text = ""
        ClearErrorMessages()
    End Sub

    Private Sub ShowLoginPage()
        ' Hide dashboard and show login panel
        pnlDashboard.Visible = False
        pnlLoginContainer.Visible = True

        ' Clear login fields
        txtUsername.Text = ""
        txtPassword.Text = ""
        ClearErrorMessages()

        ' Reset logged-in user label to placeholder
        lblLoggedInUser.Text = "Logged in as username"

        txtUsername.Focus()
    End Sub

    Private Sub ClearErrorMessages()
        lblUsernameError.Visible = False
        lblUsernameError.Text = ""
        lblPasswordError.Visible = False
        lblPasswordError.Text = ""
        lblLoginError.Visible = False
        lblLoginError.Text = ""
    End Sub
End Class
