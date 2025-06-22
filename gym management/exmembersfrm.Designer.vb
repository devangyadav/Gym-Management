<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class exmembersfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(exmembersfrm))
        Me.exmemberdataview = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.exmemberpanel = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.exmemberdataview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exmemberdataview
        '
        Me.exmemberdataview.AllowUserToAddRows = False
        Me.exmemberdataview.AllowUserToDeleteRows = False
        Me.exmemberdataview.AllowUserToResizeColumns = False
        Me.exmemberdataview.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.exmemberdataview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.exmemberdataview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.exmemberdataview.BackgroundColor = System.Drawing.Color.Black
        Me.exmemberdataview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.exmemberdataview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.exmemberdataview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.exmemberdataview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.exmemberdataview.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.exmemberdataview.DefaultCellStyle = DataGridViewCellStyle3
        Me.exmemberdataview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.exmemberdataview.EnableHeadersVisualStyles = False
        Me.exmemberdataview.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.exmemberdataview.Location = New System.Drawing.Point(0, 0)
        Me.exmemberdataview.Name = "exmemberdataview"
        Me.exmemberdataview.ReadOnly = True
        Me.exmemberdataview.RowHeadersVisible = False
        Me.exmemberdataview.RowHeadersWidth = 51
        Me.exmemberdataview.RowTemplate.Height = 24
        Me.exmemberdataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.exmemberdataview.Size = New System.Drawing.Size(1424, 733)
        Me.exmemberdataview.TabIndex = 4
        Me.exmemberdataview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Purple
        Me.exmemberdataview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.exmemberdataview.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.exmemberdataview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.exmemberdataview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.exmemberdataview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.exmemberdataview.ThemeStyle.BackColor = System.Drawing.Color.Black
        Me.exmemberdataview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.exmemberdataview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.exmemberdataview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.exmemberdataview.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.exmemberdataview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.exmemberdataview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.exmemberdataview.ThemeStyle.HeaderStyle.Height = 40
        Me.exmemberdataview.ThemeStyle.ReadOnly = True
        Me.exmemberdataview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.exmemberdataview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.exmemberdataview.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.exmemberdataview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.exmemberdataview.ThemeStyle.RowsStyle.Height = 24
        Me.exmemberdataview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.exmemberdataview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'exmemberpanel
        '
        Me.exmemberpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.exmemberpanel.Location = New System.Drawing.Point(0, 0)
        Me.exmemberpanel.Name = "exmemberpanel"
        Me.exmemberpanel.Size = New System.Drawing.Size(1424, 733)
        Me.exmemberpanel.TabIndex = 5
        '
        'exmembersfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1424, 733)
        Me.Controls.Add(Me.exmemberpanel)
        Me.Controls.Add(Me.exmemberdataview)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "exmembersfrm"
        Me.Text = "EX MEMBERS"
        CType(Me.exmemberdataview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents exmemberdataview As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Friend WithEvents exmemberpanel As FlowLayoutPanel
End Class
