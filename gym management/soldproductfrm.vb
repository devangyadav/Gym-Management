Imports System.Data.SqlClient
Imports System.IO
Public Class soldproductfrm

    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim dt As New DataTable
    Dim da As SqlDataAdapter


    Private Sub soldproductfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mainfrm.btnsearch.Clear()
        Dim column1 As New DataGridViewTextBoxColumn()
        column1.HeaderText = "#"
        column1.Name = "no"
        soldproductdv.Columns.Add(column1)

        Dim column12 As New DataGridViewTextBoxColumn()
        column12.HeaderText = "PRODUCT NAME"
        column12.Name = "pname"
        soldproductdv.Columns.Add(column12)

        Dim column2 As New DataGridViewTextBoxColumn()
        column2.HeaderText = "NAME"
        column2.Name = "buyername"
        soldproductdv.Columns.Add(column2)

        Dim column3 As New DataGridViewTextBoxColumn()
        column3.HeaderText = "DATE"
        column3.Name = "buydate"
        soldproductdv.Columns.Add(column3)

        Dim column4 As New DataGridViewTextBoxColumn()
        column4.HeaderText = "QTY"
        column4.Name = "quantity"
        soldproductdv.Columns.Add(column4)

        Dim column5 As New DataGridViewTextBoxColumn()
        column5.HeaderText = "MRP"
        column5.Name = "price"
        soldproductdv.Columns.Add(column5)

        Dim column6 As New DataGridViewTextBoxColumn()
        column6.HeaderText = "TOTAL AMOUNT"
        column6.Name = "totalamount"
        soldproductdv.Columns.Add(column6)

        loaddata()
        AddHandler Mainfrm.btnsearch.TextChanged, AddressOf btnsearch_TextChanged
    End Sub

    Public Sub btnsearch_TextChanged(sender As Object, e As EventArgs)
        If Mainfrm.menubarclicktxt.Text = "Sold Products List" Then
            loaddata()
        End If
    End Sub

    Public Sub loaddata()
        Try
            con.Open()
            dt.Clear()
            soldproductdv.Columns.Clear()
            soldproductdv.DataSource = Nothing
            cmd = New SqlCommand("SELECT * FROM buyermst with (nolock) WHERE CONCAT(p_name,buyer_name) LIKE '%" & Mainfrm.btnsearch.Text & "%' order by buyer_name", con)
            Dim column1 As New DataGridViewTextBoxColumn()
            column1.HeaderText = "#"
            column1.Name = "no"
            soldproductdv.Columns.Add(column1)

            Dim column12 As New DataGridViewTextBoxColumn()
            column12.HeaderText = "PRODUCT NAME"
            column12.Name = "pname"
            soldproductdv.Columns.Add(column12)

            Dim column2 As New DataGridViewTextBoxColumn()
            column2.HeaderText = "NAME"
            column2.Name = "buyername"
            soldproductdv.Columns.Add(column2)

            Dim column3 As New DataGridViewTextBoxColumn()
            column3.HeaderText = "DATE"
            column3.Name = "buydate"
            soldproductdv.Columns.Add(column3)

            Dim column4 As New DataGridViewTextBoxColumn()
            column4.HeaderText = "QTY"
            column4.Name = "quantity"
            soldproductdv.Columns.Add(column4)

            Dim column5 As New DataGridViewTextBoxColumn()
            column5.HeaderText = "MRP"
            column5.Name = "price"
            soldproductdv.Columns.Add(column5)

            Dim column6 As New DataGridViewTextBoxColumn()
            column6.HeaderText = "TOTAL AMOUNT"
            column6.Name = "totalamount"
            soldproductdv.Columns.Add(column6)
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim num As Integer
            soldproductdv.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                soldproductdv.Rows.Add()
                num += 1
                soldproductdv.Rows(i).Cells("no").Value = num
                soldproductdv.Rows(i).Cells("pname").Value = dt.Rows(i).Item("p_name").ToString
                soldproductdv.Rows(i).Cells("buyername").Value = dt.Rows(i).Item("buyer_name").ToString
                soldproductdv.Rows(i).Cells("buydate").Value = Format(CDate(dt.Rows(i).Item("buydate")), "d")
                soldproductdv.Rows(i).Cells("quantity").Value = dt.Rows(i).Item("quantity").ToString
                soldproductdv.Rows(i).Cells("price").Value = dt.Rows(i).Item("Price").ToString
                soldproductdv.Rows(i).Cells("totalamount").Value = dt.Rows(i).Item("Total_Price").ToString
            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class