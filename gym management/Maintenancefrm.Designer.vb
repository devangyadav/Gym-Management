<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Maintenancefrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Maintenancefrm))
        Me.btnmaintenancemail = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.gymequipleftpanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.updateplanleftpanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.electribillleftpanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Accleftpanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnplansupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btngymequipment = New Guna.UI2.WinForms.Guna2Button()
        Me.btnelectricitybills = New Guna.UI2.WinForms.Guna2Button()
        Me.btnstockmanage = New Guna.UI2.WinForms.Guna2Button()
        Me.maintenancepanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnmaintenancemail.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnmaintenancemail
        '
        Me.btnmaintenancemail.BorderColor = System.Drawing.SystemColors.Desktop
        Me.btnmaintenancemail.Controls.Add(Me.gymequipleftpanel)
        Me.btnmaintenancemail.Controls.Add(Me.updateplanleftpanel)
        Me.btnmaintenancemail.Controls.Add(Me.electribillleftpanel)
        Me.btnmaintenancemail.Controls.Add(Me.Accleftpanel)
        Me.btnmaintenancemail.Controls.Add(Me.btnplansupdate)
        Me.btnmaintenancemail.Controls.Add(Me.btngymequipment)
        Me.btnmaintenancemail.Controls.Add(Me.btnelectricitybills)
        Me.btnmaintenancemail.Controls.Add(Me.btnstockmanage)
        Me.btnmaintenancemail.CustomBorderColor = System.Drawing.SystemColors.Desktop
        Me.btnmaintenancemail.FillColor = System.Drawing.Color.Transparent
        Me.btnmaintenancemail.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmaintenancemail.ForeColor = System.Drawing.Color.DarkGray
        Me.btnmaintenancemail.Location = New System.Drawing.Point(29, 37)
        Me.btnmaintenancemail.Name = "btnmaintenancemail"
        Me.btnmaintenancemail.Size = New System.Drawing.Size(333, 283)
        Me.btnmaintenancemail.TabIndex = 9
        Me.btnmaintenancemail.Text = "Menu"
        Me.btnmaintenancemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gymequipleftpanel
        '
        Me.gymequipleftpanel.BorderColor = System.Drawing.SystemColors.Desktop
        Me.gymequipleftpanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gymequipleftpanel.Location = New System.Drawing.Point(9, 220)
        Me.gymequipleftpanel.Name = "gymequipleftpanel"
        Me.gymequipleftpanel.Size = New System.Drawing.Size(10, 45)
        Me.gymequipleftpanel.TabIndex = 3
        Me.gymequipleftpanel.Visible = False
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
        'btnplansupdate
        '
        Me.btnplansupdate.Animated = True
        Me.btnplansupdate.BorderColor = System.Drawing.SystemColors.Desktop
        Me.btnplansupdate.BorderThickness = 1
        Me.btnplansupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnplansupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnplansupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnplansupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnplansupdate.FillColor = System.Drawing.Color.Black
        Me.btnplansupdate.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnplansupdate.ForeColor = System.Drawing.Color.Gray
        Me.btnplansupdate.Location = New System.Drawing.Point(9, 165)
        Me.btnplansupdate.Name = "btnplansupdate"
        Me.btnplansupdate.Size = New System.Drawing.Size(314, 45)
        Me.btnplansupdate.TabIndex = 15
        Me.btnplansupdate.Text = "Update Plans "
        Me.btnplansupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btngymequipment
        '
        Me.btngymequipment.Animated = True
        Me.btngymequipment.BorderColor = System.Drawing.SystemColors.Desktop
        Me.btngymequipment.BorderThickness = 1
        Me.btngymequipment.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btngymequipment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btngymequipment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btngymequipment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btngymequipment.FillColor = System.Drawing.Color.Black
        Me.btngymequipment.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btngymequipment.ForeColor = System.Drawing.Color.Gray
        Me.btngymequipment.Location = New System.Drawing.Point(9, 220)
        Me.btngymequipment.Name = "btngymequipment"
        Me.btngymequipment.Size = New System.Drawing.Size(314, 45)
        Me.btngymequipment.TabIndex = 13
        Me.btngymequipment.Text = "Gym Equipment"
        Me.btngymequipment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnelectricitybills
        '
        Me.btnelectricitybills.BorderColor = System.Drawing.SystemColors.Desktop
        Me.btnelectricitybills.BorderThickness = 1
        Me.btnelectricitybills.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnelectricitybills.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnelectricitybills.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnelectricitybills.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnelectricitybills.FillColor = System.Drawing.Color.Black
        Me.btnelectricitybills.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnelectricitybills.ForeColor = System.Drawing.Color.Gray
        Me.btnelectricitybills.Location = New System.Drawing.Point(9, 109)
        Me.btnelectricitybills.Name = "btnelectricitybills"
        Me.btnelectricitybills.Size = New System.Drawing.Size(314, 45)
        Me.btnelectricitybills.TabIndex = 12
        Me.btnelectricitybills.Text = "Electricity Bills"
        Me.btnelectricitybills.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnstockmanage
        '
        Me.btnstockmanage.BorderColor = System.Drawing.SystemColors.Desktop
        Me.btnstockmanage.BorderThickness = 1
        Me.btnstockmanage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnstockmanage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnstockmanage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnstockmanage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnstockmanage.FillColor = System.Drawing.Color.Black
        Me.btnstockmanage.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnstockmanage.ForeColor = System.Drawing.Color.Gray
        Me.btnstockmanage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnstockmanage.Location = New System.Drawing.Point(9, 54)
        Me.btnstockmanage.Name = "btnstockmanage"
        Me.btnstockmanage.Size = New System.Drawing.Size(314, 45)
        Me.btnstockmanage.TabIndex = 9
        Me.btnstockmanage.Text = "Add Product"
        Me.btnstockmanage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'maintenancepanel
        '
        Me.maintenancepanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maintenancepanel.Location = New System.Drawing.Point(379, 12)
        Me.maintenancepanel.Name = "maintenancepanel"
        Me.maintenancepanel.Size = New System.Drawing.Size(900, 714)
        Me.maintenancepanel.TabIndex = 10
        '
        'Maintenancefrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 10)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1279, 728)
        Me.Controls.Add(Me.maintenancepanel)
        Me.Controls.Add(Me.btnmaintenancemail)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Maintenancefrm"
        Me.Text = "MAINTENANCE"
        Me.btnmaintenancemail.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnmaintenancemail As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents gymequipleftpanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents electribillleftpanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Accleftpanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btngymequipment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnelectricitybills As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnstockmanage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents updateplanleftpanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnplansupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents maintenancepanel As Guna.UI2.WinForms.Guna2Panel
End Class
