Imports MySql.Data.MySqlClient

Partial Class frmLabOrderEntry
    Private ReadOnly _connectionString As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(connectionString As String)
        _connectionString = connectionString
        InitializeComponent()
    End Sub

    Private Sub frmLabOrderEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNextOrderId()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateInputs() Then
            Return
        End If

        Dim orderId As Integer
        Dim physicianId As Integer
        Dim patientId As Integer

        If Not Integer.TryParse(txtOrderID.Text.Trim(), orderId) Then
            MessageBox.Show("Invalid Order ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

                Dim sql As String = "INSERT INTO lab_order (OrderID, PhysicianID, PatientID, OrderDate) VALUES (@OrderID, @PhysicianID, @PatientID, @OrderDate)"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@OrderID", orderId)
                    cmd.Parameters.AddWithValue("@PhysicianID", physicianId)
                    cmd.Parameters.AddWithValue("@PatientID", patientId)
                    cmd.Parameters.AddWithValue("@OrderDate", dtpOrderDate.Value.Date)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Lab order added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Unable to save lab order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(_connectionString) Then
            MessageBox.Show("Connection string is not set.", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtOrderID.Text) Then
            MessageBox.Show("Order ID is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

        Return True
    End Function

    Private Sub LoadNextOrderId()
        If String.IsNullOrWhiteSpace(_connectionString) Then
            txtOrderID.Text = ""
            Return
        End If

        Try
            Using conn As New MySqlConnection(_connectionString)
                conn.Open()

                Dim newOrderId As Integer = GetNextAvailableOrderId(conn)
                If newOrderId = -1 Then
                    txtOrderID.Text = ""
                    MessageBox.Show("No available OrderID in range 70001 to 79999.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                txtOrderID.Text = newOrderId.ToString()
            End Using
        Catch ex As Exception
            txtOrderID.Text = ""
            MessageBox.Show("Unable to generate lab order ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetNextAvailableOrderId(conn As MySqlConnection) As Integer
        Const minId As Integer = 70001
        Const maxId As Integer = 79999

        Dim candidate As Integer = minId
        Dim sql As String = "SELECT OrderID FROM lab_order WHERE OrderID BETWEEN @minId AND @maxId ORDER BY OrderID"

        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@minId", minId)
            cmd.Parameters.AddWithValue("@maxId", maxId)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim usedId As Integer = Convert.ToInt32(reader("OrderID"))

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