<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class strengthfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(strengthfrm))
        Me.strengthdataview = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.listpanel = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.strengthdataview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'strengthdataview
        '
        Me.strengthdataview.AllowUserToAddRows = False
        Me.strengthdataview.AllowUserToDeleteRows = False
        Me.strengthdataview.AllowUserToResizeColumns = False
        Me.strengthdataview.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.strengthdataview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.strengthdataview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.strengthdataview.BackgroundColor = System.Drawing.Color.Black
        Me.strengthdataview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.strengthdataview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.strengthdataview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.strengthdataview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.strengthdataview.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.strengthdataview.DefaultCellStyle = DataGridViewCellStyle3
        Me.strengthdataview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.strengthdataview.EnableHeadersVisualStyles = False
        Me.strengthdataview.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.strengthdataview.Location = New System.Drawing.Point(0, 0)
        Me.strengthdataview.Name = "strengthdataview"
        Me.strengthdataview.ReadOnly = True
        Me.strengthdataview.RowHeadersVisible = False
        Me.strengthdataview.RowHeadersWidth = 51
        Me.strengthdataview.RowTemplate.Height = 24
        Me.strengthdataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.strengthdataview.Size = New System.Drawing.Size(1387, 744)
        Me.strengthdataview.TabIndex = 3
        Me.strengthdataview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Purple
        Me.strengthdataview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.strengthdataview.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.strengthdataview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.strengthdataview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.strengthdataview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.strengthdataview.ThemeStyle.BackColor = System.Drawing.Color.Black
        Me.strengthdataview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.strengthdataview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.strengthdataview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.strengthdataview.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.strengthdataview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.strengthdataview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.strengthdataview.ThemeStyle.HeaderStyle.Height = 40
        Me.strengthdataview.ThemeStyle.ReadOnly = True
        Me.strengthdataview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.strengthdataview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.strengthdataview.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.strengthdataview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.strengthdataview.ThemeStyle.RowsStyle.Height = 24
        Me.strengthdataview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.strengthdataview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'listpanel
        '
        Me.listpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listpanel.Location = New System.Drawing.Point(0, 0)
        Me.listpanel.Name = "listpanel"
        Me.listpanel.Size = New System.Drawing.Size(1387, 744)
        Me.listpanel.TabIndex = 4
        '
        'strengthfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1387, 744)
        Me.Controls.Add(Me.listpanel)
        Me.Controls.Add(Me.strengthdataview)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "strengthfrm"
        Me.Text = "STRENGTH MEMBERS"
        CType(Me.strengthdataview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents strengthdataview As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ProfileDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JoindateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpiredateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentWeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlansDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalfeesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents listpanel As FlowLayoutPanel
End Class
