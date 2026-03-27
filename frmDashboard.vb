Imports System.Data
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmDashboard
    'Create connection variable/object named "MyConnection" 
    Dim MyConnection As Common.DbConnection

    'Create a Data Adapter variable/object
    '---A Data Adapter is the go-between for the connection object (MyConnection)
    'and the Dataset (borrowerDA)
    Dim userDA As New MySqlDataAdapter

    'Create a Dataset variable/object
    '---A Data Set is a place holder for the table in your database
    '---There should be one data set for each table in your database
    Dim userDS As New DataSet()

    'Declare the connection string and query variables/objects
    Dim MyConnectionString As String
    Dim userSQLQuery As String

    'We will use this later in the update and delete modules
    Dim row As Integer

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyConnectionString = "datasource=localhost;username=root;password=;database=trustmed"

        Dim logoCandidates As String() = {
            Path.Combine(Application.StartupPath, "src\TrustMed.png"),
            Path.GetFullPath(Path.Combine(Application.StartupPath, "..\src\TrustMed.png")),
            Path.GetFullPath(Path.Combine(Application.StartupPath, "..\..\src\TrustMed.png"))
        }

        For Each logoPath As String In logoCandidates
            If File.Exists(logoPath) Then
                pbTrustMedLogo.Image = Image.FromFile(logoPath)
                Exit For
            End If
        Next

        If pbTrustMedLogo.Image Is Nothing AndAlso Me.Icon IsNot Nothing Then
            pbTrustMedLogo.Image = Me.Icon.ToBitmap()
        End If

        ClearErrorMessages()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ClearErrorMessages()

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
            userSQLQuery = "SELECT * FROM USER WHERE username = @username AND password = @password"
            MyConnection = New MySqlConnection(MyConnectionString)

            Try
                MyConnection.Open()
                Dim cmd As New MySqlCommand(userSQLQuery, CType(MyConnection, MySqlConnection))
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Close()
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
                If MyConnection IsNot Nothing AndAlso MyConnection.State = ConnectionState.Open Then
                    MyConnection.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub miAccountLogout_Click(sender As Object, e As EventArgs) Handles miAccountLogout.Click
        ShowLoginPage()
    End Sub

    Private Sub btnNewPatient_Click(sender As Object, e As EventArgs) Handles btnNewPatient.Click
        ShowQuickActionPlaceholder("New Patient")
    End Sub

    Private Sub btnNewDiagnosis_Click(sender As Object, e As EventArgs) Handles btnNewDiagnosis.Click
        ShowQuickActionPlaceholder("New Diagnosis")
    End Sub

    Private Sub btnNewConsultation_Click(sender As Object, e As EventArgs) Handles btnNewConsultation.Click
        ShowQuickActionPlaceholder("New Consultation")
    End Sub

    Private Sub btnNewLabOrder_Click(sender As Object, e As EventArgs) Handles btnNewLabOrder.Click
        ShowQuickActionPlaceholder("New Lab Order")
    End Sub

    Private Sub btnNewPrescription_Click(sender As Object, e As EventArgs) Handles btnNewPrescription.Click
        ShowQuickActionPlaceholder("New Prescription")
    End Sub

    Private Sub ShowQuickActionPlaceholder(actionName As String)
        MessageBox.Show(actionName & " form will be connected in the next module.", "Quick Action", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowDashboard()
        pnlLoginContainer.Visible = False
        pnlDashboard.Visible = True

        txtUsername.Text = ""
        txtPassword.Text = ""
        ClearErrorMessages()

        LoadDashboardOverview()
    End Sub

    Private Sub ShowLoginPage()
        pnlDashboard.Visible = False
        pnlLoginContainer.Visible = True

        txtUsername.Text = ""
        txtPassword.Text = ""
        ClearErrorMessages()

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

    Private Sub LoadDashboardOverview()
        Try
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            userSQLQuery = "SELECT COUNT(*) FROM patient"
            Dim cmd As New MySqlCommand(userSQLQuery, CType(MyConnection, MySqlConnection))
            lblTotalPatientsValue.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()

            userSQLQuery = "SELECT COUNT(*) FROM lab_order"
            cmd = New MySqlCommand(userSQLQuery, CType(MyConnection, MySqlConnection))
            lblLabOrdersValue.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString()

        Catch ex As MySqlException
            lblTotalPatientsValue.Text = "0"
            lblLabOrdersValue.Text = "0"
        Catch ex As Exception
            lblTotalPatientsValue.Text = "0"
            lblLabOrdersValue.Text = "0"
        Finally
            If MyConnection IsNot Nothing AndAlso MyConnection.State = ConnectionState.Open Then
                MyConnection.Close()
            End If
        End Try
    End Sub

    Private Function ExecuteCountQuerySafe(primaryQuery As String, Optional fallbackQuery As String = "") As Integer
        Try
            userSQLQuery = primaryQuery
            Dim cmd As New MySqlCommand(userSQLQuery, CType(MyConnection, MySqlConnection))
            Return Convert.ToInt32(cmd.ExecuteScalar())
        Catch
            If fallbackQuery <> "" Then
                Try
                    userSQLQuery = fallbackQuery
                    Dim cmd As New MySqlCommand(userSQLQuery, CType(MyConnection, MySqlConnection))
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                Catch
                    Return 0
                End Try
            End If

            Return 0
        End Try
    End Function

    Private Function ExecuteTableQuerySafe(query As String, emptyMessage As String) As DataTable
        Try
            Dim dt As New DataTable()
            userDA = New MySqlDataAdapter(query, CType(MyConnection, MySqlConnection))
            userDA.Fill(dt)

            If dt.Rows.Count = 0 Then
                Return CreateInfoTable(emptyMessage)
            End If

            Return dt
        Catch
            Return CreateInfoTable(emptyMessage)
        End Try
    End Function

    Private Function CreateInfoTable(message As String) As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("Info", GetType(String))
        dt.Rows.Add(message)
        Return dt
    End Function

    Private Function TableExists(tableName As String) As Boolean
        userSQLQuery = "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = DATABASE() AND table_name = @tableName"
        Using cmd As New MySqlCommand(userSQLQuery, CType(MyConnection, MySqlConnection))
            cmd.Parameters.AddWithValue("@tableName", tableName)
            Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
        End Using
    End Function

    Private Function GetFirstExistingColumn(tableName As String, candidates As String()) As String
        For Each columnName As String In candidates
            userSQLQuery = "SELECT COUNT(*) FROM information_schema.columns WHERE table_schema = DATABASE() AND table_name = @tableName AND column_name = @columnName"
            Using cmd As New MySqlCommand(userSQLQuery, CType(MyConnection, MySqlConnection))
                cmd.Parameters.AddWithValue("@tableName", tableName)
                cmd.Parameters.AddWithValue("@columnName", columnName)
                If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
                    Return columnName
                End If
            End Using
        Next

        Return ""
    End Function

    Private Sub pbTrustMedLogo_Click(sender As Object, e As EventArgs) Handles pbTrustMedLogo.Click

    End Sub
End Class
