<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPatientEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatientEntry))
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.dtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblHouseNumber = New System.Windows.Forms.Label()
        Me.txtHouseNumber = New System.Windows.Forms.TextBox()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPatientID
        '
        Me.lblPatientID.Location = New System.Drawing.Point(20, 24)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(130, 24)
        Me.lblPatientID.TabIndex = 0
        Me.lblPatientID.Text = "Patient ID *:"
        '
        'txtPatientID
        '
        Me.txtPatientID.Location = New System.Drawing.Point(160, 20)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.ReadOnly = True
        Me.txtPatientID.Size = New System.Drawing.Size(330, 20)
        Me.txtPatientID.TabIndex = 1
        Me.txtPatientID.TabStop = False
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
        'lblSex
        '
        Me.lblSex.Location = New System.Drawing.Point(20, 138)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(130, 24)
        Me.lblSex.TabIndex = 6
        Me.lblSex.Text = "Sex *:"
        '
        'cboSex
        '
        Me.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboSex.Location = New System.Drawing.Point(160, 134)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(330, 21)
        Me.cboSex.TabIndex = 7
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.Location = New System.Drawing.Point(20, 176)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(130, 24)
        Me.lblDateOfBirth.TabIndex = 8
        Me.lblDateOfBirth.Text = "Date Of Birth *:"
        '
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(160, 172)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(330, 20)
        Me.dtpDateOfBirth.TabIndex = 9
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
        'lblHouseNumber
        '
        Me.lblHouseNumber.Location = New System.Drawing.Point(20, 252)
        Me.lblHouseNumber.Name = "lblHouseNumber"
        Me.lblHouseNumber.Size = New System.Drawing.Size(130, 24)
        Me.lblHouseNumber.TabIndex = 12
        Me.lblHouseNumber.Text = "House Number *:"
        '
        'txtHouseNumber
        '
        Me.txtHouseNumber.Location = New System.Drawing.Point(160, 248)
        Me.txtHouseNumber.Name = "txtHouseNumber"
        Me.txtHouseNumber.Size = New System.Drawing.Size(330, 20)
        Me.txtHouseNumber.TabIndex = 13
        '
        'lblStreet
        '
        Me.lblStreet.Location = New System.Drawing.Point(20, 290)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(130, 24)
        Me.lblStreet.TabIndex = 14
        Me.lblStreet.Text = "Street *:"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(160, 286)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(330, 20)
        Me.txtStreet.TabIndex = 15
        '
        'lblCity
        '
        Me.lblCity.Location = New System.Drawing.Point(20, 328)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(130, 24)
        Me.lblCity.TabIndex = 16
        Me.lblCity.Text = "City *:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(160, 324)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(330, 20)
        Me.txtCity.TabIndex = 17
        '
        'lblProvince
        '
        Me.lblProvince.Location = New System.Drawing.Point(20, 366)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(130, 24)
        Me.lblProvince.TabIndex = 18
        Me.lblProvince.Text = "Province *:"
        '
        'txtProvince
        '
        Me.txtProvince.Location = New System.Drawing.Point(160, 362)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(330, 20)
        Me.txtProvince.TabIndex = 19
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(184, 19, 66)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(300, 418)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 34)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(400, 418)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 34)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmPatientEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 470)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtProvince)
        Me.Controls.Add(Me.lblProvince)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.lblStreet)
        Me.Controls.Add(Me.txtHouseNumber)
        Me.Controls.Add(Me.lblHouseNumber)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.dtpDateOfBirth)
        Me.Controls.Add(Me.lblDateOfBirth)
        Me.Controls.Add(Me.cboSex)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.lblPatientID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPatientEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Patient"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPatientID As Label
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblSex As Label
    Friend WithEvents cboSex As ComboBox
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents dtpDateOfBirth As DateTimePicker
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents lblHouseNumber As Label
    Friend WithEvents txtHouseNumber As TextBox
    Friend WithEvents lblStreet As Label
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblProvince As Label
    Friend WithEvents txtProvince As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
