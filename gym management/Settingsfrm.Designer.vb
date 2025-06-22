<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settingsfrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settingsfrm))
        Me.txtpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnforgotpass = New Guna.UI2.WinForms.Guna2Button()
        Me.txtusername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.btnmemberenter = New Guna.UI2.WinForms.Guna2Button()
        Me.openimage = New System.Windows.Forms.OpenFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnaddprofile = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.profile = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtphone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtemail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtgymname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.profile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpassword
        '
        Me.txtpassword.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtpassword.BorderRadius = 2
        Me.txtpassword.BorderThickness = 2
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.DefaultText = ""
        Me.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.FillColor = System.Drawing.Color.Transparent
        Me.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtpassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtpassword.ForeColor = System.Drawing.Color.Gray
        Me.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtpassword.Location = New System.Drawing.Point(415, 595)
        Me.txtpassword.MaxLength = 30
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpassword.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtpassword.PlaceholderText = ""
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.Size = New System.Drawing.Size(329, 40)
        Me.txtpassword.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(44, 676)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 26)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Forgot Password"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(410, 551)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 26)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Password"
        '
        'btnforgotpass
        '
        Me.btnforgotpass.Animated = True
        Me.btnforgotpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnforgotpass.BorderColor = System.Drawing.SystemColors.Desktop
        Me.btnforgotpass.BorderThickness = 1
        Me.btnforgotpass.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnforgotpass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnforgotpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnforgotpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnforgotpass.FillColor = System.Drawing.Color.Transparent
        Me.btnforgotpass.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnforgotpass.ForeColor = System.Drawing.Color.Gray
        Me.btnforgotpass.Location = New System.Drawing.Point(49, 732)
        Me.btnforgotpass.Name = "btnforgotpass"
        Me.btnforgotpass.Size = New System.Drawing.Size(168, 45)
        Me.btnforgotpass.TabIndex = 37
        Me.btnforgotpass.Text = "Setup"
        '
        'txtusername
        '
        Me.txtusername.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtusername.BorderRadius = 2
        Me.txtusername.BorderThickness = 2
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.DefaultText = ""
        Me.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusername.FillColor = System.Drawing.Color.Transparent
        Me.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.Gray
        Me.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtusername.Location = New System.Drawing.Point(49, 595)
        Me.txtusername.MaxLength = 30
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtusername.PlaceholderText = ""
        Me.txtusername.SelectedText = ""
        Me.txtusername.Size = New System.Drawing.Size(329, 40)
        Me.txtusername.TabIndex = 41
        '
        'lblname
        '
        Me.lblname.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.DarkGray
        Me.lblname.Location = New System.Drawing.Point(44, 551)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(113, 26)
        Me.lblname.TabIndex = 40
        Me.lblname.Text = "Username "
        '
        'btnmemberenter
        '
        Me.btnmemberenter.Animated = True
        Me.btnmemberenter.BackColor = System.Drawing.Color.Transparent
        Me.btnmemberenter.BorderRadius = 4
        Me.btnmemberenter.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnmemberenter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnmemberenter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnmemberenter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnmemberenter.FillColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnmemberenter.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnmemberenter.ForeColor = System.Drawing.Color.Silver
        Me.btnmemberenter.Location = New System.Drawing.Point(49, 826)
        Me.btnmemberenter.Name = "btnmemberenter"
        Me.btnmemberenter.Size = New System.Drawing.Size(168, 45)
        Me.btnmemberenter.TabIndex = 49
        Me.btnmemberenter.Text = "Save"
        '
        'openimage
        '
        Me.openimage.FileName = "OpenFileDialog1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(44, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 26)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Photo"
        '
        'btnaddprofile
        '
        Me.btnaddprofile.BackColor = System.Drawing.Color.Transparent
        Me.btnaddprofile.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnaddprofile.HoverState.ImageSize = New System.Drawing.Size(43, 43)
        Me.btnaddprofile.Image = CType(resources.GetObject("btnaddprofile.Image"), System.Drawing.Image)
        Me.btnaddprofile.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnaddprofile.ImageRotate = 0!
        Me.btnaddprofile.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnaddprofile.Location = New System.Drawing.Point(204, 240)
        Me.btnaddprofile.Name = "btnaddprofile"
        Me.btnaddprofile.PressedState.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnaddprofile.Size = New System.Drawing.Size(39, 33)
        Me.btnaddprofile.TabIndex = 38
        Me.btnaddprofile.UseTransparentBackground = True
        '
        'profile
        '
        Me.profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.profile.Image = CType(resources.GetObject("profile.Image"), System.Drawing.Image)
        Me.profile.ImageRotate = 0!
        Me.profile.Location = New System.Drawing.Point(49, 77)
        Me.profile.Name = "profile"
        Me.profile.Size = New System.Drawing.Size(181, 184)
        Me.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.profile.TabIndex = 51
        Me.profile.TabStop = False
        '
        'txtphone
        '
        Me.txtphone.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtphone.BorderRadius = 2
        Me.txtphone.BorderThickness = 2
        Me.txtphone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtphone.DefaultText = ""
        Me.txtphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtphone.FillColor = System.Drawing.Color.Transparent
        Me.txtphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtphone.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtphone.ForeColor = System.Drawing.Color.Gray
        Me.txtphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtphone.Location = New System.Drawing.Point(415, 467)
        Me.txtphone.MaxLength = 50
        Me.txtphone.Name = "txtphone"
        Me.txtphone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtphone.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtphone.PlaceholderText = ""
        Me.txtphone.SelectedText = ""
        Me.txtphone.Size = New System.Drawing.Size(329, 40)
        Me.txtphone.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(410, 423)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 26)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Phone"
        '
        'txtemail
        '
        Me.txtemail.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtemail.BorderRadius = 2
        Me.txtemail.BorderThickness = 2
        Me.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemail.DefaultText = ""
        Me.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemail.FillColor = System.Drawing.Color.Transparent
        Me.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtemail.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.ForeColor = System.Drawing.Color.Gray
        Me.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtemail.Location = New System.Drawing.Point(49, 467)
        Me.txtemail.MaxLength = 50
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemail.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtemail.PlaceholderText = ""
        Me.txtemail.SelectedText = ""
        Me.txtemail.Size = New System.Drawing.Size(329, 40)
        Me.txtemail.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(44, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 26)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Email"
        '
        'txtgymname
        '
        Me.txtgymname.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtgymname.BorderRadius = 2
        Me.txtgymname.BorderThickness = 2
        Me.txtgymname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtgymname.DefaultText = ""
        Me.txtgymname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtgymname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtgymname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtgymname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtgymname.FillColor = System.Drawing.Color.Transparent
        Me.txtgymname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtgymname.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgymname.ForeColor = System.Drawing.Color.Gray
        Me.txtgymname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtgymname.Location = New System.Drawing.Point(49, 353)
        Me.txtgymname.MaxLength = 50
        Me.txtgymname.Name = "txtgymname"
        Me.txtgymname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtgymname.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtgymname.PlaceholderText = ""
        Me.txtgymname.SelectedText = ""
        Me.txtgymname.Size = New System.Drawing.Size(329, 40)
        Me.txtgymname.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(44, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 26)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Gym Name"
        '
        'Settingsfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 20)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1093, 896)
        Me.Controls.Add(Me.txtgymname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnaddprofile)
        Me.Controls.Add(Me.profile)
        Me.Controls.Add(Me.btnmemberenter)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnforgotpass)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lblname)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settingsfrm"
        Me.Text = "SETTINGS"
        CType(Me.profile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnforgotpass As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtusername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents btnaddprofile As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnmemberenter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents openimage As OpenFileDialog
    Friend WithEvents profile As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtphone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtemail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtgymname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
End Class
