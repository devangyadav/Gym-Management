Imports System.Data.SqlClient

Public Class gymelectricitybill

    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable

    Private Sub btnaddnewbill_Click(sender As Object, e As EventArgs) Handles btnaddnewbill.Click
        Dim expirydate As Date
        Try

            If txtunit.Text = Nothing Or txtamount.Text = Nothing Or txtdate.Text = Nothing Then
                MsgBox("please enter all values")
            Else
                expirydate = DateTime.Now.AddMonths(2)
                cmd = New SqlCommand("INSERT INTO billmst (unit,amount,date,enddate) VALUES (" & txtunit.Text & ",'" & txtamount.Text & "','" & txtdate.Text & "','" & expirydate & "')", con)
                con.Open()
                If cmd.ExecuteNonQuery Then
                    MsgBox("Insert Successfully")
                Else
                    MsgBox("Fail")
                End If
                con.Close()
                cmd.Dispose()
                showdataingv()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
    Public Sub showdataingv()
        Try
            cmd = New SqlCommand("SELECT * FROM billmst  with (nolock) where date like '%" & Mainfrm.btnsearch.Text & "%' order by id", con)
            dt = New DataTable
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            billdv.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                billdv.Rows.Add()
                billdv.Rows(i).Cells("billno").Value = dt.Rows(i).Item("id").ToString
                billdv.Rows(i).Cells("unit").Value = dt.Rows(i).Item("unit").ToString
                billdv.Rows(i).Cells("amount").Value = dt.Rows(i).Item("amount").ToString
                billdv.Rows(i).Cells("datebill").Value = Format(CDate(dt.Rows(i).Item("date")), "d")
            Next
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub gymelectricitybill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdate.MaxDate = Date.Today.AddMonths(2)
        txtdate.MinDate = Date.Today
        showdataingv()
    End Sub
End Class