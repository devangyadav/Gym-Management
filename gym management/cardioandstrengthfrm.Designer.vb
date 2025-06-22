<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cardioandstrengthfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cardioandstrengthfrm))
        Me.cardiostrengthdataview = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.listpanel = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.cardiostrengthdataview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cardiostrengthdataview
        '
        Me.cardiostrengthdataview.AllowUserToAddRows = False
        Me.cardiostrengthdataview.AllowUserToDeleteRows = False
        Me.cardiostrengthdataview.AllowUserToResizeColumns = False
        Me.cardiostrengthdataview.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.cardiostrengthdataview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.cardiostrengthdataview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.cardiostrengthdataview.BackgroundColor = System.Drawing.Color.Black
        Me.cardiostrengthdataview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cardiostrengthdataview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.cardiostrengthdataview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cardiostrengthdataview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.cardiostrengthdataview.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cardiostrengthdataview.DefaultCellStyle = DataGridViewCellStyle3
        Me.cardiostrengthdataview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cardiostrengthdataview.EnableHeadersVisualStyles = False
        Me.cardiostrengthdataview.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.cardiostrengthdataview.Location = New System.Drawing.Point(0, 0)
        Me.cardiostrengthdataview.Name = "cardiostrengthdataview"
        Me.cardiostrengthdataview.ReadOnly = True
        Me.cardiostrengthdataview.RowHeadersVisible = False
        Me.cardiostrengthdataview.RowHeadersWidth = 51
        Me.cardiostrengthdataview.RowTemplate.Height = 24
        Me.cardiostrengthdataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cardiostrengthdataview.Size = New System.Drawing.Size(1408, 729)
        Me.cardiostrengthdataview.TabIndex = 1
        Me.cardiostrengthdataview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Purple
        Me.cardiostrengthdataview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.cardiostrengthdataview.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.cardiostrengthdataview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.cardiostrengthdataview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.cardiostrengthdataview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.cardiostrengthdataview.ThemeStyle.BackColor = System.Drawing.Color.Black
        Me.cardiostrengthdataview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.cardiostrengthdataview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.cardiostrengthdataview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.cardiostrengthdataview.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cardiostrengthdataview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.cardiostrengthdataview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.cardiostrengthdataview.ThemeStyle.HeaderStyle.Height = 40
        Me.cardiostrengthdataview.ThemeStyle.ReadOnly = True
        Me.cardiostrengthdataview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cardiostrengthdataview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.cardiostrengthdataview.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.cardiostrengthdataview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.cardiostrengthdataview.ThemeStyle.RowsStyle.Height = 24
        Me.cardiostrengthdataview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.cardiostrengthdataview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'listpanel
        '
        Me.listpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listpanel.Location = New System.Drawing.Point(0, 0)
        Me.listpanel.Name = "listpanel"
        Me.listpanel.Size = New System.Drawing.Size(1408, 729)
        Me.listpanel.TabIndex = 2
        '
        'cardioandstrengthfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1408, 729)
        Me.Controls.Add(Me.listpanel)
        Me.Controls.Add(Me.cardiostrengthdataview)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cardioandstrengthfrm"
        Me.Text = "CARDIO AND STRENGTH"
        CType(Me.cardiostrengthdataview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cardiostrengthdataview As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents listpanel As FlowLayoutPanel
End Class
