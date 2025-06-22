<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mainfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainfrm))
        Me.mainbg = New Guna.UI2.WinForms.Guna2Panel()
        Me.mainpanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.topbar = New Guna.UI2.WinForms.Guna2Panel()
        Me.mainpageprofile = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnnotificationbell = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.menubarclicktxt = New System.Windows.Forms.Label()
        Me.mmcpanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnmaincancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btntaskbar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnminimax = New Guna.UI2.WinForms.Guna2Button()
        Me.Menubar = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btndasgboard = New Guna.UI2.WinForms.Guna2Button()
        Me.btndatafile = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsettings = New Guna.UI2.WinForms.Guna2Button()
        Me.btnmaintenance = New Guna.UI2.WinForms.Guna2Button()
        Me.btnproducts = New Guna.UI2.WinForms.Guna2Button()
        Me.btnmembership = New Guna.UI2.WinForms.Guna2Button()
        Me.btnlogo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnlogout = New Guna.UI2.WinForms.Guna2Button()
        Me.mainbg.SuspendLayout()
        Me.topbar.SuspendLayout()
        CType(Me.mainpageprofile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mmcpanel.SuspendLayout()
        Me.Menubar.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainbg
        '
        Me.mainbg.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mainbg.Controls.Add(Me.mainpanel)
        Me.mainbg.Controls.Add(Me.topbar)
        Me.mainbg.Controls.Add(Me.Menubar)
        resources.ApplyResources(Me.mainbg, "mainbg")
        Me.mainbg.Name = "mainbg"
        '
        'mainpanel
        '
        resources.ApplyResources(Me.mainpanel, "mainpanel")
        Me.mainpanel.BackColor = System.Drawing.Color.Black
        Me.mainpanel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.mainpanel.Name = "mainpanel"
        '
        'topbar
        '
        Me.topbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.topbar.Controls.Add(Me.mainpageprofile)
        Me.topbar.Controls.Add(Me.btnsearch)
        Me.topbar.Controls.Add(Me.btnnotificationbell)
        Me.topbar.Controls.Add(Me.menubarclicktxt)
        Me.topbar.Controls.Add(Me.mmcpanel)
        resources.ApplyResources(Me.topbar, "topbar")
        Me.topbar.Name = "topbar"
        '
        'mainpageprofile
        '
        resources.ApplyResources(Me.mainpageprofile, "mainpageprofile")
        Me.mainpageprofile.ImageRotate = 0!
        Me.mainpageprofile.Name = "mainpageprofile"
        Me.mainpageprofile.TabStop = False
        '
        'btnsearch
        '
        resources.ApplyResources(Me.btnsearch, "btnsearch")
        Me.btnsearch.Animated = True
        Me.btnsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.btnsearch.AutoRoundedCorners = True
        Me.btnsearch.BackColor = System.Drawing.Color.Transparent
        Me.btnsearch.BorderColor = System.Drawing.Color.DimGray
        Me.btnsearch.BorderRadius = 5
        Me.btnsearch.BorderThickness = 2
        Me.btnsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnsearch.DefaultText = ""
        Me.btnsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.btnsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnsearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnsearch.ForeColor = System.Drawing.Color.DimGray
        Me.btnsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnsearch.IconRight = CType(resources.GetObject("btnsearch.IconRight"), System.Drawing.Image)
        Me.btnsearch.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.btnsearch.IconRightSize = New System.Drawing.Size(24, 24)
        Me.btnsearch.MaxLength = 3000
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.btnsearch.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.btnsearch.PlaceholderText = "What are you looking for ? "
        Me.btnsearch.SelectedText = ""
        '
        'btnnotificationbell
        '
        resources.ApplyResources(Me.btnnotificationbell, "btnnotificationbell")
        Me.btnnotificationbell.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnnotificationbell.HoverState.ImageSize = New System.Drawing.Size(43, 43)
        Me.btnnotificationbell.Image = CType(resources.GetObject("btnnotificationbell.Image"), System.Drawing.Image)
        Me.btnnotificationbell.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnnotificationbell.ImageRotate = 0!
        Me.btnnotificationbell.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnnotificationbell.Name = "btnnotificationbell"
        Me.btnnotificationbell.PressedState.ImageSize = New System.Drawing.Size(40, 40)
        '
        'menubarclicktxt
        '
        resources.ApplyResources(Me.menubarclicktxt, "menubarclicktxt")
        Me.menubarclicktxt.ForeColor = System.Drawing.Color.Silver
        Me.menubarclicktxt.Name = "menubarclicktxt"
        '
        'mmcpanel
        '
        Me.mmcpanel.BackColor = System.Drawing.Color.Transparent
        Me.mmcpanel.Controls.Add(Me.btnmaincancel)
        Me.mmcpanel.Controls.Add(Me.btntaskbar)
        Me.mmcpanel.Controls.Add(Me.btnminimax)
        resources.ApplyResources(Me.mmcpanel, "mmcpanel")
        Me.mmcpanel.Name = "mmcpanel"
        '
        'btnmaincancel
        '
        resources.ApplyResources(Me.btnmaincancel, "btnmaincancel")
        Me.btnmaincancel.BorderColor = System.Drawing.Color.Transparent
        Me.btnmaincancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnmaincancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnmaincancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnmaincancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnmaincancel.FillColor = System.Drawing.Color.Transparent
        Me.btnmaincancel.ForeColor = System.Drawing.Color.White
        Me.btnmaincancel.Image = CType(resources.GetObject("btnmaincancel.Image"), System.Drawing.Image)
        Me.btnmaincancel.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnmaincancel.Name = "btnmaincancel"
        '
        'btntaskbar
        '
        resources.ApplyResources(Me.btntaskbar, "btntaskbar")
        Me.btntaskbar.BorderColor = System.Drawing.Color.Transparent
        Me.btntaskbar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btntaskbar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btntaskbar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btntaskbar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btntaskbar.FillColor = System.Drawing.Color.Transparent
        Me.btntaskbar.ForeColor = System.Drawing.Color.White
        Me.btntaskbar.Image = CType(resources.GetObject("btntaskbar.Image"), System.Drawing.Image)
        Me.btntaskbar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btntaskbar.Name = "btntaskbar"
        '
        'btnminimax
        '
        resources.ApplyResources(Me.btnminimax, "btnminimax")
        Me.btnminimax.BorderColor = System.Drawing.Color.Transparent
        Me.btnminimax.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnminimax.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnminimax.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnminimax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnminimax.FillColor = System.Drawing.Color.Transparent
        Me.btnminimax.ForeColor = System.Drawing.Color.White
        Me.btnminimax.Image = CType(resources.GetObject("btnminimax.Image"), System.Drawing.Image)
        Me.btnminimax.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnminimax.Name = "btnminimax"
        '
        'Menubar
        '
        Me.Menubar.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Menubar.Controls.Add(Me.Guna2PictureBox1)
        Me.Menubar.Controls.Add(Me.btndasgboard)
        Me.Menubar.Controls.Add(Me.btndatafile)
        Me.Menubar.Controls.Add(Me.btnsettings)
        Me.Menubar.Controls.Add(Me.btnmaintenance)
        Me.Menubar.Controls.Add(Me.btnproducts)
        Me.Menubar.Controls.Add(Me.btnmembership)
        Me.Menubar.Controls.Add(Me.btnlogo)
        Me.Menubar.Controls.Add(Me.btnlogout)
        resources.ApplyResources(Me.Menubar, "Menubar")
        Me.Menubar.FillColor = System.Drawing.Color.Transparent
        Me.Menubar.FillColor2 = System.Drawing.Color.Transparent
        Me.Menubar.FillColor3 = System.Drawing.Color.Transparent
        Me.Menubar.FillColor4 = System.Drawing.Color.Transparent
        Me.Menubar.Name = "Menubar"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Guna2PictureBox1, "Guna2PictureBox1")
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'btndasgboard
        '
        resources.ApplyResources(Me.btndasgboard, "btndasgboard")
        Me.btndasgboard.Animated = True
        Me.btndasgboard.BackColor = System.Drawing.Color.Transparent
        Me.btndasgboard.BorderColor = System.Drawing.Color.Silver
        Me.btndasgboard.BorderRadius = 2
        Me.btndasgboard.Checked = True
        Me.btndasgboard.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btndasgboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btndasgboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btndasgboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btndasgboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btndasgboard.FillColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btndasgboard.ForeColor = System.Drawing.Color.LightGray
        Me.btndasgboard.Image = CType(resources.GetObject("btndasgboard.Image"), System.Drawing.Image)
        Me.btndasgboard.ImageSize = New System.Drawing.Size(40, 40)
        Me.btndasgboard.Name = "btndasgboard"
        Me.btndasgboard.PressedDepth = 50
        Me.btndasgboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btndatafile
        '
        resources.ApplyResources(Me.btndatafile, "btndatafile")
        Me.btndatafile.Animated = True
        Me.btndatafile.BackColor = System.Drawing.Color.Transparent
        Me.btndatafile.BorderColor = System.Drawing.Color.Silver
        Me.btndatafile.BorderRadius = 5
        Me.btndatafile.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btndatafile.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btndatafile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btndatafile.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btndatafile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btndatafile.FillColor = System.Drawing.Color.Transparent
        Me.btndatafile.ForeColor = System.Drawing.Color.Transparent
        Me.btndatafile.Image = CType(resources.GetObject("btndatafile.Image"), System.Drawing.Image)
        Me.btndatafile.ImageSize = New System.Drawing.Size(55, 55)
        Me.btndatafile.Name = "btndatafile"
        Me.btndatafile.PressedDepth = 50
        Me.btndatafile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnsettings
        '
        resources.ApplyResources(Me.btnsettings, "btnsettings")
        Me.btnsettings.Animated = True
        Me.btnsettings.BackColor = System.Drawing.Color.Transparent
        Me.btnsettings.BorderColor = System.Drawing.Color.Silver
        Me.btnsettings.BorderRadius = 5
        Me.btnsettings.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnsettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsettings.FillColor = System.Drawing.Color.Transparent
        Me.btnsettings.ForeColor = System.Drawing.Color.Transparent
        Me.btnsettings.Image = CType(resources.GetObject("btnsettings.Image"), System.Drawing.Image)
        Me.btnsettings.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnsettings.Name = "btnsettings"
        Me.btnsettings.PressedDepth = 50
        Me.btnsettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnmaintenance
        '
        resources.ApplyResources(Me.btnmaintenance, "btnmaintenance")
        Me.btnmaintenance.Animated = True
        Me.btnmaintenance.BackColor = System.Drawing.Color.Transparent
        Me.btnmaintenance.BorderColor = System.Drawing.Color.Silver
        Me.btnmaintenance.BorderRadius = 5
        Me.btnmaintenance.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnmaintenance.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnmaintenance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnmaintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnmaintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnmaintenance.FillColor = System.Drawing.Color.Transparent
        Me.btnmaintenance.ForeColor = System.Drawing.Color.LightGray
        Me.btnmaintenance.Image = CType(resources.GetObject("btnmaintenance.Image"), System.Drawing.Image)
        Me.btnmaintenance.ImageSize = New System.Drawing.Size(60, 60)
        Me.btnmaintenance.Name = "btnmaintenance"
        Me.btnmaintenance.PressedDepth = 50
        Me.btnmaintenance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnproducts
        '
        resources.ApplyResources(Me.btnproducts, "btnproducts")
        Me.btnproducts.Animated = True
        Me.btnproducts.BackColor = System.Drawing.Color.Transparent
        Me.btnproducts.BorderColor = System.Drawing.Color.Silver
        Me.btnproducts.BorderRadius = 5
        Me.btnproducts.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnproducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnproducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnproducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnproducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnproducts.FillColor = System.Drawing.Color.Transparent
        Me.btnproducts.ForeColor = System.Drawing.Color.Transparent
        Me.btnproducts.Image = CType(resources.GetObject("btnproducts.Image"), System.Drawing.Image)
        Me.btnproducts.ImageSize = New System.Drawing.Size(55, 55)
        Me.btnproducts.Name = "btnproducts"
        Me.btnproducts.PressedDepth = 50
        Me.btnproducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnmembership
        '
        resources.ApplyResources(Me.btnmembership, "btnmembership")
        Me.btnmembership.Animated = True
        Me.btnmembership.BackColor = System.Drawing.Color.Transparent
        Me.btnmembership.BorderColor = System.Drawing.Color.Silver
        Me.btnmembership.BorderRadius = 5
        Me.btnmembership.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnmembership.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnmembership.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnmembership.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnmembership.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnmembership.FillColor = System.Drawing.Color.Transparent
        Me.btnmembership.ForeColor = System.Drawing.Color.Transparent
        Me.btnmembership.Image = CType(resources.GetObject("btnmembership.Image"), System.Drawing.Image)
        Me.btnmembership.ImageSize = New System.Drawing.Size(55, 55)
        Me.btnmembership.Name = "btnmembership"
        Me.btnmembership.PressedDepth = 50
        Me.btnmembership.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnlogo
        '
        Me.btnlogo.BackColor = System.Drawing.Color.Transparent
        Me.btnlogo.BorderColor = System.Drawing.Color.Silver
        Me.btnlogo.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnlogo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnlogo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnlogo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnlogo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnlogo.FillColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btnlogo, "btnlogo")
        Me.btnlogo.ForeColor = System.Drawing.Color.LightGray
        Me.btnlogo.ImageSize = New System.Drawing.Size(45, 45)
        Me.btnlogo.Name = "btnlogo"
        Me.btnlogo.PressedColor = System.Drawing.Color.Transparent
        Me.btnlogo.PressedDepth = 0
        Me.btnlogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnlogout
        '
        resources.ApplyResources(Me.btnlogout, "btnlogout")
        Me.btnlogout.Animated = True
        Me.btnlogout.BackColor = System.Drawing.Color.Transparent
        Me.btnlogout.BorderColor = System.Drawing.Color.Silver
        Me.btnlogout.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnlogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnlogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnlogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnlogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnlogout.FillColor = System.Drawing.Color.Transparent
        Me.btnlogout.ForeColor = System.Drawing.Color.LightGray
        Me.btnlogout.Image = CType(resources.GetObject("btnlogout.Image"), System.Drawing.Image)
        Me.btnlogout.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Mainfrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Controls.Add(Me.mainbg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "Mainfrm"
        Me.mainbg.ResumeLayout(False)
        Me.topbar.ResumeLayout(False)
        CType(Me.mainpageprofile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mmcpanel.ResumeLayout(False)
        Me.Menubar.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mainbg As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Menubar As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btnlogo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnlogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btndasgboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnmembership As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnmaintenance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnproducts As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents topbar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents mainpanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents mmcpanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btntaskbar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnminimax As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnmaincancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents menubarclicktxt As Label
    Friend WithEvents btndatafile As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnnotificationbell As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents mainpageprofile As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
