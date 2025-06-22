Imports System.Data.SqlClient
Imports System.IO
Public Class notificationfrm

    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim drn As SqlDataReader

    Private WithEvents pic As New PictureBox
    Private WithEvents lblplane As New Label
    Private WithEvents lblP As New Label
    Private WithEvents pname As New Label
    Private WithEvents pan As New Panel
    Private WithEvents quan As New Label

    Sub loadmemberdata()
        Try
            con.Open()
            notificationpanel.AutoScroll = True
            notificationpanel.Controls.Clear()
            Dim td As Date = Date.Today
            Dim listno As Integer = 0
            Dim gambar() As Byte
            cmd = New SqlCommand("select Profile,Name,expiredate, Plans, Phone from membersmst where expiredate < '" & td & "'  order by ID", con)
            drn = cmd.ExecuteReader
            While drn.Read
                gambar = drn.Item("Profile")
                pic = New Guna.UI2.WinForms.Guna2CirclePictureBox
                pic.Width = 43
                pic.Height = 43
                pic.Location = New Point(17, 22)
                pic.BackgroundImageLayout = ImageLayout.Stretch
                Dim ms As New MemoryStream(gambar)
                Dim img As Image = Image.FromStream(ms)
                pic.Image = resizeimage(img, 43, 43)

                pan = New Panel
                pan.Width = 920
                pan.Height = 95
                pan.BackColor = Color.FromArgb(15, 15, 15)
                pan.Margin = New Padding(5)

                pname = New Label
                pname.BackColor = Color.Transparent
                pname.Location = New Point(82, 28)
                pname.TextAlign = ContentAlignment.MiddleLeft

                lblplane = New Label
                lblplane.BackColor = Color.Transparent
                lblplane.TextAlign = ContentAlignment.MiddleRight
                lblplane.Location = New Point(298, 28)

                lblP = New Label
                lblP.BackColor = Color.Transparent
                lblP.TextAlign = ContentAlignment.MiddleRight
                lblP.Location = New Point(598, 28)

                quan = New Label
                quan.BackColor = Color.Transparent
                quan.ForeColor = Color.DarkGray
                quan.TextAlign = ContentAlignment.MiddleRight
                quan.Location = New Point(798, 28)

                pname.Text = drn.Item("Name").ToString
                lblP.Text = Format(CDate(drn.Item("expiredate")), "d").ToString
                quan.Text = drn.Item("Phone").ToString
                lblplane.Text = drn.Item("Plans").ToString
                pan.ForeColor = Color.DarkGray
                pan.Font = New Font("Microsoft YaHei", 10.12, FontStyle.Bold)
                pan.AutoSize = True

                pan.Controls.Add(pname)
                pan.Controls.Add(quan)
                pan.Controls.Add(lblplane)
                pan.Controls.Add(pic)
                pan.Controls.Add(lblP)
                notificationpanel.Controls.Add(pan)

            End While
            drn.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Sub loadtrainerdata()
        Try
            con.Open()
            notificationpanel.AutoScroll = True
            notificationpanel.Controls.Clear()
            Dim td As Date = Date.Today

            Dim listno As Integer = 0
            Dim gambar() As Byte

            cmd = New SqlCommand("select Profile,Name,Salary_date,Trainertype, Phone from Trainersmst where Salary_date < '" & td & "'  order by ID", con)

            drn = cmd.ExecuteReader
            While drn.Read

                gambar = drn.Item("Profile")
                pic = New Guna.UI2.WinForms.Guna2CirclePictureBox
                pic.Width = 43
                pic.Height = 43
                pic.Location = New Point(17, 22)
                pic.BackgroundImageLayout = ImageLayout.Stretch
                Dim ms As New MemoryStream(gambar)
                Dim img As Image = Image.FromStream(ms)
                pic.Image = resizeimage(img, 43, 43)

                pan = New Panel
                pan.Width = 920
                pan.Height = 95
                pan.BackColor = Color.FromArgb(15, 15, 15)
                pan.Margin = New Padding(5)

                pname = New Label
                pname.BackColor = Color.Transparent
                pname.Location = New Point(82, 28)
                pname.TextAlign = ContentAlignment.MiddleLeft

                lblplane = New Label
                lblplane.BackColor = Color.Transparent
                lblplane.TextAlign = ContentAlignment.MiddleRight
                lblplane.Location = New Point(298, 28)

                lblP = New Label
                lblP.BackColor = Color.Transparent
                lblP.TextAlign = ContentAlignment.MiddleRight
                lblP.Location = New Point(598, 28)

                quan = New Label
                quan.BackColor = Color.Transparent
                quan.ForeColor = Color.DarkGray
                quan.TextAlign = ContentAlignment.MiddleRight
                quan.Location = New Point(798, 28)

                pname.Text = drn.Item("Name").ToString
                lblP.Text = Format(CDate(drn.Item("Salary_date")), "d").ToString
                quan.Text = drn.Item("Phone").ToString
                lblplane.Text = drn.Item("Trainertype").ToString
                pan.ForeColor = Color.DarkGray
                pan.Font = New Font("Microsoft YaHei", 10.12, FontStyle.Bold)
                pan.AutoSize = True

                pan.Controls.Add(pname)
                pan.Controls.Add(quan)
                pan.Controls.Add(lblplane)
                pan.Controls.Add(pic)
                pan.Controls.Add(lblP)
                notificationpanel.Controls.Add(pan)

            End While
            drn.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Sub loadproductdata()
        Try
            con.Open()
            notificationpanel.AutoScroll = True
            notificationpanel.Controls.Clear()
            Dim td As Date = Date.Today

            Dim listno As Integer = 0
            Dim gambar() As Byte

            cmd = New SqlCommand("select p_image,p_name,supplier_name,productcategory,quantity,purchasedate,expiredate from stocksmst where expiredate < '" & td & "'", con)

            drn = cmd.ExecuteReader
            While drn.Read

                gambar = drn.Item("p_image")
                pic = New Guna.UI2.WinForms.Guna2CirclePictureBox
                pic.Width = 43
                pic.Height = 43
                pic.Location = New Point(17, 22)
                pic.BackgroundImageLayout = ImageLayout.Stretch
                Dim ms As New MemoryStream(gambar)
                Dim img As Image = Image.FromStream(ms)
                pic.Image = resizeimage(img, 43, 43)

                pan = New Panel
                pan.Width = 920
                pan.Height = 95
                pan.BackColor = Color.FromArgb(15, 15, 15)
                pan.Margin = New Padding(5)

                pname = New Label
                pname.BackColor = Color.Transparent
                pname.Location = New Point(82, 28)
                pname.TextAlign = ContentAlignment.MiddleLeft

                lblplane = New Label
                lblplane.BackColor = Color.Transparent
                lblplane.TextAlign = ContentAlignment.MiddleRight
                lblplane.Location = New Point(298, 28)

                lblP = New Label
                lblP.BackColor = Color.Transparent
                lblP.TextAlign = ContentAlignment.MiddleRight
                lblP.Location = New Point(598, 28)

                quan = New Label
                quan.BackColor = Color.Transparent
                quan.ForeColor = Color.DarkGray
                quan.TextAlign = ContentAlignment.MiddleRight
                quan.Location = New Point(798, 28)

                pname.Text = drn.Item("p_name").ToString
                lblP.Text = Format(CDate(drn.Item("expiredate")), "d").ToString
                quan.Text = drn.Item("supplier_name").ToString
                lblplane.Text = drn.Item("productcategory").ToString
                pan.ForeColor = Color.DarkGray
                pan.Font = New Font("Microsoft YaHei", 10.12, FontStyle.Bold)
                pan.AutoSize = True

                pan.Controls.Add(pname)
                pan.Controls.Add(quan)
                pan.Controls.Add(lblplane)
                pan.Controls.Add(pic)
                pan.Controls.Add(lblP)
                notificationpanel.Controls.Add(pan)

            End While
            drn.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Function resizeimage(ByVal img As Image, ByVal w As Integer, ByVal h As Integer) As Image
        Try
            Dim newImagesize As New Bitmap(w, h)
            Using g As Graphics = Graphics.FromImage(newImagesize)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(img, New Rectangle(0, 0, w, h))
            End Using
            Return newImagesize
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
        Return Nothing
    End Function

    Private Sub notificationfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnmembernoti.PerformClick()
    End Sub

    Private Sub btnmembernoti_Click(sender As Object, e As EventArgs) Handles btnmembernoti.Click
        loadmemberdata()
    End Sub

    Private Sub btntrainernoti_Click(sender As Object, e As EventArgs) Handles btntrainernoti.Click
        loadtrainerdata()
    End Sub

    Private Sub btnproductsnoti_Click(sender As Object, e As EventArgs) Handles btnproductsnoti.Click
        loadproductdata()
    End Sub
End Class

