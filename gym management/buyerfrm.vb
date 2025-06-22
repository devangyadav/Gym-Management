Imports System.Data.SqlClient
Imports System.IO
Public Class buyerfrm

    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim dt As New DataTable
    Dim da As SqlDataAdapter


    Private currentform As Form = Nothing

    Public Sub openchildform(childform As Form)
        If currentform IsNot Nothing Then
            currentform.Close()
        End If
        currentform = childform
        currentform.TopLevel = False
        currentform.FormBorderStyle = FormBorderStyle.None
        currentform.Dock = DockStyle.Fill
        Mainfrm.mainpanel.Controls.Add(childform)
        Mainfrm.mainpanel.Tag = childform
        childform.BringToFront()
        childform.Show()
    End Sub

    Private Sub soldproductfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mainfrm.btnsearch.Clear()
        Dim column1 As New DataGridViewTextBoxColumn()
        column1.HeaderText = "#"
        column1.Name = "no"
        buyerdv.Columns.Add(column1)

        Dim column12 As New DataGridViewTextBoxColumn()
        column12.HeaderText = "NAME"
        column12.Name = "buyername"
        buyerdv.Columns.Add(column12)

        Dim column3 As New DataGridViewTextBoxColumn()
        column3.HeaderText = "EMAIL"
        column3.Name = "buyeremail"
        buyerdv.Columns.Add(column3)

        Dim column4 As New DataGridViewTextBoxColumn()
        column4.HeaderText = "PHONE"
        column4.Name = "buyerphone"
        buyerdv.Columns.Add(column4)

        Dim column5 As New DataGridViewTextBoxColumn()
        column5.HeaderText = "DATE"
        column5.Name = "buydate"
        buyerdv.Columns.Add(column5)

        Dim column6 As New DataGridViewTextBoxColumn()
        column6.HeaderText = "MRP"
        column6.Name = "price"
        buyerdv.Columns.Add(column6)

        Dim column7 As New DataGridViewTextBoxColumn()
        column7.HeaderText = "DISCOUNT"
        column7.Name = "discount"
        buyerdv.Columns.Add(column7)

        Dim column8 As New DataGridViewTextBoxColumn()
        column8.HeaderText = "TOTAL AMOUNT"
        column8.Name = "totalamount"
        buyerdv.Columns.Add(column8)
        loaddata()
        AddHandler Mainfrm.btnsearch.TextChanged, AddressOf btnsearch_TextChanged
    End Sub

    Public Sub btnsearch_TextChanged(sender As Object, e As EventArgs)
        loaddata()
    End Sub

    Public Sub loaddata()
        Try
            con.Open()
            dt.Clear()
            buyerdv.Columns.Clear()
            buyerdv.DataSource = Nothing
            cmd = New SqlCommand("SELECT * FROM buyertotlperreportmst with (nolock) WHERE buyer_name LIKE '%" & Mainfrm.btnsearch.Text & "%' order by buyer_name", con)
            Dim column1 As New DataGridViewTextBoxColumn()
            column1.HeaderText = "#"
            column1.Name = "no"
            buyerdv.Columns.Add(column1)

            Dim column12 As New DataGridViewTextBoxColumn()
            column12.HeaderText = "NAME"
            column12.Name = "buyername"
            buyerdv.Columns.Add(column12)

            Dim column3 As New DataGridViewTextBoxColumn()
            column3.HeaderText = "EMAIL"
            column3.Name = "buyeremail"
            buyerdv.Columns.Add(column3)

            Dim column4 As New DataGridViewTextBoxColumn()
            column4.HeaderText = "PHONE"
            column4.Name = "buyerphone"
            buyerdv.Columns.Add(column4)

            Dim column5 As New DataGridViewTextBoxColumn()
            column5.HeaderText = "DATE"
            column5.Name = "buydate"
            buyerdv.Columns.Add(column5)

            Dim column6 As New DataGridViewTextBoxColumn()
            column6.HeaderText = "MRP"
            column6.Name = "price"
            buyerdv.Columns.Add(column6)

            Dim column7 As New DataGridViewTextBoxColumn()
            column7.HeaderText = "DISCOUNT"
            column7.Name = "discount"
            buyerdv.Columns.Add(column7)

            Dim column8 As New DataGridViewTextBoxColumn()
            column8.HeaderText = "TOTAL AMOUNT"
            column8.Name = "totalamount"
            buyerdv.Columns.Add(column8)

            da = New SqlDataAdapter(cmd)
            Dim num As Integer

            da.Fill(dt)
            buyerdv.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                buyerdv.Rows.Add()
                num += 1
                buyerdv.Rows(i).Cells("no").Value = num
                buyerdv.Rows(i).Cells("buyername").Value = dt.Rows(i).Item("buyer_name").ToString
                buyerdv.Rows(i).Cells("buyeremail").Value = dt.Rows(i).Item("buyer_email").ToString
                buyerdv.Rows(i).Cells("buyerphone").Value = dt.Rows(i).Item("buyer_phoneno").ToString
                buyerdv.Rows(i).Cells("buydate").Value = dt.Rows(i).Item("buydate").ToString
                buyerdv.Rows(i).Cells("price").Value = dt.Rows(i).Item("originalprice").ToString
                buyerdv.Rows(i).Cells("discount").Value = dt.Rows(i).Item("discount").ToString
                buyerdv.Rows(i).Cells("totalamount").Value = dt.Rows(i).Item("total_price").ToString
            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class