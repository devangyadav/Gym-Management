<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddProductfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProductfrm))
        Me.txtproductname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtproductquantity = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnproductclear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnaddnewproduct = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsuppliername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblphoto = New System.Windows.Forms.Label()
        Me.txtproductcategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.openimage = New System.Windows.Forms.OpenFileDialog()
        Me.txtproductdescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtproductprice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsupplierphone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttotalamount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtsupplieremail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.btnaddproduct = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.productphoto = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtpurchase = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblpurchase = New System.Windows.Forms.Label()
        Me.txtpurchasedate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtexpiredate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtpid = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.txtproductquantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtproductname
        '
        Me.txtproductname.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtproductname.BorderRadius = 2
        Me.txtproductname.BorderThickness = 2
        Me.txtproductname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtproductname.DefaultText = ""
        Me.txtproductname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtproductname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtproductname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtproductname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtproductname.FillColor = System.Drawing.Color.Transparent
        Me.txtproductname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtproductname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtproductname.ForeColor = System.Drawing.Color.Gray
        Me.txtproductname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtproductname.Location = New System.Drawing.Point(34, 294)
        Me.txtproductname.MaxLength = 50
        Me.txtproductname.Name = "txtproductname"
        Me.txtproductname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtproductname.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtproductname.PlaceholderText = ""
        Me.txtproductname.SelectedText = ""
        Me.txtproductname.Size = New System.Drawing.Size(435, 40)
        Me.txtproductname.TabIndex = 1
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.DarkGray
        Me.lblname.Location = New System.Drawing.Point(29, 242)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(150, 26)
        Me.lblname.TabIndex = 53
        Me.lblname.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(29, 572)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 26)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Description"
        '
        'txtproductquantity
        '
        Me.txtproductquantity.BackColor = System.Drawing.Color.Transparent
        Me.txtproductquantity.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtproductquantity.BorderThickness = 2
        Me.txtproductquantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtproductquantity.FillColor = System.Drawing.Color.Black
        Me.txtproductquantity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtproductquantity.ForeColor = System.Drawing.Color.Gray
        Me.txtproductquantity.Location = New System.Drawing.Point(203, 513)
        Me.txtproductquantity.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtproductquantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtproductquantity.Name = "txtproductquantity"
        Me.txtproductquantity.Size = New System.Drawing.Size(91, 40)
        Me.txtproductquantity.TabIndex = 8
        Me.txtproductquantity.UpDownButtonFillColor = System.Drawing.SystemColors.Desktop
        Me.txtproductquantity.UpDownButtonForeColor = System.Drawing.Color.Black
        Me.txtproductquantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(198, 465)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 26)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Quantity"
        '
        'btnproductclear
        '
        Me.btnproductclear.BorderRadius = 4
        Me.btnproductclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnproductclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnproductclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnproductclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnproductclear.FillColor = System.Drawing.SystemColors.Desktop
        Me.btnproductclear.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnproductclear.ForeColor = System.Drawing.Color.Silver
        Me.btnproductclear.Location = New System.Drawing.Point(269, 795)
        Me.btnproductclear.Name = "btnproductclear"
        Me.btnproductclear.Size = New System.Drawing.Size(200, 45)
        Me.btnproductclear.TabIndex = 64
        Me.btnproductclear.Text = "Clear"
        '
        'btnaddnewproduct
        '
        Me.btnaddnewproduct.Animated = True
        Me.btnaddnewproduct.BackColor = System.Drawing.Color.Transparent
        Me.btnaddnewproduct.BorderRadius = 4
        Me.btnaddnewproduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnaddnewproduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnaddnewproduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnaddnewproduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnaddnewproduct.FillColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnaddnewproduct.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnaddnewproduct.ForeColor = System.Drawing.Color.Silver
        Me.btnaddnewproduct.Location = New System.Drawing.Point(34, 795)
        Me.btnaddnewproduct.Name = "btnaddnewproduct"
        Me.btnaddnewproduct.Size = New System.Drawing.Size(200, 45)
        Me.btnaddnewproduct.TabIndex = 13
        Me.btnaddnewproduct.Text = "Add"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(29, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 26)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Supplier Name"
        '
        'txtsuppliername
        '
        Me.txtsuppliername.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtsuppliername.BorderRadius = 2
        Me.txtsuppliername.BorderThickness = 2
        Me.txtsuppliername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsuppliername.DefaultText = ""
        Me.txtsuppliername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsuppliername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsuppliername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsuppliername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsuppliername.FillColor = System.Drawing.Color.Transparent
        Me.txtsuppliername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtsuppliername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtsuppliername.ForeColor = System.Drawing.Color.Gray
        Me.txtsuppliername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtsuppliername.Location = New System.Drawing.Point(34, 401)
        Me.txtsuppliername.MaxLength = 50
        Me.txtsuppliername.Name = "txtsuppliername"
        Me.txtsuppliername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsuppliername.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtsuppliername.PlaceholderText = ""
        Me.txtsuppliername.SelectedText = ""
        Me.txtsuppliername.Size = New System.Drawing.Size(435, 40)
        Me.txtsuppliername.TabIndex = 4
        '
        'lblphoto
        '
        Me.lblphoto.AutoSize = True
        Me.lblphoto.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphoto.ForeColor = System.Drawing.Color.Gray
        Me.lblphoto.Location = New System.Drawing.Point(89, 104)
        Me.lblphoto.Name = "lblphoto"
        Me.lblphoto.Size = New System.Drawing.Size(68, 26)
        Me.lblphoto.TabIndex = 67
        Me.lblphoto.Text = "Photo"
        '
        'txtproductcategory
        '
        Me.txtproductcategory.BackColor = System.Drawing.Color.Transparent
        Me.txtproductcategory.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtproductcategory.BorderRadius = 2
        Me.txtproductcategory.BorderThickness = 2
        Me.txtproductcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtproductcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtproductcategory.FillColor = System.Drawing.Color.Transparent
        Me.txtproductcategory.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtproductcategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtproductcategory.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtproductcategory.ForeColor = System.Drawing.Color.Gray
        Me.txtproductcategory.ItemHeight = 30
        Me.txtproductcategory.Items.AddRange(New Object() {"Creatine", "Other", "Protein"})
        Me.txtproductcategory.ItemsAppearance.BackColor = System.Drawing.Color.Black
        Me.txtproductcategory.ItemsAppearance.ForeColor = System.Drawing.Color.Gray
        Me.txtproductcategory.ItemsAppearance.SelectedBackColor = System.Drawing.Color.DimGray
        Me.txtproductcategory.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Silver
        Me.txtproductcategory.Location = New System.Drawing.Point(520, 294)
        Me.txtproductcategory.Name = "txtproductcategory"
        Me.txtproductcategory.Size = New System.Drawing.Size(175, 36)
        Me.txtproductcategory.Sorted = True
        Me.txtproductcategory.StartIndex = 0
        Me.txtproductcategory.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(515, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 26)
        Me.Label7.TabIndex = 705
        Me.Label7.Text = "Category"
        '
        'openimage
        '
        Me.openimage.FileName = "OpenFileDialog1"
        '
        'txtproductdescription
        '
        Me.txtproductdescription.BackColor = System.Drawing.Color.Transparent
        Me.txtproductdescription.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtproductdescription.BorderRadius = 2
        Me.txtproductdescription.BorderThickness = 2
        Me.txtproductdescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtproductdescription.DefaultText = ""
        Me.txtproductdescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtproductdescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtproductdescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtproductdescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtproductdescription.FillColor = System.Drawing.Color.Transparent
        Me.txtproductdescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtproductdescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtproductdescription.ForeColor = System.Drawing.Color.Gray
        Me.txtproductdescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtproductdescription.Location = New System.Drawing.Point(34, 613)
        Me.txtproductdescription.Margin = New System.Windows.Forms.Padding(0)
        Me.txtproductdescription.Multiline = True
        Me.txtproductdescription.Name = "txtproductdescription"
        Me.txtproductdescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtproductdescription.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtproductdescription.PlaceholderText = "Write description of product.... "
        Me.txtproductdescription.SelectedText = ""
        Me.txtproductdescription.Size = New System.Drawing.Size(886, 160)
        Me.txtproductdescription.TabIndex = 12
        '
        'txtproductprice
        '
        Me.txtproductprice.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtproductprice.BorderRadius = 2
        Me.txtproductprice.BorderThickness = 2
        Me.txtproductprice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtproductprice.DefaultText = ""
        Me.txtproductprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtproductprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtproductprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtproductprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtproductprice.FillColor = System.Drawing.Color.Transparent
        Me.txtproductprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtproductprice.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtproductprice.ForeColor = System.Drawing.Color.Gray
        Me.txtproductprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtproductprice.Location = New System.Drawing.Point(324, 513)
        Me.txtproductprice.MaxLength = 6
        Me.txtproductprice.Name = "txtproductprice"
        Me.txtproductprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtproductprice.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtproductprice.PlaceholderText = "₹"
        Me.txtproductprice.SelectedText = ""
        Me.txtproductprice.Size = New System.Drawing.Size(145, 40)
        Me.txtproductprice.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(319, 465)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 26)
        Me.Label6.TabIndex = 707
        Me.Label6.Text = "MRP"
        '
        'txtsupplierphone
        '
        Me.txtsupplierphone.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtsupplierphone.BorderRadius = 2
        Me.txtsupplierphone.BorderThickness = 2
        Me.txtsupplierphone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsupplierphone.DefaultText = ""
        Me.txtsupplierphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsupplierphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsupplierphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsupplierphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsupplierphone.FillColor = System.Drawing.Color.Transparent
        Me.txtsupplierphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtsupplierphone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsupplierphone.ForeColor = System.Drawing.Color.Gray
        Me.txtsupplierphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtsupplierphone.Location = New System.Drawing.Point(520, 401)
        Me.txtsupplierphone.MaxLength = 10
        Me.txtsupplierphone.Name = "txtsupplierphone"
        Me.txtsupplierphone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsupplierphone.PlaceholderText = ""
        Me.txtsupplierphone.SelectedText = ""
        Me.txtsupplierphone.Size = New System.Drawing.Size(175, 40)
        Me.txtsupplierphone.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(515, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 31)
        Me.Label3.TabIndex = 710
        Me.Label3.Text = "Phone"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(29, 465)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 31)
        Me.Label8.TabIndex = 712
        Me.Label8.Text = "Expire date"
        '
        'txttotalamount
        '
        Me.txttotalamount.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txttotalamount.BorderRadius = 2
        Me.txttotalamount.BorderThickness = 2
        Me.txttotalamount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttotalamount.DefaultText = ""
        Me.txttotalamount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txttotalamount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txttotalamount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotalamount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotalamount.FillColor = System.Drawing.Color.Transparent
        Me.txttotalamount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txttotalamount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txttotalamount.ForeColor = System.Drawing.Color.Gray
        Me.txttotalamount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txttotalamount.Location = New System.Drawing.Point(738, 513)
        Me.txttotalamount.MaxLength = 7
        Me.txttotalamount.Name = "txttotalamount"
        Me.txttotalamount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttotalamount.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txttotalamount.PlaceholderText = "₹"
        Me.txttotalamount.SelectedText = ""
        Me.txttotalamount.Size = New System.Drawing.Size(182, 40)
        Me.txttotalamount.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGray
        Me.Label9.Location = New System.Drawing.Point(733, 465)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 26)
        Me.Label9.TabIndex = 714
        Me.Label9.Text = "Total Amount"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.DarkGray
        Me.Label10.Location = New System.Drawing.Point(733, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 31)
        Me.Label10.TabIndex = 716
        Me.Label10.Text = "Purchase date"
        '
        'txtsupplieremail
        '
        Me.txtsupplieremail.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtsupplieremail.BorderRadius = 2
        Me.txtsupplieremail.BorderThickness = 2
        Me.txtsupplieremail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsupplieremail.DefaultText = ""
        Me.txtsupplieremail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsupplieremail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsupplieremail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsupplieremail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsupplieremail.FillColor = System.Drawing.Color.Transparent
        Me.txtsupplieremail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtsupplieremail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsupplieremail.ForeColor = System.Drawing.Color.Gray
        Me.txtsupplieremail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtsupplieremail.Location = New System.Drawing.Point(738, 401)
        Me.txtsupplieremail.MaxLength = 50
        Me.txtsupplieremail.Name = "txtsupplieremail"
        Me.txtsupplieremail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsupplieremail.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtsupplieremail.PlaceholderText = "Email@Example.com"
        Me.txtsupplieremail.SelectedText = ""
        Me.txtsupplieremail.Size = New System.Drawing.Size(182, 40)
        Me.txtsupplieremail.TabIndex = 6
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblemail.ForeColor = System.Drawing.Color.DarkGray
        Me.lblemail.Location = New System.Drawing.Point(733, 359)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(65, 26)
        Me.lblemail.TabIndex = 718
        Me.lblemail.Text = "Email"
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
        Me.btnaddproduct.Location = New System.Drawing.Point(194, 191)
        Me.btnaddproduct.Name = "btnaddproduct"
        Me.btnaddproduct.PressedState.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnaddproduct.Size = New System.Drawing.Size(39, 33)
        Me.btnaddproduct.TabIndex = 0
        Me.btnaddproduct.UseTransparentBackground = True
        '
        'productphoto
        '
        Me.productphoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.productphoto.FillColor = System.Drawing.Color.Transparent
        Me.productphoto.ImageRotate = 0!
        Me.productphoto.Location = New System.Drawing.Point(34, 24)
        Me.productphoto.Name = "productphoto"
        Me.productphoto.Size = New System.Drawing.Size(181, 184)
        Me.productphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.productphoto.TabIndex = 55
        Me.productphoto.TabStop = False
        '
        'txtpurchase
        '
        Me.txtpurchase.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtpurchase.BorderRadius = 2
        Me.txtpurchase.BorderThickness = 2
        Me.txtpurchase.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpurchase.DefaultText = ""
        Me.txtpurchase.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpurchase.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpurchase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpurchase.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpurchase.FillColor = System.Drawing.Color.Transparent
        Me.txtpurchase.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtpurchase.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtpurchase.ForeColor = System.Drawing.Color.Gray
        Me.txtpurchase.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtpurchase.Location = New System.Drawing.Point(520, 513)
        Me.txtpurchase.MaxLength = 7
        Me.txtpurchase.Name = "txtpurchase"
        Me.txtpurchase.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpurchase.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtpurchase.PlaceholderText = "₹"
        Me.txtpurchase.SelectedText = ""
        Me.txtpurchase.Size = New System.Drawing.Size(175, 40)
        Me.txtpurchase.TabIndex = 10
        '
        'lblpurchase
        '
        Me.lblpurchase.AutoSize = True
        Me.lblpurchase.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpurchase.ForeColor = System.Drawing.Color.DarkGray
        Me.lblpurchase.Location = New System.Drawing.Point(515, 465)
        Me.lblpurchase.Name = "lblpurchase"
        Me.lblpurchase.Size = New System.Drawing.Size(123, 26)
        Me.lblpurchase.TabIndex = 720
        Me.lblpurchase.Text = "PURCHASE "
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
        Me.txtpurchasedate.Location = New System.Drawing.Point(738, 294)
        Me.txtpurchasedate.MaxDate = New Date(2003, 12, 31, 0, 0, 0, 0)
        Me.txtpurchasedate.MinDate = New Date(1942, 1, 1, 0, 0, 0, 0)
        Me.txtpurchasedate.Name = "txtpurchasedate"
        Me.txtpurchasedate.Size = New System.Drawing.Size(182, 36)
        Me.txtpurchasedate.TabIndex = 722
        Me.txtpurchasedate.Value = New Date(2003, 1, 1, 0, 0, 0, 0)
        '
        'txtexpiredate
        '
        Me.txtexpiredate.BorderRadius = 2
        Me.txtexpiredate.Checked = True
        Me.txtexpiredate.CustomFormat = "yyyy-MM-dd"
        Me.txtexpiredate.FillColor = System.Drawing.SystemColors.Desktop
        Me.txtexpiredate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtexpiredate.ForeColor = System.Drawing.Color.Black
        Me.txtexpiredate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtexpiredate.Location = New System.Drawing.Point(34, 513)
        Me.txtexpiredate.MaxDate = New Date(2003, 12, 31, 0, 0, 0, 0)
        Me.txtexpiredate.MinDate = New Date(1942, 1, 1, 0, 0, 0, 0)
        Me.txtexpiredate.Name = "txtexpiredate"
        Me.txtexpiredate.Size = New System.Drawing.Size(150, 40)
        Me.txtexpiredate.TabIndex = 723
        Me.txtexpiredate.Value = New Date(2003, 1, 1, 0, 0, 0, 0)
        '
        'txtpid
        '
        Me.txtpid.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtpid.BorderRadius = 2
        Me.txtpid.BorderThickness = 2
        Me.txtpid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpid.DefaultText = ""
        Me.txtpid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpid.FillColor = System.Drawing.Color.Transparent
        Me.txtpid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtpid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpid.ForeColor = System.Drawing.Color.Gray
        Me.txtpid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtpid.Location = New System.Drawing.Point(94, 46)
        Me.txtpid.MaxLength = 10
        Me.txtpid.Name = "txtpid"
        Me.txtpid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpid.PlaceholderText = ""
        Me.txtpid.SelectedText = ""
        Me.txtpid.Size = New System.Drawing.Size(68, 34)
        Me.txtpid.TabIndex = 726
        '
        'AddProductfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(20, 20)
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(948, 860)
        Me.Controls.Add(Me.txtexpiredate)
        Me.Controls.Add(Me.txtpurchasedate)
        Me.Controls.Add(Me.txtpurchase)
        Me.Controls.Add(Me.lblpurchase)
        Me.Controls.Add(Me.txtsupplieremail)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txttotalamount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtsupplierphone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtproductprice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtproductdescription)
        Me.Controls.Add(Me.txtproductcategory)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtsuppliername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnproductclear)
        Me.Controls.Add(Me.btnaddnewproduct)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtproductquantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnaddproduct)
        Me.Controls.Add(Me.txtproductname)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblphoto)
        Me.Controls.Add(Me.productphoto)
        Me.Controls.Add(Me.txtpid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddProductfrm"
        Me.Text = "ADD PRODUCT"
        CType(Me.txtproductquantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productphoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnaddproduct As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents productphoto As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtproductname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtproductquantity As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents btnproductclear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnaddnewproduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsuppliername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblphoto As Label
    Friend WithEvents txtproductcategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents openimage As OpenFileDialog
    Friend WithEvents txtproductdescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtproductprice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsupplierphone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txttotalamount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtsupplieremail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblemail As Label
    Friend WithEvents txtpurchase As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblpurchase As Label
    Friend WithEvents txtpurchasedate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtexpiredate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtpid As Guna.UI2.WinForms.Guna2TextBox
End Class
