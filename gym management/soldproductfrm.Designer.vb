<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class soldproductfrm
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(soldproductfrm))
        Me.soldproductdv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.productbanner = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.soldproductdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productbanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'soldproductdv
        '
        Me.soldproductdv.AllowUserToAddRows = False
        Me.soldproductdv.AllowUserToDeleteRows = False
        Me.soldproductdv.AllowUserToResizeColumns = False
        Me.soldproductdv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.soldproductdv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.soldproductdv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.soldproductdv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.soldproductdv.BackgroundColor = System.Drawing.Color.Black
        Me.soldproductdv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.soldproductdv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.soldproductdv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.soldproductdv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.soldproductdv.ColumnHeadersHeight = 55
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.soldproductdv.DefaultCellStyle = DataGridViewCellStyle3
        Me.soldproductdv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.soldproductdv.EnableHeadersVisualStyles = False
        Me.soldproductdv.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.soldproductdv.Location = New System.Drawing.Point(0, 306)
        Me.soldproductdv.Name = "soldproductdv"
        Me.soldproductdv.ReadOnly = True
        Me.soldproductdv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.soldproductdv.RowHeadersVisible = False
        Me.soldproductdv.RowHeadersWidth = 60
        Me.soldproductdv.RowTemplate.Height = 24
        Me.soldproductdv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.soldproductdv.Size = New System.Drawing.Size(1297, 433)
        Me.soldproductdv.TabIndex = 2
        Me.soldproductdv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Purple
        Me.soldproductdv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.soldproductdv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.soldproductdv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.soldproductdv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.soldproductdv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.soldproductdv.ThemeStyle.BackColor = System.Drawing.Color.Black
        Me.soldproductdv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.soldproductdv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.soldproductdv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.soldproductdv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.soldproductdv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.soldproductdv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.soldproductdv.ThemeStyle.HeaderStyle.Height = 55
        Me.soldproductdv.ThemeStyle.ReadOnly = True
        Me.soldproductdv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.soldproductdv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.soldproductdv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.soldproductdv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.soldproductdv.ThemeStyle.RowsStyle.Height = 24
        Me.soldproductdv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.soldproductdv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'productbanner
        '
        Me.productbanner.Dock = System.Windows.Forms.DockStyle.Top
        Me.productbanner.Image = CType(resources.GetObject("productbanner.Image"), System.Drawing.Image)
        Me.productbanner.ImageRotate = 0!
        Me.productbanner.Location = New System.Drawing.Point(0, 0)
        Me.productbanner.Name = "productbanner"
        Me.productbanner.Size = New System.Drawing.Size(1297, 306)
        Me.productbanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.productbanner.TabIndex = 720
        Me.productbanner.TabStop = False
        '
        'soldproductfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1297, 739)
        Me.Controls.Add(Me.soldproductdv)
        Me.Controls.Add(Me.productbanner)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "soldproductfrm"
        Me.Text = "SOLD PRODUCTS"
        CType(Me.soldproductdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productbanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents soldproductdv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents productbanner As Guna.UI2.WinForms.Guna2PictureBox
End Class
