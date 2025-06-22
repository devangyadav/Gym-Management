<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class trainersalaryfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(trainersalaryfrm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnclear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsave = New Guna.UI2.WinForms.Guna2Button()
        Me.txttodaydate = New System.Windows.Forms.Label()
        Me.txtsalary = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txttrainertype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtfullname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblphoto = New System.Windows.Forms.Label()
        Me.trainerphoto = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbonus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.trainerdatagridview = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.trainerphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trainerdatagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(27, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 26)
        Me.Label2.TabIndex = 717
        Me.Label2.Text = "Profile"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.AutoScroll = True
        Me.Guna2Panel1.AutoScrollMargin = New System.Drawing.Size(0, 20)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.btnclear)
        Me.Guna2Panel1.Controls.Add(Me.btnsave)
        Me.Guna2Panel1.Controls.Add(Me.txttodaydate)
        Me.Guna2Panel1.Controls.Add(Me.txtsalary)
        Me.Guna2Panel1.Controls.Add(Me.txttrainertype)
        Me.Guna2Panel1.Controls.Add(Me.txtfullname)
        Me.Guna2Panel1.Controls.Add(Me.lblphoto)
        Me.Guna2Panel1.Controls.Add(Me.trainerphoto)
        Me.Guna2Panel1.Controls.Add(Me.Label7)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.txtbonus)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel1.Location = New System.Drawing.Point(996, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(395, 979)
        Me.Guna2Panel1.TabIndex = 721
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(35, 459)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 26)
        Me.Label4.TabIndex = 735
        Me.Label4.Text = "Name"
        '
        'btnclear
        '
        Me.btnclear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnclear.BorderRadius = 4
        Me.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnclear.FillColor = System.Drawing.SystemColors.Desktop
        Me.btnclear.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnclear.ForeColor = System.Drawing.Color.Silver
        Me.btnclear.Location = New System.Drawing.Point(204, 865)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(142, 45)
        Me.btnclear.TabIndex = 729
        Me.btnclear.Text = "Back"
        '
        'btnsave
        '
        Me.btnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsave.Animated = True
        Me.btnsave.BackColor = System.Drawing.Color.Transparent
        Me.btnsave.BorderRadius = 4
        Me.btnsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsave.FillColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnsave.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnsave.ForeColor = System.Drawing.Color.Silver
        Me.btnsave.Location = New System.Drawing.Point(40, 865)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(142, 45)
        Me.btnsave.TabIndex = 728
        Me.btnsave.Text = "Save"
        '
        'txttodaydate
        '
        Me.txttodaydate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttodaydate.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txttodaydate.ForeColor = System.Drawing.Color.DarkGray
        Me.txttodaydate.Location = New System.Drawing.Point(257, 19)
        Me.txttodaydate.Name = "txttodaydate"
        Me.txttodaydate.Size = New System.Drawing.Size(126, 26)
        Me.txttodaydate.TabIndex = 731
        Me.txttodaydate.Text = "Date"
        Me.txttodaydate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.txtsalary.ForeColor = System.Drawing.Color.Gray
        Me.txtsalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtsalary.Location = New System.Drawing.Point(204, 763)
        Me.txtsalary.MaxLength = 10
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsalary.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtsalary.PlaceholderText = "₹"
        Me.txtsalary.SelectedText = ""
        Me.txtsalary.Size = New System.Drawing.Size(142, 49)
        Me.txtsalary.TabIndex = 730
        '
        'txttrainertype
        '
        Me.txttrainertype.BackColor = System.Drawing.Color.Transparent
        Me.txttrainertype.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txttrainertype.BorderThickness = 2
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
        Me.txttrainertype.Location = New System.Drawing.Point(40, 634)
        Me.txttrainertype.Name = "txttrainertype"
        Me.txttrainertype.Size = New System.Drawing.Size(306, 36)
        Me.txttrainertype.Sorted = True
        Me.txttrainertype.StartIndex = 0
        Me.txttrainertype.TabIndex = 732
        '
        'txtfullname
        '
        Me.txtfullname.AutoSize = True
        Me.txtfullname.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtfullname.BorderRadius = 2
        Me.txtfullname.BorderThickness = 2
        Me.txtfullname.Cursor = System.Windows.Forms.Cursors.No
        Me.txtfullname.DefaultText = ""
        Me.txtfullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtfullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtfullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfullname.FillColor = System.Drawing.Color.Transparent
        Me.txtfullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtfullname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtfullname.ForeColor = System.Drawing.Color.Gray
        Me.txtfullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtfullname.Location = New System.Drawing.Point(40, 499)
        Me.txtfullname.MaxLength = 4
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfullname.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtfullname.PlaceholderText = ""
        Me.txtfullname.ReadOnly = True
        Me.txtfullname.SelectedText = ""
        Me.txtfullname.Size = New System.Drawing.Size(306, 49)
        Me.txtfullname.TabIndex = 734
        '
        'lblphoto
        '
        Me.lblphoto.AutoSize = True
        Me.lblphoto.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphoto.ForeColor = System.Drawing.Color.Gray
        Me.lblphoto.Location = New System.Drawing.Point(154, 236)
        Me.lblphoto.Name = "lblphoto"
        Me.lblphoto.Size = New System.Drawing.Size(68, 26)
        Me.lblphoto.TabIndex = 727
        Me.lblphoto.Text = "Photo"
        '
        'trainerphoto
        '
        Me.trainerphoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.trainerphoto.FillColor = System.Drawing.Color.Transparent
        Me.trainerphoto.ImageRotate = 0!
        Me.trainerphoto.Location = New System.Drawing.Point(98, 155)
        Me.trainerphoto.Name = "trainerphoto"
        Me.trainerphoto.Size = New System.Drawing.Size(181, 184)
        Me.trainerphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.trainerphoto.TabIndex = 726
        Me.trainerphoto.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(35, 584)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 26)
        Me.Label7.TabIndex = 723
        Me.Label7.Text = "Trainer Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(199, 714)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 26)
        Me.Label1.TabIndex = 724
        Me.Label1.Text = "Salary"
        '
        'txtbonus
        '
        Me.txtbonus.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtbonus.BorderRadius = 2
        Me.txtbonus.BorderThickness = 2
        Me.txtbonus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbonus.DefaultText = ""
        Me.txtbonus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbonus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbonus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbonus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbonus.FillColor = System.Drawing.Color.Transparent
        Me.txtbonus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtbonus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbonus.ForeColor = System.Drawing.Color.DarkGray
        Me.txtbonus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtbonus.Location = New System.Drawing.Point(40, 763)
        Me.txtbonus.MaxLength = 6
        Me.txtbonus.Name = "txtbonus"
        Me.txtbonus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbonus.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtbonus.PlaceholderText = "₹"
        Me.txtbonus.SelectedText = ""
        Me.txtbonus.Size = New System.Drawing.Size(142, 49)
        Me.txtbonus.TabIndex = 722
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(35, 714)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 26)
        Me.Label3.TabIndex = 721
        Me.Label3.Text = "Bonus"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(996, 979)
        Me.Guna2Panel2.TabIndex = 722
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.trainerdatagridview)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 339)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(996, 640)
        Me.Guna2Panel3.TabIndex = 735
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(996, 339)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 734
        Me.Guna2PictureBox1.TabStop = False
        '
        'trainerdatagridview
        '
        Me.trainerdatagridview.AllowUserToAddRows = False
        Me.trainerdatagridview.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.trainerdatagridview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.trainerdatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.trainerdatagridview.BackgroundColor = System.Drawing.Color.Black
        Me.trainerdatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.trainerdatagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.trainerdatagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.trainerdatagridview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.trainerdatagridview.ColumnHeadersHeight = 27
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.trainerdatagridview.DefaultCellStyle = DataGridViewCellStyle3
        Me.trainerdatagridview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trainerdatagridview.EnableHeadersVisualStyles = False
        Me.trainerdatagridview.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.trainerdatagridview.Location = New System.Drawing.Point(0, 0)
        Me.trainerdatagridview.Name = "trainerdatagridview"
        Me.trainerdatagridview.ReadOnly = True
        Me.trainerdatagridview.RowHeadersVisible = False
        Me.trainerdatagridview.RowHeadersWidth = 51
        Me.trainerdatagridview.RowTemplate.Height = 24
        Me.trainerdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.trainerdatagridview.Size = New System.Drawing.Size(996, 640)
        Me.trainerdatagridview.TabIndex = 0
        Me.trainerdatagridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Purple
        Me.trainerdatagridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.trainerdatagridview.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.trainerdatagridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.trainerdatagridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.trainerdatagridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.trainerdatagridview.ThemeStyle.BackColor = System.Drawing.Color.Black
        Me.trainerdatagridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.trainerdatagridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.trainerdatagridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.trainerdatagridview.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.trainerdatagridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.trainerdatagridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.trainerdatagridview.ThemeStyle.HeaderStyle.Height = 27
        Me.trainerdatagridview.ThemeStyle.ReadOnly = True
        Me.trainerdatagridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.trainerdatagridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.trainerdatagridview.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.trainerdatagridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.trainerdatagridview.ThemeStyle.RowsStyle.Height = 24
        Me.trainerdatagridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.trainerdatagridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'trainersalaryfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(20, 20)
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1391, 979)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "trainersalaryfrm"
        Me.ShowIcon = False
        Me.Text = "TRAINER SALARY"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.trainerphoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trainerdatagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtfullname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents trainerphoto As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txttrainertype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtsalary As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txttodaydate As Label
    Friend WithEvents btnclear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblphoto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbonus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents trainerdatagridview As Guna.UI2.WinForms.Guna2DataGridView
End Class
