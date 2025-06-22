Imports System.Data.SqlClient
Imports System.IO
Public Class purchasefrm

    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim dt As New DataTable
    Dim da As SqlDataAdapter


    Private Sub soldproductfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mainfrm.btnsearch.Clear()
        Dim column1 As New DataGridViewTextBoxColumn()
        column1.HeaderText = "#"
        column1.Name = "no"
        purchasedv.Columns.Add(column1)

        Dim column2 As New DataGridViewTextBoxColumn()
        column2.HeaderText = "DATE"
        column2.Name = "buydate"
        purchasedv.Columns.Add(column2)

        Dim column3 As New DataGridViewTextBoxColumn()
        column3.HeaderText = "PLANS"
        column3.Name = "pname"
        purchasedv.Columns.Add(column3)

        Dim column4 As New DataGridViewTextBoxColumn()
        column4.HeaderText = "CATEGORY"
        column4.Name = "productcategory"
        purchasedv.Columns.Add(column4)

        Dim column5 As New DataGridViewTextBoxColumn()
        column5.HeaderText = "SUPPLIER NAME"
        column5.Name = "suppliername"
        purchasedv.Columns.Add(column5)

        Dim column6 As New DataGridViewTextBoxColumn()
        column6.HeaderText = "SUPPLIER EMAIL"
        column6.Name = "supplieremail"
        purchasedv.Columns.Add(column6)

        Dim column7 As New DataGridViewTextBoxColumn()
        column7.HeaderText = "EXP DATE"
        column7.Name = "expiredate"
        purchasedv.Columns.Add(column7)

        Dim column8 As New DataGridViewTextBoxColumn()
        column8.HeaderText = "QTY"
        column8.Name = "quantity"
        purchasedv.Columns.Add(column8)

        Dim column9 As New DataGridViewTextBoxColumn()
        column9.HeaderText = "PURCHASE DATE"
        column9.Name = "purchaseprice"
        purchasedv.Columns.Add(column9)

        Dim column10 As New DataGridViewTextBoxColumn()
        column10.HeaderText = "AMOUNT"
        column10.Name = "price"
        purchasedv.Columns.Add(column10)

        Dim column11 As New DataGridViewTextBoxColumn()
        column11.HeaderText = "TOTAL AMOUNT"
        column11.Name = "totalamount"
        purchasedv.Columns.Add(column11)

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
            purchasedv.Columns.Clear()
            purchasedv.DataSource = Nothing
            cmd = New SqlCommand("SELECT * FROM stocksmst with (nolock) WHERE CONCAT(p_name,supplier_name)LIKE '%" & Mainfrm.btnsearch.Text & "%' order by purchasedate", con)
            Dim column1 As New DataGridViewTextBoxColumn()
            column1.HeaderText = "#"
            column1.Name = "no"
            purchasedv.Columns.Add(column1)

            Dim column2 As New DataGridViewTextBoxColumn()
            column2.HeaderText = "DATE"
            column2.Name = "buydate"
            purchasedv.Columns.Add(column2)

            Dim column3 As New DataGridViewTextBoxColumn()
            column3.HeaderText = "NAME"
            column3.Name = "pname"
            purchasedv.Columns.Add(column3)

            Dim column4 As New DataGridViewTextBoxColumn()
            column4.HeaderText = "CATEGORY"
            column4.Name = "productcategory"
            purchasedv.Columns.Add(column4)

            Dim column5 As New DataGridViewTextBoxColumn()
            column5.HeaderText = "SUPPLIER NAME"
            column5.Name = "suppliername"
            purchasedv.Columns.Add(column5)

            Dim column6 As New DataGridViewTextBoxColumn()
            column6.HeaderText = "EMAIL"
            column6.Name = "supplieremail"
            purchasedv.Columns.Add(column6)

            Dim column12 As New DataGridViewTextBoxColumn()
            column12.HeaderText = "PHONE"
            column12.Name = "supplierphone"
            purchasedv.Columns.Add(column12)

            Dim column7 As New DataGridViewTextBoxColumn()
            column7.HeaderText = "EXP DATE"
            column7.Name = "expiredate"
            purchasedv.Columns.Add(column7)

            Dim column8 As New DataGridViewTextBoxColumn()
            column8.HeaderText = "QTY"
            column8.Name = "quantity"
            purchasedv.Columns.Add(column8)

            Dim column9 As New DataGridViewTextBoxColumn()
            column9.HeaderText = "PURCHASE DATE"
            column9.Name = "purchaseprice"
            purchasedv.Columns.Add(column9)

            Dim column10 As New DataGridViewTextBoxColumn()
            column10.HeaderText = "AMOUNT"
            column10.Name = "price"
            purchasedv.Columns.Add(column10)

            Dim column11 As New DataGridViewTextBoxColumn()
            column11.HeaderText = "TOTAL AMOUNT"
            column11.Name = "totalamount"
            purchasedv.Columns.Add(column11)

            da = New SqlDataAdapter(cmd)
            Dim num As Integer
            da.Fill(dt)
            purchasedv.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                purchasedv.Rows.Add()
                num += 1
                purchasedv.Rows(i).Cells("no").Value = num
                purchasedv.Rows(i).Cells("buydate").Value = dt.Rows(i).Item("purchasedate").ToString
                purchasedv.Rows(i).Cells("pname").Value = dt.Rows(i).Item("p_name").ToString
                purchasedv.Rows(i).Cells("productcategory").Value = dt.Rows(i).Item("productcategory").ToString
                purchasedv.Rows(i).Cells("suppliername").Value = dt.Rows(i).Item("supplier_name").ToString
                purchasedv.Rows(i).Cells("supplierphone").Value = dt.Rows(i).Item("supplier_phone").ToString
                purchasedv.Rows(i).Cells("supplieremail").Value = dt.Rows(i).Item("supplier_email").ToString
                purchasedv.Rows(i).Cells("expiredate").Value = dt.Rows(i).Item("expiredate").ToString
                purchasedv.Rows(i).Cells("quantity").Value = dt.Rows(i).Item("fixedquantity").ToString
                purchasedv.Rows(i).Cells("purchaseprice").Value = dt.Rows(i).Item("purchaseprice").ToString
                purchasedv.Rows(i).Cells("price").Value = dt.Rows(i).Item("price").ToString
                purchasedv.Rows(i).Cells("totalamount").Value = dt.Rows(i).Item("totalprice").ToString
            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class