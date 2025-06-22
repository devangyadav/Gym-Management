<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Allmembersfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Allmembersfrm))
        Me.allmemberpanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'allmemberpanel
        '
        Me.allmemberpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.allmemberpanel.Location = New System.Drawing.Point(0, 0)
        Me.allmemberpanel.Name = "allmemberpanel"
        Me.allmemberpanel.Size = New System.Drawing.Size(1406, 656)
        Me.allmemberpanel.TabIndex = 0
        '
        'Allmembersfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1406, 656)
        Me.Controls.Add(Me.allmemberpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Allmembersfrm"
        Me.Text = "ALL MEMBERS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listpanel As FlowLayoutPanel
    Friend WithEvents allmemberpanel As FlowLayoutPanel
End Class
