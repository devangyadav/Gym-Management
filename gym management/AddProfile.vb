Imports System.Data.SqlClient
Imports System.IO
Public Class AddProfile

    Declare Function setprocessworkingsetsize Lib "kernel32.dil" (ByVal process As IntPtr, ByVal minimumworkingsetsize As Integer, ByVal maximumworkingsetsize As Integer) As Integer

    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim cmd2 As SqlCommand
    Dim cmd3 As SqlCommand
    Dim cmd4 As SqlCommand
    Dim dt As New DataTable
    Dim fid As Integer

    Dim gender As String

    Dim memberstatus As String = "Active"

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

    Private Sub Membersfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As Date = Today
        txtjoindate.Text = dt.ToString("yyyy-MM-dd")
        txtbirthdate.MaxDate = Date.Today.AddYears(-18)
        txtbirthdate.MinDate = txtbirthdate.MaxDate.AddYears(-50)
    End Sub

    Private Sub btnaddprofile_Click(sender As Object, e As EventArgs) Handles btnaddprofile.Click
        openimage.Title = "Select Images"
        openimage.InitialDirectory = "D:\"
        openimage.Filter = "Images (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG"
        openimage.RestoreDirectory = True
        openimage.FileName = ""
        openimage.Multiselect = False
        If openimage.ShowDialog = Windows.Forms.DialogResult.OK Then
            Displayprofile.Image = Image.FromFile(openimage.FileName)
            Displayprofile.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub


    Private Sub txtmonths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtmonths.SelectedIndexChanged
        If txtmemberplan.SelectedItem = "Cardio" Then
            Dim cmd1 = New SqlCommand("select cardio from gymplansmst where months='" & txtmonths.SelectedItem & "'", con)

            da = New SqlDataAdapter(cmd1)

            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <= 0 Then
                MessageBox.Show("no data found")
            Else
                txttotalfees.Text = dt.Rows(0)(0)
            End If
        ElseIf txtmemberplan.SelectedItem = "Strength" Then
            Dim cmd1 = New SqlCommand("select strength from gymplansmst where months='" & txtmonths.SelectedItem & "'", con)

            da = New SqlDataAdapter(cmd1)

            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <= 0 Then
                MessageBox.Show("no data found")
            Else
                txttotalfees.Text = dt.Rows(0)(0)
            End If
        ElseIf txtmemberplan.SelectedItem = "Cardio and Strength" Then
            Dim cmd1 = New SqlCommand("select cardioandstrength from gymplansmst where months='" & txtmonths.SelectedItem & "'", con)

            da = New SqlDataAdapter(cmd1)

            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <= 0 Then
                MessageBox.Show("no data found")
            Else
                txttotalfees.Text = dt.Rows(0)(0)
            End If
        ElseIf txtmemberplan.SelectedItem = "Personal" Then
            Dim cmd1 = New SqlCommand("select personal from gymplansmst where months='" & txtmonths.SelectedItem & "'", con)

            da = New SqlDataAdapter(cmd1)

            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <= 0 Then
                MessageBox.Show("no data found")
            Else
                txttotalfees.Text = dt.Rows(0)(0)
            End If
        End If
    End Sub
    Private Sub txtmemberplan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtmemberplan.SelectedIndexChanged
        If txtmemberplan.SelectedItem = "Cardio" Then
            Dim cmd1 = New SqlCommand("select cardio from gymplansmst where months='" & txtmonths.SelectedItem & "'", con)

            da = New SqlDataAdapter(cmd1)

            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <= 0 Then
                MessageBox.Show("no data found")
            Else
                txttotalfees.Text = dt.Rows(0)(0)
            End If
        ElseIf txtmemberplan.SelectedItem = "Strength" Then
            Dim cmd1 = New SqlCommand("select strength from gymplansmst where months='" & txtmonths.SelectedItem & "'", con)

            da = New SqlDataAdapter(cmd1)

            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <= 0 Then
                MessageBox.Show("no data found")
            Else
                txttotalfees.Text = dt.Rows(0)(0)
            End If
        ElseIf txtmemberplan.SelectedItem = "Cardio and Strength" Then
            Dim cmd1 = New SqlCommand("select cardioandstrength from gymplansmst where months='" & txtmonths.SelectedItem & "'", con)

            da = New SqlDataAdapter(cmd1)

            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <= 0 Then
                MessageBox.Show("no data found")
            Else
                txttotalfees.Text = dt.Rows(0)(0)
            End If
        ElseIf txtmemberplan.SelectedItem = "Personal" Then
            Dim cmd1 = New SqlCommand("select personal from gymplansmst where months='" & txtmonths.SelectedItem & "'", con)

            da = New SqlDataAdapter(cmd1)

            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count <= 0 Then
                MessageBox.Show("no data found")
            Else
                txttotalfees.Text = dt.Rows(0)(0)
            End If
        End If
    End Sub

    Private Sub btnmale_CheckedChanged(sender As Object, e As EventArgs) Handles btnmale.CheckedChanged
        gender = "Male"
    End Sub
    Private Sub btnfemale_CheckedChanged(sender As Object, e As EventArgs) Handles btnfemale.CheckedChanged
        gender = "Female"
    End Sub
    Private Sub btnmemberenter_Click(sender As Object, e As EventArgs) Handles btnmemberenter.Click

        If txtcategory.SelectedItem = "Member" Then
            Try

                If (txtfullname.Text = "" Or txtmemberage.Text = "" Or txtcurrentweight.Text = "" Or txtheight.Text = "" Or txtmemberphone.Text = "" Or txtmemberemail.Text = "" Or txtmemberplan.Text = "" Or txtmonths.Text = "" Or txtmemberaddress.Text = "" Or txttotalfees.Text = "") Or (btnmale.Checked = False And btnfemale.Checked = False) Then
                    MsgBox("Please Enter All Values", MsgBoxStyle.Critical)
                Else

                    Dim expirydate As Date

                    If txtmonths.SelectedItem = "01 Month" Then
                        expirydate = Date.Now.AddMonths(1)

                    ElseIf txtmonths.SelectedItem = "03 Months" Then
                        expirydate = Date.Now.AddMonths(3)
                    ElseIf txtmonths.SelectedItem = "06 Months" Then
                        expirydate = Date.Now.AddMonths(6)
                    ElseIf txtmonths.SelectedItem = "09 Months" Then
                        expirydate = Date.Now.AddMonths(9)
                    ElseIf txtmonths.SelectedItem = "12 Months" Then
                        expirydate = Date.Now.AddMonths(12)
                    End If

                    cmd = New SqlCommand("INSERT INTO membersmst
           (Profile
           ,Name
           ,Joindate
           ,expiredate
           ,Birthdate
           ,Age
           ,Gender
           ,CurrentWeight
           ,Height
           ,Phone
           ,Email
           ,Plans
           ,Months
           ,Address
           ,Status
           ,Totalfees)
     VALUES
           (@profile,'" & txtfullname.Text & "','" & txtjoindate.Text & "','" & expirydate & "','" & txtbirthdate.Value & "'," & txtmemberage.Text & ",'" & gender & "'," & txtcurrentweight.Text & "," & txtheight.Text & "," & txtmemberphone.Text & ",'" & txtmemberemail.Text & "','" & txtmemberplan.Text & "','" & txtmonths.Text & "','" & txtmemberaddress.Text & "','" & memberstatus & "'," & txttotalfees.Text & ")", con)

                    Dim ms As New MemoryStream
                    Dim bmpimage As New Bitmap(Displayprofile.Image)
                    bmpimage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim data As Byte() = ms.GetBuffer

                    Dim p As New SqlParameter("@profile", SqlDbType.Image)
                    p.Value = data
                    cmd.Parameters.Add(p)

                    con.Open()
                    If cmd.ExecuteNonQuery Then
                    Else
                        MsgBox("Fail")
                    End If
                    con.Close()

                    Dim newmstatus As String = "paid"

                    cmd2 = New SqlCommand("select ID from membersmst where Name='" & txtfullname.Text & "' And Age=" & txtmemberage.Text & " ", con)

                    da = New SqlDataAdapter(cmd2)

                    dt = New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count <= 0 Then
                        MessageBox.Show("no data found")
                    Else
                        fid = dt.Rows(0)(0)


                        cmd3 = New SqlCommand("INSERT INTO memberfeesreportmst (id,m_name,pay_date,expiry_date,plans,months,fees)VALUES ('" & fid & "','" & txtfullname.Text & "','" & txtjoindate.Text & "','" & expirydate & "','" & txtmemberplan.Text & "','" & txtmonths.Text & "'," & txttotalfees.Text & ")", con)

                        con.Open()
                        If cmd3.ExecuteNonQuery Then
                            MsgBox("Insert Successfully")
                        Else
                            MsgBox("Fail")
                        End If
                        con.Close()

                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        ElseIf txtcategory.SelectedItem = "Trainer" Then
            Try
                If (txtfullname.Text = "" Or txtmemberage.Text = "" Or gender = "" Or txtcurrentweight.Text = "" Or txtheight.Text = "" Or txtmemberphone.Text = "" Or txtmemberemail.Text = "" Or txtmemberaddress.Text = "" Or txtsalary.Text = "") Or (btnmale.Checked = False And btnfemale.Checked = False) Then
                    MsgBox("Please Enter All Values", MsgBoxStyle.Critical)
                Else


                    Dim expirydate As Date = Date.Now.AddMonths(1)

                    cmd = New SqlCommand("INSERT INTO trainersmst
           (Profile
           ,Name
           ,Joindate
           ,Birthdate
           ,Age
           ,Gender
           ,CurrentWeight
           ,Height
           ,Phone
           ,Email
           ,Address
           ,Trainertype
           ,Trainer_status
           ,Salary
           ,Salary_date)
     VALUES
          
           (@profile,'" & txtfullname.Text & "','" & txtjoindate.Text & "','" & txtbirthdate.Value & "'," & txtmemberage.Text & ",'" & gender & "'," & txtcurrentweight.Text & "," & txtheight.Text & "," & txtmemberphone.Text & ",'" & txtmemberemail.Text & "','" & txtmemberaddress.Text & "','" & txttrainertype.Text & "','" & memberstatus & "'," & txtsalary.Text & ",'" & expirydate & "')", con)


                    Dim ms As New MemoryStream
                    Dim bmpimage As New Bitmap(Displayprofile.Image)
                    bmpimage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim data As Byte() = ms.GetBuffer

                    Dim p As New SqlParameter("@profile", SqlDbType.Image)
                    p.Value = data
                    cmd.Parameters.Add(p)


                    con.Open()
                    If cmd.ExecuteNonQuery Then
                        MsgBox("Insert Successfully ")
                    Else
                        MsgBox("Fail")
                    End If
                    con.Close()


                    Dim newmstatus As String = "paid"


                    cmd2 = New SqlCommand("select ID from trainersmst where Name='" & txtfullname.Text & "' And Age=" & txtmemberage.Text & " ", con)

                    da = New SqlDataAdapter(cmd2)

                    dt = New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count <= 0 Then
                        MessageBox.Show("no data found")
                    Else
                        fid = dt.Rows(0)(0)
                        cmd3 = New SqlCommand("INSERT INTO trainersalaryreport (id,name,trainertype,date,enddate,salary)VALUES ('" & fid & "','" & txtfullname.Text & "','" & txttrainertype.Text & "','" & txtjoindate.Text & "','" & expirydate & "'," & txtsalary.Text & ")", con)
                        con.Open()
                        If cmd3.ExecuteNonQuery Then
                            MsgBox("Insert Successfully 1")
                        Else
                            MsgBox("Fail")
                        End If
                        con.Close()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnmemberclear_Click(sender As Object, e As EventArgs) Handles btnmemberclear.Click
        Mainfrm.openchildform(New AddProfile)
    End Sub

    Private Sub txtfullname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfullname.KeyPress
        Dim allowchar As String = "abcdefghijklmnopqrstuvwxyz"
        If Not allowchar.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtmemberage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmemberage.KeyPress
        Dim allownos As String = "0123456789"
        If Not allownos.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtmemberphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmemberphone.KeyPress
        Dim allownos As String = "0123456789"
        If Not allownos.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtmemberemail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmemberemail.KeyPress
        Dim allowchar As String = "abcdefghijklmnopqrstuvwxyz"
        Dim allownos As String = "0123456789"
        Dim allowsymbols As String = "@."

        If Not allownos.Contains(e.KeyChar.ToString) And Not allowchar.Contains(e.KeyChar.ToString) And Not allowsymbols.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If

    End Sub


    Private Sub txtcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcategory.SelectedIndexChanged
        If txtcategory.SelectedItem = "Trainer" Then
            Mainfrm.menubarclicktxt.Text = "Add Trainer"
            memberpanel.Visible = False
            trainerpanel.Location = New Point(476, 406)
            trainerpanel.Visible = True
        ElseIf txtcategory.SelectedItem = "Member" Then
            Mainfrm.menubarclicktxt.Text = "Add Member"
            trainerpanel.Visible = False
            memberpanel.Visible = True
        End If
    End Sub

    Private Sub txtbirthdate_ValueChanged(sender As Object, e As EventArgs) Handles txtbirthdate.ValueChanged
        Dim today, dob As Integer
        today = Date.Today.Year
        dob = txtbirthdate.Value.Year
        txtmemberage.Text = today - dob
    End Sub

    Private Sub txtcurrentweight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcurrentweight.KeyPress
        Dim allownos As String = "0123456789"
        Dim allowsymbols As String = "."

        If Not allownos.Contains(e.KeyChar.ToString) And Not allowsymbols.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtheight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtheight.KeyPress
        Dim allownos As String = "0123456789"
        Dim allowsymbols As String = "."
        If Not allownos.Contains(e.KeyChar.ToString) And Not allowsymbols.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtsalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsalary.KeyPress
        Dim allownos As String = "0123456789"
        Dim allowsymbols As String = "."
        If Not allownos.Contains(e.KeyChar.ToString) And Not allowsymbols.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnremoveuser_Click(sender As Object, e As EventArgs) Handles btnremoveuser.Click
        memberstatus = "Inactive"
        If txtcategory.Text = "Member" Then
            cmd = New SqlCommand("Update membersmst set Status ='" & memberstatus & "' where ID ='" & txtuserid.Text & "'", con)
        ElseIf txtcategory.Text = "Trainer" Then
            cmd = New SqlCommand("Update Trainersmst set Trainer_status ='" & memberstatus & "' where ID ='" & txtuserid.Text & "'", con)
        End If
        con.Open()
        If cmd.ExecuteNonQuery Then
            MsgBox("Removed Successfully ")
        Else
            MsgBox("Fail")
        End If
        con.Close()
        Mainfrm.openchildform(New Datafilefrm)
    End Sub
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtcategory.SelectedItem = "Member" Then
            Try
                If (txtfullname.Text = Nothing Or txtmemberage.Text = Nothing Or txtcurrentweight.Text = Nothing Or txtheight.Text = Nothing Or txtmemberphone.Text = Nothing Or txtmemberemail.Text = Nothing Or txtmemberplan.Text = Nothing Or txtmonths.Text = Nothing Or txtmemberaddress.Text = Nothing Or txttotalfees.Text = Nothing) Or (btnmale.Checked = False And btnfemale.Checked = False) Then
                    MsgBox("Please Enter All Values", MsgBoxStyle.Critical)
                Else
                    cmd = New SqlCommand("Update membersmst set Profile=@profile,Name='" & txtfullname.Text & "',Joindate='" & txtjoindate.Text & "',Birthdate='" & txtbirthdate.Value & "',Age=" & txtmemberage.Text & ",Gender='" & gender & "',CurrentWeight=" & txtcurrentweight.Text & ",Height=" & txtheight.Text & ",Phone=" & txtmemberphone.Text & ",Email='" & txtmemberemail.Text & "',Plans='" & txtmemberplan.Text & "',Months='" & txtmonths.Text & "',Address='" & txtmemberaddress.Text & "',Totalfees=" & txttotalfees.Text & " where ID ='" & txtuserid.Text & "'", con)
                    Dim ms As New MemoryStream
                    Dim bmpimage As New Bitmap(Displayprofile.Image)
                    bmpimage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim data As Byte() = ms.GetBuffer
                    Dim p As New SqlParameter("@profile", SqlDbType.Image)
                    p.Value = data
                    cmd.Parameters.Add(p)
                    con.Open()
                    If cmd.ExecuteNonQuery Then
                        MsgBox("Update Successfully ")
                    Else
                        MsgBox("Fail")
                    End If
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        ElseIf txtcategory.SelectedItem = "Trainer" Then
            Try
                If (txtfullname.Text = Nothing Or txtmemberage.Text = Nothing Or gender = Nothing Or txtcurrentweight.Text = Nothing Or txtheight.Text = Nothing Or txtmemberphone.Text = Nothing Or txtmemberemail.Text = Nothing Or txtmemberaddress.Text = Nothing Or txtsalary.Text = Nothing) Or (btnmale.Checked = False And btnfemale.Checked = False) Then
                    MsgBox("Please Enter All Values", MsgBoxStyle.Critical)
                Else
                    Dim expirydate As Date = Date.Now.AddMonths(1)
                    cmd = New SqlCommand("Update trainersmst set Profile=@profile,Name='" & txtfullname.Text & "',Joindate='" & txtjoindate.Text & "',Birthdate='" & txtbirthdate.Value & "',Age=" & txtmemberage.Text & ",Gender='" & gender & "',CurrentWeight=" & txtcurrentweight.Text & ",Height=" & txtheight.Text & ",Phone=" & txtmemberphone.Text & ",Email='" & txtmemberemail.Text & "',Address='" & txtmemberaddress.Text & "',Trainertype='" & txttrainertype.SelectedItem & "',Salary=" & txtsalary.Text & "  where ID ='" & txtuserid.Text & "'", con)
                    Dim ms As New MemoryStream
                    Dim bmpimage As New Bitmap(Displayprofile.Image)
                    bmpimage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim data As Byte() = ms.GetBuffer

                    Dim p As New SqlParameter("@profile", SqlDbType.Image)
                    p.Value = data
                    cmd.Parameters.Add(p)
                    con.Open()
                    If cmd.ExecuteNonQuery Then
                        MsgBox("Update Successfully ")
                    Else
                        MsgBox("Fail")
                    End If
                    con.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        If txtcategory.Text = "Member" Then
            Mainfrm.openchildform(New Allmembersfrm)
        ElseIf txtcategory.Text = "Trainer" Then
            Mainfrm.openchildform(New Datafilefrm)
        End If
    End Sub

    Private Sub txtmemberaddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmemberaddress.KeyPress
        Dim allowchar As String = "abcdefghijklmnopqrstuvwxyz"
        Dim allownos As String = "0123456789"
        Dim allowsymbols As String = "./"
        If Not allowchar.Contains(e.KeyChar.ToString) And Not allownos.Contains(e.KeyChar.ToString) And Not allowsymbols.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnrestore_Click(sender As Object, e As EventArgs) Handles btnrestore.Click
        If txtcategory.Text = "Member" Then
            cmd = New SqlCommand("Update membersmst set Status ='" & memberstatus & "' where ID ='" & txtuserid.Text & "'", con)
        ElseIf txtcategory.Text = "Trainer" Then
            cmd = New SqlCommand("Update Trainersmst set Trainer_status ='" & memberstatus & "' where ID ='" & txtuserid.Text & "'", con)
        End If
        con.Open()
        If cmd.ExecuteNonQuery Then
            MsgBox("Restore Successfully ")
            Mainfrm.openchildform(New Datafilefrm)
        Else
            MsgBox("Fail")
        End If
        con.Close()
    End Sub
End Class