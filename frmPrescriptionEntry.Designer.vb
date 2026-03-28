<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrescriptionEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblPrescriptionID = New System.Windows.Forms.Label()
        Me.txtPrescriptionID = New System.Windows.Forms.TextBox()
        Me.lblPhysicianID = New System.Windows.Forms.Label()
        Me.txtPhysicianID = New System.Windows.Forms.TextBox()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.txtInstruction = New System.Windows.Forms.TextBox()
        Me.lblPrescriptionDate = New System.Windows.Forms.Label()
        Me.dtpPrescriptionDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrescriptionID
        '
        Me.lblPrescriptionID.Location = New System.Drawing.Point(20, 24)
        Me.lblPrescriptionID.Name = "lblPrescriptionID"
        Me.lblPrescriptionID.Size = New System.Drawing.Size(130, 24)
        Me.lblPrescriptionID.TabIndex = 0
        Me.lblPrescriptionID.Text = "Prescription ID *:"
        '
        'txtPrescriptionID
        '
        Me.txtPrescriptionID.Location = New System.Drawing.Point(160, 20)
        Me.txtPrescriptionID.Name = "txtPrescriptionID"
        Me.txtPrescriptionID.ReadOnly = True
        Me.txtPrescriptionID.Size = New System.Drawing.Size(330, 20)
        Me.txtPrescriptionID.TabIndex = 1
        Me.txtPrescriptionID.TabStop = False
        '
        'lblPhysicianID
        '
        Me.lblPhysicianID.Location = New System.Drawing.Point(20, 62)
        Me.lblPhysicianID.Name = "lblPhysicianID"
        Me.lblPhysicianID.Size = New System.Drawing.Size(130, 24)
        Me.lblPhysicianID.TabIndex = 2
        Me.lblPhysicianID.Text = "Physician ID *:"
        '
        'txtPhysicianID
        '
        Me.txtPhysicianID.Location = New System.Drawing.Point(160, 58)
        Me.txtPhysicianID.Name = "txtPhysicianID"
        Me.txtPhysicianID.Size = New System.Drawing.Size(330, 20)
        Me.txtPhysicianID.TabIndex = 3
        '
        'lblPatientID
        '
        Me.lblPatientID.Location = New System.Drawing.Point(20, 100)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(130, 24)
        Me.lblPatientID.TabIndex = 4
        Me.lblPatientID.Text = "Patient ID *:"
        '
        'txtPatientID
        '
        Me.txtPatientID.Location = New System.Drawing.Point(160, 96)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(330, 20)
        Me.txtPatientID.TabIndex = 5
        '
        'lblInstruction
        '
        Me.lblInstruction.Location = New System.Drawing.Point(20, 138)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(130, 24)
        Me.lblInstruction.TabIndex = 6
        Me.lblInstruction.Text = "Instruction *:"
        '
        'txtInstruction
        '
        Me.txtInstruction.Location = New System.Drawing.Point(160, 134)
        Me.txtInstruction.Multiline = True
        Me.txtInstruction.Name = "txtInstruction"
        Me.txtInstruction.Size = New System.Drawing.Size(330, 92)
        Me.txtInstruction.TabIndex = 7
        '
        'lblPrescriptionDate
        '
        Me.lblPrescriptionDate.Location = New System.Drawing.Point(20, 242)
        Me.lblPrescriptionDate.Name = "lblPrescriptionDate"
        Me.lblPrescriptionDate.Size = New System.Drawing.Size(130, 24)
        Me.lblPrescriptionDate.TabIndex = 8
        Me.lblPrescriptionDate.Text = "Prescription Date *:"
        '
        'dtpPrescriptionDate
        '
        Me.dtpPrescriptionDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPrescriptionDate.Location = New System.Drawing.Point(160, 238)
        Me.dtpPrescriptionDate.Name = "dtpPrescriptionDate"
        Me.dtpPrescriptionDate.Size = New System.Drawing.Size(330, 20)
        Me.dtpPrescriptionDate.TabIndex = 9
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkBlue
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(300, 282)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 34)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(400, 282)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 34)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmPrescriptionEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 340)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpPrescriptionDate)
        Me.Controls.Add(Me.lblPrescriptionDate)
        Me.Controls.Add(Me.txtInstruction)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.lblPatientID)
        Me.Controls.Add(Me.txtPhysicianID)
        Me.Controls.Add(Me.lblPhysicianID)
        Me.Controls.Add(Me.txtPrescriptionID)
        Me.Controls.Add(Me.lblPrescriptionID)
        Me.Name = "frmPrescriptionEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Prescription"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrescriptionID As Label
    Friend WithEvents txtPrescriptionID As TextBox
    Friend WithEvents lblPhysicianID As Label
    Friend WithEvents txtPhysicianID As TextBox
    Friend WithEvents lblPatientID As Label
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents lblInstruction As Label
    Friend WithEvents txtInstruction As TextBox
    Friend WithEvents lblPrescriptionDate As Label
    Friend WithEvents dtpPrescriptionDate As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
