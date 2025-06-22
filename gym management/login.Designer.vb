<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.P2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btncloselogin = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtusername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblforgot = New System.Windows.Forms.LinkLabel()
        Me.btnlogin = New Guna.UI2.WinForms.Guna2Button()
        Me.P3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.btncloseforgot = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdecrypt = New System.Windows.Forms.TextBox()
        Me.lblcheckedpassword = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtverify = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblverify = New System.Windows.Forms.Label()
        Me.txtpersonalkey = New System.Windows.Forms.TextBox()
        Me.txtusbstorage = New System.Windows.Forms.TextBox()
        Me.txtusbpassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btndecrypt = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtserialusb = New System.Windows.Forms.TextBox()
        Me.txtcorrectpass = New System.Windows.Forms.TextBox()
        Me.T1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.P2.SuspendLayout()
        CType(Me.btncloselogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P3.SuspendLayout()
        CType(Me.btncloseforgot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'P2
        '
        Me.P2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.P2.BorderRadius = 8
        Me.P2.Controls.Add(Me.Label9)
        Me.P2.Controls.Add(Me.Label1)
        Me.P2.Controls.Add(Me.Label8)
        Me.P2.Controls.Add(Me.btncloselogin)
        Me.P2.Controls.Add(Me.txtpassword)
        Me.P2.Controls.Add(Me.Guna2PictureBox1)
        Me.P2.Controls.Add(Me.txtusername)
        Me.P2.Controls.Add(Me.lblforgot)
        Me.P2.Controls.Add(Me.btnlogin)
        Me.T1.SetDecoration(Me.P2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.P2.Location = New System.Drawing.Point(0, 0)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(473, 713)
        Me.P2.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.T1.SetDecoration(Me.Label9, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label9.ForeColor = System.Drawing.Color.Silver
        Me.Label9.Location = New System.Drawing.Point(111, 683)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(249, 17)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "© All rights reserved to devang yadav."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.T1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(132, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 80)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "GYM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.T1.SetDecoration(Me.Label8, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Mongolian Baiti", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(96, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(281, 50)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Management"
        '
        'btncloselogin
        '
        Me.btncloselogin.BackColor = System.Drawing.Color.Transparent
        Me.T1.SetDecoration(Me.btncloselogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btncloselogin.FillColor = System.Drawing.Color.Transparent
        Me.btncloselogin.Image = CType(resources.GetObject("btncloselogin.Image"), System.Drawing.Image)
        Me.btncloselogin.ImageRotate = 0!
        Me.btncloselogin.Location = New System.Drawing.Point(434, 10)
        Me.btncloselogin.Name = "btncloselogin"
        Me.btncloselogin.Size = New System.Drawing.Size(30, 30)
        Me.btncloselogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncloselogin.TabIndex = 10
        Me.btncloselogin.TabStop = False
        Me.btncloselogin.UseTransparentBackground = True
        '
        'txtpassword
        '
        Me.txtpassword.Animated = True
        Me.txtpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtpassword.BorderColor = System.Drawing.Color.Gray
        Me.txtpassword.BorderRadius = 8
        Me.txtpassword.BorderThickness = 2
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.T1.SetDecoration(Me.txtpassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtpassword.DefaultText = ""
        Me.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.FillColor = System.Drawing.Color.Transparent
        Me.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtpassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.txtpassword.ForeColor = System.Drawing.Color.Gray
        Me.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtpassword.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.txtpassword.Location = New System.Drawing.Point(71, 486)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtpassword.MaxLength = 100
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtpassword.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtpassword.PlaceholderText = "Password"
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.Size = New System.Drawing.Size(350, 49)
        Me.txtpassword.TabIndex = 6
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.T1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 30.0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(154, 108)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(164, 126)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 23
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'txtusername
        '
        Me.txtusername.Animated = True
        Me.txtusername.BackColor = System.Drawing.Color.Transparent
        Me.txtusername.BorderColor = System.Drawing.Color.Gray
        Me.txtusername.BorderRadius = 8
        Me.txtusername.BorderThickness = 2
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.T1.SetDecoration(Me.txtusername, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtusername.DefaultText = ""
        Me.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusername.FillColor = System.Drawing.Color.Transparent
        Me.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtusername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!)
        Me.txtusername.ForeColor = System.Drawing.Color.Gray
        Me.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.txtusername.Location = New System.Drawing.Point(71, 407)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtusername.MaxLength = 100
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtusername.PlaceholderText = "Username"
        Me.txtusername.SelectedText = ""
        Me.txtusername.Size = New System.Drawing.Size(350, 49)
        Me.txtusername.TabIndex = 5
        '
        'lblforgot
        '
        Me.lblforgot.ActiveLinkColor = System.Drawing.Color.White
        Me.lblforgot.AutoSize = True
        Me.T1.SetDecoration(Me.lblforgot, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblforgot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblforgot.LinkColor = System.Drawing.Color.DarkGray
        Me.lblforgot.Location = New System.Drawing.Point(298, 556)
        Me.lblforgot.Name = "lblforgot"
        Me.lblforgot.Size = New System.Drawing.Size(123, 18)
        Me.lblforgot.TabIndex = 4
        Me.lblforgot.TabStop = True
        Me.lblforgot.Text = "Forgot Password"
        Me.lblforgot.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'btnlogin
        '
        Me.btnlogin.Animated = True
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.BorderColor = System.Drawing.Color.DimGray
        Me.btnlogin.BorderRadius = 8
        Me.T1.SetDecoration(Me.btnlogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnlogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.btnlogin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!)
        Me.btnlogin.ForeColor = System.Drawing.Color.LightGray
        Me.btnlogin.Location = New System.Drawing.Point(71, 596)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(350, 53)
        Me.btnlogin.TabIndex = 3
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseTransparentBackground = True
        '
        'P3
        '
        Me.P3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.P3.BorderRadius = 8
        Me.P3.Controls.Add(Me.lblstatus)
        Me.P3.Controls.Add(Me.btncloseforgot)
        Me.P3.Controls.Add(Me.Guna2PictureBox3)
        Me.P3.Controls.Add(Me.GroupBox1)
        Me.T1.SetDecoration(Me.P3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.P3.Location = New System.Drawing.Point(0, 0)
        Me.P3.Name = "P3"
        Me.P3.Size = New System.Drawing.Size(473, 713)
        Me.P3.TabIndex = 22
        Me.P3.Visible = False
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.T1.SetDecoration(Me.lblstatus, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblstatus.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold)
        Me.lblstatus.ForeColor = System.Drawing.Color.Silver
        Me.lblstatus.Location = New System.Drawing.Point(99, 203)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(288, 31)
        Me.lblstatus.TabIndex = 21
        Me.lblstatus.Text = "Login With PenDrive !!"
        Me.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncloseforgot
        '
        Me.btncloseforgot.BackColor = System.Drawing.Color.Transparent
        Me.T1.SetDecoration(Me.btncloseforgot, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btncloseforgot.Image = CType(resources.GetObject("btncloseforgot.Image"), System.Drawing.Image)
        Me.btncloseforgot.ImageRotate = 0!
        Me.btncloseforgot.Location = New System.Drawing.Point(429, 9)
        Me.btncloseforgot.Name = "btncloseforgot"
        Me.btncloseforgot.Size = New System.Drawing.Size(35, 35)
        Me.btncloseforgot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncloseforgot.TabIndex = 11
        Me.btncloseforgot.TabStop = False
        Me.btncloseforgot.UseTransparentBackground = True
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T1.SetDecoration(Me.Guna2PictureBox3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(154, 12)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(164, 174)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox3.TabIndex = 9
        Me.Guna2PictureBox3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdecrypt)
        Me.GroupBox1.Controls.Add(Me.lblcheckedpassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtverify)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblverify)
        Me.GroupBox1.Controls.Add(Me.txtpersonalkey)
        Me.GroupBox1.Controls.Add(Me.txtusbstorage)
        Me.GroupBox1.Controls.Add(Me.txtusbpassword)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btndecrypt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtserialusb)
        Me.GroupBox1.Controls.Add(Me.txtcorrectpass)
        Me.T1.SetDecoration(Me.GroupBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 243)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 452)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'txtdecrypt
        '
        Me.T1.SetDecoration(Me.txtdecrypt, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtdecrypt.Location = New System.Drawing.Point(153, 102)
        Me.txtdecrypt.Multiline = True
        Me.txtdecrypt.Name = "txtdecrypt"
        Me.txtdecrypt.Size = New System.Drawing.Size(197, 45)
        Me.txtdecrypt.TabIndex = 25
        '
        'lblcheckedpassword
        '
        Me.lblcheckedpassword.AutoSize = True
        Me.T1.SetDecoration(Me.lblcheckedpassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblcheckedpassword.ForeColor = System.Drawing.Color.Silver
        Me.lblcheckedpassword.Location = New System.Drawing.Point(206, 342)
        Me.lblcheckedpassword.Name = "lblcheckedpassword"
        Me.lblcheckedpassword.Size = New System.Drawing.Size(135, 17)
        Me.lblcheckedpassword.TabIndex = 36
        Me.lblcheckedpassword.Text = "lblcheckedpassword"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.T1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(22, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "personal key"
        '
        'ProgressBar1
        '
        Me.T1.SetDecoration(Me.ProgressBar1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 423)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(428, 17)
        Me.ProgressBar1.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.T1.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(22, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "password"
        '
        'txtverify
        '
        Me.txtverify.Cursor = System.Windows.Forms.Cursors.No
        Me.T1.SetDecoration(Me.txtverify, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtverify.Location = New System.Drawing.Point(153, 380)
        Me.txtverify.Name = "txtverify"
        Me.txtverify.ReadOnly = True
        Me.txtverify.Size = New System.Drawing.Size(197, 22)
        Me.txtverify.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.T1.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(22, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "decrypt"
        '
        'lblverify
        '
        Me.lblverify.AutoSize = True
        Me.T1.SetDecoration(Me.lblverify, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.lblverify.ForeColor = System.Drawing.Color.Silver
        Me.lblverify.Location = New System.Drawing.Point(22, 380)
        Me.lblverify.Name = "lblverify"
        Me.lblverify.Size = New System.Drawing.Size(42, 17)
        Me.lblverify.TabIndex = 33
        Me.lblverify.Text = "verify"
        '
        'txtpersonalkey
        '
        Me.T1.SetDecoration(Me.txtpersonalkey, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtpersonalkey.Location = New System.Drawing.Point(153, 25)
        Me.txtpersonalkey.Name = "txtpersonalkey"
        Me.txtpersonalkey.ReadOnly = True
        Me.txtpersonalkey.Size = New System.Drawing.Size(197, 22)
        Me.txtpersonalkey.TabIndex = 23
        '
        'txtusbstorage
        '
        Me.T1.SetDecoration(Me.txtusbstorage, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtusbstorage.Location = New System.Drawing.Point(153, 299)
        Me.txtusbstorage.Name = "txtusbstorage"
        Me.txtusbstorage.Size = New System.Drawing.Size(197, 22)
        Me.txtusbstorage.TabIndex = 32
        '
        'txtusbpassword
        '
        Me.T1.SetDecoration(Me.txtusbpassword, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtusbpassword.Location = New System.Drawing.Point(153, 63)
        Me.txtusbpassword.Name = "txtusbpassword"
        Me.txtusbpassword.ReadOnly = True
        Me.txtusbpassword.Size = New System.Drawing.Size(197, 22)
        Me.txtusbpassword.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.T1.SetDecoration(Me.Label7, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(22, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "serial usb storage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.T1.SetDecoration(Me.Label6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(22, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Correct password"
        '
        'btndecrypt
        '
        Me.T1.SetDecoration(Me.btndecrypt, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btndecrypt.Location = New System.Drawing.Point(209, 172)
        Me.btndecrypt.Name = "btndecrypt"
        Me.btndecrypt.Size = New System.Drawing.Size(75, 29)
        Me.btndecrypt.TabIndex = 30
        Me.btndecrypt.TabStop = False
        Me.btndecrypt.Text = "decrypt"
        Me.btndecrypt.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.T1.SetDecoration(Me.Label5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(22, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "serial usb"
        '
        'txtserialusb
        '
        Me.T1.SetDecoration(Me.txtserialusb, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtserialusb.Location = New System.Drawing.Point(154, 259)
        Me.txtserialusb.Name = "txtserialusb"
        Me.txtserialusb.Size = New System.Drawing.Size(197, 22)
        Me.txtserialusb.TabIndex = 29
        '
        'txtcorrectpass
        '
        Me.T1.SetDecoration(Me.txtcorrectpass, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtcorrectpass.Location = New System.Drawing.Point(154, 220)
        Me.txtcorrectpass.Name = "txtcorrectpass"
        Me.txtcorrectpass.Size = New System.Drawing.Size(197, 22)
        Me.txtcorrectpass.TabIndex = 28
        '
        'T1
        '
        Me.T1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.T1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 1.0!
        Me.T1.DefaultAnimation = Animation2
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 11
        Me.Guna2Elipse1.TargetControl = Me
        '
        'login
        '
        Me.AcceptButton = Me.btnlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(475, 710)
        Me.Controls.Add(Me.P3)
        Me.Controls.Add(Me.P2)
        Me.T1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.P2.ResumeLayout(False)
        Me.P2.PerformLayout()
        CType(Me.btncloselogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P3.ResumeLayout(False)
        Me.P3.PerformLayout()
        CType(Me.btncloseforgot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtusername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblforgot As LinkLabel
    Friend WithEvents btnlogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents T1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents btncloselogin As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents P3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblstatus As Label
    Friend WithEvents btncloseforgot As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label9 As Label
    Friend WithEvents txtdecrypt As TextBox
    Friend WithEvents lblcheckedpassword As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents txtverify As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblverify As Label
    Friend WithEvents txtpersonalkey As TextBox
    Friend WithEvents txtusbstorage As TextBox
    Friend WithEvents txtusbpassword As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btndecrypt As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtserialusb As TextBox
    Friend WithEvents txtcorrectpass As TextBox
End Class
