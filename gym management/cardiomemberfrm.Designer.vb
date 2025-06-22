<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cardiomemberfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cardiomemberfrm))
        Me.listpanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'listpanel
        '
        Me.listpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listpanel.Location = New System.Drawing.Point(0, 0)
        Me.listpanel.Name = "listpanel"
        Me.listpanel.Size = New System.Drawing.Size(1249, 715)
        Me.listpanel.TabIndex = 0
        '
        'cardiomemberfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1249, 715)
        Me.Controls.Add(Me.listpanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cardiomemberfrm"
        Me.Text = "CARDIO MEMBERS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProfileDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JoindateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentWeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlansDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalfeesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents listpanel As FlowLayoutPanel
End Class
