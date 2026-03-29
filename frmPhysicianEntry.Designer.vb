<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPhysicianEntry
    Inherits System.Windows.Forms.Form

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
        Me.lblPhysicianID = New System.Windows.Forms.Label()
        Me.txtPhysicianID = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblSpecialty = New System.Windows.Forms.Label()
        Me.txtSpecialty = New System.Windows.Forms.TextBox()
        Me.lblLicenseNo = New System.Windows.Forms.Label()
        Me.txtLicenseNo = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPhysicianID
        '
        Me.lblPhysicianID.Location = New System.Drawing.Point(20, 24)
        Me.lblPhysicianID.Name = "lblPhysicianID"
        Me.lblPhysicianID.Size = New System.Drawing.Size(130, 24)
        Me.lblPhysicianID.TabIndex = 0
        Me.lblPhysicianID.Text = "Physician ID *:"
        '
        'txtPhysicianID
        '
        Me.txtPhysicianID.Location = New System.Drawing.Point(160, 20)
        Me.txtPhysicianID.Name = "txtPhysicianID"
        Me.txtPhysicianID.ReadOnly = True
        Me.txtPhysicianID.Size = New System.Drawing.Size(330, 20)
        Me.txtPhysicianID.TabIndex = 1
        Me.txtPhysicianID.TabStop = False
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(20, 62)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(130, 24)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name *:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(160, 58)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(330, 20)
        Me.txtFirstName.TabIndex = 3
        '
        'lblLastName
        '
        Me.lblLastName.Location = New System.Drawing.Point(20, 100)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(130, 24)
        Me.lblLastName.TabIndex = 4
        Me.lblLastName.Text = "Last Name *:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(160, 96)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(330, 20)
        Me.txtLastName.TabIndex = 5
        '
        'lblSpecialty
        '
        Me.lblSpecialty.Location = New System.Drawing.Point(20, 138)
        Me.lblSpecialty.Name = "lblSpecialty"
        Me.lblSpecialty.Size = New System.Drawing.Size(130, 24)
        Me.lblSpecialty.TabIndex = 6
        Me.lblSpecialty.Text = "Specialty *:"
        '
        'txtSpecialty
        '
        Me.txtSpecialty.Location = New System.Drawing.Point(160, 134)
        Me.txtSpecialty.Name = "txtSpecialty"
        Me.txtSpecialty.Size = New System.Drawing.Size(330, 20)
        Me.txtSpecialty.TabIndex = 7
        '
        'lblLicenseNo
        '
        Me.lblLicenseNo.Location = New System.Drawing.Point(20, 176)
        Me.lblLicenseNo.Name = "lblLicenseNo"
        Me.lblLicenseNo.Size = New System.Drawing.Size(130, 24)
        Me.lblLicenseNo.TabIndex = 8
        Me.lblLicenseNo.Text = "License No. *:"
        '
        'txtLicenseNo
        '
        Me.txtLicenseNo.Location = New System.Drawing.Point(160, 172)
        Me.txtLicenseNo.Name = "txtLicenseNo"
        Me.txtLicenseNo.Size = New System.Drawing.Size(330, 20)
        Me.txtLicenseNo.TabIndex = 9
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.Location = New System.Drawing.Point(20, 214)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(130, 24)
        Me.lblPhoneNumber.TabIndex = 10
        Me.lblPhoneNumber.Text = "Phone Number *:"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(160, 210)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(330, 20)
        Me.txtPhoneNumber.TabIndex = 11
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(184, 19, 66)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(300, 272)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 34)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(400, 272)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 34)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmPhysicianEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 330)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.txtLicenseNo)
        Me.Controls.Add(Me.lblLicenseNo)
        Me.Controls.Add(Me.txtSpecialty)
        Me.Controls.Add(Me.lblSpecialty)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtPhysicianID)
        Me.Controls.Add(Me.lblPhysicianID)
        Me.Name = "frmPhysicianEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Physician"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPhysicianID As Label
    Friend WithEvents txtPhysicianID As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblSpecialty As Label
    Friend WithEvents txtSpecialty As TextBox
    Friend WithEvents lblLicenseNo As Label
    Friend WithEvents txtLicenseNo As TextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
