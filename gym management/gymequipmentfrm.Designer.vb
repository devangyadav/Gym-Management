<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gymequipmentfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gymequipmentfrm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtpurchasedate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnaddproduct = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.lblphoto = New System.Windows.Forms.Label()
        Me.equipmentphoto = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnsave = New Guna.UI2.WinForms.Guna2Button()
        Me.txtequipquantity = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.txtamount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblfees = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblplan = New System.Windows.Forms.Label()
        Me.txtequipname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gymequipdv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buydate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.equipimage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.equipname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.equipquan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.openimage = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.equipmentphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtequipquantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.gymequipdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.txtpurchasedate)
        Me.Guna2Panel1.Controls.Add(Me.Label10)
        Me.Guna2Panel1.Controls.Add(Me.btnaddproduct)
        Me.Guna2Panel1.Controls.Add(Me.lblphoto)
        Me.Guna2Panel1.Controls.Add(Me.equipmentphoto)
        Me.Guna2Panel1.Controls.Add(Me.btnsave)
        Me.Guna2Panel1.Controls.Add(Me.txtequipquantity)
        Me.Guna2Panel1.Controls.Add(Me.txtamount)
        Me.Guna2Panel1.Controls.Add(Me.lblfees)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.lblplan)
        Me.Guna2Panel1.Controls.Add(Me.txtequipname)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1395, 282)
        Me.Guna2Panel1.TabIndex = 725
        '
        'txtpurchasedate
        '
        Me.txtpurchasedate.BorderRadius = 2
        Me.txtpurchasedate.Checked = True
        Me.txtpurchasedate.CustomFormat = "yyyy-MM-dd"
        Me.txtpurchasedate.FillColor = System.Drawing.SystemColors.Desktop
        Me.txtpurchasedate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpurchasedate.ForeColor = System.Drawing.Color.Black
        Me.txtpurchasedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtpurchasedate.Location = New System.Drawing.Point(1009, 169)
        Me.txtpurchasedate.MaxDate = New Date(2003, 12, 31, 0, 0, 0, 0)
        Me.txtpurchasedate.MinDate = New Date(1942, 1, 1, 0, 0, 0, 0)
        Me.txtpurchasedate.Name = "txtpurchasedate"
        Me.txtpurchasedate.Size = New System.Drawing.Size(145, 49)
        Me.txtpurchasedate.TabIndex = 738
        Me.txtpurchasedate.Value = New Date(2003, 1, 1, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.DarkGray
        Me.Label10.Location = New System.Drawing.Point(1004, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 31)
        Me.Label10.TabIndex = 737
        Me.Label10.Text = "Purchase date"
        '
        'btnaddproduct
        '
        Me.btnaddproduct.BackColor = System.Drawing.Color.Transparent
        Me.btnaddproduct.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnaddproduct.HoverState.ImageSize = New System.Drawing.Size(43, 43)
        Me.btnaddproduct.Image = CType(resources.GetObject("btnaddproduct.Image"), System.Drawing.Image)
        Me.btnaddproduct.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnaddproduct.ImageRotate = 0!
        Me.btnaddproduct.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnaddproduct.Location = New System.Drawing.Point(202, 201)
        Me.btnaddproduct.Name = "btnaddproduct"
        Me.btnaddproduct.PressedState.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnaddproduct.Size = New System.Drawing.Size(39, 33)
        Me.btnaddproduct.TabIndex = 734
        Me.btnaddproduct.UseTransparentBackground = True
        '
        'lblphoto
        '
        Me.lblphoto.AutoSize = True
        Me.lblphoto.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphoto.ForeColor = System.Drawing.Color.Gray
        Me.lblphoto.Location = New System.Drawing.Point(97, 114)
        Me.lblphoto.Name = "lblphoto"
        Me.lblphoto.Size = New System.Drawing.Size(68, 26)
        Me.lblphoto.TabIndex = 736
        Me.lblphoto.Text = "Photo"
        '
        'equipmentphoto
        '
        Me.equipmentphoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.equipmentphoto.FillColor = System.Drawing.Color.Transparent
        Me.equipmentphoto.ImageRotate = 0!
        Me.equipmentphoto.Location = New System.Drawing.Point(42, 34)
        Me.equipmentphoto.Name = "equipmentphoto"
        Me.equipmentphoto.Size = New System.Drawing.Size(181, 184)
        Me.equipmentphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.equipmentphoto.TabIndex = 735
        Me.equipmentphoto.TabStop = False
        '
        'btnsave
        '
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
        Me.btnsave.Location = New System.Drawing.Point(1191, 169)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(182, 49)
        Me.btnsave.TabIndex = 733
        Me.btnsave.Text = "Save"
        '
        'txtequipquantity
        '
        Me.txtequipquantity.BackColor = System.Drawing.Color.Transparent
        Me.txtequipquantity.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtequipquantity.BorderThickness = 2
        Me.txtequipquantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtequipquantity.FillColor = System.Drawing.Color.Black
        Me.txtequipquantity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtequipquantity.ForeColor = System.Drawing.Color.Gray
        Me.txtequipquantity.Location = New System.Drawing.Point(633, 169)
        Me.txtequipquantity.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtequipquantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtequipquantity.Name = "txtequipquantity"
        Me.txtequipquantity.Size = New System.Drawing.Size(104, 49)
        Me.txtequipquantity.TabIndex = 732
        Me.txtequipquantity.UpDownButtonFillColor = System.Drawing.SystemColors.Desktop
        Me.txtequipquantity.UpDownButtonForeColor = System.Drawing.Color.Black
        Me.txtequipquantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtamount
        '
        Me.txtamount.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtamount.BorderRadius = 2
        Me.txtamount.BorderThickness = 2
        Me.txtamount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtamount.DefaultText = ""
        Me.txtamount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtamount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtamount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtamount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtamount.FillColor = System.Drawing.Color.Transparent
        Me.txtamount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtamount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtamount.ForeColor = System.Drawing.Color.Gray
        Me.txtamount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtamount.Location = New System.Drawing.Point(788, 169)
        Me.txtamount.MaxLength = 4
        Me.txtamount.Name = "txtamount"
        Me.txtamount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtamount.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtamount.PlaceholderText = "₹"
        Me.txtamount.SelectedText = ""
        Me.txtamount.Size = New System.Drawing.Size(167, 49)
        Me.txtamount.TabIndex = 729
        '
        'lblfees
        '
        Me.lblfees.AutoSize = True
        Me.lblfees.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblfees.ForeColor = System.Drawing.Color.DarkGray
        Me.lblfees.Location = New System.Drawing.Point(782, 126)
        Me.lblfees.Name = "lblfees"
        Me.lblfees.Size = New System.Drawing.Size(89, 26)
        Me.lblfees.TabIndex = 726
        Me.lblfees.Text = "Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(285, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 26)
        Me.Label1.TabIndex = 731
        Me.Label1.Text = "Equipment Name"
        '
        'lblplan
        '
        Me.lblplan.AutoSize = True
        Me.lblplan.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblplan.ForeColor = System.Drawing.Color.DarkGray
        Me.lblplan.Location = New System.Drawing.Point(628, 126)
        Me.lblplan.Name = "lblplan"
        Me.lblplan.Size = New System.Drawing.Size(96, 26)
        Me.lblplan.TabIndex = 725
        Me.lblplan.Text = "Quantity"
        '
        'txtequipname
        '
        Me.txtequipname.AutoSize = True
        Me.txtequipname.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtequipname.BorderRadius = 2
        Me.txtequipname.BorderThickness = 2
        Me.txtequipname.Cursor = System.Windows.Forms.Cursors.No
        Me.txtequipname.DefaultText = ""
        Me.txtequipname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtequipname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtequipname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtequipname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtequipname.FillColor = System.Drawing.Color.Transparent
        Me.txtequipname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtequipname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtequipname.ForeColor = System.Drawing.Color.Gray
        Me.txtequipname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtequipname.Location = New System.Drawing.Point(290, 169)
        Me.txtequipname.MaxLength = 4
        Me.txtequipname.Name = "txtequipname"
        Me.txtequipname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtequipname.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtequipname.PlaceholderText = ""
        Me.txtequipname.SelectedText = ""
        Me.txtequipname.Size = New System.Drawing.Size(306, 49)
        Me.txtequipname.TabIndex = 730
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gymequipdv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 282)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1395, 455)
        Me.Panel1.TabIndex = 726
        '
        'gymequipdv
        '
        Me.gymequipdv.AllowUserToAddRows = False
        Me.gymequipdv.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.gymequipdv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gymequipdv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gymequipdv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.gymequipdv.BackgroundColor = System.Drawing.Color.Black
        Me.gymequipdv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gymequipdv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gymequipdv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gymequipdv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gymequipdv.ColumnHeadersHeight = 55
        Me.gymequipdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gymequipdv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.buydate, Me.equipimage, Me.equipname, Me.equipquan, Me.amount})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gymequipdv.DefaultCellStyle = DataGridViewCellStyle4
        Me.gymequipdv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gymequipdv.EnableHeadersVisualStyles = False
        Me.gymequipdv.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.gymequipdv.Location = New System.Drawing.Point(0, 0)
        Me.gymequipdv.Name = "gymequipdv"
        Me.gymequipdv.ReadOnly = True
        Me.gymequipdv.RowHeadersVisible = False
        Me.gymequipdv.RowHeadersWidth = 51
        Me.gymequipdv.RowTemplate.Height = 24
        Me.gymequipdv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gymequipdv.Size = New System.Drawing.Size(1395, 455)
        Me.gymequipdv.TabIndex = 723
        Me.gymequipdv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Purple
        Me.gymequipdv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.gymequipdv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gymequipdv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gymequipdv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gymequipdv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gymequipdv.ThemeStyle.BackColor = System.Drawing.Color.Black
        Me.gymequipdv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.gymequipdv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.gymequipdv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gymequipdv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gymequipdv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gymequipdv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gymequipdv.ThemeStyle.HeaderStyle.Height = 55
        Me.gymequipdv.ThemeStyle.ReadOnly = True
        Me.gymequipdv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.gymequipdv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gymequipdv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gymequipdv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gymequipdv.ThemeStyle.RowsStyle.Height = 24
        Me.gymequipdv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.gymequipdv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'no
        '
        Me.no.FillWeight = 37.43316!
        Me.no.HeaderText = "#"
        Me.no.MinimumWidth = 6
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        '
        'buydate
        '
        Me.buydate.FillWeight = 110.4278!
        Me.buydate.HeaderText = "DATE"
        Me.buydate.MinimumWidth = 6
        Me.buydate.Name = "buydate"
        Me.buydate.ReadOnly = True
        '
        'equipimage
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.NullValue = CType(resources.GetObject("DataGridViewCellStyle3.NullValue"), Object)
        Me.equipimage.DefaultCellStyle = DataGridViewCellStyle3
        Me.equipimage.HeaderText = "IMAGE"
        Me.equipimage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.equipimage.MinimumWidth = 6
        Me.equipimage.Name = "equipimage"
        Me.equipimage.ReadOnly = True
        '
        'equipname
        '
        Me.equipname.FillWeight = 110.4278!
        Me.equipname.HeaderText = "NAME"
        Me.equipname.MinimumWidth = 6
        Me.equipname.Name = "equipname"
        Me.equipname.ReadOnly = True
        '
        'equipquan
        '
        Me.equipquan.FillWeight = 110.4278!
        Me.equipquan.HeaderText = "QUANTITY"
        Me.equipquan.MinimumWidth = 6
        Me.equipquan.Name = "equipquan"
        Me.equipquan.ReadOnly = True
        '
        'amount
        '
        Me.amount.FillWeight = 110.4278!
        Me.amount.HeaderText = "AMOUNT"
        Me.amount.MinimumWidth = 6
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        '
        'openimage
        '
        Me.openimage.FileName = "OpenFileDialog1"
        '
        'gymequipmentfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1395, 737)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gymequipmentfrm"
        Me.Text = "EQUIPMENTS"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.equipmentphoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtequipquantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.gymequipdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtamount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblfees As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblplan As Label
    Friend WithEvents txtequipname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtequipquantity As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents btnsave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnaddproduct As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents lblphoto As Label
    Friend WithEvents equipmentphoto As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents gymequipdv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtpurchasedate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents openimage As OpenFileDialog
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents buydate As DataGridViewTextBoxColumn
    Friend WithEvents equipimage As DataGridViewImageColumn
    Friend WithEvents equipname As DataGridViewTextBoxColumn
    Friend WithEvents equipquan As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
End Class
