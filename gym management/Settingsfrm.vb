Imports System.Data.SqlClient
Imports System.IO
Public Class Settingsfrm
    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim no As Integer = 1

    Private Sub btnmemberenter_Click(sender As Object, e As EventArgs) Handles btnmemberenter.Click

        Try
            If txtgymname.Text = Nothing Or txtusername.Text = Nothing Or txtpassword.Text = Nothing Or txtemail.Text = Nothing Or txtphone.Text = Nothing Then
                MsgBox("Please Enter all Values")
            Else
                cmd = New SqlCommand("UPDATE settingsmst SET profile=@profile,gymname='" & txtgymname.Text & "',username='" & txtusername.Text & "',password='" & txtpassword.Text & "',email='" & txtemail.Text & "',phone=" & txtphone.Text & " WHERE id=" & no & " ", con)
                Dim ms As New MemoryStream
                Dim bmpimage As New Bitmap(profile.Image)
                bmpimage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim data As Byte() = ms.GetBuffer

                Dim p As New SqlParameter("@profile", SqlDbType.Image)
                p.Value = data
                cmd.Parameters.Add(p)
                con.Open()
                If cmd.ExecuteNonQuery Then
                    MsgBox("Update Successfully...")
                Else
                    MsgBox("Something Went Wrong..")
                End If
                con.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnaddprofile_Click(sender As Object, e As EventArgs) Handles btnaddprofile.Click
        openimage.Title = "Add Photo"
        openimage.Filter = "jpg|*.jpg|png|*.png|jpeg|*.jpeg|ALL Files| *.*"
        openimage.FileName = "Photos"
        If openimage.ShowDialog = Windows.Forms.DialogResult.OK Then
            profile.Image = Image.FromFile(openimage.FileName)
            Mainfrm.mainpageprofile.Image = Image.FromFile(openimage.FileName)
            profile.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Settingsfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imagecmd As SqlCommand
        Dim rd As SqlDataReader
        Dim gambar() As Byte
        Dim no As Integer = 1
        Try
            imagecmd = New SqlCommand("select * from settingsmst  WHERE id=" & no & "", con)
            con.Open()
            rd = imagecmd.ExecuteReader
            rd.Read()

            If rd.HasRows() Then
                gambar = rd("profile")
                txtgymname.Text = rd("gymname")
                txtusername.Text = rd("username")
                txtpassword.Text = rd("password")
                txtemail.Text = rd("email")
                txtphone.Text = rd("phone")
                Dim ms As New MemoryStream(gambar)
                profile.Image = Image.FromStream(ms)
                Mainfrm.mainpageprofile.Image = Image.FromStream(ms)
                Mainfrm.mainpageprofile.SizeMode = PictureBoxSizeMode.StretchImage
                profile.Size = New Size(181, 184)
                profile.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub btnforgotpass_Click(sender As Object, e As EventArgs) Handles btnforgotpass.Click
        Usbsetupfrm.Show()
    End Sub

    Private Sub txtgymname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtgymname.KeyPress
        Dim allowchar As String = "abcdefghijklmnopqrstuvwxyz"
        If Not allowchar.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtemail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtemail.KeyPress
        Dim allowchar As String = "abcdefghijklmnopqrstuvwxyz"
        If Not allowchar.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtphone.KeyPress
        Dim allownos As String = "0123456789"
        If Not allownos.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub
End Class