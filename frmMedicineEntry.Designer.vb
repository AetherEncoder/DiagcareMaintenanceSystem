<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMedicineEntry
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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblMedicineID = New System.Windows.Forms.Label()
        Me.txtMedicineID = New System.Windows.Forms.TextBox()
        Me.lblMedicineName = New System.Windows.Forms.Label()
        Me.txtMedicineName = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblMedicineDescription = New System.Windows.Forms.Label()
        Me.txtMedicineDescription = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMedicineID
        '
        Me.lblMedicineID.Location = New System.Drawing.Point(20, 24)
        Me.lblMedicineID.Name = "lblMedicineID"
        Me.lblMedicineID.Size = New System.Drawing.Size(130, 24)
        Me.lblMedicineID.TabIndex = 0
        Me.lblMedicineID.Text = "Medicine ID *:"
        '
        'txtMedicineID
        '
        Me.txtMedicineID.Location = New System.Drawing.Point(160, 20)
        Me.txtMedicineID.Name = "txtMedicineID"
        Me.txtMedicineID.ReadOnly = True
        Me.txtMedicineID.Size = New System.Drawing.Size(330, 20)
        Me.txtMedicineID.TabIndex = 1
        Me.txtMedicineID.TabStop = False
        '
        'lblMedicineName
        '
        Me.lblMedicineName.Location = New System.Drawing.Point(20, 62)
        Me.lblMedicineName.Name = "lblMedicineName"
        Me.lblMedicineName.Size = New System.Drawing.Size(130, 24)
        Me.lblMedicineName.TabIndex = 2
        Me.lblMedicineName.Text = "Medicine Name *:"
        '
        'txtMedicineName
        '
        Me.txtMedicineName.Location = New System.Drawing.Point(160, 58)
        Me.txtMedicineName.Name = "txtMedicineName"
        Me.txtMedicineName.Size = New System.Drawing.Size(330, 20)
        Me.txtMedicineName.TabIndex = 3
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(20, 100)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(130, 24)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.Text = "Price *:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(160, 96)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(330, 20)
        Me.txtPrice.TabIndex = 5
        '
        'lblMedicineDescription
        '
        Me.lblMedicineDescription.Location = New System.Drawing.Point(20, 138)
        Me.lblMedicineDescription.Name = "lblMedicineDescription"
        Me.lblMedicineDescription.Size = New System.Drawing.Size(130, 24)
        Me.lblMedicineDescription.TabIndex = 6
        Me.lblMedicineDescription.Text = "Description *:"
        '
        'txtMedicineDescription
        '
        Me.txtMedicineDescription.Location = New System.Drawing.Point(160, 134)
        Me.txtMedicineDescription.Multiline = True
        Me.txtMedicineDescription.Name = "txtMedicineDescription"
        Me.txtMedicineDescription.Size = New System.Drawing.Size(330, 92)
        Me.txtMedicineDescription.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkBlue
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(300, 244)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 34)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(400, 244)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 34)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmMedicineEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 295)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtMedicineDescription)
        Me.Controls.Add(Me.lblMedicineDescription)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtMedicineName)
        Me.Controls.Add(Me.lblMedicineName)
        Me.Controls.Add(Me.txtMedicineID)
        Me.Controls.Add(Me.lblMedicineID)
        Me.Name = "frmMedicineEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Medicine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMedicineID As Label
    Friend WithEvents txtMedicineID As TextBox
    Friend WithEvents lblMedicineName As Label
    Friend WithEvents txtMedicineName As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblMedicineDescription As Label
    Friend WithEvents txtMedicineDescription As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
