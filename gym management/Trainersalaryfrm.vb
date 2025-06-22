Imports System.Data.SqlClient
Imports System.IO
Public Class trainersalaryfrm

    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim cmd2 As SqlCommand
    Dim cmd3 As SqlCommand
    Dim cmd4 As SqlCommand
    Dim dt As New DataTable
    Dim fid As Integer

    Private Sub trainersalaryfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim column1 As New DataGridViewTextBoxColumn()
        column1.HeaderText = "ID"
        column1.Name = "trainerid"
        trainerdatagridview.Columns.Add(column1)

        Dim column2 As New DataGridViewTextBoxColumn()
        column2.HeaderText = "NAME"
        column2.Name = "trainername"
        trainerdatagridview.Columns.Add(column2)

        Dim column3 As New DataGridViewTextBoxColumn()
        column3.HeaderText = "TRAINER TYPE"
        column3.Name = "trainertype"
        trainerdatagridview.Columns.Add(column3)

        Dim column4 As New DataGridViewTextBoxColumn()
        column4.HeaderText = "DATE"
        column4.Name = "paydate"
        trainerdatagridview.Columns.Add(column4)

        Dim column5 As New DataGridViewTextBoxColumn()
        column5.HeaderText = "BONUS"
        column5.Name = "bonus"
        trainerdatagridview.Columns.Add(column5)

        Dim column6 As New DataGridViewTextBoxColumn()
        column6.HeaderText = "SALARY"
        column6.Name = "salary"
        trainerdatagridview.Columns.Add(column6)
        showdataingv()
        Dim dt As Date = Today
        txttodaydate.Text = dt.ToString("yyyy-MM-dd")
        Mainfrm.btnsearch.Clear()
        AddHandler Mainfrm.btnsearch.TextChanged, AddressOf btnsearch_TextChanged
    End Sub
    Public Sub btnsearch_TextChanged(sender As Object, e As EventArgs)
        If Mainfrm.menubarclicktxt.Text = "Trainer Salary" Then
            loaddata()
            showdataingv()
        End If
    End Sub


    Sub loaddata()
        Dim imagecmd As SqlCommand
        Dim rd As SqlDataReader
        Dim gambar() As Byte
        imagecmd = New SqlCommand("select * from Trainersmst with (nolock) WHERE CONCAT(Name,ID)LIKE '%" & Mainfrm.btnsearch.Text & "%'", con)
        con.Open()
        rd = imagecmd.ExecuteReader
        Try
            rd.Read()
            If rd.HasRows() Then
                gambar = rd("Profile")
                txtfullname.Text = rd("Name")
                txttrainertype.Text = rd("Trainertype")
                txtsalary.Text = rd("Salary")

                Dim ms As New MemoryStream(gambar)
                lblphoto.Visible = False
                trainerphoto.Image = Image.FromStream(ms)
                trainerphoto.Size = New Size(181, 184)
                trainerphoto.SizeMode = PictureBoxSizeMode.StretchImage
            End If
            rd.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        imagecmd.Dispose()
    End Sub

    Public Sub showdataingv()
        Try
            con.Open()
            dt.Clear()
            trainerdatagridview.Columns.Clear()
            cmd = New SqlCommand("SELECT * FROM trainersalaryreport with (nolock) WHERE CONCAT(name,id) LIKE '%" & Mainfrm.btnsearch.Text & "%' order by id", con)
            Dim column1 As New DataGridViewTextBoxColumn()
            column1.HeaderText = "ID"
            column1.Name = "trainerid"
            trainerdatagridview.Columns.Add(column1)

            Dim column2 As New DataGridViewTextBoxColumn()
            column2.HeaderText = "NAME"
            column2.Name = "trainername"
            trainerdatagridview.Columns.Add(column2)

            Dim column3 As New DataGridViewTextBoxColumn()
            column3.HeaderText = "TRAINER TYPE"
            column3.Name = "trainertype"
            trainerdatagridview.Columns.Add(column3)

            Dim column4 As New DataGridViewTextBoxColumn()
            column4.HeaderText = "DATE"
            column4.Name = "paydate"
            trainerdatagridview.Columns.Add(column4)

            Dim column5 As New DataGridViewTextBoxColumn()
            column5.HeaderText = "BONUS"
            column5.Name = "bonus"
            trainerdatagridview.Columns.Add(column5)

            Dim column6 As New DataGridViewTextBoxColumn()
            column6.HeaderText = "SALARY"
            column6.Name = "salary"
            trainerdatagridview.Columns.Add(column6)
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            trainerdatagridview.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                trainerdatagridview.Rows.Add()
                trainerdatagridview.Rows(i).Cells("trainerid").Value = dt.Rows(i).Item("id").ToString
                trainerdatagridview.Rows(i).Cells("trainername").Value = dt.Rows(i).Item("name").ToString
                trainerdatagridview.Rows(i).Cells("trainertype").Value = dt.Rows(i).Item("trainertype").ToString
                trainerdatagridview.Rows(i).Cells("paydate").Value = Format(CDate(dt.Rows(i).Item("date")), "d")
                trainerdatagridview.Rows(i).Cells("bonus").Value = dt.Rows(i).Item("bonus").ToString
                trainerdatagridview.Rows(i).Cells("salary").Value = dt.Rows(i).Item("salary").ToString
            Next
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub



    Private Sub btnsave_Click(sender As Object, e As EventArgs)
        Try
            If Mainfrm.btnsearch.Text = "" Or txtfullname.Text = "" Then
                MsgBox("please enter value")
            Else

                cmd2 = New SqlCommand("SELECT ID from Trainersmst WHERE Name='" & txtfullname.Text & "'", con)

                da = New SqlDataAdapter(cmd2)

                dt = New DataTable
                da.Fill(dt)
                If dt.Rows.Count <= 0 Then
                    MessageBox.Show("no data found")
                Else
                    fid = dt.Rows(0)(0)

                    Dim newmstatus As String = "paid"

                    Dim expirydate As Date

                    expirydate = Date.Now.AddMonths(1)



                    cmd3 = New SqlCommand("INSERT INTO trainersalaryreport (id,name,trainertype,date,enddate,bonus,salary)VALUES ('" & fid & "','" & txtfullname.Text & "','" & txttrainertype.Text & "','" & txttodaydate.Text & "','" & expirydate & "'," & txtbonus.Text & "," & txtsalary.Text & ")", con)

                    con.Open()
                    If cmd3.ExecuteNonQuery Then
                        MsgBox("Insert Successfully")
                    Else
                        MsgBox("Fail")
                    End If
                    con.Close()

                    cmd4 = New SqlCommand("UPDATE Trainersmst Set Trainertype ='" & txttrainertype.Text & "',Salary=" & txtsalary.Text & ",Endsalary='" & expirydate & "',Salary_status='" & newmstatus & "' WHERE ID=" & fid & "", con)

                    con.Open()
                    If cmd4.ExecuteNonQuery Then
                    Else
                        MsgBox("Fail to Update")
                    End If
                    con.Close()

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Mainfrm.btnsearch.Text = ""
        Mainfrm.openchildform(New Datafilefrm)
    End Sub

End Class
