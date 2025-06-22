Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Productsfrm
    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim cmd1 As SqlCommand
    Dim cmd2 As SqlCommand
    Dim cmd3 As SqlCommand
    Dim cmd4 As SqlCommand
    Dim cmd5 As SqlCommand
    Dim cmd6 As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim dr As SqlDataReader
    Dim drquan As SqlDataReader

    Dim _total As Double
    Dim itemsno As Integer
    Dim totquan As Integer
    Dim totalpay As Double
    Dim decriquan As Integer
    Dim originalprice As Decimal
    Dim bid As Integer
    Dim dispri As Decimal
    Dim td As Date = Date.Today

    Private WithEvents pic As New PictureBox
    Private WithEvents lblD As New Label
    Private WithEvents lblP As New Label
    Private WithEvents btn As New Label
    Private WithEvents pname As New Label
    Private WithEvents pan As New Panel
    Private WithEvents quan As New Label

    Private Sub Productsfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mainfrm.btnsearch.Clear()
        loaddata()
        AddHandler Mainfrm.btnsearch.TextChanged, AddressOf btnsearch_TextChanged
    End Sub
    Public Sub btnsearch_TextChanged(sender As Object, e As EventArgs)
        loaddata()
    End Sub

    Sub loaddata()
        Try
            con.Open()
            productlistpanel.AutoScroll = True
            productlistpanel.Controls.Clear()
            Dim listno As Integer = 0
            cmd = New SqlCommand("select p_image, p_name, description, quantity, price,p_id from stocksmst with (nolock) where expiredate > '" & td & "' and quantity > " & listno & " and (CONCAT(p_name,description,productcategory,price)LIKE '%" & Mainfrm.btnsearch.Text & "%') order by p_name", con)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
                Dim array(CInt(len)) As Byte
                dr.GetBytes(0, 0, array, 0, CInt(len))

                pic = New PictureBox
                pic.Width = 168
                pic.Height = 170
                pic.BackgroundImageLayout = ImageLayout.Stretch
                pic.Tag = dr.Item("p_id").ToString

                pan = New Panel
                pan.Width = 168
                pan.Height = 198

                pname = New Label
                pname.BackColor = Color.Orchid
                pname.TextAlign = ContentAlignment.MiddleCenter
                pname.Dock = DockStyle.Top


                lblP = New Label
                lblP.BackColor = Color.PaleGoldenrod
                lblP.TextAlign = ContentAlignment.MiddleRight
                lblP.Dock = DockStyle.Bottom

                quan = New Label
                quan.BackColor = Color.PaleGoldenrod
                quan.TextAlign = ContentAlignment.MiddleLeft
                quan.Size = New Size(89, 0)
                quan.Dock = DockStyle.Left


                Dim ms As New System.IO.MemoryStream(array)
                Dim bitmap As New System.Drawing.Bitmap(ms)
                pic.BackgroundImage = bitmap

                pname.Text = dr.Item("p_name").ToString
                lblP.Text = "₹ " + dr.Item("price").ToString

                If dr.Item("quantity") <= 10 Then
                    quan.ForeColor = Color.Red
                    quan.Text = "Only " + dr.Item("quantity").ToString + " left"
                Else
                    quan.Text = "Qty*  " + dr.Item("quantity").ToString
                End If

                pan.Controls.Add(pname)
                lblP.Controls.Add(quan)
                pan.Controls.Add(pic)
                pan.Controls.Add(lblP)
                productlistpanel.Controls.Add(pan)

                AddHandler pic.Click, AddressOf pic_click

            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub pic_click(sender As Object, e As EventArgs)

        Try

            con.Open()
            cmd = New SqlCommand("select p_id,p_name, quantity, price,productcategory from stocksmst where p_id like '" & sender.tag.ToString & "'", con)
            dr = cmd.ExecuteReader

            While dr.Read
                Dim tempname As String = dr.Item("p_name")
                Dim bool As Boolean = False
                Dim tempprice As Decimal = dr.Item("price")

                For i = 0 To buyproductlistdataview.Rows.Count - 1

                    If buyproductlistdataview.Rows(i).Cells("items").Value = tempname Then
                        buyproductlistdataview.Rows(i).Cells("quantity").Value += 1
                        buyproductlistdataview.Rows(i).Cells("totalprice").Value += tempprice
                        totalpay += CDbl(dr.Item("price"))
                        bool = True
                        productlistpanel.Refresh()
                    End If
                Next
                If bool = False Then
                    _total = CDbl(dr.Item("price"))
                    totalpay += CDbl(dr.Item("price"))
                    itemsno += 1
                    totquan = 1
                    buyproductlistdataview.Rows.Add(itemsno, dr.Item("p_name").ToString, totquan, dr.Item("price"), _total, dr.Item("productcategory"))
                End If
            End While
            dr.Close()
            con.Close()
            txttotal.Text = Format(CDbl(totalpay), "#,##0.00")
            originalprice = txttotal.Text
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnsavesellitems_Click(sender As Object, e As EventArgs) Handles btnsavesellitems.Click
        Try

            Dim buydate As Date = Date.Now
            If txtbuyername.Text = "" Or txtbuyeremail.Text = "" Or txtbuyerph.Text = "" Then
                MsgBox("Please Enter Value")
            Else
                changelongpaper()
                PPD.Document = PD
                PPD.ShowDialog()
                'PD.Print()  'Direct Print
                If txtdiscount.Text = "" Then
                    cmd4 = New SqlCommand("INSERT INTO buyertotlperreportmst (buyer_name,buyer_email,buyer_phoneno,buydate,originalprice,total_price) VALUES('" & txtbuyername.Text & "','" & txtbuyeremail.Text & "'," & txtbuyerph.Text & ",'" & buydate & "'," & originalprice & "," & dispri & ")", con)

                Else
                    cmd4 = New SqlCommand("INSERT INTO buyertotlperreportmst (buyer_name,buyer_email,buyer_phoneno,buydate,discount,originalprice,total_price) VALUES('" & txtbuyername.Text & "','" & txtbuyeremail.Text & "'," & txtbuyerph.Text & ",'" & buydate & "'," & txtdiscount.Text & "," & originalprice & "," & dispri & ")", con)
                End If
                con.Open()
                If cmd4.ExecuteNonQuery Then
                Else
                    MsgBox("Fail")
                End If
                con.Close()


                For i = 0 To buyproductlistdataview.RowCount - 1
                    Dim updatequan As Integer
                    cmd2 = New SqlCommand("select quantity from stocksmst WHERE p_name='" & buyproductlistdataview.Rows(i).Cells("items").Value & "'", con)

                    da = New SqlDataAdapter(cmd2)

                    dt = New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count <= 0 Then
                        MessageBox.Show("no data found")
                    Else
                        updatequan = dt.Rows(0).Item("quantity") - buyproductlistdataview.Rows(i).Cells("quantity").Value
                    End If

                    con.Open()

                    cmd6 = New SqlCommand("update stocksmst set  quantity ='" & updatequan & "' WHERE p_name='" & buyproductlistdataview.Rows(i).Cells("items").Value & "'", con)
                    If cmd6.ExecuteNonQuery Then
                    Else
                        MsgBox("fail")
                    End If
                    con.Close()
                    loaddata()
                Next


                cmd5 = New SqlCommand("select id from buyertotlperreportmst WHERE buyer_name='" & txtbuyername.Text & "' and buyer_phoneno=" & txtbuyerph.Text & " and buydate='" & buydate & "'", con)

                da = New SqlDataAdapter(cmd5)

                dt = New DataTable
                da.Fill(dt)
                If dt.Rows.Count <= 0 Then
                    MessageBox.Show("no data found")
                Else
                    bid = dt.Rows(0)(0)
                End If

                For i = 0 To buyproductlistdataview.RowCount - 1

                    con.Open()

                    cmd3 = New SqlCommand("INSERT INTO buyermst (b_id,p_name,buyer_name,quantity,Price,Total_Price,buydate,productcategory) VALUES('" & bid & "','" & buyproductlistdataview.Rows(i).Cells("items").Value & "','" & txtbuyername.Text & "'," & buyproductlistdataview.Rows(i).Cells("quantity").Value & "," & buyproductlistdataview.Rows(i).Cells("price").Value & "," & buyproductlistdataview.Rows(i).Cells("totalprice").Value & ",'" & buydate & "','" & buyproductlistdataview.Rows(i).Cells("productcategory").Value & "')", con)

                    If cmd3.ExecuteNonQuery Then
                    Else
                        MsgBox("fail")
                    End If
                    con.Close()
                Next

            End If

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnproductclear_Click(sender As Object, e As EventArgs) Handles btnproductclear.Click
        buyproductlistdataview.Rows.Clear()
        txtdiscount.Text = ""
        txttotal.Text = ""
        txtbuyername.Text = ""
        txtbuyeremail.Text = ""
        txtbuyerph.Text = ""
        totalpay = Nothing
        itemsno = 0
        con.Close()
    End Sub

    Private Sub txtbuyername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuyername.KeyPress
        Dim allowchar As String = "abcdefghijklmnopqrstuvwxyz"
        If Not allowchar.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub



    Private Sub txtbuyerph_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuyerph.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdiscount.KeyPress
        Dim allownos As String = "0123456789"
        If Not allownos.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtdiscount_TextChanged(sender As Object, e As EventArgs) Handles txtdiscount.TextChanged

        Dim a As Decimal = Val(totalpay) * Val(txtdiscount.Text) / 100
        txttotal.Text = Val(totalpay) - a
        dispri = txttotal.Text
        txttotal.Text = Format(CDbl(txttotal.Text), "#,##0.00")

    End Sub

    Private Sub buyproductlistdataview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles buyproductlistdataview.CellContentClick
        Try
            If buyproductlistdataview.Columns(e.ColumnIndex).Name = "btnremove" Then
                buyproductlistdataview.Rows.RemoveAt(buyproductlistdataview.SelectedRows(0).Index)
                Dim itemno As Integer
                For i = 0 To buyproductlistdataview.Rows.Count - 1
                    itemno += 1
                    buyproductlistdataview.Rows(i).Cells("itemno").Value = itemno
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtbuyeremail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuyeremail.KeyPress
        Dim allowchar As String = "abcdefghijklmnopqrstuvwxyz"
        Dim allownos As String = "0123456789"
        Dim allowsymbols As String = "@."

        If Not allownos.Contains(e.KeyChar.ToString) And Not allowchar.Contains(e.KeyChar.ToString) And Not allowsymbols.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then

            e.Handled = True
        End If
    End Sub
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = buyproductlistdataview.Rows.Count
        longpaper = rowcount * 10
        longpaper += 200
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        'pagesetup.PaperSize = New PaperSize("Custom", 250, 800) 'fixed size
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "--------------------------------------------------------------------------"


        e.Graphics.DrawString("GYM MANAGEMENT", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("Email GYM@gmail.com", f10b, Brushes.Black, centermargin, 23, center)
        e.Graphics.DrawString("Tel +1763545473", f10b, Brushes.Black, centermargin, 38, center)

        e.Graphics.DrawString("Buyer :", f10b, Brushes.Black, 0, 55)
        e.Graphics.DrawString(txtbuyername.Text, f10, Brushes.Black, 50, 55)

        e.Graphics.DrawString("Ph :", f10b, Brushes.Black, 0, 70)
        e.Graphics.DrawString(txtbuyerph.Text, f10, Brushes.Black, 50, 70)

        e.Graphics.DrawString(Format(CDate(td), "d"), f8, Brushes.Black, rightmargin, 55, right)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 100)

        Dim height As Integer 'DGV Position
        buyproductlistdataview.AllowUserToAddRows = False

        e.Graphics.DrawString("No.", f10b, Brushes.Black, 0, 90)
        e.Graphics.DrawString("Item", f10b, Brushes.Black, 25, 90)
        e.Graphics.DrawString("Qty", f10b, Brushes.Black, 135, 90, right)
        e.Graphics.DrawString("Price", f10b, Brushes.Black, 190, 90, right)
        e.Graphics.DrawString("Total", f10b, Brushes.Black, rightmargin, 90, right)

        For row As Integer = 0 To buyproductlistdataview.RowCount - 1
            height += 15
            e.Graphics.DrawString(buyproductlistdataview.Rows(row).Cells(0).Value.ToString, f10, Brushes.Black, 0, 100 + height)
            e.Graphics.DrawString(buyproductlistdataview.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 25, 100 + height)
            e.Graphics.DrawString(buyproductlistdataview.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, 125, 100 + height)
            e.Graphics.DrawString(Format(buyproductlistdataview.Rows(row).Cells(3).Value, "##,##0").ToString, f10, Brushes.Black, 190, 100 + height, right)
            e.Graphics.DrawString(Format(buyproductlistdataview.Rows(row).Cells(4).Value, "##,##0").ToString, f10, Brushes.Black, rightmargin, 100 + height, right)
        Next

        Dim height2 As Integer
        height2 = 110 + height
        sumprice() 'call sub
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("Total Qty: " & t_qty, f10b, Brushes.Black, 0, 10 + height2)
        e.Graphics.DrawString("Total: " & Format(originalprice, "##,##0"), f10b, Brushes.Black, rightmargin, 10 + height2, right)
        e.Graphics.DrawString("Dis: " & txtdiscount.Text & " %", f10b, Brushes.Black, 0, 30 + height2)
        e.Graphics.DrawString("Total: " & Format(t_price, "##,##0"), f10b, Brushes.Black, rightmargin, 30 + height2, right)
        e.Graphics.DrawString("~ Thanks for shopping ~", f10b, Brushes.Black, centermargin, 50 + height2, center)
    End Sub
    Dim t_price As Long
    Dim t_qty As Long
    Sub sumprice()
        t_price = txttotal.Text
        Dim countqty As Long = 0
        For rowitem As Long = 0 To buyproductlistdataview.RowCount - 1
            countqty += buyproductlistdataview.Rows(rowitem).Cells(2).Value
        Next
        t_qty = countqty
    End Sub
End Class