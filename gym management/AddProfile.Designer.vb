<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProfile))
        Me.openimage = New System.Windows.Forms.OpenFileDialog()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblage = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.lbljoindate = New System.Windows.Forms.Label()
        Me.txtfullname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtmemberage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtmemberemail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtmemberaddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnmemberenter = New Guna.UI2.WinForms.Guna2Button()
        Me.btnmemberclear = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmemberphone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbirthdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.lblcategory = New System.Windows.Forms.Label()
        Me.txtcategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtjoindate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblcurrentweight = New System.Windows.Forms.Label()
        Me.txtcurrentweight = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtheight = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txttrainertype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtsalary = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.memberpanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblmonths = New System.Windows.Forms.Label()
        Me.txttotalfees = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbltotalfees = New System.Windows.Forms.Label()
        Me.txtmemberplan = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblplan = New System.Windows.Forms.Label()
        Me.txtmonths = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.openpdf = New System.Windows.Forms.OpenFileDialog()
        Me.btnmale = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnfemale = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.btnback = New Guna.UI2.WinForms.Guna2Button()
        Me.btnupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.txtuserid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.subexpanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblsalarydate = New System.Windows.Forms.Label()
        Me.txtsubexdate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblsubexpire = New System.Windows.Forms.Label()
        Me.trainerpanel = New System.Windows.Forms.Panel()
        Me.btnaddprofile = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Displayprofile = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnremoveuser = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnrestore = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.memberpanel.SuspendLayout()
        Me.subexpanel.SuspendLayout()
        Me.trainerpanel.SuspendLayout()
        CType(Me.Displayprofile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'openimage
        '
        Me.openimage.FileName = "OpenFileDialog1"
        '
        'lblname
        '
        Me.lblname.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.DarkGray
        Me.lblname.Location = New System.Drawing.Point(17, 216)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(110, 26)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Full Name"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblemail.ForeColor = System.Drawing.Color.DarkGray
        Me.lblemail.Location = New System.Drawing.Point(255, 509)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(65, 26)
        Me.lblemail.TabIndex = 1
        Me.lblemail.Text = "Email"
        '
        'lblage
        '
        Me.lblage.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblage.ForeColor = System.Drawing.Color.DarkGray
        Me.lblage.Location = New System.Drawing.Point(255, 403)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(55, 34)
        Me.lblage.TabIndex = 2
        Me.lblage.Text = "Age"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbladdress.ForeColor = System.Drawing.Color.DarkGray
        Me.lbladdress.Location = New System.Drawing.Point(17, 610)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(89, 26)
        Me.lbladdress.TabIndex = 3
        Me.lbladdress.Text = "Address"
        '
        'lbljoindate
        '
        Me.lbljoindate.AutoSize = True
        Me.lbljoindate.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbljoindate.ForeColor = System.Drawing.Color.DarkGray
        Me.lbljoindate.Location = New System.Drawing.Point(735, 216)
        Me.lbljoindate.Name = "lbljoindate"
        Me.lbljoindate.Size = New System.Drawing.Size(102, 26)
        Me.lbljoindate.TabIndex = 5
        Me.lbljoindate.Text = "Join Date"
        '
        'txtfullname
        '
        Me.txtfullname.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtfullname.BorderRadius = 2
        Me.txtfullname.BorderThickness = 2
        Me.txtfullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfullname.DefaultText = ""
        Me.txtfullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtfullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtfullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfullname.FillColor = System.Drawing.Color.Transparent
        Me.txtfullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtfullname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtfullname.ForeColor = System.Drawing.Color.Gray
        Me.txtfullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtfullname.Location = New System.Drawing.Point(17, 258)
        Me.txtfullname.MaxLength = 50
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfullname.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtfullname.PlaceholderText = ""
        Me.txtfullname.SelectedText = ""
        Me.txtfullname.Size = New System.Drawing.Size(443, 40)
        Me.txtfullname.TabIndex = 1
        '
        'txtmemberage
        '
        Me.txtmemberage.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtmemberage.BorderRadius = 2
        Me.txtmemberage.BorderThickness = 2
        Me.txtmemberage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmemberage.DefaultText = ""
        Me.txtmemberage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtmemberage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtmemberage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmemberage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmemberage.FillColor = System.Drawing.Color.Transparent
        Me.txtmemberage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtmemberage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtmemberage.ForeColor = System.Drawing.Color.Gray
        Me.txtmemberage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtmemberage.Location = New System.Drawing.Point(260, 447)
        Me.txtmemberage.MaxLength = 2
        Me.txtmemberage.Name = "txtmemberage"
        Me.txtmemberage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmemberage.PlaceholderText = ""
        Me.txtmemberage.SelectedText = ""
        Me.txtmemberage.Size = New System.Drawing.Size(200, 34)
        Me.txtmemberage.TabIndex = 7
        '
        'txtmemberemail
        '
        Me.txtmemberemail.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtmemberemail.BorderRadius = 2
        Me.txtmemberemail.BorderThickness = 2
        Me.txtmemberemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmemberemail.DefaultText = ""
        Me.txtmemberemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtmemberemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtmemberemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmemberemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmemberemail.FillColor = System.Drawing.Color.Transparent
        Me.txtmemberemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtmemberemail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtmemberemail.ForeColor = System.Drawing.Color.Gray
        Me.txtmemberemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtmemberemail.Location = New System.Drawing.Point(260, 545)
        Me.txtmemberemail.MaxLength = 50
        Me.txtmemberemail.Name = "txtmemberemail"
        Me.txtmemberemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmemberemail.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtmemberemail.PlaceholderText = "Email@Example.com"
        Me.txtmemberemail.SelectedText = ""
        Me.txtmemberemail.Size = New System.Drawing.Size(200, 34)
        Me.txtmemberemail.TabIndex = 12
        '
        'txtmemberaddress
        '
        Me.txtmemberaddress.BackColor = System.Drawing.Color.Transparent
        Me.txtmemberaddress.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtmemberaddress.BorderRadius = 2
        Me.txtmemberaddress.BorderThickness = 2
        Me.txtmemberaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmemberaddress.DefaultText = ""
        Me.txtmemberaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtmemberaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtmemberaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmemberaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmemberaddress.FillColor = System.Drawing.Color.Transparent
        Me.txtmemberaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtmemberaddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtmemberaddress.ForeColor = System.Drawing.Color.Gray
        Me.txtmemberaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtmemberaddress.Location = New System.Drawing.Point(17, 647)
        Me.txtmemberaddress.Margin = New System.Windows.Forms.Padding(0)
        Me.txtmemberaddress.Multiline = True
        Me.txtmemberaddress.Name = "txtmemberaddress"
        Me.txtmemberaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmemberaddress.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtmemberaddress.PlaceholderText = "Write Address......"
        Me.txtmemberaddress.SelectedText = ""
        Me.txtmemberaddress.Size = New System.Drawing.Size(930, 213)
        Me.txtmemberaddress.TabIndex = 13
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
        Me.btnmemberenter.Location = New System.Drawing.Point(17, 883)
        Me.btnmemberenter.Name = "btnmemberenter"
        Me.btnmemberenter.Size = New System.Drawing.Size(200, 45)
        Me.btnmemberenter.TabIndex = 14
        Me.btnmemberenter.Text = "Save"
        '
        'btnmemberclear
        '
        Me.btnmemberclear.BorderRadius = 4
        Me.btnmemberclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnmemberclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnmemberclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnmemberclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnmemberclear.FillColor = System.Drawing.SystemColors.Desktop
        Me.btnmemberclear.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnmemberclear.ForeColor = System.Drawing.Color.Silver
        Me.btnmemberclear.Location = New System.Drawing.Point(249, 883)
        Me.btnmemberclear.Name = "btnmemberclear"
        Me.btnmemberclear.Size = New System.Drawing.Size(200, 45)
        Me.btnmemberclear.TabIndex = 15
        Me.btnmemberclear.Text = "Clear"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(20, 510)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Phone"
        '
        'txtmemberphone
        '
        Me.txtmemberphone.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtmemberphone.BorderRadius = 2
        Me.txtmemberphone.BorderThickness = 2
        Me.txtmemberphone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmemberphone.DefaultText = ""
        Me.txtmemberphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtmemberphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtmemberphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmemberphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmemberphone.FillColor = System.Drawing.Color.Transparent
        Me.txtmemberphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtmemberphone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtmemberphone.ForeColor = System.Drawing.Color.Gray
        Me.txtmemberphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtmemberphone.Location = New System.Drawing.Point(20, 545)
        Me.txtmemberphone.MaxLength = 10
        Me.txtmemberphone.Name = "txtmemberphone"
        Me.txtmemberphone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmemberphone.PlaceholderText = ""
        Me.txtmemberphone.SelectedText = ""
        Me.txtmemberphone.Size = New System.Drawing.Size(200, 34)
        Me.txtmemberphone.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(24, 407)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 26)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Birth Date"
        '
        'txtbirthdate
        '
        Me.txtbirthdate.BorderRadius = 2
        Me.txtbirthdate.Checked = True
        Me.txtbirthdate.CustomFormat = "yyyy-MM-dd"
        Me.txtbirthdate.FillColor = System.Drawing.SystemColors.Desktop
        Me.txtbirthdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbirthdate.ForeColor = System.Drawing.Color.Black
        Me.txtbirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtbirthdate.Location = New System.Drawing.Point(20, 446)
        Me.txtbirthdate.MaxDate = New Date(2003, 12, 31, 0, 0, 0, 0)
        Me.txtbirthdate.MinDate = New Date(1942, 1, 1, 0, 0, 0, 0)
        Me.txtbirthdate.Name = "txtbirthdate"
        Me.txtbirthdate.Size = New System.Drawing.Size(200, 36)
        Me.txtbirthdate.TabIndex = 6
        Me.txtbirthdate.Value = New Date(2003, 1, 1, 0, 0, 0, 0)
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblgender.ForeColor = System.Drawing.Color.DarkGray
        Me.lblgender.Location = New System.Drawing.Point(15, 313)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(82, 26)
        Me.lblgender.TabIndex = 22
        Me.lblgender.Text = "Gender"
        '
        'lblcategory
        '
        Me.lblcategory.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategory.ForeColor = System.Drawing.Color.DarkGray
        Me.lblcategory.Location = New System.Drawing.Point(483, 216)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(110, 26)
        Me.lblcategory.TabIndex = 30
        Me.lblcategory.Text = "Category"
        '
        'txtcategory
        '
        Me.txtcategory.BackColor = System.Drawing.Color.Transparent
        Me.txtcategory.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtcategory.BorderRadius = 2
        Me.txtcategory.BorderThickness = 2
        Me.txtcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtcategory.FillColor = System.Drawing.Color.Transparent
        Me.txtcategory.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtcategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtcategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtcategory.ForeColor = System.Drawing.Color.Gray
        Me.txtcategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtcategory.ItemHeight = 30
        Me.txtcategory.Items.AddRange(New Object() {"Member", "Trainer"})
        Me.txtcategory.ItemsAppearance.BackColor = System.Drawing.Color.Black
        Me.txtcategory.ItemsAppearance.SelectedBackColor = System.Drawing.Color.DimGray
        Me.txtcategory.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Silver
        Me.txtcategory.Location = New System.Drawing.Point(488, 260)
        Me.txtcategory.Name = "txtcategory"
        Me.txtcategory.Size = New System.Drawing.Size(200, 36)
        Me.txtcategory.Sorted = True
        Me.txtcategory.StartIndex = 0
        Me.txtcategory.TabIndex = 2
        '
        'txtjoindate
        '
        Me.txtjoindate.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtjoindate.BorderRadius = 2
        Me.txtjoindate.BorderThickness = 2
        Me.txtjoindate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtjoindate.DefaultText = ""
        Me.txtjoindate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtjoindate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtjoindate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtjoindate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtjoindate.FillColor = System.Drawing.Color.Transparent
        Me.txtjoindate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtjoindate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtjoindate.ForeColor = System.Drawing.Color.Gray
        Me.txtjoindate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtjoindate.Location = New System.Drawing.Point(740, 261)
        Me.txtjoindate.MaxLength = 10
        Me.txtjoindate.Name = "txtjoindate"
        Me.txtjoindate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjoindate.PlaceholderText = ""
        Me.txtjoindate.ReadOnly = True
        Me.txtjoindate.SelectedText = ""
        Me.txtjoindate.Size = New System.Drawing.Size(200, 34)
        Me.txtjoindate.TabIndex = 33
        '
        'lblcurrentweight
        '
        Me.lblcurrentweight.AutoSize = True
        Me.lblcurrentweight.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblcurrentweight.ForeColor = System.Drawing.Color.DarkGray
        Me.lblcurrentweight.Location = New System.Drawing.Point(485, 313)
        Me.lblcurrentweight.Name = "lblcurrentweight"
        Me.lblcurrentweight.Size = New System.Drawing.Size(82, 26)
        Me.lblcurrentweight.TabIndex = 33
        Me.lblcurrentweight.Text = "Weight"
        '
        'txtcurrentweight
        '
        Me.txtcurrentweight.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtcurrentweight.BorderRadius = 2
        Me.txtcurrentweight.BorderThickness = 2
        Me.txtcurrentweight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcurrentweight.DefaultText = ""
        Me.txtcurrentweight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcurrentweight.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcurrentweight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcurrentweight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcurrentweight.FillColor = System.Drawing.Color.Transparent
        Me.txtcurrentweight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtcurrentweight.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtcurrentweight.ForeColor = System.Drawing.Color.Gray
        Me.txtcurrentweight.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtcurrentweight.Location = New System.Drawing.Point(490, 358)
        Me.txtcurrentweight.MaxLength = 6
        Me.txtcurrentweight.Name = "txtcurrentweight"
        Me.txtcurrentweight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcurrentweight.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtcurrentweight.PlaceholderText = "KG"
        Me.txtcurrentweight.SelectedText = ""
        Me.txtcurrentweight.Size = New System.Drawing.Size(200, 34)
        Me.txtcurrentweight.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(735, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 26)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Height"
        '
        'txtheight
        '
        Me.txtheight.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtheight.BorderRadius = 2
        Me.txtheight.BorderThickness = 2
        Me.txtheight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtheight.DefaultText = ""
        Me.txtheight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtheight.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtheight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtheight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtheight.FillColor = System.Drawing.Color.Transparent
        Me.txtheight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtheight.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtheight.ForeColor = System.Drawing.Color.Gray
        Me.txtheight.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtheight.Location = New System.Drawing.Point(740, 358)
        Me.txtheight.MaxLength = 6
        Me.txtheight.Name = "txtheight"
        Me.txtheight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtheight.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtheight.PlaceholderText = "CM"
        Me.txtheight.SelectedText = ""
        Me.txtheight.Size = New System.Drawing.Size(200, 34)
        Me.txtheight.TabIndex = 5
        '
        'txttrainertype
        '
        Me.txttrainertype.BackColor = System.Drawing.Color.Transparent
        Me.txttrainertype.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txttrainertype.BorderRadius = 2
        Me.txttrainertype.BorderThickness = 2
        Me.txttrainertype.DisplayMember = "f"
        Me.txttrainertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txttrainertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txttrainertype.FillColor = System.Drawing.Color.Transparent
        Me.txttrainertype.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txttrainertype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txttrainertype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txttrainertype.ForeColor = System.Drawing.Color.Gray
        Me.txttrainertype.ItemHeight = 30
        Me.txttrainertype.Items.AddRange(New Object() {"Cardio", "Cardio and Strength", "Personal ", "Strength"})
        Me.txttrainertype.ItemsAppearance.BackColor = System.Drawing.Color.Black
        Me.txttrainertype.ItemsAppearance.SelectedBackColor = System.Drawing.Color.DimGray
        Me.txttrainertype.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Silver
        Me.txttrainertype.Location = New System.Drawing.Point(12, 39)
        Me.txttrainertype.Name = "txttrainertype"
        Me.txttrainertype.Size = New System.Drawing.Size(200, 36)
        Me.txttrainertype.Sorted = True
        Me.txttrainertype.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(7, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 26)
        Me.Label7.TabIndex = 703
        Me.Label7.Text = "Trainer Type"
        '
        'txtsalary
        '
        Me.txtsalary.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtsalary.BorderRadius = 2
        Me.txtsalary.BorderThickness = 2
        Me.txtsalary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsalary.DefaultText = ""
        Me.txtsalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsalary.FillColor = System.Drawing.Color.Transparent
        Me.txtsalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtsalary.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsalary.ForeColor = System.Drawing.Color.DarkGray
        Me.txtsalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtsalary.Location = New System.Drawing.Point(12, 139)
        Me.txtsalary.MaxLength = 6
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsalary.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtsalary.PlaceholderText = "₹"
        Me.txtsalary.SelectedText = ""
        Me.txtsalary.Size = New System.Drawing.Size(200, 36)
        Me.txtsalary.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(9, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 26)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Salary"
        '
        'memberpanel
        '
        Me.memberpanel.Controls.Add(Me.lblmonths)
        Me.memberpanel.Controls.Add(Me.txttotalfees)
        Me.memberpanel.Controls.Add(Me.lbltotalfees)
        Me.memberpanel.Controls.Add(Me.txtmemberplan)
        Me.memberpanel.Controls.Add(Me.lblplan)
        Me.memberpanel.Controls.Add(Me.txtmonths)
        Me.memberpanel.Location = New System.Drawing.Point(476, 406)
        Me.memberpanel.Name = "memberpanel"
        Me.memberpanel.Size = New System.Drawing.Size(471, 194)
        Me.memberpanel.TabIndex = 39
        '
        'lblmonths
        '
        Me.lblmonths.AutoSize = True
        Me.lblmonths.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblmonths.ForeColor = System.Drawing.Color.DarkGray
        Me.lblmonths.Location = New System.Drawing.Point(259, 1)
        Me.lblmonths.Name = "lblmonths"
        Me.lblmonths.Size = New System.Drawing.Size(85, 26)
        Me.lblmonths.TabIndex = 49
        Me.lblmonths.Text = "Months"
        '
        'txttotalfees
        '
        Me.txttotalfees.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txttotalfees.BorderRadius = 2
        Me.txttotalfees.BorderThickness = 2
        Me.txttotalfees.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttotalfees.DefaultText = ""
        Me.txttotalfees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txttotalfees.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txttotalfees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotalfees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotalfees.FillColor = System.Drawing.Color.Transparent
        Me.txttotalfees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txttotalfees.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txttotalfees.ForeColor = System.Drawing.Color.Gray
        Me.txttotalfees.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txttotalfees.Location = New System.Drawing.Point(12, 139)
        Me.txttotalfees.MaxLength = 4
        Me.txttotalfees.Name = "txttotalfees"
        Me.txttotalfees.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttotalfees.PlaceholderText = ""
        Me.txttotalfees.ReadOnly = True
        Me.txttotalfees.SelectedText = ""
        Me.txttotalfees.Size = New System.Drawing.Size(200, 34)
        Me.txttotalfees.TabIndex = 10
        '
        'lbltotalfees
        '
        Me.lbltotalfees.AutoSize = True
        Me.lbltotalfees.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbltotalfees.ForeColor = System.Drawing.Color.DarkGray
        Me.lbltotalfees.Location = New System.Drawing.Point(9, 104)
        Me.lbltotalfees.Name = "lbltotalfees"
        Me.lbltotalfees.Size = New System.Drawing.Size(144, 26)
        Me.lbltotalfees.TabIndex = 48
        Me.lbltotalfees.Text = "Total Amount"
        '
        'txtmemberplan
        '
        Me.txtmemberplan.BackColor = System.Drawing.Color.Transparent
        Me.txtmemberplan.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtmemberplan.BorderRadius = 2
        Me.txtmemberplan.BorderThickness = 2
        Me.txtmemberplan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtmemberplan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtmemberplan.FillColor = System.Drawing.Color.Transparent
        Me.txtmemberplan.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtmemberplan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtmemberplan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtmemberplan.ForeColor = System.Drawing.Color.Gray
        Me.txtmemberplan.ItemHeight = 30
        Me.txtmemberplan.Items.AddRange(New Object() {"Cardio", "Cardio and Strength", "Personal", "Strength"})
        Me.txtmemberplan.ItemsAppearance.BackColor = System.Drawing.Color.Black
        Me.txtmemberplan.ItemsAppearance.SelectedBackColor = System.Drawing.Color.DimGray
        Me.txtmemberplan.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Silver
        Me.txtmemberplan.Location = New System.Drawing.Point(12, 41)
        Me.txtmemberplan.Name = "txtmemberplan"
        Me.txtmemberplan.Size = New System.Drawing.Size(200, 36)
        Me.txtmemberplan.Sorted = True
        Me.txtmemberplan.TabIndex = 8
        '
        'lblplan
        '
        Me.lblplan.AutoSize = True
        Me.lblplan.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblplan.ForeColor = System.Drawing.Color.DarkGray
        Me.lblplan.Location = New System.Drawing.Point(7, 1)
        Me.lblplan.Name = "lblplan"
        Me.lblplan.Size = New System.Drawing.Size(53, 26)
        Me.lblplan.TabIndex = 44
        Me.lblplan.Text = "Plan"
        '
        'txtmonths
        '
        Me.txtmonths.BackColor = System.Drawing.Color.Transparent
        Me.txtmonths.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtmonths.BorderRadius = 2
        Me.txtmonths.BorderThickness = 2
        Me.txtmonths.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtmonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtmonths.FillColor = System.Drawing.Color.Transparent
        Me.txtmonths.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtmonths.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtmonths.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtmonths.ForeColor = System.Drawing.Color.Gray
        Me.txtmonths.ItemHeight = 30
        Me.txtmonths.Items.AddRange(New Object() {"01 Month", "03 Months", "06 Months", "09 Months", "12 Months"})
        Me.txtmonths.ItemsAppearance.BackColor = System.Drawing.Color.Black
        Me.txtmonths.ItemsAppearance.SelectedBackColor = System.Drawing.Color.DimGray
        Me.txtmonths.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Silver
        Me.txtmonths.Location = New System.Drawing.Point(264, 41)
        Me.txtmonths.Name = "txtmonths"
        Me.txtmonths.Size = New System.Drawing.Size(200, 36)
        Me.txtmonths.Sorted = True
        Me.txtmonths.StartIndex = 0
        Me.txtmonths.TabIndex = 9
        '
        'openpdf
        '
        Me.openpdf.FileName = "OpenFileDialog1"
        '
        'btnmale
        '
        Me.btnmale.CheckedState.BorderColor = System.Drawing.SystemColors.Desktop
        Me.btnmale.CheckedState.BorderThickness = 0
        Me.btnmale.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnmale.CheckedState.InnerColor = System.Drawing.Color.White
        Me.btnmale.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnmale.Location = New System.Drawing.Point(22, 366)
        Me.btnmale.Name = "btnmale"
        Me.btnmale.Size = New System.Drawing.Size(18, 18)
        Me.btnmale.TabIndex = 3
        Me.btnmale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnmale.UncheckedState.BorderThickness = 2
        Me.btnmale.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btnmale.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(47, 362)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 26)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Male"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(144, 362)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 26)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Female"
        '
        'btnfemale
        '
        Me.btnfemale.CheckedState.BorderColor = System.Drawing.SystemColors.Desktop
        Me.btnfemale.CheckedState.BorderThickness = 0
        Me.btnfemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnfemale.CheckedState.InnerColor = System.Drawing.Color.White
        Me.btnfemale.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnfemale.Location = New System.Drawing.Point(119, 366)
        Me.btnfemale.Name = "btnfemale"
        Me.btnfemale.Size = New System.Drawing.Size(18, 18)
        Me.btnfemale.TabIndex = 43
        Me.btnfemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnfemale.UncheckedState.BorderThickness = 2
        Me.btnfemale.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btnfemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'btnback
        '
        Me.btnback.BorderRadius = 4
        Me.btnback.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnback.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnback.FillColor = System.Drawing.SystemColors.Desktop
        Me.btnback.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnback.ForeColor = System.Drawing.Color.Silver
        Me.btnback.Location = New System.Drawing.Point(249, 883)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(200, 45)
        Me.btnback.TabIndex = 15
        Me.btnback.Text = "Back"
        Me.btnback.Visible = False
        '
        'btnupdate
        '
        Me.btnupdate.Animated = True
        Me.btnupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnupdate.BorderRadius = 4
        Me.btnupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnupdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnupdate.ForeColor = System.Drawing.Color.Silver
        Me.btnupdate.Location = New System.Drawing.Point(17, 883)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(200, 45)
        Me.btnupdate.TabIndex = 14
        Me.btnupdate.Text = "Update"
        Me.btnupdate.Visible = False
        '
        'txtuserid
        '
        Me.txtuserid.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtuserid.BorderRadius = 2
        Me.txtuserid.BorderThickness = 2
        Me.txtuserid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtuserid.DefaultText = ""
        Me.txtuserid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtuserid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtuserid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtuserid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtuserid.FillColor = System.Drawing.Color.Transparent
        Me.txtuserid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtuserid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtuserid.ForeColor = System.Drawing.Color.Gray
        Me.txtuserid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtuserid.Location = New System.Drawing.Point(92, 39)
        Me.txtuserid.MaxLength = 10
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtuserid.PlaceholderText = ""
        Me.txtuserid.SelectedText = ""
        Me.txtuserid.Size = New System.Drawing.Size(68, 34)
        Me.txtuserid.TabIndex = 48
        '
        'subexpanel
        '
        Me.subexpanel.Controls.Add(Me.lblsalarydate)
        Me.subexpanel.Controls.Add(Me.txtsubexdate)
        Me.subexpanel.Controls.Add(Me.lblsubexpire)
        Me.subexpanel.Location = New System.Drawing.Point(476, 207)
        Me.subexpanel.Name = "subexpanel"
        Me.subexpanel.Size = New System.Drawing.Size(224, 103)
        Me.subexpanel.TabIndex = 705
        Me.subexpanel.Visible = False
        '
        'lblsalarydate
        '
        Me.lblsalarydate.AutoSize = True
        Me.lblsalarydate.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblsalarydate.ForeColor = System.Drawing.Color.DarkGray
        Me.lblsalarydate.Location = New System.Drawing.Point(9, 9)
        Me.lblsalarydate.Name = "lblsalarydate"
        Me.lblsalarydate.Size = New System.Drawing.Size(121, 26)
        Me.lblsalarydate.TabIndex = 707
        Me.lblsalarydate.Text = "Salary Date"
        Me.lblsalarydate.Visible = False
        '
        'txtsubexdate
        '
        Me.txtsubexdate.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtsubexdate.BorderRadius = 2
        Me.txtsubexdate.BorderThickness = 2
        Me.txtsubexdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsubexdate.DefaultText = ""
        Me.txtsubexdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsubexdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsubexdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsubexdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsubexdate.FillColor = System.Drawing.Color.Transparent
        Me.txtsubexdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtsubexdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsubexdate.ForeColor = System.Drawing.Color.Gray
        Me.txtsubexdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtsubexdate.Location = New System.Drawing.Point(12, 54)
        Me.txtsubexdate.MaxLength = 10
        Me.txtsubexdate.Name = "txtsubexdate"
        Me.txtsubexdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsubexdate.PlaceholderText = ""
        Me.txtsubexdate.ReadOnly = True
        Me.txtsubexdate.SelectedText = ""
        Me.txtsubexdate.Size = New System.Drawing.Size(200, 34)
        Me.txtsubexdate.TabIndex = 0
        '
        'lblsubexpire
        '
        Me.lblsubexpire.AutoSize = True
        Me.lblsubexpire.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblsubexpire.ForeColor = System.Drawing.Color.DarkGray
        Me.lblsubexpire.Location = New System.Drawing.Point(9, 9)
        Me.lblsubexpire.Name = "lblsubexpire"
        Me.lblsubexpire.Size = New System.Drawing.Size(114, 26)
        Me.lblsubexpire.TabIndex = 45
        Me.lblsubexpire.Text = "Sub Expire"
        '
        'trainerpanel
        '
        Me.trainerpanel.Controls.Add(Me.txttrainertype)
        Me.trainerpanel.Controls.Add(Me.Label7)
        Me.trainerpanel.Controls.Add(Me.Label3)
        Me.trainerpanel.Controls.Add(Me.txtsalary)
        Me.trainerpanel.Location = New System.Drawing.Point(476, 406)
        Me.trainerpanel.Name = "trainerpanel"
        Me.trainerpanel.Size = New System.Drawing.Size(471, 202)
        Me.trainerpanel.TabIndex = 706
        Me.trainerpanel.Visible = False
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
        Me.btnaddprofile.Location = New System.Drawing.Point(181, 186)
        Me.btnaddprofile.Name = "btnaddprofile"
        Me.btnaddprofile.PressedState.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnaddprofile.Size = New System.Drawing.Size(39, 33)
        Me.btnaddprofile.TabIndex = 0
        Me.btnaddprofile.UseTransparentBackground = True
        '
        'Displayprofile
        '
        Me.Displayprofile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Displayprofile.Image = CType(resources.GetObject("Displayprofile.Image"), System.Drawing.Image)
        Me.Displayprofile.ImageRotate = 0!
        Me.Displayprofile.Location = New System.Drawing.Point(17, 20)
        Me.Displayprofile.Name = "Displayprofile"
        Me.Displayprofile.Size = New System.Drawing.Size(181, 184)
        Me.Displayprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Displayprofile.TabIndex = 40
        Me.Displayprofile.TabStop = False
        '
        'btnremoveuser
        '
        Me.btnremoveuser.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnremoveuser.HoverState.ImageSize = New System.Drawing.Size(59, 59)
        Me.btnremoveuser.Image = CType(resources.GetObject("btnremoveuser.Image"), System.Drawing.Image)
        Me.btnremoveuser.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnremoveuser.ImageRotate = 0!
        Me.btnremoveuser.ImageSize = New System.Drawing.Size(60, 60)
        Me.btnremoveuser.Location = New System.Drawing.Point(890, 20)
        Me.btnremoveuser.Name = "btnremoveuser"
        Me.btnremoveuser.PressedState.ImageSize = New System.Drawing.Size(60, 60)
        Me.btnremoveuser.Size = New System.Drawing.Size(50, 53)
        Me.btnremoveuser.TabIndex = 50
        Me.btnremoveuser.Visible = False
        '
        'btnrestore
        '
        Me.btnrestore.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnrestore.HoverState.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnrestore.Image = CType(resources.GetObject("btnrestore.Image"), System.Drawing.Image)
        Me.btnrestore.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnrestore.ImageRotate = 0!
        Me.btnrestore.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnrestore.Location = New System.Drawing.Point(890, 20)
        Me.btnrestore.Name = "btnrestore"
        Me.btnrestore.PressedState.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnrestore.Size = New System.Drawing.Size(43, 53)
        Me.btnrestore.TabIndex = 707
        Me.btnrestore.Visible = False
        '
        'AddProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(10, 10)
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(964, 949)
        Me.Controls.Add(Me.btnrestore)
        Me.Controls.Add(Me.trainerpanel)
        Me.Controls.Add(Me.subexpanel)
        Me.Controls.Add(Me.btnremoveuser)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.txtmemberphone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmemberemail)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnfemale)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnmale)
        Me.Controls.Add(Me.btnaddprofile)
        Me.Controls.Add(Me.Displayprofile)
        Me.Controls.Add(Me.memberpanel)
        Me.Controls.Add(Me.txtheight)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcurrentweight)
        Me.Controls.Add(Me.lblcurrentweight)
        Me.Controls.Add(Me.txtjoindate)
        Me.Controls.Add(Me.txtcategory)
        Me.Controls.Add(Me.lblcategory)
        Me.Controls.Add(Me.lblgender)
        Me.Controls.Add(Me.txtbirthdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnmemberclear)
        Me.Controls.Add(Me.btnmemberenter)
        Me.Controls.Add(Me.txtmemberaddress)
        Me.Controls.Add(Me.txtmemberage)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.lbljoindate)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.lblage)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.txtuserid)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddProfile"
        Me.Text = "ADD PROFILE"
        Me.memberpanel.ResumeLayout(False)
        Me.memberpanel.PerformLayout()
        Me.subexpanel.ResumeLayout(False)
        Me.subexpanel.PerformLayout()
        Me.trainerpanel.ResumeLayout(False)
        Me.trainerpanel.PerformLayout()
        CType(Me.Displayprofile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents openimage As OpenFileDialog
    Friend WithEvents lblname As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents lblage As Label
    Friend WithEvents lbladdress As Label
    Friend WithEvents lbljoindate As Label
    Friend WithEvents txtfullname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtmemberage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtmemberemail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtmemberaddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnmemberenter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnmemberclear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtmemberphone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbirthdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblgender As Label
    Friend WithEvents btnaddprofile As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents lblcategory As Label
    Friend WithEvents txtcategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtjoindate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblcurrentweight As Label
    Friend WithEvents txtcurrentweight As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtheight As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents memberpanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtmonths As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblmonths As Label
    Friend WithEvents txttotalfees As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbltotalfees As Label
    Friend WithEvents txtmemberplan As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblplan As Label
    Friend WithEvents txtsalary As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txttrainertype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents openpdf As OpenFileDialog
    Friend WithEvents Displayprofile As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnmale As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnfemale As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents btnback As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtuserid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents subexpanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtsubexdate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblsubexpire As Label
    Friend WithEvents lblsalarydate As Label
    Friend WithEvents trainerpanel As Panel
    Friend WithEvents btnremoveuser As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnrestore As Guna.UI2.WinForms.Guna2ImageButton
End Class
