Imports System.Data.SqlClient
Imports System.IO
    Public Class alltrainerfrm

        Declare Function setprocessworkingsetsize Lib "kernel32.dil" (ByVal process As IntPtr, ByVal minimumworkingsetsize As Integer, ByVal maximumworkingsetsize As Integer) As Integer

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


    Private Sub alltrainerfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mainfrm.btnsearch.Text = ""
        loaddata()
        AddHandler Mainfrm.btnsearch.TextChanged, AddressOf btnsearch_TextChanged
    End Sub

    Public Sub btnsearch_TextChanged(sender As Object, e As EventArgs)
            loaddata()
        End Sub

        Public Sub flushmemory()
            Try
                GC.Collect()
                GC.WaitForPendingFinalizers()
                If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                    setprocessworkingsetsize(Process.GetCurrentProcess().Handle, -1, -1)
                    Dim myprocesses As Process() = Process.GetProcessesByName("ApplicationName")
                    Dim myprocess As Process

                    For Each myprocess In myprocesses
                        setprocessworkingsetsize(myprocess.Handle, -1, -1)

                    Next myprocess
                End If
            Catch ex As Exception
            End Try
        End Sub

        Sub loaddata()

            Try
                con.Open()
                listpanel.AutoScroll = True
                listpanel.Controls.Clear()
                Dim stat As String = "Active"

            cmd = New SqlCommand("SELECT Profile,Name,ID FROM Trainersmst with (nolock)  WHERE Name LIKE '%" & Mainfrm.btnsearch.Text & "%' and  Trainer_status='" & stat & "' order by ID", con)
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
                    listpanel.Controls.Add(pan)

                    AddHandler pic.Click, AddressOf pic_click
                    flushmemory()
                End While
                dr.Close()
                cmd.Dispose()
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
                cmd = New SqlCommand("select * FROM Trainersmst where ID like '" & sender.tag.ToString & "'", con)
                dr = cmd.ExecuteReader
            Dim gambar() As Byte

            Dim mal As String = "Male"
                Dim femal As String = "Female"
                While dr.Read
                    gambar = dr.Item("Profile")
                    Dim ms As New MemoryStream(gambar)
                    AddProfile.txtcategory.Text = "Trainer"
                AddProfile.txtcategory.Visible = False
                AddProfile.btnrestore.Visible = False
                AddProfile.lblcategory.Visible = False
                    AddProfile.subexpanel.Visible = True
                    AddProfile.lblsubexpire.Visible = False
                    AddProfile.btnremoveuser.Visible = True
                    AddProfile.lblsalarydate.Visible = True
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
                    AddProfile.txttrainertype.Text = dr.Item("Trainertype")
                    AddProfile.txtmemberaddress.Text = dr.Item("Address")
                    AddProfile.txtsubexdate.Text = dr.Item("Salary_date")
                    AddProfile.txtsalary.Text = dr.Item("Salary")
                    If mal = dr.Item("Gender") Then
                        AddProfile.btnmale.Checked = True
                    ElseIf femal = dr.Item("Gender") Then
                        AddProfile.btnfemale.Checked = True
                    End If


                AddProfile.btnmemberenter.Visible = False
                    AddProfile.btnmemberclear.Visible = False
                    AddProfile.btnupdate.Visible = True
                    AddProfile.btnback.Visible = True
                Mainfrm.openchildform(AddProfile)
                Mainfrm.menubarclicktxt.Text = "Update Trainer Profile"
                    flushmemory()
                End While
                dr.Close()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            Finally
                con.Close()
            End Try
        End Sub
    End Class