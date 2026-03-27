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
    Private currentSectionName As String = "Patients"
    Private currentSectionSingular As String = "Patient"

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

        ShowDashboardHome()
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

    Private Sub ShowDashboardHome()
        pnlSummaryCards.Visible = True
        grpQuickActions.Visible = True
        pnlPatientsSection.Visible = False
    End Sub

    Private Sub ShowPatientsSection()
        ShowEntitySection("patients")
    End Sub

    Private Sub ShowEntitySection(sectionKey As String)
        Dim sectionTitle As String = ""
        Dim sectionSingular As String = ""
        Dim sectionQuery As String = ""

        GetSectionConfig(sectionKey, sectionTitle, sectionSingular, sectionQuery)

        currentSectionName = sectionTitle
        currentSectionSingular = sectionSingular

        pnlSummaryCards.Visible = False
        grpQuickActions.Visible = False
        pnlPatientsSection.Visible = True

        grpPatientList.Text = sectionTitle
        grpPatientOptions.Text = sectionTitle & " Options"
        btnAddPatient.Text = "Add New " & sectionSingular
        btnDeletePatient.Text = "Delete " & sectionSingular
        btnUpdatePatient.Text = "Update " & sectionSingular

        LoadSectionList(sectionKey, sectionQuery)
    End Sub

    Private Sub GetSectionConfig(sectionKey As String, ByRef sectionTitle As String, ByRef sectionSingular As String, ByRef sectionQuery As String)
        Select Case sectionKey.ToLowerInvariant()
            Case "patients"
                sectionTitle = "Patients"
                sectionSingular = "Patient"
                sectionQuery = "SELECT PatientID, FirstName, LastName, Sex, DateOfBirth, PhoneNumber, Province, City, Street, HouseNumber, " &
                               "CONCAT(HouseNumber, ', ', Street, ', ', City, ', ', Province) AS Address " &
                               "FROM patient ORDER BY PatientID DESC"
            Case "consultations"
                sectionTitle = "Consultations"
                sectionSingular = "Consultation"
                sectionQuery = "SELECT ConsultationID, PatientID, PhysicianID, Complaint, Notes, ConsultationDate FROM consultation ORDER BY ConsultationID DESC"
            Case "diagnoses"
                sectionTitle = "Diagnoses"
                sectionSingular = "Diagnosis"
                sectionQuery = "SELECT DiagnosisID, PatientID, PhysicianID, DiagnosisName, DiagnosisDescription, DiagnosisDate FROM diagnosis ORDER BY DiagnosisID DESC"
            Case "lab orders"
                sectionTitle = "Lab Orders"
                sectionSingular = "Lab Order"
                sectionQuery = "SELECT OrderID, PatientID, PhysicianID, OrderDate FROM lab_order ORDER BY OrderID DESC"
            Case "examinations"
                sectionTitle = "Examinations"
                sectionSingular = "Examination"
                sectionQuery = "SELECT ExaminationID, PatientID, Result, DatePerformed FROM examination ORDER BY ExaminationID DESC"
            Case "medical tests"
                sectionTitle = "Medical Tests"
                sectionSingular = "Medical Test"
                sectionQuery = "SELECT TestID, TestName, TestDescription, Cost FROM medical_test ORDER BY TestID DESC"
            Case "medicines"
                sectionTitle = "Medicines"
                sectionSingular = "Medicine"
                sectionQuery = "SELECT MedicineID, MedicineName, Price, MedicineDescription FROM medicine ORDER BY MedicineID DESC"
            Case "prescriptions"
                sectionTitle = "Prescriptions"
                sectionSingular = "Prescription"
                sectionQuery = "SELECT PrescriptionID, PatientID, PhysicianID, Instruction, PrescriptionDate FROM prescription ORDER BY PrescriptionID DESC"
            Case "physicians"
                sectionTitle = "Physicians"
                sectionSingular = "Physician"
                sectionQuery = "SELECT PhysicianID, FirstName, LastName, Specialty, LicenseNo, PhoneNumber FROM physician ORDER BY PhysicianID DESC"
            Case "medtechs"
                sectionTitle = "MedTechs"
                sectionSingular = "MedTech"
                sectionQuery = "SELECT MedtechID, FirstName, LastName, LicenseNo, PhoneNumber FROM medtech ORDER BY MedtechID DESC"
            Case Else
                sectionTitle = "Patients"
                sectionSingular = "Patient"
                sectionQuery = "SELECT PatientID, FirstName, LastName, Sex, DateOfBirth, PhoneNumber, Province, City, Street, HouseNumber, " &
                               "CONCAT(HouseNumber, ', ', Street, ', ', City, ', ', Province) AS Address " &
                               "FROM patient ORDER BY PatientID DESC"
        End Select
    End Sub

    Private Sub LoadSectionList(sectionKey As String, sectionQuery As String)
        Dim dt As New DataTable()

        Try
            userSQLQuery = sectionQuery
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            userDA = New MySqlDataAdapter(userSQLQuery, CType(MyConnection, MySqlConnection))
            userDA.Fill(dt)
            dgvPatients.DataSource = dt

            If sectionKey.ToLowerInvariant() = "patients" Then
                If dgvPatients.Columns.Contains("Province") Then dgvPatients.Columns("Province").Visible = False
                If dgvPatients.Columns.Contains("City") Then dgvPatients.Columns("City").Visible = False
                If dgvPatients.Columns.Contains("Street") Then dgvPatients.Columns("Street").Visible = False
                If dgvPatients.Columns.Contains("HouseNumber") Then dgvPatients.Columns("HouseNumber").Visible = False

                If dgvPatients.Columns.Contains("PatientID") Then dgvPatients.Columns("PatientID").Width = 80
                If dgvPatients.Columns.Contains("FirstName") Then dgvPatients.Columns("FirstName").Width = 120
                If dgvPatients.Columns.Contains("LastName") Then dgvPatients.Columns("LastName").Width = 120
                If dgvPatients.Columns.Contains("Sex") Then dgvPatients.Columns("Sex").Width = 70
                If dgvPatients.Columns.Contains("DateOfBirth") Then dgvPatients.Columns("DateOfBirth").Width = 95
                If dgvPatients.Columns.Contains("PhoneNumber") Then dgvPatients.Columns("PhoneNumber").Width = 120
                If dgvPatients.Columns.Contains("Address") Then
                    dgvPatients.Columns("Address").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    dgvPatients.Columns("Address").MinimumWidth = 380
                End If
            Else
                For Each col As DataGridViewColumn In dgvPatients.Columns
                    col.Visible = True
                Next
            End If
        Catch
            dgvPatients.DataSource = Nothing
        Finally
            If MyConnection IsNot Nothing AndAlso MyConnection.State = ConnectionState.Open Then
                MyConnection.Close()
            End If
        End Try
    End Sub

    Private Sub miDashboard_Click(sender As Object, e As EventArgs) Handles miDashboard.Click
        ShowDashboardHome()
    End Sub

    Private Sub miPatients_Click(sender As Object, e As EventArgs) Handles miPatients.Click
        ShowEntitySection("patients")
    End Sub

    Private Sub miConsultation_Click(sender As Object, e As EventArgs) Handles miConsultation.Click
        ShowEntitySection("consultations")
    End Sub

    Private Sub miDiagnosis_Click(sender As Object, e As EventArgs) Handles miDiagnosis.Click
        ShowEntitySection("diagnoses")
    End Sub

    Private Sub miLabOrders_Click(sender As Object, e As EventArgs) Handles miLabOrders.Click
        ShowEntitySection("lab orders")
    End Sub

    Private Sub miExamination_Click(sender As Object, e As EventArgs) Handles miExamination.Click
        ShowEntitySection("examinations")
    End Sub

    Private Sub miMedicalTest_Click(sender As Object, e As EventArgs) Handles miMedicalTest.Click
        ShowEntitySection("medical tests")
    End Sub

    Private Sub miMedicine_Click(sender As Object, e As EventArgs) Handles miMedicine.Click
        ShowEntitySection("medicines")
    End Sub

    Private Sub miPrescription_Click(sender As Object, e As EventArgs) Handles miPrescription.Click
        ShowEntitySection("prescriptions")
    End Sub

    Private Sub miPhysician_Click(sender As Object, e As EventArgs) Handles miPhysician.Click
        ShowEntitySection("physicians")
    End Sub

    Private Sub miMedTech_Click(sender As Object, e As EventArgs) Handles miMedTech.Click
        ShowEntitySection("medtechs")
    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        ShowQuickActionPlaceholder("Add New " & currentSectionSingular)
    End Sub

    Private Sub btnDeletePatient_Click(sender As Object, e As EventArgs) Handles btnDeletePatient.Click
        ShowQuickActionPlaceholder("Delete " & currentSectionSingular)
    End Sub

    Private Sub btnUpdatePatient_Click(sender As Object, e As EventArgs) Handles btnUpdatePatient.Click
        ShowQuickActionPlaceholder("Update " & currentSectionSingular)
    End Sub
End Class
