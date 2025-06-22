Imports System.Data.SqlClient
Imports System.IO

Public Class Memberfeesfrm

    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim cmd2 As SqlCommand
    Dim cmd3 As SqlCommand
    Dim cmd4 As SqlCommand
    Dim dt As New DataTable
    Dim fid As Integer

    Private Sub Memberfeesfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mainfrm.btnsearch.Clear()
        Dim column1 As New DataGridViewTextBoxColumn()
        column1.HeaderText = "ID"
        column1.Name = "no"
        memberfeedataview.Columns.Add(column1)

        Dim column2 As New DataGridViewTextBoxColumn()
        column2.HeaderText = "NAME"
        column2.Name = "member_name"
        memberfeedataview.Columns.Add(column2)

        Dim column3 As New DataGridViewTextBoxColumn()
        column3.HeaderText = "PLANS"
        column3.Name = "plans"
        memberfeedataview.Columns.Add(column3)

        Dim column4 As New DataGridViewTextBoxColumn()
        column4.HeaderText = "DATE"
        column4.Name = "paydate"
        memberfeedataview.Columns.Add(column4)

        Dim column5 As New DataGridViewTextBoxColumn()
        column5.HeaderText = "EXP DATE"
        column5.Name = "expirydate"
        memberfeedataview.Columns.Add(column5)

        Dim column6 As New DataGridViewTextBoxColumn()
        column6.HeaderText = "MONTHS"
        column6.Name = "months"
        memberfeedataview.Columns.Add(column6)

        Dim column7 As New DataGridViewTextBoxColumn()
        column7.HeaderText = "AMOUNT"
        column7.Name = "fees"
        memberfeedataview.Columns.Add(column7)
        showdataingv()
        Dim dt As Date = Today
        txttodaydate.Text = dt.ToString("yyyy-MM-dd")
        AddHandler Mainfrm.btnsearch.TextChanged, AddressOf btnsearch_TextChanged
    End Sub

    Public Sub btnsearch_TextChanged(sender As Object, e As EventArgs)
        loaddata()
        showdataingv()
    End Sub

    Sub loaddata()
        Dim imagecmd As SqlCommand
        Dim rd As SqlDataReader
        Dim gambar() As Byte

        imagecmd = New SqlCommand("select * from membersmst with (nolock) where CONCAT(name,id)like '%" & Mainfrm.btnsearch.Text & "%'", con)

        con.Open()
        rd = imagecmd.ExecuteReader
        Try
            rd.Read()
            If rd.HasRows() Then
                gambar = rd("profile")
                txtfullname.Text = rd("name")
                txtplanstype.Text = rd("plans")
                txtmonths.Text = rd("months")
                txtpayfees.Text = rd("totalfees")
                Dim ms As New MemoryStream(gambar)
                lblphoto.Visible = False
                memberfeeprofile.Image = Image.FromStream(ms)
                memberfeeprofile.Size = New Size(181, 184)
                memberfeeprofile.SizeMode = PictureBoxSizeMode.StretchImage

            End If
            rd.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Public Sub showdataingv()
        Try
            con.Open()
            dt.Clear()
            memberfeedataview.Columns.Clear()
            memberfeedataview.DataSource = Nothing
            cmd = New SqlCommand("SELECT * FROM memberfeesreportmst with (nolock)  WHERE CONCAT(m_name,id)LIKE '%" & Mainfrm.btnsearch.Text & "%' order by id", con)
            Dim column1 As New DataGridViewTextBoxColumn()
            column1.HeaderText = "ID"
            column1.Name = "no"
            memberfeedataview.Columns.Add(column1)

            Dim column2 As New DataGridViewTextBoxColumn()
            column2.HeaderText = "NAME"
            column2.Name = "member_name"
            memberfeedataview.Columns.Add(column2)

            Dim column3 As New DataGridViewTextBoxColumn()
            column3.HeaderText = "PLANS"
            column3.Name = "plans"
            memberfeedataview.Columns.Add(column3)

            Dim column4 As New DataGridViewTextBoxColumn()
            column4.HeaderText = "DATE"
            column4.Name = "paydate"
            memberfeedataview.Columns.Add(column4)

            Dim column5 As New DataGridViewTextBoxColumn()
            column5.HeaderText = "EXP DATE"
            column5.Name = "expirydate"
            memberfeedataview.Columns.Add(column5)

            Dim column6 As New DataGridViewTextBoxColumn()
            column6.HeaderText = "MONTHS"
            column6.Name = "months"
            memberfeedataview.Columns.Add(column6)

            Dim column7 As New DataGridViewTextBoxColumn()
            column7.HeaderText = "AMOUNT"
            column7.Name = "fees"
            memberfeedataview.Columns.Add(column7)
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            memberfeedataview.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                memberfeedataview.Rows.Add()
                memberfeedataview.Rows(i).Cells("no").Value = dt.Rows(i).Item("id").ToString
                memberfeedataview.Rows(i).Cells("member_name").Value = dt.Rows(i).Item("m_name").ToString
                memberfeedataview.Rows(i).Cells("plans").Value = dt.Rows(i).Item("plans").ToString
                memberfeedataview.Rows(i).Cells("paydate").Value = Format(CDate(dt.Rows(i).Item("pay_date")), "d")
                memberfeedataview.Rows(i).Cells("expirydate").Value = Format(CDate(dt.Rows(i).Item("expiry_date")), "d")
                memberfeedataview.Rows(i).Cells("months").Value = dt.Rows(i).Item("months").ToString
                memberfeedataview.Rows(i).Cells("fees").Value = dt.Rows(i).Item("fees").ToString
            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnfeesupdate_Click(sender As Object, e As EventArgs) Handles btnfeesupdate.Click
        Dim newmstatus As String = "paid"

        Dim expirydate As Date
        Try
            If Mainfrm.btnsearch.Text = Nothing And txtfullname.Text = Nothing Then
                MsgBox("Please enter value")
            Else

                cmd2 = New SqlCommand("select ID from membersmst WHERE Name='" & txtfullname.Text & "'", con)

                da = New SqlDataAdapter(cmd2)

                dt = New DataTable
                da.Fill(dt)
                If dt.Rows.Count <= 0 Then
                    MessageBox.Show("no data found")
                Else
                    fid = dt.Rows(0)(0)

                    If txtmonths.SelectedItem = "01 Month" Then
                        expirydate = DateTime.Now.AddMonths(1)
                    ElseIf txtmonths.SelectedItem = "03 Months" Then
                        expirydate = DateTime.Now.AddMonths(3)
                    ElseIf txtmonths.SelectedItem = "06 Months" Then
                        expirydate = DateTime.Now.AddMonths(6)
                    ElseIf txtmonths.SelectedItem = "09 Months" Then
                        expirydate = DateTime.Now.AddMonths(9)
                    ElseIf txtmonths.SelectedItem = "12 Months" Then
                        expirydate = DateTime.Now.AddMonths(12)
                    End If

                    cmd3 = New SqlCommand("INSERT INTO memberfeesreportmst (id,m_name,pay_date,expiry_date,months,fees)VALUES ('" & fid & "','" & txtfullname.Text & "','" & txttodaydate.Text & "','" & expirydate & "','" & txtmonths.Text & "'," & txtpayfees.Text & ")", con)
                    con.Open()
                    If cmd3.ExecuteNonQuery Then
                        MsgBox("Insert Successfully")
                    Else
                        MsgBox("Fail")
                    End If
                    con.Close()
                End If

                cmd4 = New SqlCommand("UPDATE membersmst Set Plans ='" & txtplanstype.Text & "',Months='" & txtmonths.Text & "',Totalfees=" & txtpayfees.Text & ",expiredate='" & expirydate & "',Status='" & newmstatus & "' WHERE ID=" & fid & "", con)

                con.Open()
                If cmd4.ExecuteNonQuery Then
                Else
                    MsgBox("Fail to Update")
                End If
                con.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Mainfrm.openchildform(New Datafilefrm)
    End Sub
End Class