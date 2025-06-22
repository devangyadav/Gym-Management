<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Memberfeesfrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Memberfeesfrm))
        Me.txtplanstype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblplan = New System.Windows.Forms.Label()
        Me.lblfees = New System.Windows.Forms.Label()
        Me.txtmonths = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblmonths = New System.Windows.Forms.Label()
        Me.txtpayfees = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txttodaydate = New System.Windows.Forms.Label()
        Me.btnfeesupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.txtfullname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblphoto = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnclear = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.memberfeeprofile = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.memberfeedataview = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.banner = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.memberfeeprofile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.memberfeedataview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtplanstype
        '
        Me.txtplanstype.BackColor = System.Drawing.Color.Transparent
        Me.txtplanstype.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtplanstype.BorderRadius = 2
        Me.txtplanstype.BorderThickness = 2
        Me.txtplanstype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtplanstype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtplanstype.FillColor = System.Drawing.Color.Transparent
        Me.txtplanstype.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtplanstype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtplanstype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtplanstype.ForeColor = System.Drawing.Color.Gray
        Me.txtplanstype.ItemHeight = 30
        Me.txtplanstype.Items.AddRange(New Object() {"Cardio", "Cardio and Strength", "Personal ", "Strength"})
        Me.txtplanstype.ItemsAppearance.BackColor = System.Drawing.Color.Black
        Me.txtplanstype.ItemsAppearance.SelectedBackColor = System.Drawing.Color.DimGray
        Me.txtplanstype.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Silver
        Me.txtplanstype.Location = New System.Drawing.Point(48, 470)
        Me.txtplanstype.Name = "txtplanstype"
        Me.txtplanstype.Size = New System.Drawing.Size(306, 36)
        Me.txtplanstype.Sorted = True
        Me.txtplanstype.TabIndex = 51
        '
        'lblplan
        '
        Me.lblplan.AutoSize = True
        Me.lblplan.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblplan.ForeColor = System.Drawing.Color.DarkGray
        Me.lblplan.Location = New System.Drawing.Point(43, 430)
        Me.lblplan.Name = "lblplan"
        Me.lblplan.Size = New System.Drawing.Size(62, 26)
        Me.lblplan.TabIndex = 704
        Me.lblplan.Text = "Plans"
        '
        'lblfees
        '
        Me.lblfees.AutoSize = True
        Me.lblfees.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblfees.ForeColor = System.Drawing.Color.DarkGray
        Me.lblfees.Location = New System.Drawing.Point(43, 633)
        Me.lblfees.Name = "lblfees"
        Me.lblfees.Size = New System.Drawing.Size(89, 26)
        Me.lblfees.TabIndex = 705
        Me.lblfees.Text = "Amount"
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
        Me.txtmonths.Items.AddRange(New Object() {"01 Month", "03 Months", "06 Months", "12 Months"})
        Me.txtmonths.ItemsAppearance.BackColor = System.Drawing.Color.Black
        Me.txtmonths.ItemsAppearance.SelectedBackColor = System.Drawing.Color.DimGray
        Me.txtmonths.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Silver
        Me.txtmonths.Location = New System.Drawing.Point(48, 574)
        Me.txtmonths.Name = "txtmonths"
        Me.txtmonths.Size = New System.Drawing.Size(306, 36)
        Me.txtmonths.Sorted = True
        Me.txtmonths.TabIndex = 706
        '
        'lblmonths
        '
        Me.lblmonths.AutoSize = True
        Me.lblmonths.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblmonths.ForeColor = System.Drawing.Color.DarkGray
        Me.lblmonths.Location = New System.Drawing.Point(43, 527)
        Me.lblmonths.Name = "lblmonths"
        Me.lblmonths.Size = New System.Drawing.Size(85, 26)
        Me.lblmonths.TabIndex = 707
        Me.lblmonths.Text = "Months"
        '
        'txtpayfees
        '
        Me.txtpayfees.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtpayfees.BorderRadius = 2
        Me.txtpayfees.BorderThickness = 2
        Me.txtpayfees.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpayfees.DefaultText = ""
        Me.txtpayfees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpayfees.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpayfees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpayfees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpayfees.FillColor = System.Drawing.Color.Transparent
        Me.txtpayfees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtpayfees.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpayfees.ForeColor = System.Drawing.Color.Gray
        Me.txtpayfees.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtpayfees.Location = New System.Drawing.Point(48, 676)
        Me.txtpayfees.MaxLength = 4
        Me.txtpayfees.Name = "txtpayfees"
        Me.txtpayfees.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpayfees.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtpayfees.PlaceholderText = "₹"
        Me.txtpayfees.SelectedText = ""
        Me.txtpayfees.Size = New System.Drawing.Size(306, 49)
        Me.txtpayfees.TabIndex = 708
        '
        'txttodaydate
        '
        Me.txttodaydate.AutoSize = True
        Me.txttodaydate.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.txttodaydate.ForeColor = System.Drawing.Color.DarkGray
        Me.txttodaydate.Location = New System.Drawing.Point(269, 18)
        Me.txttodaydate.Name = "txttodaydate"
        Me.txttodaydate.Size = New System.Drawing.Size(0, 26)
        Me.txttodaydate.TabIndex = 710
        '
        'btnfeesupdate
        '
        Me.btnfeesupdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnfeesupdate.Animated = True
        Me.btnfeesupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnfeesupdate.BorderColor = System.Drawing.Color.Transparent
        Me.btnfeesupdate.BorderRadius = 4
        Me.btnfeesupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnfeesupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnfeesupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnfeesupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnfeesupdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnfeesupdate.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnfeesupdate.ForeColor = System.Drawing.Color.Silver
        Me.btnfeesupdate.Location = New System.Drawing.Point(48, 764)
        Me.btnfeesupdate.Name = "btnfeesupdate"
        Me.btnfeesupdate.Size = New System.Drawing.Size(131, 45)
        Me.btnfeesupdate.TabIndex = 713
        Me.btnfeesupdate.Text = "Save"
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
        Me.txtfullname.Location = New System.Drawing.Point(48, 371)
        Me.txtfullname.MaxLength = 4
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfullname.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtfullname.PlaceholderText = ""
        Me.txtfullname.ReadOnly = True
        Me.txtfullname.SelectedText = ""
        Me.txtfullname.Size = New System.Drawing.Size(306, 49)
        Me.txtfullname.TabIndex = 716
        '
        'lblphoto
        '
        Me.lblphoto.AutoSize = True
        Me.lblphoto.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphoto.ForeColor = System.Drawing.Color.Gray
        Me.lblphoto.Location = New System.Drawing.Point(161, 177)
        Me.lblphoto.Name = "lblphoto"
        Me.lblphoto.Size = New System.Drawing.Size(68, 26)
        Me.lblphoto.TabIndex = 718
        Me.lblphoto.Text = "Photo"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnclear)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.lblphoto)
        Me.Guna2Panel1.Controls.Add(Me.txttodaydate)
        Me.Guna2Panel1.Controls.Add(Me.btnfeesupdate)
        Me.Guna2Panel1.Controls.Add(Me.txtfullname)
        Me.Guna2Panel1.Controls.Add(Me.txtpayfees)
        Me.Guna2Panel1.Controls.Add(Me.lblfees)
        Me.Guna2Panel1.Controls.Add(Me.memberfeeprofile)
        Me.Guna2Panel1.Controls.Add(Me.lblmonths)
        Me.Guna2Panel1.Controls.Add(Me.txtplanstype)
        Me.Guna2Panel1.Controls.Add(Me.txtmonths)
        Me.Guna2Panel1.Controls.Add(Me.lblplan)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel1.Location = New System.Drawing.Point(1025, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(395, 848)
        Me.Guna2Panel1.TabIndex = 722
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
        Me.btnclear.Location = New System.Drawing.Point(223, 764)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(131, 45)
        Me.btnclear.TabIndex = 730
        Me.btnclear.Text = "Back"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(43, 334)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 26)
        Me.Label1.TabIndex = 723
        Me.Label1.Text = "Name"
        '
        'memberfeeprofile
        '
        Me.memberfeeprofile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.memberfeeprofile.FillColor = System.Drawing.Color.Transparent
        Me.memberfeeprofile.ImageRotate = 0!
        Me.memberfeeprofile.Location = New System.Drawing.Point(108, 98)
        Me.memberfeeprofile.Name = "memberfeeprofile"
        Me.memberfeeprofile.Size = New System.Drawing.Size(181, 184)
        Me.memberfeeprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.memberfeeprofile.TabIndex = 717
        Me.memberfeeprofile.TabStop = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.memberfeedataview)
        Me.Guna2Panel2.Controls.Add(Me.banner)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1025, 848)
        Me.Guna2Panel2.TabIndex = 723
        '
        'memberfeedataview
        '
        Me.memberfeedataview.AllowUserToAddRows = False
        Me.memberfeedataview.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.memberfeedataview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.memberfeedataview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.memberfeedataview.BackgroundColor = System.Drawing.Color.Black
        Me.memberfeedataview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.memberfeedataview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.memberfeedataview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.memberfeedataview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.memberfeedataview.ColumnHeadersHeight = 55
        Me.memberfeedataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.memberfeedataview.DefaultCellStyle = DataGridViewCellStyle3
        Me.memberfeedataview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.memberfeedataview.EnableHeadersVisualStyles = False
        Me.memberfeedataview.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.memberfeedataview.Location = New System.Drawing.Point(0, 306)
        Me.memberfeedataview.Name = "memberfeedataview"
        Me.memberfeedataview.ReadOnly = True
        Me.memberfeedataview.RowHeadersVisible = False
        Me.memberfeedataview.RowHeadersWidth = 51
        Me.memberfeedataview.RowTemplate.Height = 24
        Me.memberfeedataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.memberfeedataview.Size = New System.Drawing.Size(1025, 542)
        Me.memberfeedataview.TabIndex = 722
        Me.memberfeedataview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Purple
        Me.memberfeedataview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.memberfeedataview.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.memberfeedataview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.memberfeedataview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.memberfeedataview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.memberfeedataview.ThemeStyle.BackColor = System.Drawing.Color.Black
        Me.memberfeedataview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.memberfeedataview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.memberfeedataview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.memberfeedataview.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.memberfeedataview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.memberfeedataview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.memberfeedataview.ThemeStyle.HeaderStyle.Height = 55
        Me.memberfeedataview.ThemeStyle.ReadOnly = True
        Me.memberfeedataview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.memberfeedataview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.memberfeedataview.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.memberfeedataview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.memberfeedataview.ThemeStyle.RowsStyle.Height = 24
        Me.memberfeedataview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.memberfeedataview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'banner
        '
        Me.banner.Dock = System.Windows.Forms.DockStyle.Top
        Me.banner.Image = CType(resources.GetObject("banner.Image"), System.Drawing.Image)
        Me.banner.ImageRotate = 0!
        Me.banner.Location = New System.Drawing.Point(0, 0)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(1025, 306)
        Me.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.banner.TabIndex = 723
        Me.banner.TabStop = False
        '
        'Memberfeesfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(20, 0)
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1420, 848)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Memberfeesfrm"
        Me.Text = "MEMBER FEES"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.memberfeeprofile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.memberfeedataview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtplanstype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblplan As Label
    Friend WithEvents lblfees As Label
    Friend WithEvents txtmonths As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblmonths As Label
    Friend WithEvents txtpayfees As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnfeesupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtfullname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents memberfeeprofile As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblphoto As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txttodaydate As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents memberfeedataview As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents banner As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnclear As Guna.UI2.WinForms.Guna2Button
End Class
