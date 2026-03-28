Imports MySql.Data.MySqlClient

Partial Class frmPrescriptionEntry

    Private ReadOnly _connectionString As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(connectionString As String)
        _connectionString = connectionString
        InitializeComponent()
    End Sub

    Private Sub frmPrescriptionEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNextPrescriptionId()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateInputs() Then
            Return
        End If

        Dim prescriptionId As Integer
        Dim physicianId As Integer
        Dim patientId As Integer

        If Not Integer.TryParse(txtPrescriptionID.Text.Trim(), prescriptionId) Then
            MessageBox.Show("Invalid Prescription ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Integer.TryParse(txtPhysicianID.Text.Trim(), physicianId) Then
            MessageBox.Show("Physician ID must be numeric.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhysicianID.Focus()
            Return
        End If

        If Not Integer.TryParse(txtPatientID.Text.Trim(), patientId) Then
            MessageBox.Show("Patient ID must be numeric.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPatientID.Focus()
            Return
        End If

        Try
            Using conn As New MySqlConnection(_connectionString)
                conn.Open()

                Dim sql As String = "INSERT INTO prescription (PrescriptionID, PhysicianID, PatientID, Instruction, PrescriptionDate) " &
                                    "VALUES (@PrescriptionID, @PhysicianID, @PatientID, @Instruction, @PrescriptionDate)"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@PrescriptionID", prescriptionId)
                    cmd.Parameters.AddWithValue("@PhysicianID", physicianId)
                    cmd.Parameters.AddWithValue("@PatientID", patientId)
                    cmd.Parameters.AddWithValue("@Instruction", txtInstruction.Text.Trim())
                    cmd.Parameters.AddWithValue("@PrescriptionDate", dtpPrescriptionDate.Value.Date)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Prescription added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to save prescription: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(_connectionString) Then
            MessageBox.Show("Connection string is not set.", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPrescriptionID.Text) Then
            MessageBox.Show("Prescription ID is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPhysicianID.Text) Then
            MessageBox.Show("Physician ID is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhysicianID.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPatientID.Text) Then
            MessageBox.Show("Patient ID is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPatientID.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtInstruction.Text) Then
            MessageBox.Show("Instruction is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtInstruction.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub LoadNextPrescriptionId()
        If String.IsNullOrWhiteSpace(_connectionString) Then
            txtPrescriptionID.Text = ""
            Return
        End If

        Try
            Using conn As New MySqlConnection(_connectionString)
                conn.Open()

                Dim newPrescriptionId As Integer = GetNextAvailablePrescriptionId(conn)
                If newPrescriptionId = -1 Then
                    txtPrescriptionID.Text = ""
                    MessageBox.Show("No available PrescriptionID in range 90001 to 99999.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                txtPrescriptionID.Text = newPrescriptionId.ToString()
            End Using
        Catch ex As Exception
            txtPrescriptionID.Text = ""
            MessageBox.Show("Unable to generate prescription ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetNextAvailablePrescriptionId(conn As MySqlConnection) As Integer
        Const minId As Integer = 90001
        Const maxId As Integer = 99999

        Dim candidate As Integer = minId
        Dim sql As String = "SELECT PrescriptionID FROM prescription WHERE PrescriptionID BETWEEN @minId AND @maxId ORDER BY PrescriptionID"

        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@minId", minId)
            cmd.Parameters.AddWithValue("@maxId", maxId)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim usedId As Integer = Convert.ToInt32(reader("PrescriptionID"))

                    If usedId < candidate Then
                        Continue While
                    End If

                    If usedId = candidate Then
                        candidate += 1
                        If candidate > maxId Then
                            Return -1
                        End If
                    ElseIf usedId > candidate Then
                        Exit While
                    End If
                End While
            End Using
        End Using

        If candidate > maxId Then
            Return -1
        End If

        Return candidate
    End Function
End Class