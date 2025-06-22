<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class strengthtrainerfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(strengthtrainerfrm))
        Me.listpanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'listpanel
        '
        Me.listpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listpanel.Location = New System.Drawing.Point(0, 0)
        Me.listpanel.Name = "listpanel"
        Me.listpanel.Size = New System.Drawing.Size(1304, 713)
        Me.listpanel.TabIndex = 2
        '
        'strengthtrainerfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1304, 713)
        Me.Controls.Add(Me.listpanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "strengthtrainerfrm"
        Me.Text = "STRENGTH TRAINER"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listpanel As FlowLayoutPanel
End Class
