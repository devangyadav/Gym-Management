<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notificationfrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnmaintenancemail = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.updateplanleftpanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.electribillleftpanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Accleftpanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnproductsnoti = New Guna.UI2.WinForms.Guna2Button()
        Me.btntrainernoti = New Guna.UI2.WinForms.Guna2Button()
        Me.btnmembernoti = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.notificationpanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.btnmaintenancemail.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnmaintenancemail)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 744)
        Me.Panel1.TabIndex = 3
        '
        'btnmaintenancemail
        '
        Me.btnmaintenancemail.BorderColor = System.Drawing.SystemColors.Desktop
        Me.btnmaintenancemail.Controls.Add(Me.updateplanleftpanel)
        Me.btnmaintenancemail.Controls.Add(Me.electribillleftpanel)
        Me.btnmaintenancemail.Controls.Add(Me.Accleftpanel)
        Me.btnmaintenancemail.Controls.Add(Me.btnproductsnoti)
        Me.btnmaintenancemail.Controls.Add(Me.btntrainernoti)
        Me.btnmaintenancemail.Controls.Add(Me.btnmembernoti)
        Me.btnmaintenancemail.CustomBorderColor = System.Drawing.SystemColors.Desktop
        Me.btnmaintenancemail.FillColor = System.Drawing.Color.Transparent
        Me.btnmaintenancemail.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmaintenancemail.ForeColor = System.Drawing.Color.DarkGray
        Me.btnmaintenancemail.Location = New System.Drawing.Point(50, 48)
        Me.btnmaintenancemail.Name = "btnmaintenancemail"
        Me.btnmaintenancemail.Size = New System.Drawing.Size(333, 221)
        Me.btnmaintenancemail.TabIndex = 11
        Me.btnmaintenancemail.Text = "Notification Menu"
        '
        'updateplanleftpanel
        '
        Me.updateplanleftpanel.BorderColor = System.Drawing.SystemColors.Desktop
        Me.updateplanleftpanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.updateplanleftpanel.Location = New System.Drawing.Point(9, 165)
        Me.updateplanleftpanel.Name = "updateplanleftpanel"
        Me.updateplanleftpanel.Size = New System.Drawing.Size(10, 45)
        Me.updateplanleftpanel.TabIndex = 14
        Me.updateplanleftpanel.Visible = False
        '
        'electribillleftpanel
        '
        Me.electribillleftpanel.BorderColor = System.Drawing.SystemColors.Desktop
        Me.electribillleftpanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.electribillleftpanel.Location = New System.Drawing.Point(9, 109)
        Me.electribillleftpanel.Name = "electribillleftpanel"
        Me.electribillleftpanel.Size = New System.Drawing.Size(10, 45)
        Me.electribillleftpanel.TabIndex = 2
        Me.electribillleftpanel.Visible = False
        '
        'Accleftpanel
        '
        Me.Accleftpanel.BorderColor = System.Drawing.SystemColors.Desktop
        Me.Accleftpanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Accleftpanel.Location = New System.Drawing.Point(9, 54)
        Me.Accleftpanel.Name = "Accleftpanel"
        Me.Accleftpanel.Size = New System.Drawing.Size(10, 45)
        Me.Accleftpanel.TabIndex = 0
        Me.Accleftpanel.Visible = False
        '
        'btnproductsnoti
        '
        Me.btnproductsnoti.Animated = True
        Me.btnproductsnoti.BorderColor = System.Drawing.SystemColors.Desktop
        Me.btnproductsnoti.BorderThickness = 1
        Me.btnproductsnoti.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnproductsnoti.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnproductsnoti.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnproductsnoti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnproductsnoti.FillColor = System.Drawing.Color.Black
        Me.btnproductsnoti.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnproductsnoti.ForeColor = System.Drawing.Color.Gray
        Me.btnproductsnoti.Location = New System.Drawing.Point(9, 165)
        Me.btnproductsnoti.Name = "btnproductsnoti"
        Me.btnproductsnoti.Size = New System.Drawing.Size(314, 45)
        Me.btnproductsnoti.TabIndex = 15
        Me.btnproductsnoti.Text = "Products"
        Me.btnproductsnoti.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btntrainernoti
        '
        Me.btntrainernoti.BorderColor = System.Drawing.SystemColors.Desktop
        Me.btntrainernoti.BorderThickness = 1
        Me.btntrainernoti.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btntrainernoti.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btntrainernoti.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btntrainernoti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btntrainernoti.FillColor = System.Drawing.Color.Black
        Me.btntrainernoti.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btntrainernoti.ForeColor = System.Drawing.Color.Gray
        Me.btntrainernoti.Location = New System.Drawing.Point(9, 109)
        Me.btntrainernoti.Name = "btntrainernoti"
        Me.btntrainernoti.Size = New System.Drawing.Size(314, 45)
        Me.btntrainernoti.TabIndex = 12
        Me.btntrainernoti.Text = "Trainers"
        Me.btntrainernoti.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnmembernoti
        '
        Me.btnmembernoti.BorderColor = System.Drawing.SystemColors.Desktop
        Me.btnmembernoti.BorderThickness = 1
        Me.btnmembernoti.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnmembernoti.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnmembernoti.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnmembernoti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnmembernoti.FillColor = System.Drawing.Color.Black
        Me.btnmembernoti.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnmembernoti.ForeColor = System.Drawing.Color.Gray
        Me.btnmembernoti.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnmembernoti.Location = New System.Drawing.Point(9, 54)
        Me.btnmembernoti.Name = "btnmembernoti"
        Me.btnmembernoti.Size = New System.Drawing.Size(314, 45)
        Me.btnmembernoti.TabIndex = 9
        Me.btnmembernoti.Text = "Members"
        Me.btnmembernoti.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.notificationpanel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(448, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(763, 744)
        Me.Panel2.TabIndex = 4
        '
        'notificationpanel
        '
        Me.notificationpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.notificationpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.notificationpanel.Location = New System.Drawing.Point(0, 0)
        Me.notificationpanel.Name = "notificationpanel"
        Me.notificationpanel.Size = New System.Drawing.Size(763, 744)
        Me.notificationpanel.TabIndex = 3
        '
        'notificationfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1211, 744)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "notificationfrm"
        Me.Text = "NOTIFICATION"
        Me.Panel1.ResumeLayout(False)
        Me.btnmaintenancemail.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnmaintenancemail As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents updateplanleftpanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents electribillleftpanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Accleftpanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnproductsnoti As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btntrainernoti As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnmembernoti As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents notificationpanel As FlowLayoutPanel
End Class
