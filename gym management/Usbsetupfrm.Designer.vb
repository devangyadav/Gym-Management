<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usbsetupfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usbsetupfrm))
        Me.txtusbserial = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtusbpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtencrypte = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnsave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnclear = New Guna.UI2.WinForms.Guna2Button()
        Me.txtpersonalkey = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnpersonalkey = New Guna.UI2.WinForms.Guna2Button()
        Me.btnusbpassword = New Guna.UI2.WinForms.Guna2Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.lblusb = New System.Windows.Forms.Label()
        Me.lblpersonalkey = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.lblencrypte = New System.Windows.Forms.Label()
        Me.usbsetupcancel = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'txtusbserial
        '
        Me.txtusbserial.BackColor = System.Drawing.Color.Transparent
        Me.txtusbserial.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusbserial.ForeColor = System.Drawing.Color.Lime
        Me.txtusbserial.Location = New System.Drawing.Point(233, 26)
        Me.txtusbserial.Name = "txtusbserial"
        Me.txtusbserial.Size = New System.Drawing.Size(57, 23)
        Me.txtusbserial.TabIndex = 1
        Me.txtusbserial.Text = "---------"
        '
        'txtusbpassword
        '
        Me.txtusbpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusbpassword.DefaultText = ""
        Me.txtusbpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtusbpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtusbpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusbpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtusbpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusbpassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtusbpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusbpassword.Location = New System.Drawing.Point(233, 166)
        Me.txtusbpassword.Name = "txtusbpassword"
        Me.txtusbpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusbpassword.PlaceholderText = ""
        Me.txtusbpassword.SelectedText = ""
        Me.txtusbpassword.Size = New System.Drawing.Size(248, 36)
        Me.txtusbpassword.TabIndex = 2
        '
        'txtencrypte
        '
        Me.txtencrypte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtencrypte.DefaultText = ""
        Me.txtencrypte.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtencrypte.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtencrypte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtencrypte.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtencrypte.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtencrypte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtencrypte.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtencrypte.Location = New System.Drawing.Point(233, 259)
        Me.txtencrypte.Name = "txtencrypte"
        Me.txtencrypte.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtencrypte.PlaceholderText = ""
        Me.txtencrypte.ReadOnly = True
        Me.txtencrypte.SelectedText = ""
        Me.txtencrypte.Size = New System.Drawing.Size(248, 36)
        Me.txtencrypte.TabIndex = 5
        '
        'btnsave
        '
        Me.btnsave.BorderRadius = 2
        Me.btnsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsave.FillColor = System.Drawing.SystemColors.Desktop
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(28, 409)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(180, 45)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "Save"
        '
        'btnclear
        '
        Me.btnclear.BorderRadius = 2
        Me.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnclear.FillColor = System.Drawing.SystemColors.Desktop
        Me.btnclear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnclear.ForeColor = System.Drawing.Color.White
        Me.btnclear.Location = New System.Drawing.Point(286, 409)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(180, 45)
        Me.btnclear.TabIndex = 700
        Me.btnclear.Text = "Clear"
        '
        'txtpersonalkey
        '
        Me.txtpersonalkey.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpersonalkey.DefaultText = ""
        Me.txtpersonalkey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpersonalkey.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpersonalkey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpersonalkey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpersonalkey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpersonalkey.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpersonalkey.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpersonalkey.Location = New System.Drawing.Point(233, 82)
        Me.txtpersonalkey.Name = "txtpersonalkey"
        Me.txtpersonalkey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpersonalkey.PlaceholderText = ""
        Me.txtpersonalkey.SelectedText = ""
        Me.txtpersonalkey.Size = New System.Drawing.Size(248, 36)
        Me.txtpersonalkey.TabIndex = 8
        '
        'btnpersonalkey
        '
        Me.btnpersonalkey.BorderRadius = 4
        Me.btnpersonalkey.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnpersonalkey.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnpersonalkey.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnpersonalkey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnpersonalkey.FillColor = System.Drawing.SystemColors.Desktop
        Me.btnpersonalkey.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnpersonalkey.ForeColor = System.Drawing.Color.White
        Me.btnpersonalkey.Location = New System.Drawing.Point(531, 82)
        Me.btnpersonalkey.Name = "btnpersonalkey"
        Me.btnpersonalkey.Size = New System.Drawing.Size(180, 45)
        Me.btnpersonalkey.TabIndex = 1
        Me.btnpersonalkey.Text = "Enter"
        '
        'btnusbpassword
        '
        Me.btnusbpassword.BorderRadius = 2
        Me.btnusbpassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnusbpassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnusbpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnusbpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnusbpassword.FillColor = System.Drawing.SystemColors.Desktop
        Me.btnusbpassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnusbpassword.ForeColor = System.Drawing.Color.White
        Me.btnusbpassword.Location = New System.Drawing.Point(531, 157)
        Me.btnusbpassword.Name = "btnusbpassword"
        Me.btnusbpassword.Size = New System.Drawing.Size(180, 45)
        Me.btnusbpassword.TabIndex = 2
        Me.btnusbpassword.Text = "Enter"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.CheckPathExists = False
        Me.SaveFileDialog1.DefaultExt = "dll"
        Me.SaveFileDialog1.FileName = "password"
        Me.SaveFileDialog1.Filter = "passwordformat (*.dll)|*.dll"
        Me.SaveFileDialog1.OverwritePrompt = False
        '
        'lblusb
        '
        Me.lblusb.AutoSize = True
        Me.lblusb.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lblusb.ForeColor = System.Drawing.Color.Silver
        Me.lblusb.Location = New System.Drawing.Point(24, 34)
        Me.lblusb.Name = "lblusb"
        Me.lblusb.Size = New System.Drawing.Size(123, 20)
        Me.lblusb.TabIndex = 12
        Me.lblusb.Text = "USB SERIAL :"
        '
        'lblpersonalkey
        '
        Me.lblpersonalkey.AutoSize = True
        Me.lblpersonalkey.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lblpersonalkey.ForeColor = System.Drawing.Color.Silver
        Me.lblpersonalkey.Location = New System.Drawing.Point(24, 98)
        Me.lblpersonalkey.Name = "lblpersonalkey"
        Me.lblpersonalkey.Size = New System.Drawing.Size(133, 20)
        Me.lblpersonalkey.TabIndex = 13
        Me.lblpersonalkey.Text = "Personal Key:"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lblpassword.ForeColor = System.Drawing.Color.Silver
        Me.lblpassword.Location = New System.Drawing.Point(24, 182)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(101, 20)
        Me.lblpassword.TabIndex = 14
        Me.lblpassword.Text = "Password:"
        '
        'lblencrypte
        '
        Me.lblencrypte.AutoSize = True
        Me.lblencrypte.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lblencrypte.ForeColor = System.Drawing.Color.Silver
        Me.lblencrypte.Location = New System.Drawing.Point(24, 259)
        Me.lblencrypte.Name = "lblencrypte"
        Me.lblencrypte.Size = New System.Drawing.Size(188, 20)
        Me.lblencrypte.TabIndex = 15
        Me.lblencrypte.Text = "Encrypte Password:"
        '
        'usbsetupcancel
        '
        Me.usbsetupcancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.usbsetupcancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.usbsetupcancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.usbsetupcancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.usbsetupcancel.FillColor = System.Drawing.Color.Transparent
        Me.usbsetupcancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usbsetupcancel.ForeColor = System.Drawing.Color.White
        Me.usbsetupcancel.Image = CType(resources.GetObject("usbsetupcancel.Image"), System.Drawing.Image)
        Me.usbsetupcancel.ImageSize = New System.Drawing.Size(30, 30)
        Me.usbsetupcancel.Location = New System.Drawing.Point(728, 12)
        Me.usbsetupcancel.Name = "usbsetupcancel"
        Me.usbsetupcancel.Size = New System.Drawing.Size(39, 37)
        Me.usbsetupcancel.TabIndex = 701
        '
        'Usbsetupfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 497)
        Me.Controls.Add(Me.usbsetupcancel)
        Me.Controls.Add(Me.lblencrypte)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblpersonalkey)
        Me.Controls.Add(Me.lblusb)
        Me.Controls.Add(Me.btnusbpassword)
        Me.Controls.Add(Me.btnpersonalkey)
        Me.Controls.Add(Me.txtpersonalkey)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtencrypte)
        Me.Controls.Add(Me.txtusbpassword)
        Me.Controls.Add(Me.txtusbserial)
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Usbsetupfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USB SETUP"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtusbserial As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtusbpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtencrypte As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnsave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnclear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtpersonalkey As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnpersonalkey As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnusbpassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents lblusb As Label
    Friend WithEvents lblpersonalkey As Label
    Friend WithEvents lblpassword As Label
    Friend WithEvents lblencrypte As Label
    Friend WithEvents usbsetupcancel As Guna.UI2.WinForms.Guna2Button
End Class
