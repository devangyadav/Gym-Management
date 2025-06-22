Imports System.Data.SqlClient
Imports System.IO
Public Class expireproductfrm

    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim dt As New DataTable
    Dim da As SqlDataAdapter


    Private Sub soldproductfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mainfrm.btnsearch.Clear()
        Dim column1 As New DataGridViewTextBoxColumn()
        column1.HeaderText = "#"
        column1.Name = "no"
        expireproductdv.Columns.Add(column1)

        Dim column2 As New DataGridViewTextBoxColumn()
        column2.HeaderText = "NAME"
        column2.Name = "pname"
        expireproductdv.Columns.Add(column2)

        Dim column3 As New DataGridViewTextBoxColumn()
        column3.HeaderText = "DATE"
        column3.Name = "buydate"
        expireproductdv.Columns.Add(column3)

        Dim column4 As New DataGridViewTextBoxColumn()
        column4.HeaderText = "EXP DATE"
        column4.Name = "expiredate"
        expireproductdv.Columns.Add(column4)

        Dim column5 As New DataGridViewTextBoxColumn()
        column5.HeaderText = "QTY"
        column5.Name = "quantity"
        expireproductdv.Columns.Add(column5)

        Dim column6 As New DataGridViewTextBoxColumn()
        column6.HeaderText = "MRP"
        column6.Name = "price"
        expireproductdv.Columns.Add(column6)

        Dim column7 As New DataGridViewTextBoxColumn()
        column7.HeaderText = "TOTAL AMOUNT"
        column7.Name = "totalamount"
        expireproductdv.Columns.Add(column7)
        loaddata()
        AddHandler Mainfrm.btnsearch.TextChanged, AddressOf btnsearch_TextChanged
    End Sub

    Public Sub btnsearch_TextChanged(sender As Object, e As EventArgs)
        loaddata()
    End Sub

    Public Sub loaddata()
        Dim num As Integer
        Dim totalamount As Decimal
        Dim td As Date = Date.Today
        Try
            con.Open()
            dt.Clear()
            expireproductdv.Columns.Clear()
            expireproductdv.DataSource = Nothing
            cmd = New SqlCommand("Select * FROM stocksmst With (nolock) WHERE p_name Like '%" & Mainfrm.btnsearch.Text & "%' and expiredate < '" & td & "' ", con)
            Dim column1 As New DataGridViewTextBoxColumn()
            column1.HeaderText = "#"
            column1.Name = "no"
            expireproductdv.Columns.Add(column1)

            Dim column2 As New DataGridViewTextBoxColumn()
            column2.HeaderText = "NAME"
            column2.Name = "pname"
            expireproductdv.Columns.Add(column2)

            Dim column3 As New DataGridViewTextBoxColumn()
            column3.HeaderText = "DATE"
            column3.Name = "buydate"
            expireproductdv.Columns.Add(column3)

            Dim column4 As New DataGridViewTextBoxColumn()
            column4.HeaderText = "EXP DATE"
            column4.Name = "expiredate"
            expireproductdv.Columns.Add(column4)

            Dim column5 As New DataGridViewTextBoxColumn()
            column5.HeaderText = "QTY"
            column5.Name = "quantity"
            expireproductdv.Columns.Add(column5)

            Dim column6 As New DataGridViewTextBoxColumn()
            column6.HeaderText = "MRP"
            column6.Name = "price"
            expireproductdv.Columns.Add(column6)

            Dim column7 As New DataGridViewTextBoxColumn()
            column7.HeaderText = "TOTAL AMOUNT"
            column7.Name = "totalamount"
            expireproductdv.Columns.Add(column7)
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            expireproductdv.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                expireproductdv.Rows.Add()

                num += 1
                expireproductdv.Rows(i).Cells("no").Value = num
                expireproductdv.Rows(i).Cells("pname").Value = dt.Rows(i).Item("p_name").ToString
                expireproductdv.Rows(i).Cells("buydate").Value = dt.Rows(i).Item("purchasedate").ToString
                expireproductdv.Rows(i).Cells("expiredate").Value = Format(CDate(dt.Rows(i).Item("expiredate").ToString), "d")
                expireproductdv.Rows(i).Cells("quantity").Value = dt.Rows(i).Item("quantity").ToString
                totalamount = dt.Rows(i).Item("Price") * dt.Rows(i).Item("quantity")
                expireproductdv.Rows(i).Cells("price").Value = dt.Rows(i).Item("Price").ToString
                expireproductdv.Rows(i).Cells("totalamount").Value = totalamount.ToString

            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class