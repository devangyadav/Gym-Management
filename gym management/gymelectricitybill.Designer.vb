<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gymelectricitybill
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gymelectricitybill))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtunit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtamount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnaddnewbill = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.billdv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.billno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datebill = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billunit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalamount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btndel = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.billdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.txtdate)
        Me.Guna2Panel1.Controls.Add(Me.Label10)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.txtunit)
        Me.Guna2Panel1.Controls.Add(Me.txtamount)
        Me.Guna2Panel1.Controls.Add(Me.btnaddnewbill)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(920, 203)
        Me.Guna2Panel1.TabIndex = 756
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(20, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 26)
        Me.Label4.TabIndex = 730
        Me.Label4.Text = "Unit"
        '
        'txtdate
        '
        Me.txtdate.BorderRadius = 2
        Me.txtdate.Checked = True
        Me.txtdate.CustomFormat = "yyyy-MM-dd"
        Me.txtdate.FillColor = System.Drawing.SystemColors.Desktop
        Me.txtdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdate.ForeColor = System.Drawing.Color.Black
        Me.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtdate.Location = New System.Drawing.Point(523, 96)
        Me.txtdate.MaxDate = New Date(2003, 12, 31, 0, 0, 0, 0)
        Me.txtdate.MinDate = New Date(1942, 1, 1, 0, 0, 0, 0)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(155, 45)
        Me.txtdate.TabIndex = 751
        Me.txtdate.Value = New Date(2003, 1, 1, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.DarkGray
        Me.Label10.Location = New System.Drawing.Point(518, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 31)
        Me.Label10.TabIndex = 746
        Me.Label10.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(264, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 26)
        Me.Label1.TabIndex = 752
        Me.Label1.Text = "Amount"
        '
        'txtunit
        '
        Me.txtunit.BorderColor = System.Drawing.SystemColors.Desktop
        Me.txtunit.BorderRadius = 2
        Me.txtunit.BorderThickness = 2
        Me.txtunit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtunit.DefaultText = ""
        Me.txtunit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtunit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtunit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtunit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtunit.FillColor = System.Drawing.Color.Transparent
        Me.txtunit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtunit.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtunit.ForeColor = System.Drawing.Color.Gray
        Me.txtunit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtunit.Location = New System.Drawing.Point(25, 96)
        Me.txtunit.MaxLength = 50
        Me.txtunit.Name = "txtunit"
        Me.txtunit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtunit.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtunit.PlaceholderText = "0"
        Me.txtunit.SelectedText = ""
        Me.txtunit.Size = New System.Drawing.Size(200, 45)
        Me.txtunit.TabIndex = 754
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
        Me.txtamount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtamount.ForeColor = System.Drawing.Color.Gray
        Me.txtamount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.txtamount.Location = New System.Drawing.Point(269, 96)
        Me.txtamount.MaxLength = 50
        Me.txtamount.Name = "txtamount"
        Me.txtamount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtamount.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtamount.PlaceholderText = "₹"
        Me.txtamount.SelectedText = ""
        Me.txtamount.Size = New System.Drawing.Size(200, 45)
        Me.txtamount.TabIndex = 753
        '
        'btnaddnewbill
        '
        Me.btnaddnewbill.Animated = True
        Me.btnaddnewbill.BackColor = System.Drawing.Color.Transparent
        Me.btnaddnewbill.BorderRadius = 4
        Me.btnaddnewbill.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnaddnewbill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnaddnewbill.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnaddnewbill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnaddnewbill.FillColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnaddnewbill.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnaddnewbill.ForeColor = System.Drawing.Color.Silver
        Me.btnaddnewbill.Location = New System.Drawing.Point(738, 96)
        Me.btnaddnewbill.Name = "btnaddnewbill"
        Me.btnaddnewbill.Size = New System.Drawing.Size(155, 45)
        Me.btnaddnewbill.TabIndex = 731
        Me.btnaddnewbill.Text = "Add"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.billdv)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 203)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(920, 519)
        Me.Guna2Panel2.TabIndex = 757
        '
        'billdv
        '
        Me.billdv.AllowUserToAddRows = False
        Me.billdv.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.billdv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.billdv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.billdv.BackgroundColor = System.Drawing.Color.Black
        Me.billdv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.billdv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.billdv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.billdv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.billdv.ColumnHeadersHeight = 55
        Me.billdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.billdv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.billno, Me.datebill, Me.unit, Me.amount})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.billdv.DefaultCellStyle = DataGridViewCellStyle3
        Me.billdv.Dock = System.Windows.Forms.DockStyle.Left
        Me.billdv.EnableHeadersVisualStyles = False
        Me.billdv.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.billdv.Location = New System.Drawing.Point(0, 0)
        Me.billdv.Name = "billdv"
        Me.billdv.ReadOnly = True
        Me.billdv.RowHeadersVisible = False
        Me.billdv.RowHeadersWidth = 51
        Me.billdv.RowTemplate.Height = 24
        Me.billdv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.billdv.Size = New System.Drawing.Size(920, 519)
        Me.billdv.TabIndex = 723
        Me.billdv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Purple
        Me.billdv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.billdv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.billdv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.billdv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.billdv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.billdv.ThemeStyle.BackColor = System.Drawing.Color.Black
        Me.billdv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.billdv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.billdv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.billdv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.billdv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.billdv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.billdv.ThemeStyle.HeaderStyle.Height = 55
        Me.billdv.ThemeStyle.ReadOnly = True
        Me.billdv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.billdv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.billdv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.billdv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.billdv.ThemeStyle.RowsStyle.Height = 24
        Me.billdv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.billdv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'billno
        '
        Me.billno.FillWeight = 37.43316!
        Me.billno.HeaderText = "#"
        Me.billno.MinimumWidth = 6
        Me.billno.Name = "billno"
        Me.billno.ReadOnly = True
        '
        'datebill
        '
        Me.datebill.FillWeight = 110.4278!
        Me.datebill.HeaderText = "DATE"
        Me.datebill.MinimumWidth = 6
        Me.datebill.Name = "datebill"
        Me.datebill.ReadOnly = True
        '
        'unit
        '
        Me.unit.FillWeight = 110.4278!
        Me.unit.HeaderText = "UNIT"
        Me.unit.MinimumWidth = 6
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        '
        'amount
        '
        Me.amount.FillWeight = 110.4278!
        Me.amount.HeaderText = "AMOUNT"
        Me.amount.MinimumWidth = 6
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        '
        'no
        '
        Me.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.no.FillWeight = 46.74052!
        Me.no.HeaderText = "#"
        Me.no.MinimumWidth = 6
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        '
        'billdate
        '
        Me.billdate.HeaderText = "DATE"
        Me.billdate.MinimumWidth = 6
        Me.billdate.Name = "billdate"
        Me.billdate.ReadOnly = True
        Me.billdate.Width = 125
        '
        'billunit
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.billunit.DefaultCellStyle = DataGridViewCellStyle4
        Me.billunit.FillWeight = 118.7453!
        Me.billunit.HeaderText = "UNIT"
        Me.billunit.MinimumWidth = 6
        Me.billunit.Name = "billunit"
        Me.billunit.ReadOnly = True
        Me.billunit.Width = 125
        '
        'totalamount
        '
        Me.totalamount.FillWeight = 116.4829!
        Me.totalamount.HeaderText = "AMOUNT"
        Me.totalamount.MinimumWidth = 6
        Me.totalamount.Name = "totalamount"
        Me.totalamount.ReadOnly = True
        Me.totalamount.Width = 125
        '
        'btndel
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.NullValue = Nothing
        Me.btndel.DefaultCellStyle = DataGridViewCellStyle5
        Me.btndel.FillWeight = 65.51474!
        Me.btndel.HeaderText = "DELETE"
        Me.btndel.Image = CType(resources.GetObject("btndel.Image"), System.Drawing.Image)
        Me.btndel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.btndel.MinimumWidth = 6
        Me.btndel.Name = "btndel"
        Me.btndel.ReadOnly = True
        Me.btndel.Width = 125
        '
        'gymelectricitybill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(920, 722)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gymelectricitybill"
        Me.Text = "ELECTRICITY BILLS"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.billdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtunit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtamount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnaddnewbill As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents billdate As DataGridViewTextBoxColumn
    Friend WithEvents billunit As DataGridViewTextBoxColumn
    Friend WithEvents totalamount As DataGridViewTextBoxColumn
    Friend WithEvents btndel As DataGridViewImageColumn
    Friend WithEvents billdv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents billno As DataGridViewTextBoxColumn
    Friend WithEvents datebill As DataGridViewTextBoxColumn
    Friend WithEvents unit As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
End Class
