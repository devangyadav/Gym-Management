Imports System.Data.SqlClient
Imports System.IO
Public Class exmembersfrm

    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim cmder As SqlCommand
    Dim dt As New DataTable
    Dim dter As New DataTable
    Dim da As SqlDataAdapter
    Dim daer As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim drer As SqlDataReader

    Private WithEvents pic As New PictureBox
    Private WithEvents memberno As New Label
    Private WithEvents membername As New Label
    Private WithEvents pan As New Panel



    Private Sub exmembersfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mainfrm.btnsearch.Clear()
        loaddata()
        AddHandler Mainfrm.btnsearch.TextChanged, AddressOf btnsearch_TextChanged
    End Sub

    Public Sub btnsearch_TextChanged(sender As Object, e As EventArgs)
        loaddata()
    End Sub
    Sub loaddata()
        Try
            con.Open()
            exmemberpanel.AutoScroll = True
            exmemberpanel.Controls.Clear()
            Dim stat As String = "Inactive"

            cmd = New SqlCommand("SELECT Profile,Name,ID FROM membersmst  with (nolock)  WHERE Name LIKE '%" & Mainfrm.btnsearch.Text & "%' and  Status='" & stat & "' order by ID", con)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
                Dim array(CInt(len)) As Byte
                dr.GetBytes(0, 0, array, 0, CInt(len))

                pic = New PictureBox
                pic.Width = 157
                pic.Height = 160
                pic.BackgroundImageLayout = ImageLayout.Stretch
                pic.Tag = dr.Item("ID").ToString

                pan = New Panel
                pan.Width = 157
                pan.Height = 185
                pan.BorderStyle = BorderStyle.FixedSingle

                membername = New Label
                membername.BackColor = Color.Purple
                membername.ForeColor = Color.WhiteSmoke
                membername.TextAlign = ContentAlignment.MiddleCenter
                membername.Dock = DockStyle.Bottom

                memberno = New Label
                memberno.BackColor = Color.Purple
                memberno.ForeColor = Color.WhiteSmoke
                memberno.TextAlign = ContentAlignment.MiddleLeft
                memberno.Size = New Size(35, 0)
                memberno.Dock = DockStyle.Left

                Dim ms As New System.IO.MemoryStream(array)
                Dim bitmap As New System.Drawing.Bitmap(ms)
                pic.BackgroundImage = bitmap

                memberno.Text = dr.Item("ID").ToString
                membername.Text = dr.Item("Name").ToString

                pan.Controls.Add(pic)
                membername.Controls.Add(memberno)
                pan.Controls.Add(membername)
                exmemberpanel.Controls.Add(pan)

                AddHandler pic.Click, AddressOf pic_click

            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub pic_click(sender As Object, e As EventArgs)


        Try
            con.Open()
            cmd = New SqlCommand("select * FROM membersmst where ID like '" & sender.tag.ToString & "'", con)
            dr = cmd.ExecuteReader
            Dim gambar() As Byte
            While dr.Read
                gambar = dr.Item("Profile")
                Dim ms As New MemoryStream(gambar)
                AddProfile.Displayprofile.Image = Image.FromStream(ms)
                AddProfile.Displayprofile.Size = New Size(181, 184)
                AddProfile.Displayprofile.SizeMode = PictureBoxSizeMode.StretchImage
                AddProfile.txtuserid.Text = dr.Item("ID")
                AddProfile.txtfullname.Text = dr.Item("Name")
                AddProfile.txtjoindate.Text = dr.Item("Joindate")
                AddProfile.txtbirthdate.Text = dr.Item("Birthdate")
                AddProfile.txtmemberage.Text = dr.Item("Age")
                AddProfile.txtcurrentweight.Text = dr.Item("CurrentWeight")
                AddProfile.txtheight.Text = dr.Item("Height")
                AddProfile.txtmemberphone.Text = dr.Item("Phone")
                AddProfile.txtmemberemail.Text = dr.Item("Email")
                AddProfile.txtmemberplan.Text = dr.Item("Plans")
                AddProfile.txtmonths.Text = dr.Item("Months")
                AddProfile.txtmemberaddress.Text = dr.Item("Address")
                AddProfile.txttotalfees.Text = dr.Item("Totalfees")
                If dr.Item("Gender") = "Male" Then
                    AddProfile.btnmale.Checked = True
                ElseIf dr.Item("Gender") = "Female" Then
                    AddProfile.btnfemale.Checked = True
                End If
                AddProfile.btnrestore.Visible = True
                AddProfile.btnmemberenter.Visible = False
                AddProfile.btnmemberclear.Visible = False
                AddProfile.btnupdate.Visible = True
                AddProfile.btnback.Visible = True
                Mainfrm.openchildform(AddProfile)
                Mainfrm.menubarclicktxt.Text = "Update Member Profile"
            End While
            dr.Close()
            con.Close()

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class