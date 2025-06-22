Imports System.Data.SqlClient

Public Class Dashboardfrm

    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim cmd1 As SqlCommand
    Dim cmd2 As SqlCommand
    Dim dt As New DataTable
    Dim dt1 As New DataTable
    Dim dt2 As New DataTable
    Dim da As SqlDataAdapter
    Dim da1 As SqlDataAdapter
    Dim da2 As SqlDataAdapter
    Dim dr As SqlDataReader

    Dim counttcreatine As Double
    Dim countsellcreatine As Double

    Dim counttprotein As Double
    Dim countsellprotein As Double

    Dim counttother As Double
    Dim countsellother As Double
    Private Sub Dashboardfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mainfrm.btnsearch.Clear()
        sells()
        overview()
        recentmember()
        trainerlist()
        totalrevenue()
        membersstatics()
        recentorders()
    End Sub

    Sub recentorders()

        cmd = New SqlCommand("Select p_name,buyer_name,quantity,Total_Price,buydate from buyermst order by b_id desc", con)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        con.Open()
        cmd1 = New SqlCommand("Select p_image from stocksmst where p_name='" & dt.Rows(0).Item("p_name") & "' ", con)
        dr = cmd1.ExecuteReader
        dr.Read()
        Dim img0() As Byte = dr.Item("p_image")
        Dim ms0 As New System.IO.MemoryStream(img0)
        dr.Close()
        Dim fimg As Image = Image.FromStream(ms0)

        pico1.Image = resizeimage(fimg, 40, 40)
        txtpname1.Text = dt.Rows(0).Item("p_name").ToString
        txtobname1.Text = dt.Rows(0).Item("buyer_name").ToString
        txtquan1.Text = dt.Rows(0).Item("quantity").ToString
        txtototal1.Text = "₹" + dt.Rows(0).Item("Total_Price").ToString
        txtobuydate1.Text = Format(CDate(dt.Rows(0).Item("buydate")), "d")
        cmd1.Dispose()
        con.Close()
        con.Open()
        cmd1 = New SqlCommand("Select p_image from stocksmst where p_name='" & dt.Rows(1).Item("p_name") & "' ", con)
        dr = cmd1.ExecuteReader
        dr.Read()
        Dim img1() As Byte = dr.Item("p_image")
        Dim ms1 As New System.IO.MemoryStream(img1)
        dr.Close()
        Dim simg As Image = Image.FromStream(ms1)

        pico2.Image = resizeimage(simg, 40, 40)
        txtpname2.Text = dt.Rows(1).Item("p_name").ToString
        txtobname2.Text = dt.Rows(1).Item("buyer_name").ToString
        txtquan2.Text = dt.Rows(1).Item("quantity").ToString
        txtototal2.Text = "₹" + dt.Rows(1).Item("Total_Price").ToString
        txtobuydate2.Text = Format(CDate(dt.Rows(1).Item("buydate")), "d")
        con.Close()
    End Sub
    Sub membersstatics()
        Dim cstat As String = "Cardio"
        Dim atviestat As String = "Active"
        con.Open()
        cmd = New SqlCommand("Select count(*) from membersmst where Plans='" & cstat & "' and  Status='" & atviestat & "'", con)
        txtcardiocount.Text = cmd.ExecuteScalar
        cardioprogressbar.Value = cmd.ExecuteScalar
        con.Close()
        cmd.Dispose()

        Dim sstat As String = "Strength"
        con.Open()
        cmd = New SqlCommand("Select count(*) from membersmst where Plans='" & sstat & "' and  Status='" & atviestat & "'", con)
        txtstrengthcount.Text = cmd.ExecuteScalar
        strengthprogressbar.Value = cmd.ExecuteScalar
        con.Close()
        cmd.Dispose()

        Dim pstat As String = "Personal"
        con.Open()
        cmd = New SqlCommand("Select count(*) from membersmst where Plans='" & pstat & "' and  Status='" & atviestat & "'", con)
        txtpersonalcount.Text = cmd.ExecuteScalar
        personalprogressbar.Value = cmd.ExecuteScalar
        con.Close()
        cmd.Dispose()

        Dim csstat As String = "Cardio and Strength"
        con.Open()
        cmd = New SqlCommand("Select count(*) from membersmst where Plans='" & csstat & "' and  Status='" & atviestat & "'", con)
        txtcscount.Text = cmd.ExecuteScalar
        cardiostrengthprogressbar.Value = cmd.ExecuteScalar
        con.Close()
        cmd.Dispose()

    End Sub

    Sub totalrevenue()
        Dim totalrevenue1 As Decimal
        Dim totalrevenue2 As Decimal

        con.Open()
        dt.Clear()
        dt1.Clear()
        cmd = New SqlCommand("Select total_price from buyertotlperreportmst", con)
        cmd1 = New SqlCommand("Select Totalfees from membersmst", con)
        da = New SqlDataAdapter(cmd)
        da1 = New SqlDataAdapter(cmd1)
        da.Fill(dt)
        da1.Fill(dt1)

        For i = 0 To dt.Rows.Count - 1
            totalrevenue1 += dt.Rows(i).Item("total_price")
        Next

        For i = 0 To dt1.Rows.Count - 1
            totalrevenue2 += dt1.Rows(i).Item("Totalfees")
        Next
        txttotalrevenue.Text = "₹" + (totalrevenue1 + totalrevenue2).ToString
        con.Close()
        cmd.Dispose()
    End Sub


    Sub trainerlist()
        con.Open()

        cmd = New SqlCommand("Select Profile,Name,Trainertype from Trainersmst order by ID desc", con)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)

        dr = cmd.ExecuteReader
        dr.Read()
        Dim img0() As Byte = dt.Rows(0).Item("Profile")
        Dim ms0 As New System.IO.MemoryStream(img0)
        dr.Close()
        Dim fimg As Image = Image.FromStream(ms0)

        PictureBox1.Image = resizeimage(fimg, 75, 79)
        txttrainer1.Text = dt.Rows(0).Item("Name")
        txttrainertype1.Text = dt.Rows(0).Item("Trainertype")

        dr = cmd.ExecuteReader
        dr.Read()
        Dim img1() As Byte = dt.Rows(1).Item("Profile")
        Dim ms1 As New System.IO.MemoryStream(img1)
        dr.Close()
        Dim simg As Image = Image.FromStream(ms1)

        PictureBox2.Image = resizeimage(simg, 75, 79)
        txttrainer2.Text = dt.Rows(1).Item("Name")
        txttrainertype2.Text = dt.Rows(1).Item("Trainertype")

        dr = cmd.ExecuteReader
        dr.Read()
        Dim img2() As Byte = dt.Rows(2).Item("Profile")
        Dim ms2 As New System.IO.MemoryStream(img2)
        dr.Close()
        Dim timg As Image = Image.FromStream(ms2)

        PictureBox3.Image = resizeimage(timg, 75, 79)
        txttrainer3.Text = dt.Rows(2).Item("Name")
        txttrainertype3.Text = dt.Rows(2).Item("Trainertype")

        con.Close()
    End Sub
    Sub sells()
        'protein
        Dim sp As String = "Protein"

        dt.Clear()
        cmd = New SqlCommand("Select quantity from stocksmst where productcategory='" & sp & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)

        For i = 0 To dt.Rows.Count - 1
            counttprotein += dt.Rows(i).Item("quantity")
        Next
        proteinbar.Maximum = counttprotein

        cmd.Dispose()

        dt1.Clear()
        cmd1 = New SqlCommand("Select quantity from buyermst where productcategory='" & sp & "'", con)
        da1 = New SqlDataAdapter(cmd1)
        da1.Fill(dt1)

        For i = 0 To dt1.Rows.Count - 1
            countsellprotein += dt1.Rows(i).Item("quantity")
        Next
        proteinbar.Value = countsellprotein
        txtprotein.Text = countsellprotein
        cmd1.Dispose()


        'creatine
        Dim sc As String = "Creatine"

        dt.Clear()
        cmd = New SqlCommand("Select quantity from stocksmst where productcategory='" & sc & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)

        For i = 0 To dt.Rows.Count - 1
            counttcreatine += dt.Rows(i).Item("quantity")
        Next
        creatinebar.Maximum = counttcreatine

        cmd.Dispose()

        dt1.Clear()
        cmd1 = New SqlCommand("Select quantity from buyermst where productcategory='" & sc & "'", con)
        da1 = New SqlDataAdapter(cmd1)
        da1.Fill(dt1)

        For i = 0 To dt1.Rows.Count - 1
            countsellcreatine += dt1.Rows(i).Item("quantity")
        Next
        creatinebar.Value = countsellcreatine
        txtcreatine.Text = countsellcreatine
        cmd1.Dispose()

        'other
        Dim so As String = "Other"


        dt.Clear()
        cmd = New SqlCommand("Select quantity from stocksmst where productcategory='" & so & "'", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)

        For i = 0 To dt.Rows.Count - 1
            counttother += dt.Rows(i).Item("quantity")
        Next
        otherbar.Maximum = counttother

        cmd.Dispose()

        dt1.Clear()
        cmd1 = New SqlCommand("Select quantity from buyermst where productcategory='" & so & "'", con)
        da1 = New SqlDataAdapter(cmd1)
        da1.Fill(dt1)

        For i = 0 To dt1.Rows.Count - 1
            countsellother += dt1.Rows(i).Item("quantity")
        Next
        otherbar.Value = countsellother
        txtotheritems.Text = countsellother
        cmd1.Dispose()

    End Sub

    Sub overview()
        Dim astat As String = "Active"
        Dim tdate As Date = Date.Today
        Dim totalexpence1 As Decimal
        Dim totalexpence2 As Decimal
        Dim totalexpence3 As Decimal
        Dim totalexpensive As Decimal
        con.Open()
        cmd = New SqlCommand("Select count(*) from membersmst where Status='" & astat & "'", con)
        txttotalmember.Text = cmd.ExecuteScalar

        memberprogressbar.Value = cmd.ExecuteScalar
        con.Close()
        cmd.Dispose()
        orderprogressbar.Maximum = counttprotein + counttcreatine + counttother
        con.Open()
        cmd = New SqlCommand("Select count(*) from buyertotlperreportmst", con)
        txttotalorder.Text = cmd.ExecuteScalar
        orderprogressbar.Value = cmd.ExecuteScalar
        con.Close()
        cmd.Dispose()

        con.Open()
        dt.Clear()
        dt1.Clear()
        dt2.Clear()
        cmd = New SqlCommand("Select purchaseprice from stocksmst", con)
        cmd1 = New SqlCommand("Select amount from billmst", con)
        cmd2 = New SqlCommand("Select amount from gymequipmentmst", con)
        da = New SqlDataAdapter(cmd)
        da1 = New SqlDataAdapter(cmd1)
        da2 = New SqlDataAdapter(cmd2)
        da.Fill(dt)
        da1.Fill(dt1)
        da2.Fill(dt2)

        For i = 0 To dt.Rows.Count - 1
            totalexpence1 += dt.Rows(i).Item("purchaseprice")
        Next

        For i = 0 To dt1.Rows.Count - 1
            totalexpence2 += dt1.Rows(i).Item("amount")

        Next
        For i = 0 To dt2.Rows.Count - 1
            totalexpence3 += dt2.Rows(i).Item("amount")

        Next
        txttotalexpense.Text = "₹" + (totalexpence1 + totalexpence2 + totalexpence3).ToString
        totalexpenseprogressbar.Value = totalexpence1 + totalexpence2 + totalexpence3
        con.Close()
        cmd.Dispose()

        con.Open()
        dt.Clear()
        cmd = New SqlCommand("Select purchaseprice,price from stocksmst", con)
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)

        For i = 0 To dt.Rows.Count - 1
            totalexpensive += dt.Rows(i).Item("price") - dt.Rows(i).Item("purchaseprice")
        Next
        txtincome.Text = "₹" + totalexpensive.ToString
        progressbartotalincome.Maximum = totalexpence1 + totalexpence2 + totalexpence3
        progressbartotalincome.Value = totalexpensive

        totalexpenseprogressbar.Maximum = totalexpensive
        con.Close()
        cmd.Dispose()
    End Sub

    Sub recentmember()
        con.Open()
        dt.Clear()
        cmd = New SqlCommand("Select Profile,Name,Plans,Totalfees,Joindate from membersmst order by ID desc", con)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)

        dr = cmd.ExecuteReader
        dr.Read()
        Dim img0() As Byte = dt.Rows(0).Item("Profile")
        Dim ms0 As New System.IO.MemoryStream(img0)
        dr.Close()
        Dim fimg As Image = Image.FromStream(ms0)

        recentlympic1.Image = resizeimage(fimg, 60, 60)
        txtname1.Text = dt.Rows(0).Item("Name").ToString
        txtplan1.Text = dt.Rows(0).Item("Plans").ToString
        txtprice1.Text = "₹" + dt.Rows(0).Item("Totalfees").ToString
        txtdate1.Text = Format(CDate(dt.Rows(0).Item("Joindate")), "d")

        dr = cmd.ExecuteReader
        dr.Read()
        Dim img1() As Byte = dt.Rows(1).Item("Profile")
        Dim ms1 As New System.IO.MemoryStream(img1)
        dr.Close()
        Dim simg As Image = Image.FromStream(ms1)

        recentlympic2.Image = resizeimage(simg, 60, 60)
        txtname2.Text = dt.Rows(1).Item("Name").ToString
        txtplan2.Text = dt.Rows(1).Item("Plans").ToString
        txtprice2.Text = "₹" + dt.Rows(1).Item("Totalfees").ToString
        txtdate2.Text = Format(CDate(dt.Rows(0).Item("Joindate")), "d")

        dr = cmd.ExecuteReader
        dr.Read()
        Dim img2() As Byte = dt.Rows(2).Item("Profile")
        Dim ms2 As New System.IO.MemoryStream(img2)
        dr.Close()
        Dim timg As Image = Image.FromStream(ms2)

        recentlympic3.Image = resizeimage(timg, 60, 60)
        txtname3.Text = dt.Rows(2).Item("Name").ToString
        txtplan3.Text = dt.Rows(2).Item("Plans").ToString
        txtprice3.Text = "₹" + dt.Rows(2).Item("Totalfees").ToString
        txtdate3.Text = Format(CDate(dt.Rows(2).Item("Joindate")), "d")

        dr = cmd.ExecuteReader
        dr.Read()
        Dim img3() As Byte = dt.Rows(3).Item("Profile")
        Dim ms3 As New System.IO.MemoryStream(img3)
        dr.Close()
        Dim foimg As Image = Image.FromStream(ms3)

        recentlympic4.Image = resizeimage(foimg, 60, 60)
        txtname4.Text = dt.Rows(3).Item("Name").ToString
        txtplan4.Text = dt.Rows(3).Item("Plans").ToString
        txtprice4.Text = "₹" + dt.Rows(3).Item("Totalfees").ToString
        txtdate4.Text = Format(CDate(dt.Rows(3).Item("Joindate")), "d")
        con.Close()
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

End Class