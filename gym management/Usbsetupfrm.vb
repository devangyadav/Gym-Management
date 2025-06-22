Imports System.Runtime.InteropServices
Imports System.IO

Public Class Usbsetupfrm

    Dim detectedkeydate As Date

    Private Const WM_DEVICECHANGE As Integer = &H219
    Private Const DBT_DEVICEARTVAL As Integer = &H8000
    Private Const DBT_DEVITY_VOLUME As Integer = &H2
    Private Const DBT_DEVICEREMOVECOMPLETE As Integer = &H8004

    Public Structure DEV_BRODCAST_HDR
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

    Private Sub btnpersonalkey_Click(sender As Object, e As EventArgs) Handles btnpersonalkey.Click
        If txtpersonalkey.Text = "" Then
            MsgBox("enter personal key")
        Else

            txtusbpassword.ReadOnly = False
            Me.AcceptButton = btnusbpassword
            txtusbpassword.Focus()

        End If
    End Sub

    Private Sub btnusbpassword_Click(sender As Object, e As EventArgs) Handles btnusbpassword.Click
        Dim msg As String = txtusbpassword.Text
        Dim password As String = txtpersonalkey.Text
        Me.AcceptButton = btnsave

        Try
            Dim encryptedstring As String = EncryptClass.EncryptString(msg, password)
            txtencrypte.Text = encryptedstring
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "error")
        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        My.Settings.personalkey = txtpersonalkey.Text
        My.Settings.usbpassword = txtusbpassword.Text
        My.Settings.usbserial = txtusbserial.Text

        SaveFileDialog1.ShowDialog()

        SaveFileDialog1.Filter = "passwordformat (*.dll)|*.dll"

        If My.Computer.FileSystem.FileExists(SaveFileDialog1.FileName) Then
            Dim ask As MsgBoxResult
            ask = MsgBox("File is exiting,do you want to replace it", MsgBoxStyle.YesNo, "file existing")

            If ask = MsgBoxResult.No Then
                SaveFileDialog1.ShowDialog()
            ElseIf ask = MsgBoxResult.Yes Then
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, txtencrypte.Text, False)
            End If
        Else
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, txtencrypte.Text, False)
        End If
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtusbpassword.Text = ""
        txtpersonalkey.Text = ""
        txtencrypte.Text = ""

        txtpersonalkey.Enabled = True
        txtpersonalkey.Focus()
        txtusbpassword.ReadOnly = True
        txtencrypte.ReadOnly = True

    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        If m.Msg = WM_DEVICECHANGE Then
            If m.WParam.ToInt32 = DBT_DEVICEARTVAL Then
                If CInt(m.WParam) = DBT_DEVICEARTVAL Then
                    Dim DeviceInfo As DEV_BRODCAST_HDR
                    DeviceInfo = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(DEV_BRODCAST_HDR)), DEV_BRODCAST_HDR)
                    If DeviceInfo.dbch_devicetype = DBT_DEVITY_VOLUME Then
                        Dim Volume As DEV_BRODCASTE_VOLUME
                        Volume = DirectCast(Marshal.PtrToStructure(m.LParam, GetType(DEV_BRODCASTE_VOLUME)), DEV_BRODCASTE_VOLUME)
                        Dim DriverLetter As String = (getdriveletterfrommask(Volume.dbcv_unitmask) & ":\")

                        Dim fso As Scripting.FileSystemObject
                        Dim odrive As Scripting.Drive

                        fso = CreateObject("Scripting.FileSystemObject")
                        odrive = fso.GetDrive(DriverLetter)


                        txtusbserial.Text = odrive.SerialNumber

                        txtpersonalkey.ReadOnly = False
                        txtpersonalkey.Focus()
                        Me.AcceptButton = btnpersonalkey

                    End If
                End If
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub usbsetupcancel_Click(sender As Object, e As EventArgs) Handles usbsetupcancel.Click
        Me.Close()
    End Sub
End Class
