<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class expireproductfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(expireproductfrm))
        Me.expireproductdv = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(Me.expireproductdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'expireproductdv
        '
        Me.expireproductdv.AllowUserToAddRows = False
        Me.expireproductdv.AllowUserToDeleteRows = False
        Me.expireproductdv.AllowUserToResizeColumns = False
        Me.expireproductdv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.expireproductdv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.expireproductdv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.expireproductdv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.expireproductdv.BackgroundColor = System.Drawing.Color.Black
        Me.expireproductdv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.expireproductdv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.expireproductdv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.expireproductdv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.expireproductdv.ColumnHeadersHeight = 55
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.expireproductdv.DefaultCellStyle = DataGridViewCellStyle3
        Me.expireproductdv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.expireproductdv.EnableHeadersVisualStyles = False
        Me.expireproductdv.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.expireproductdv.Location = New System.Drawing.Point(0, 0)
        Me.expireproductdv.Name = "expireproductdv"
        Me.expireproductdv.ReadOnly = True
        Me.expireproductdv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.expireproductdv.RowHeadersVisible = False
        Me.expireproductdv.RowHeadersWidth = 60
        Me.expireproductdv.RowTemplate.Height = 24
        Me.expireproductdv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.expireproductdv.Size = New System.Drawing.Size(1357, 719)
        Me.expireproductdv.TabIndex = 3
        Me.expireproductdv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Purple
        Me.expireproductdv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.expireproductdv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.expireproductdv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.expireproductdv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.expireproductdv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.expireproductdv.ThemeStyle.BackColor = System.Drawing.Color.Black
        Me.expireproductdv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.expireproductdv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.expireproductdv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.expireproductdv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.expireproductdv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.expireproductdv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.expireproductdv.ThemeStyle.HeaderStyle.Height = 55
        Me.expireproductdv.ThemeStyle.ReadOnly = True
        Me.expireproductdv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.expireproductdv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.expireproductdv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.expireproductdv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.expireproductdv.ThemeStyle.RowsStyle.Height = 24
        Me.expireproductdv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.expireproductdv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'expireproductfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1357, 719)
        Me.Controls.Add(Me.expireproductdv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "expireproductfrm"
        Me.Text = "EXPIRE PRODUCTS"
        CType(Me.expireproductdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents expireproductdv As Guna.UI2.WinForms.Guna2DataGridView
End Class
