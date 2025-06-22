Public Class Datafilefrm

    Declare Function setprocessworkingsetsize Lib "kernel32.dil" (ByVal process As IntPtr, ByVal minimumworkingsetsize As Integer, ByVal maximumworkingsetsize As Integer) As Integer


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

    Private Sub Datafilefrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mainfrm.btnsearch.Text = ""

        flushmemory()
    End Sub

    Private Sub allmemberfile_Click(sender As Object, e As EventArgs) Handles allmemberfile.Click
        Mainfrm.menubarclicktxt.Text = "All Members List"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New Allmembersfrm)
        flushmemory()
    End Sub

    Private Sub cardiomemberfile_Click(sender As Object, e As EventArgs) Handles cardiomemberfile.Click
        Mainfrm.menubarclicktxt.Text = "Cardio Members List"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New cardiomemberfrm)
        flushmemory()
    End Sub

    Private Sub bothcsmemberfile_Click(sender As Object, e As EventArgs) Handles bothcsmemberfile.Click
        Mainfrm.menubarclicktxt.Text = "Cardio and Strength Members List"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New cardioandstrengthfrm)
        flushmemory()
    End Sub

    Private Sub strngthmemberfile_Click(sender As Object, e As EventArgs) Handles strngthmemberfile.Click
        Mainfrm.menubarclicktxt.Text = "Strength Members List"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New strengthfrm)
        flushmemory()
    End Sub

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs) Handles personalmemberfile.Click
        Mainfrm.menubarclicktxt.Text = "Personal Members List"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New personalfrm)
        flushmemory()
    End Sub

    Private Sub exmemberfile_Click(sender As Object, e As EventArgs) Handles exmemberfile.Click
        Mainfrm.menubarclicktxt.Text = "EX Members List"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New exmembersfrm)
        flushmemory()
    End Sub

    Private Sub memberfeesfile_Click(sender As Object, e As EventArgs) Handles memberfeesfile.Click
        Mainfrm.menubarclicktxt.Text = "Members Fees"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New Memberfeesfrm)
        flushmemory()
    End Sub

    Private Sub txttrainersalary_Click(sender As Object, e As EventArgs) Handles txttrainersalary.Click
        Mainfrm.menubarclicktxt.Text = "Trainer Salary"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New trainersalaryfrm)
        flushmemory()
    End Sub

    Private Sub txtstocks_Click(sender As Object, e As EventArgs) Handles txtstocks.Click
        Mainfrm.menubarclicktxt.Text = "Stock Limit Products List"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New stockfrm)
        flushmemory()
    End Sub

    Private Sub txtsoldproduct_Click(sender As Object, e As EventArgs) Handles txtsoldproduct.Click
        Mainfrm.menubarclicktxt.Text = "Sold Products List"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New soldproductfrm)
        flushmemory()
    End Sub

    Private Sub txtexpireproduct_Click(sender As Object, e As EventArgs) Handles txtexpireproduct.Click
        Mainfrm.menubarclicktxt.Text = "Expire Products List"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New expireproductfrm)
        flushmemory()
    End Sub

    Private Sub txtbuyerdetail_Click(sender As Object, e As EventArgs) Handles txtbuyerdetail.Click
        Mainfrm.menubarclicktxt.Text = "Customer List"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New buyerfrm)
        flushmemory()
    End Sub

    Private Sub btnpurchase_Click(sender As Object, e As EventArgs) Handles btnpurchase.Click
        Mainfrm.menubarclicktxt.Text = "Purchase List"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New purchasefrm)
        flushmemory()
    End Sub

    Private Sub alltrainerfile_Click(sender As Object, e As EventArgs) Handles alltrainerfile.Click
        Mainfrm.menubarclicktxt.Text = "All Trainer List"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New alltrainerfrm)
        flushmemory()
    End Sub

    Private Sub cardiotrainerfile_Click(sender As Object, e As EventArgs) Handles cardiotrainerfile.Click
        Mainfrm.menubarclicktxt.Text = "Cardio Trainer List"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New cardiotrainerfrm)
        flushmemory()
    End Sub

    Private Sub strengthtrainerfile_Click(sender As Object, e As EventArgs) Handles strengthtrainerfile.Click
        Mainfrm.menubarclicktxt.Text = "Strength Trainer List"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New strengthtrainerfrm)
        flushmemory()
    End Sub

    Private Sub cardiostrengthtrainer_Click(sender As Object, e As EventArgs) Handles cardiostrengthtrainer.Click
        Mainfrm.menubarclicktxt.Text = "Cardio And Strength Trainer List"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New cardiostrengthtrainerfrm)
        flushmemory()
    End Sub

    Private Sub personaltrainerfile_Click(sender As Object, e As EventArgs) Handles personaltrainerfile.Click
        Mainfrm.menubarclicktxt.Text = "Personal Trainer List"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New personaltrainerfrm)
        flushmemory()
    End Sub

    Private Sub extrainerfile_Click(sender As Object, e As EventArgs) Handles extrainerfile.Click
        Mainfrm.menubarclicktxt.Text = "EX Trainer List"
        Mainfrm.btnsearch.ReadOnly = False
        Mainfrm.openchildform(New extrainerfrm)
        flushmemory()
    End Sub
End Class