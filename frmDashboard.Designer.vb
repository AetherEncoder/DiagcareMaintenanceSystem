<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblUsernameError = New System.Windows.Forms.Label()
        Me.lblPasswordError = New System.Windows.Forms.Label()
        Me.pnlLoginContainer = New System.Windows.Forms.Panel()
        Me.lblLoginError = New System.Windows.Forms.Label()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblLoggedInUser = New System.Windows.Forms.Label()
        Me.lblDashboardHeader = New System.Windows.Forms.Label()
        Me.msDashboardMenu = New System.Windows.Forms.MenuStrip()
        Me.miOperations = New System.Windows.Forms.ToolStripMenuItem()
        Me.miMedTech = New System.Windows.Forms.ToolStripMenuItem()
        Me.miMedicalTest = New System.Windows.Forms.ToolStripMenuItem()
        Me.miExamination = New System.Windows.Forms.ToolStripMenuItem()
        Me.miLabOrders = New System.Windows.Forms.ToolStripMenuItem()
        Me.miConsultation = New System.Windows.Forms.ToolStripMenuItem()
        Me.miDiagnosis = New System.Windows.Forms.ToolStripMenuItem()
        Me.miManagement = New System.Windows.Forms.ToolStripMenuItem()
        Me.miPatients = New System.Windows.Forms.ToolStripMenuItem()
        Me.miMedicine = New System.Windows.Forms.ToolStripMenuItem()
        Me.miPrescription = New System.Windows.Forms.ToolStripMenuItem()
        Me.miPhysician = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlLoginContainer.SuspendLayout()
        Me.pnlDashboard.SuspendLayout()
        Me.msDashboardMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblHeader.Location = New System.Drawing.Point(250, 50)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(571, 37)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "TrustMed Health Information System"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(300, 200)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(97, 20)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username: *"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(300, 280)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(92, 20)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password: *"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(300, 230)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(400, 26)
        Me.txtUsername.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(300, 310)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(400, 26)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DarkBlue
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(350, 420)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 40)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(550, 420)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 40)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblUsernameError
        '
        Me.lblUsernameError.AutoSize = True
        Me.lblUsernameError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameError.ForeColor = System.Drawing.Color.Red
        Me.lblUsernameError.Location = New System.Drawing.Point(300, 260)
        Me.lblUsernameError.Name = "lblUsernameError"
        Me.lblUsernameError.Size = New System.Drawing.Size(0, 15)
        Me.lblUsernameError.TabIndex = 7
        Me.lblUsernameError.Visible = False
        '
        'lblPasswordError
        '
        Me.lblPasswordError.AutoSize = True
        Me.lblPasswordError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordError.ForeColor = System.Drawing.Color.Red
        Me.lblPasswordError.Location = New System.Drawing.Point(300, 340)
        Me.lblPasswordError.Name = "lblPasswordError"
        Me.lblPasswordError.Size = New System.Drawing.Size(0, 15)
        Me.lblPasswordError.TabIndex = 8
        Me.lblPasswordError.Visible = False
        '
        'pnlLoginContainer
        '
        Me.pnlLoginContainer.Controls.Add(Me.lblLoginError)
        Me.pnlLoginContainer.Controls.Add(Me.lblPasswordError)
        Me.pnlLoginContainer.Controls.Add(Me.lblUsernameError)
        Me.pnlLoginContainer.Controls.Add(Me.btnClose)
        Me.pnlLoginContainer.Controls.Add(Me.btnLogin)
        Me.pnlLoginContainer.Controls.Add(Me.txtPassword)
        Me.pnlLoginContainer.Controls.Add(Me.txtUsername)
        Me.pnlLoginContainer.Controls.Add(Me.lblPassword)
        Me.pnlLoginContainer.Controls.Add(Me.lblUsername)
        Me.pnlLoginContainer.Controls.Add(Me.lblHeader)
        Me.pnlLoginContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoginContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlLoginContainer.Name = "pnlLoginContainer"
        Me.pnlLoginContainer.Size = New System.Drawing.Size(1008, 729)
        Me.pnlLoginContainer.TabIndex = 10
        '
        'lblLoginError
        '
        Me.lblLoginError.AutoSize = True
        Me.lblLoginError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginError.ForeColor = System.Drawing.Color.Red
        Me.lblLoginError.Location = New System.Drawing.Point(300, 365)
        Me.lblLoginError.Name = "lblLoginError"
        Me.lblLoginError.Size = New System.Drawing.Size(0, 17)
        Me.lblLoginError.TabIndex = 9
        Me.lblLoginError.Visible = False
        '
        'pnlDashboard
        '
        Me.pnlDashboard.Controls.Add(Me.btnLogout)
        Me.pnlDashboard.Controls.Add(Me.lblLoggedInUser)
        Me.pnlDashboard.Controls.Add(Me.lblDashboardHeader)
        Me.pnlDashboard.Controls.Add(Me.msDashboardMenu)
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.Location = New System.Drawing.Point(0, 0)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(1008, 729)
        Me.pnlDashboard.TabIndex = 11
        Me.pnlDashboard.Visible = False
        '
        'msDashboardMenu
        '
        Me.msDashboardMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miOperations, Me.miManagement})
        Me.msDashboardMenu.Location = New System.Drawing.Point(0, 0)
        Me.msDashboardMenu.Name = "msDashboardMenu"
        Me.msDashboardMenu.Size = New System.Drawing.Size(1008, 24)
        Me.msDashboardMenu.TabIndex = 3
        Me.msDashboardMenu.Text = "msDashboardMenu"
        '
        'miOperations
        '
        Me.miOperations.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miExamination, Me.miLabOrders, Me.miConsultation, Me.miDiagnosis, Me.miPrescription})
        Me.miOperations.Name = "miOperations"
        Me.miOperations.Size = New System.Drawing.Size(77, 20)
        Me.miOperations.Text = "Operations"
        '
        'miExamination
        '
        Me.miExamination.Name = "miExamination"
        Me.miExamination.Size = New System.Drawing.Size(180, 22)
        Me.miExamination.Text = "Examination"
        '
        'miLabOrders
        '
        Me.miLabOrders.Name = "miLabOrders"
        Me.miLabOrders.Size = New System.Drawing.Size(180, 22)
        Me.miLabOrders.Text = "Lab Orders"
        '
        'miConsultation
        '
        Me.miConsultation.Name = "miConsultation"
        Me.miConsultation.Size = New System.Drawing.Size(180, 22)
        Me.miConsultation.Text = "Consultation"
        '
        'miDiagnosis
        '
        Me.miDiagnosis.Name = "miDiagnosis"
        Me.miDiagnosis.Size = New System.Drawing.Size(180, 22)
        Me.miDiagnosis.Text = "Diagnosis"
        '
        'miManagement
        '
        Me.miManagement.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miMedTech, Me.miMedicalTest, Me.miPatients, Me.miMedicine, Me.miPhysician})
        Me.miManagement.Name = "miManagement"
        Me.miManagement.Size = New System.Drawing.Size(90, 20)
        Me.miManagement.Text = "Management"
        '
        'miMedTech
        '
        Me.miMedTech.Name = "miMedTech"
        Me.miMedTech.Size = New System.Drawing.Size(180, 22)
        Me.miMedTech.Text = "MedTech"
        '
        'miMedicalTest
        '
        Me.miMedicalTest.Name = "miMedicalTest"
        Me.miMedicalTest.Size = New System.Drawing.Size(180, 22)
        Me.miMedicalTest.Text = "Medical Test"
        '
        'miPatients
        '
        Me.miPatients.Name = "miPatients"
        Me.miPatients.Size = New System.Drawing.Size(180, 22)
        Me.miPatients.Text = "Patients"
        '
        'miMedicine
        '
        Me.miMedicine.Name = "miMedicine"
        Me.miMedicine.Size = New System.Drawing.Size(180, 22)
        Me.miMedicine.Text = "Medicine"
        '
        'miPrescription
        '
        Me.miPrescription.Name = "miPrescription"
        Me.miPrescription.Size = New System.Drawing.Size(180, 22)
        Me.miPrescription.Text = "Prescription"
        '
        'miPhysician
        '
        Me.miPhysician.Name = "miPhysician"
        Me.miPhysician.Size = New System.Drawing.Size(180, 22)
        Me.miPhysician.Text = "Physician"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Gray
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(820, 80)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 35)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblLoggedInUser
        '
        Me.lblLoggedInUser.AutoSize = True
        Me.lblLoggedInUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoggedInUser.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblLoggedInUser.Location = New System.Drawing.Point(750, 50)
        Me.lblLoggedInUser.Name = "lblLoggedInUser"
        Me.lblLoggedInUser.Size = New System.Drawing.Size(162, 18)
        Me.lblLoggedInUser.TabIndex = 2
        Me.lblLoggedInUser.Text = "Logged in as username"
        '
        'lblDashboardHeader
        '
        Me.lblDashboardHeader.AutoSize = True
        Me.lblDashboardHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboardHeader.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblDashboardHeader.Location = New System.Drawing.Point(50, 50)
        Me.lblDashboardHeader.Name = "lblDashboardHeader"
        Me.lblDashboardHeader.Size = New System.Drawing.Size(184, 37)
        Me.lblDashboardHeader.TabIndex = 0
        Me.lblDashboardHeader.Text = "Dashboard"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.pnlDashboard)
        Me.Controls.Add(Me.pnlLoginContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msDashboardMenu
        Me.Name = "frmLogin"
        Me.Text = "TrustMed Health Information System"
        Me.pnlLoginContainer.ResumeLayout(False)
        Me.pnlLoginContainer.PerformLayout()
        Me.pnlDashboard.ResumeLayout(False)
        Me.pnlDashboard.PerformLayout()
        Me.msDashboardMenu.ResumeLayout(False)
        Me.msDashboardMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblUsernameError As Label
    Friend WithEvents lblPasswordError As Label
    Friend WithEvents pnlLoginContainer As Panel
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents lblDashboardHeader As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblLoginError As Label
    Friend WithEvents lblLoggedInUser As Label
    Friend WithEvents msDashboardMenu As MenuStrip
    Friend WithEvents miOperations As ToolStripMenuItem
    Friend WithEvents miMedTech As ToolStripMenuItem
    Friend WithEvents miMedicalTest As ToolStripMenuItem
    Friend WithEvents miExamination As ToolStripMenuItem
    Friend WithEvents miLabOrders As ToolStripMenuItem
    Friend WithEvents miConsultation As ToolStripMenuItem
    Friend WithEvents miDiagnosis As ToolStripMenuItem
    Friend WithEvents miManagement As ToolStripMenuItem
    Friend WithEvents miPatients As ToolStripMenuItem
    Friend WithEvents miMedicine As ToolStripMenuItem
    Friend WithEvents miPrescription As ToolStripMenuItem
    Friend WithEvents miPhysician As ToolStripMenuItem

End Class
