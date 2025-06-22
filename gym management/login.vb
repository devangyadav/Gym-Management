Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices

Public Class login

    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable

    Dim detectedkeydate As Date

    Private Const WM_DEVICECHANGE As Integer = &H219
    Private Const DBT_DEVICEARTVAL As Integer = &H8000
    Private Const DBT_DEVITY_VOLUME As Integer = &H2

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        txtpersonalkey.Text = My.Settings.personalkey
        txtusbstorage.Text = My.Settings.usbserial
    End Sub

    Private Sub btncloselogin_Click(sender As Object, e As EventArgs) Handles btncloselogin.Click
        Application.Exit()
    End Sub

    Private Sub lblforgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblforgot.LinkClicked
        btncloselogin.Hide()
        T1.HideSync(P2)
        T1.ShowSync(P3)
        My.Settings.forgot = True
    End Sub

    Private Sub btncloseforgot_Click(sender As Object, e As EventArgs) Handles btncloseforgot.Click
        T1.HideSync(P3)
        btncloselogin.Show()
        T1.ShowSync(P2)
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        cmd = New SqlCommand("select * from settingsmst where username='" & txtusername.Text & "' and password='" & txtpassword.Text & "'", con)

        da = New SqlDataAdapter(cmd)

        dt = New DataTable()

        da.Fill(dt)

        If (dt.Rows.Count > 0) Then
            If StrComp(txtusername.Text, dt.Rows(0).Item("username"), 0) = 0 And StrComp(txtpassword.Text, dt.Rows(0).Item("password"), 0) = 0 Then
                Mainfrm.Show()
                Me.Close()
            Else
                txtusername.BorderColor = Color.Red
                txtpassword.BorderColor = Color.Red
                MsgBox("Invalid Username and Password", MsgBoxStyle.Critical)
            End If
        ElseIf txtusername.Text = "" And txtpassword.Text = "" Then
                txtusername.BorderColor = Color.Red
                txtpassword.BorderColor = Color.Red
                MsgBox("Please Enter Username and Password", MsgBoxStyle.Critical)
            ElseIf txtusername.Text = "" Then
                txtusername.BorderColor = Color.Red
                MsgBox("Please Enter Username", MsgBoxStyle.Critical)
            ElseIf txtpassword.Text = "" Then
                txtpassword.BorderColor = Color.Red
                MsgBox("Please Enter Password", MsgBoxStyle.Critical)
            Else
                txtusername.BorderColor = Color.Red
            txtpassword.BorderColor = Color.Red
            MsgBox("Wrong Username and Password", MsgBoxStyle.Critical)
            txtusername.Text = ""
            txtpassword.Text = ""
        End If

    End Sub

    Public Structure DEV_BROADCAST_HDR
        Public dbch_size As Int32
        Public dbch_devicetype As Int32
        Public dbch_reserved As Int32
    End Structure

    Private Structure DEV_BRODCASTE_VOLUME
        Public dbcv_size As Int32
        Public dbcv_devicetype As Int32
        Public dbcv_reserved As Int32
        Public dbcv_unitmask As Int32
        Public dbcv_flags As Int16
    End Structure

    Private Function getdriveletterfrommask(ByRef Unit As Int32) As Char
        For i As Integer = 0 To 25
            If Unit = (2 ^ i) Then
                Return Chr(Asc("A") + i)
            End If
        Next
        End
    End Function

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If My.Settings.forgot = True Then
            If m.Msg = WM_DEVICECHANGE Then
                If m.WParam.ToInt32 = DBT_DEVICEARTVAL Then
                    If CInt(m.WParam) = DBT_DEVICEARTVAL Then
                        Dim deviceinfo As DEV_BROADCAST_HDR
                        deviceinfo = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(DEV_BROADCAST_HDR)), DEV_BROADCAST_HDR)
                        If deviceinfo.dbch_devicetype = DBT_DEVITY_VOLUME Then
                            Dim Volume As DEV_BRODCASTE_VOLUME

                            Volume = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(DEV_BRODCASTE_VOLUME)), DEV_BRODCASTE_VOLUME)
                            Dim DriveLetter As String = (getdriveletterfrommask(Volume.dbcv_unitmask) & ":\")

                            Dim key_is_gone = True
                            For Each drv As DriveInfo In My.Computer.FileSystem.Drives
                                If drv.Name = DriveLetter AndAlso drv.RootDirectory.CreationTime = detectedkeydate Then
                                    key_is_gone = False
                                    Exit For
                                End If
                            Next
                            If key_is_gone Then
                                If IO.File.Exists(IO.Path.Combine(DriveLetter, "password.dll")) Then
                                    Dim fso As Scripting.FileSystemObject
                                    Dim odrive As Scripting.Drive

                                    fso = CreateObject("Scripting.FileSystemObject")
                                    odrive = fso.GetDrive(DriveLetter)

                                    Dim passline As String() = File.ReadAllLines(DriveLetter & "password.dll")
                                    txtusbpassword.Text = passline(0)
                                    btndecrypt.PerformClick()

                                    txtserialusb.Text = odrive.SerialNumber

                                    If txtserialusb.Text = My.Settings.usbserial Then

                                        txtcorrectpass.Text = txtdecrypt.Text & odrive.SerialNumber

                                        If txtcorrectpass.Text = My.Settings.usbpassword & odrive.SerialNumber Then
                                            txtverify.Text = "!"
                                        Else
                                            MsgBox("This is not your password", MsgBoxStyle.Exclamation)
                                        End If
                                    Else
                                        MsgBox("this is not the verified usb", MsgBoxStyle.Exclamation)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 5 Then
            Timer1.Stop()
        End If
        If ProgressBar1.Value = 30 Then
            lblstatus.Text = "Checking...."
            lblstatus.TextAlign = ContentAlignment.MiddleRight
            lblstatus.ForeColor = Color.Yellow
        End If
        If ProgressBar1.Value = 60 Then
            lblstatus.Text = "Activation...."
            lblstatus.TextAlign = ContentAlignment.MiddleRight
            lblstatus.ForeColor = Color.Blue
        End If
        If ProgressBar1.Value = 70 Then
            lblstatus.Text = "Active...."
            lblstatus.TextAlign = ContentAlignment.MiddleRight
            lblstatus.ForeColor = Color.Green
            ProgressBar1.Value = 0
            Timer2.Stop()
            lblstatus.Cursor = Cursors.Default
            Me.Hide()
            Mainfrm.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If txtverify.Text = "!" Then
            Timer2.Start()
            lblstatus.Text = "please wait"
            lblstatus.TextAlign = ContentAlignment.MiddleRight
            lblstatus.ForeColor = Color.Blue

        End If
    End Sub

    Private Sub btndecrypt_Click(sender As Object, e As EventArgs) Handles btndecrypt.Click
        Try
            Dim decriptstring As String = EncryptClass.DecryptString(txtusbpassword.Text, txtpersonalkey.Text)
            txtdecrypt.Text = decriptstring
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "error")
        End Try
    End Sub
End Class
