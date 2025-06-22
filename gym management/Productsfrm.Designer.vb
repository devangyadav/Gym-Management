<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Productsfrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productsfrm))
        Me.productlistpanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtbuyeremail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtdiscount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnproductclear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsavesellitems = New Guna.UI2.WinForms.Guna2Button()
        Me.txtbuyerph = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbuyername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.buyname = New System.Windows.Forms.Label()
        Me.buyproductlistdataview = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.itemno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.items = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productcategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnremove = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.buyproductlistdataview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'productlistpanel
        '
        Me.productlistpanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.productlistpanel.AutoScroll = True
        Me.productlistpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.productlistpanel.Location = New System.Drawing.Point(0, 0)
        Me.productlistpanel.Name = "productlistpanel"
        Me.productlistpanel.Size = New System.Drawing.Size(920, 882)
        Me.productlistpanel.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.txtbuyeremail)
        Me.Guna2Panel1.Controls.Add(Me.txtdiscount)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.txttotal)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.btnproductclear)
        Me.Guna2Panel1.Controls.Add(Me.btnsavesellitems)
        Me.Guna2Panel1.Controls.Add(Me.txtbuyerph)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.txtbuyername)
        Me.Guna2Panel1.Controls.Add(Me.buyname)
        Me.Guna2Panel1.Controls.Add(Me.buyproductlistdataview)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel1.Location = New System.Drawing.Point(920, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(450, 882)
        Me.Guna2Panel1.TabIndex = 1
        '
        'txtbuyeremail
        '
        Me.txtbuyeremail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtbuyeremail.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtbuyeremail.BorderRadius = 2
        Me.txtbuyeremail.BorderThickness = 2
        Me.txtbuyeremail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbuyeremail.DefaultText = ""
        Me.txtbuyeremail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbuyeremail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbuyeremail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbuyeremail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbuyeremail.FillColor = System.Drawing.Color.Transparent
        Me.txtbuyeremail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtbuyeremail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbuyeremail.ForeColor = System.Drawing.Color.Gray
        Me.txtbuyeremail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtbuyeremail.Location = New System.Drawing.Point(16, 750)
        Me.txtbuyeremail.MaxLength = 50
        Me.txtbuyeremail.Name = "txtbuyeremail"
        Me.txtbuyeremail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbuyeremail.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtbuyeremail.PlaceholderText = "Email@Example.com"
        Me.txtbuyeremail.SelectedText = ""
        Me.txtbuyeremail.Size = New System.Drawing.Size(200, 40)
        Me.txtbuyeremail.TabIndex = 1
        '
        'txtdiscount
        '
        Me.txtdiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtdiscount.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtdiscount.BorderRadius = 2
        Me.txtdiscount.BorderThickness = 2
        Me.txtdiscount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdiscount.DefaultText = ""
        Me.txtdiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtdiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtdiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdiscount.FillColor = System.Drawing.Color.Transparent
        Me.txtdiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtdiscount.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscount.ForeColor = System.Drawing.Color.Gray
        Me.txtdiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtdiscount.Location = New System.Drawing.Point(15, 533)
        Me.txtdiscount.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtdiscount.MaxLength = 3
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdiscount.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtdiscount.PlaceholderText = "%"
        Me.txtdiscount.SelectedText = ""
        Me.txtdiscount.Size = New System.Drawing.Size(200, 60)
        Me.txtdiscount.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(11, 493)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 26)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Discount percent (%)"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(233, 493)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 26)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Total Price "
        '
        'txttotal
        '
        Me.txttotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txttotal.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txttotal.BorderRadius = 2
        Me.txttotal.BorderThickness = 2
        Me.txttotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttotal.DefaultText = ""
        Me.txttotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txttotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txttotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotal.FillColor = System.Drawing.Color.Transparent
        Me.txttotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txttotal.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.Gray
        Me.txttotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txttotal.Location = New System.Drawing.Point(238, 533)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txttotal.MaxLength = 50
        Me.txttotal.Name = "txttotal"
        Me.txttotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttotal.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txttotal.PlaceholderText = "₹"
        Me.txttotal.ReadOnly = True
        Me.txttotal.SelectedText = ""
        Me.txttotal.Size = New System.Drawing.Size(200, 60)
        Me.txttotal.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(11, 705)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 26)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Email"
        '
        'btnproductclear
        '
        Me.btnproductclear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnproductclear.BorderRadius = 4
        Me.btnproductclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnproductclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnproductclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnproductclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnproductclear.FillColor = System.Drawing.SystemColors.Desktop
        Me.btnproductclear.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnproductclear.ForeColor = System.Drawing.Color.Silver
        Me.btnproductclear.Location = New System.Drawing.Point(231, 821)
        Me.btnproductclear.Name = "btnproductclear"
        Me.btnproductclear.Size = New System.Drawing.Size(207, 45)
        Me.btnproductclear.TabIndex = 66
        Me.btnproductclear.Text = "Clear"
        '
        'btnsavesellitems
        '
        Me.btnsavesellitems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnsavesellitems.Animated = True
        Me.btnsavesellitems.BackColor = System.Drawing.Color.Transparent
        Me.btnsavesellitems.BorderRadius = 4
        Me.btnsavesellitems.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsavesellitems.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsavesellitems.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsavesellitems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsavesellitems.FillColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnsavesellitems.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnsavesellitems.ForeColor = System.Drawing.Color.Silver
        Me.btnsavesellitems.Location = New System.Drawing.Point(16, 821)
        Me.btnsavesellitems.Name = "btnsavesellitems"
        Me.btnsavesellitems.Size = New System.Drawing.Size(200, 45)
        Me.btnsavesellitems.TabIndex = 3
        Me.btnsavesellitems.Text = "Done"
        '
        'txtbuyerph
        '
        Me.txtbuyerph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtbuyerph.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtbuyerph.BorderRadius = 2
        Me.txtbuyerph.BorderThickness = 2
        Me.txtbuyerph.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbuyerph.DefaultText = ""
        Me.txtbuyerph.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbuyerph.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbuyerph.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbuyerph.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbuyerph.FillColor = System.Drawing.Color.Transparent
        Me.txtbuyerph.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtbuyerph.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtbuyerph.ForeColor = System.Drawing.Color.Gray
        Me.txtbuyerph.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtbuyerph.Location = New System.Drawing.Point(231, 750)
        Me.txtbuyerph.MaxLength = 10
        Me.txtbuyerph.Name = "txtbuyerph"
        Me.txtbuyerph.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbuyerph.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtbuyerph.PlaceholderText = ""
        Me.txtbuyerph.SelectedText = ""
        Me.txtbuyerph.Size = New System.Drawing.Size(207, 40)
        Me.txtbuyerph.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(226, 705)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 26)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Phone No"
        '
        'txtbuyername
        '
        Me.txtbuyername.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtbuyername.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtbuyername.BorderRadius = 2
        Me.txtbuyername.BorderThickness = 2
        Me.txtbuyername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbuyername.DefaultText = ""
        Me.txtbuyername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbuyername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbuyername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbuyername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbuyername.FillColor = System.Drawing.Color.Transparent
        Me.txtbuyername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtbuyername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtbuyername.ForeColor = System.Drawing.Color.Gray
        Me.txtbuyername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtbuyername.Location = New System.Drawing.Point(15, 648)
        Me.txtbuyername.MaxLength = 50
        Me.txtbuyername.Name = "txtbuyername"
        Me.txtbuyername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbuyername.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtbuyername.PlaceholderText = ""
        Me.txtbuyername.SelectedText = ""
        Me.txtbuyername.Size = New System.Drawing.Size(423, 40)
        Me.txtbuyername.TabIndex = 0
        '
        'buyname
        '
        Me.buyname.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buyname.AutoSize = True
        Me.buyname.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buyname.ForeColor = System.Drawing.Color.DarkGray
        Me.buyname.Location = New System.Drawing.Point(11, 608)
        Me.buyname.Name = "buyname"
        Me.buyname.Size = New System.Drawing.Size(130, 26)
        Me.buyname.TabIndex = 57
        Me.buyname.Text = "Buyer Name"
        '
        'buyproductlistdataview
        '
        Me.buyproductlistdataview.AllowUserToAddRows = False
        Me.buyproductlistdataview.AllowUserToDeleteRows = False
        Me.buyproductlistdataview.AllowUserToResizeColumns = False
        Me.buyproductlistdataview.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.buyproductlistdataview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.buyproductlistdataview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buyproductlistdataview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.buyproductlistdataview.BackgroundColor = System.Drawing.Color.DimGray
        Me.buyproductlistdataview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.buyproductlistdataview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.buyproductlistdataview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.buyproductlistdataview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.buyproductlistdataview.ColumnHeadersHeight = 55
        Me.buyproductlistdataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.buyproductlistdataview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemno, Me.items, Me.quantity, Me.price, Me.totalprice, Me.productcategory, Me.btnremove})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.buyproductlistdataview.DefaultCellStyle = DataGridViewCellStyle8
        Me.buyproductlistdataview.EnableHeadersVisualStyles = False
        Me.buyproductlistdataview.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.buyproductlistdataview.Location = New System.Drawing.Point(-2, 0)
        Me.buyproductlistdataview.Name = "buyproductlistdataview"
        Me.buyproductlistdataview.ReadOnly = True
        Me.buyproductlistdataview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.buyproductlistdataview.RowHeadersVisible = False
        Me.buyproductlistdataview.RowHeadersWidth = 15
        Me.buyproductlistdataview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.buyproductlistdataview.RowTemplate.Height = 24
        Me.buyproductlistdataview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.buyproductlistdataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.buyproductlistdataview.Size = New System.Drawing.Size(452, 477)
        Me.buyproductlistdataview.TabIndex = 100
        Me.buyproductlistdataview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Purple
        Me.buyproductlistdataview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.buyproductlistdataview.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.buyproductlistdataview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.buyproductlistdataview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.buyproductlistdataview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.buyproductlistdataview.ThemeStyle.BackColor = System.Drawing.Color.DimGray
        Me.buyproductlistdataview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.buyproductlistdataview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.buyproductlistdataview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.buyproductlistdataview.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.buyproductlistdataview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.buyproductlistdataview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.buyproductlistdataview.ThemeStyle.HeaderStyle.Height = 55
        Me.buyproductlistdataview.ThemeStyle.ReadOnly = True
        Me.buyproductlistdataview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.buyproductlistdataview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.buyproductlistdataview.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.buyproductlistdataview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.buyproductlistdataview.ThemeStyle.RowsStyle.Height = 24
        Me.buyproductlistdataview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.buyproductlistdataview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'itemno
        '
        Me.itemno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.itemno.DefaultCellStyle = DataGridViewCellStyle3
        Me.itemno.FillWeight = 69.49561!
        Me.itemno.HeaderText = "#"
        Me.itemno.MinimumWidth = 3
        Me.itemno.Name = "itemno"
        Me.itemno.ReadOnly = True
        Me.itemno.Width = 50
        '
        'items
        '
        Me.items.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.items.DefaultCellStyle = DataGridViewCellStyle4
        Me.items.FillWeight = 126.0946!
        Me.items.HeaderText = "ITEM"
        Me.items.MinimumWidth = 6
        Me.items.Name = "items"
        Me.items.ReadOnly = True
        Me.items.Width = 78
        '
        'quantity
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.quantity.DefaultCellStyle = DataGridViewCellStyle5
        Me.quantity.FillWeight = 95.20247!
        Me.quantity.HeaderText = "QTY"
        Me.quantity.MinimumWidth = 6
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        '
        'price
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.price.DefaultCellStyle = DataGridViewCellStyle6
        Me.price.FillWeight = 89.36223!
        Me.price.HeaderText = "MRP"
        Me.price.MinimumWidth = 6
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'totalprice
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.totalprice.DefaultCellStyle = DataGridViewCellStyle7
        Me.totalprice.FillWeight = 91.50286!
        Me.totalprice.HeaderText = "TOTAL"
        Me.totalprice.MinimumWidth = 6
        Me.totalprice.Name = "totalprice"
        Me.totalprice.ReadOnly = True
        '
        'productcategory
        '
        Me.productcategory.HeaderText = "productcategory"
        Me.productcategory.MinimumWidth = 6
        Me.productcategory.Name = "productcategory"
        Me.productcategory.ReadOnly = True
        Me.productcategory.Visible = False
        '
        'btnremove
        '
        Me.btnremove.HeaderText = "REMOVE"
        Me.btnremove.Image = CType(resources.GetObject("btnremove.Image"), System.Drawing.Image)
        Me.btnremove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.btnremove.MinimumWidth = 6
        Me.btnremove.Name = "btnremove"
        Me.btnremove.ReadOnly = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn1.FillWeight = 128.3422!
        Me.DataGridViewImageColumn1.HeaderText = "REMOVE"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn1.Width = 125
        '
        'Productsfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1370, 882)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.productlistpanel)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Productsfrm"
        Me.Text = "PRODUCTS"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.buyproductlistdataview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents productlistpanel As FlowLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents buyproductlistdataview As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnproductclear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsavesellitems As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtbuyerph As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbuyername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents buyname As Label
    Friend WithEvents txttotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdiscount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents txtbuyeremail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents itemno As DataGridViewTextBoxColumn
    Friend WithEvents items As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents totalprice As DataGridViewTextBoxColumn
    Friend WithEvents productcategory As DataGridViewTextBoxColumn
    Friend WithEvents btnremove As DataGridViewImageColumn
End Class
