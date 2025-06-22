Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic.Devices
Public Class Mainfrm

    Declare Function setprocessworkingsetsize Lib "kernel32.dil" (ByVal process As IntPtr, ByVal minimumworkingsetsize As Integer, ByVal maximumworkingsetsize As Integer) As Integer

    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim cmd As SqlCommand
    Dim drn As SqlDataReader

    Private currentform As Form = Nothing

    Public Sub openchildform(childform As Form)
        If currentform IsNot Nothing Then
            currentform.Close()
        End If
        currentform = childform
        currentform.TopLevel = False
        currentform.Dock = DockStyle.Fill
        currentform.FormBorderStyle = FormBorderStyle.None
        mainpanel.Controls.Add(childform)
        mainpanel.Tag = childform
        childform.BringToFront()
        childform.Show()
    End Sub



    Public Sub getAvailableRAM()
        Dim CI As New ComputerInfo()
        Dim avl, used As String
        Dim mem As ULong = ULong.Parse(CI.AvailablePhysicalMemory.ToString())
        Dim mem1 As ULong = ULong.Parse(CI.TotalPhysicalMemory.ToString()) - ULong.Parse(CI.AvailablePhysicalMemory.ToString())
        avl = (mem / (1024 * 1024) & " MB").ToString() 'changed + to &
        used = (mem1 / (1024 * 1024) & " MB").ToString() 'changed + to &
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

    Private Sub btnnotificationbell_Click(sender As Object, e As EventArgs) Handles btnnotificationbell.Click
        menubarclicktxt.Text = "Notifications"
        openchildform(New notificationfrm)
    End Sub

    Private Sub btndasgboard_Click(sender As Object, e As EventArgs) Handles btndasgboard.Click
        menubarclicktxt.Text = "DashBoard"
        btnsearch.ReadOnly = True
        openchildform(New Dashboardfrm)

    End Sub

    Private Sub btnmembership_Click(sender As Object, e As EventArgs) Handles btnmembership.Click
        openchildform(New AddProfile)
    End Sub

    Private Sub btnproducts_Click(sender As Object, e As EventArgs) Handles btnproducts.Click
        menubarclicktxt.Text = "Products"
        btnsearch.ReadOnly = False
        openchildform(New Productsfrm)

    End Sub


    Private Sub btndatafile_Click(sender As Object, e As EventArgs) Handles btndatafile.Click
        menubarclicktxt.Text = "All Data File"
        btnsearch.ReadOnly = True
        openchildform(New Datafilefrm)
    End Sub

    Private Sub btnmaintenance_Click(sender As Object, e As EventArgs) Handles btnmaintenance.Click
        menubarclicktxt.Text = "Maintenance"
        btnsearch.ReadOnly = True
        openchildform(New Maintenancefrm)
    End Sub

    Private Sub btnsettings_Click(sender As Object, e As EventArgs) Handles btnsettings.Click
        menubarclicktxt.Text = "Settings"
        btnsearch.ReadOnly = True
        openchildform(New Settingsfrm)
    End Sub

    Private Sub mainpageprofile_Click(sender As Object, e As EventArgs)
        menubarclicktxt.Text = "Settings"
        btnsearch.ReadOnly = True
        openchildform(New Settingsfrm)
    End Sub

    Private Sub btnmaincancel_Click(sender As Object, e As EventArgs) Handles btnmaincancel.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Application.ExitThread()
            GC.SuppressFinalize(Me)
            GC.Collect()
            Finalize()
        End If
    End Sub

    Private Sub btnminimax_Click(sender As Object, e As EventArgs) Handles btnminimax.Click
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        If Me.WindowState = WindowState.Normal Then
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
            Me.WindowState = WindowState.Maximized
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        ElseIf Me.WindowState = WindowState.Maximized Then
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
            Me.WindowState = WindowState.Normal
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        End If
    End Sub

    Private Sub btntaskbar_Click(sender As Object, e As EventArgs) Handles btntaskbar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Mainfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        flushmemory()

        btndasgboard.PerformClick()
        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
        Dim imagecmd As SqlCommand
        Dim rd As SqlDataReader
        Dim gambar() As Byte
        Dim no As Integer = 1

        imagecmd = New SqlCommand("select profile from settingsmst  WHERE id=" & no & "", con)
        con.Open()
        rd = imagecmd.ExecuteReader
        rd.Read()
        Try
            If rd.HasRows() Then
                gambar = rd("profile")

                Dim ms As New MemoryStream(gambar)
                mainpageprofile.Image = Image.FromStream(ms)
                mainpageprofile.SizeMode = PictureBoxSizeMode.StretchImage
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Dispose()
        login.Show()
    End Sub


    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    ' Left mouse button pressed
    Private Sub Topbar_MouseDown(sender As Object, e As MouseEventArgs) Handles topbar.MouseDown, mmcpanel.MouseDown, btnlogo.MouseDown, menubarclicktxt.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    ' MouseMove used to check if mouse cursor is moving
    Private Sub Topbar_MouseMove(sender As Object, e As MouseEventArgs) Handles topbar.MouseMove, mmcpanel.MouseMove, btnlogo.MouseMove, menubarclicktxt.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    ' Left mouse button released, form should stop moving
    Private Sub Topbar_MouseUp(sender As Object, e As MouseEventArgs) Handles topbar.MouseUp, mmcpanel.MouseUp, btnlogo.MouseUp, menubarclicktxt.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

End Class