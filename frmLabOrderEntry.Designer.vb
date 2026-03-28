<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLabOrderEntry
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.lblPhysicianID = New System.Windows.Forms.Label()
        Me.txtPhysicianID = New System.Windows.Forms.TextBox()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.lblOrderDate = New System.Windows.Forms.Label()
        Me.dtpOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOrderID
        '
        Me.lblOrderID.Location = New System.Drawing.Point(20, 24)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(130, 24)
        Me.lblOrderID.TabIndex = 0
        Me.lblOrderID.Text = "Order ID *:"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(160, 20)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.ReadOnly = True
        Me.txtOrderID.Size = New System.Drawing.Size(330, 20)
        Me.txtOrderID.TabIndex = 1
        Me.txtOrderID.TabStop = False
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
        'lblOrderDate
        '
        Me.lblOrderDate.Location = New System.Drawing.Point(20, 138)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(130, 24)
        Me.lblOrderDate.TabIndex = 6
        Me.lblOrderDate.Text = "Order Date *:"
        '
        'dtpOrderDate
        '
        Me.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOrderDate.Location = New System.Drawing.Point(160, 134)
        Me.dtpOrderDate.Name = "dtpOrderDate"
        Me.dtpOrderDate.Size = New System.Drawing.Size(330, 20)
        Me.dtpOrderDate.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkBlue
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(300, 184)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 34)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(400, 184)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 34)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmLabOrderEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 245)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpOrderDate)
        Me.Controls.Add(Me.lblOrderDate)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.lblPatientID)
        Me.Controls.Add(Me.txtPhysicianID)
        Me.Controls.Add(Me.lblPhysicianID)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.lblOrderID)
        Me.Name = "frmLabOrderEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Lab Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOrderID As Label
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents lblPhysicianID As Label
    Friend WithEvents txtPhysicianID As TextBox
    Friend WithEvents lblPatientID As Label
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents lblOrderDate As Label
    Friend WithEvents dtpOrderDate As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
