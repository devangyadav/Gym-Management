<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Plansfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Plansfrm))
        Me.txtcardioplans = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtstrengthplans = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtmonthsplans = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcardiostrengthplans = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpersonalplans = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnplansupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.productphoto = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.productphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcardioplans
        '
        Me.txtcardioplans.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtcardioplans.BorderRadius = 2
        Me.txtcardioplans.BorderThickness = 2
        Me.txtcardioplans.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcardioplans.DefaultText = ""
        Me.txtcardioplans.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcardioplans.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcardioplans.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcardioplans.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcardioplans.FillColor = System.Drawing.Color.Transparent
        Me.txtcardioplans.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtcardioplans.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtcardioplans.ForeColor = System.Drawing.Color.Gray
        Me.txtcardioplans.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtcardioplans.Location = New System.Drawing.Point(25, 439)
        Me.txtcardioplans.MaxLength = 50
        Me.txtcardioplans.Name = "txtcardioplans"
        Me.txtcardioplans.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcardioplans.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtcardioplans.PlaceholderText = ""
        Me.txtcardioplans.SelectedText = ""
        Me.txtcardioplans.Size = New System.Drawing.Size(193, 40)
        Me.txtcardioplans.TabIndex = 1
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.DarkGray
        Me.lblname.Location = New System.Drawing.Point(71, 389)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(75, 26)
        Me.lblname.TabIndex = 3
        Me.lblname.Text = "Cardio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(347, 389)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Strength"
        '
        'txtstrengthplans
        '
        Me.txtstrengthplans.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtstrengthplans.BorderRadius = 2
        Me.txtstrengthplans.BorderThickness = 2
        Me.txtstrengthplans.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtstrengthplans.DefaultText = ""
        Me.txtstrengthplans.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtstrengthplans.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtstrengthplans.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstrengthplans.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstrengthplans.FillColor = System.Drawing.Color.Transparent
        Me.txtstrengthplans.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtstrengthplans.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtstrengthplans.ForeColor = System.Drawing.Color.Gray
        Me.txtstrengthplans.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtstrengthplans.Location = New System.Drawing.Point(304, 439)
        Me.txtstrengthplans.MaxLength = 50
        Me.txtstrengthplans.Name = "txtstrengthplans"
        Me.txtstrengthplans.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtstrengthplans.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtstrengthplans.PlaceholderText = ""
        Me.txtstrengthplans.SelectedText = ""
        Me.txtstrengthplans.Size = New System.Drawing.Size(193, 40)
        Me.txtstrengthplans.TabIndex = 2
        '
        'txtmonthsplans
        '
        Me.txtmonthsplans.BackColor = System.Drawing.Color.Transparent
        Me.txtmonthsplans.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtmonthsplans.BorderRadius = 2
        Me.txtmonthsplans.BorderThickness = 2
        Me.txtmonthsplans.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtmonthsplans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtmonthsplans.FillColor = System.Drawing.Color.Transparent
        Me.txtmonthsplans.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtmonthsplans.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtmonthsplans.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtmonthsplans.ForeColor = System.Drawing.Color.Gray
        Me.txtmonthsplans.ItemHeight = 30
        Me.txtmonthsplans.Items.AddRange(New Object() {"01 Month", "03 Months", "06 Months", "09 Months", "12 Months"})
        Me.txtmonthsplans.ItemsAppearance.BackColor = System.Drawing.Color.Black
        Me.txtmonthsplans.ItemsAppearance.SelectedBackColor = System.Drawing.Color.DimGray
        Me.txtmonthsplans.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Silver
        Me.txtmonthsplans.Location = New System.Drawing.Point(824, 85)
        Me.txtmonthsplans.Name = "txtmonthsplans"
        Me.txtmonthsplans.Size = New System.Drawing.Size(193, 36)
        Me.txtmonthsplans.Sorted = True
        Me.txtmonthsplans.StartIndex = 0
        Me.txtmonthsplans.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(582, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 26)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Cardio Strength"
        '
        'txtcardiostrengthplans
        '
        Me.txtcardiostrengthplans.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtcardiostrengthplans.BorderRadius = 2
        Me.txtcardiostrengthplans.BorderThickness = 2
        Me.txtcardiostrengthplans.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcardiostrengthplans.DefaultText = ""
        Me.txtcardiostrengthplans.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcardiostrengthplans.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcardiostrengthplans.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcardiostrengthplans.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcardiostrengthplans.FillColor = System.Drawing.Color.Transparent
        Me.txtcardiostrengthplans.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtcardiostrengthplans.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtcardiostrengthplans.ForeColor = System.Drawing.Color.Gray
        Me.txtcardiostrengthplans.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtcardiostrengthplans.Location = New System.Drawing.Point(566, 439)
        Me.txtcardiostrengthplans.MaxLength = 50
        Me.txtcardiostrengthplans.Name = "txtcardiostrengthplans"
        Me.txtcardiostrengthplans.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcardiostrengthplans.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtcardiostrengthplans.PlaceholderText = ""
        Me.txtcardiostrengthplans.SelectedText = ""
        Me.txtcardiostrengthplans.Size = New System.Drawing.Size(193, 40)
        Me.txtcardiostrengthplans.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(829, 389)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 26)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Personal Training"
        '
        'txtpersonalplans
        '
        Me.txtpersonalplans.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtpersonalplans.BorderRadius = 2
        Me.txtpersonalplans.BorderThickness = 2
        Me.txtpersonalplans.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpersonalplans.DefaultText = ""
        Me.txtpersonalplans.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpersonalplans.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpersonalplans.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpersonalplans.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpersonalplans.FillColor = System.Drawing.Color.Transparent
        Me.txtpersonalplans.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtpersonalplans.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtpersonalplans.ForeColor = System.Drawing.Color.Gray
        Me.txtpersonalplans.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtpersonalplans.Location = New System.Drawing.Point(824, 439)
        Me.txtpersonalplans.MaxLength = 50
        Me.txtpersonalplans.Name = "txtpersonalplans"
        Me.txtpersonalplans.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpersonalplans.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtpersonalplans.PlaceholderText = ""
        Me.txtpersonalplans.SelectedText = ""
        Me.txtpersonalplans.Size = New System.Drawing.Size(193, 40)
        Me.txtpersonalplans.TabIndex = 4
        '
        'btnplansupdate
        '
        Me.btnplansupdate.Animated = True
        Me.btnplansupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnplansupdate.BorderRadius = 4
        Me.btnplansupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnplansupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnplansupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnplansupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnplansupdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnplansupdate.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnplansupdate.ForeColor = System.Drawing.Color.Silver
        Me.btnplansupdate.Location = New System.Drawing.Point(824, 588)
        Me.btnplansupdate.Name = "btnplansupdate"
        Me.btnplansupdate.Size = New System.Drawing.Size(193, 45)
        Me.btnplansupdate.TabIndex = 5
        Me.btnplansupdate.Text = "Save"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(819, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 26)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Months"
        '
        'productphoto
        '
        Me.productphoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.productphoto.FillColor = System.Drawing.Color.Transparent
        Me.productphoto.Image = CType(resources.GetObject("productphoto.Image"), System.Drawing.Image)
        Me.productphoto.ImageRotate = 0!
        Me.productphoto.Location = New System.Drawing.Point(25, 180)
        Me.productphoto.Name = "productphoto"
        Me.productphoto.Size = New System.Drawing.Size(193, 184)
        Me.productphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.productphoto.TabIndex = 61
        Me.productphoto.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(304, 180)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(193, 184)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 62
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(824, 180)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(193, 184)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 63
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2PictureBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(566, 180)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(193, 184)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox3.TabIndex = 64
        Me.Guna2PictureBox3.TabStop = False
        '
        'Plansfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1052, 670)
        Me.Controls.Add(Me.Guna2PictureBox3)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.productphoto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnplansupdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpersonalplans)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcardiostrengthplans)
        Me.Controls.Add(Me.txtmonthsplans)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtstrengthplans)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.txtcardioplans)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Plansfrm"
        Me.Text = "UPDATE PLANS"
        CType(Me.productphoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcardioplans As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtstrengthplans As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtmonthsplans As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcardiostrengthplans As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpersonalplans As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnplansupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents productphoto As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
End Class
