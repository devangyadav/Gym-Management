Imports System.Data.SqlClient
Imports System.IO

Public Class AddProductfrm

    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Private currentform As Form = Nothing

    Public Sub openchildform(childform As Form)
        If currentform IsNot Nothing Then
            currentform.Close()
        End If
        currentform = childform
        currentform.Dock = DockStyle.Fill
        currentform.FormBorderStyle = FormBorderStyle.None
        currentform.TopLevel = False
        Mainfrm.mainpanel.Controls.Add(childform)
        Mainfrm.mainpanel.Tag = childform
        childform.BringToFront()
        childform.Show()

    End Sub


    Private Sub btnaddproduct_Click(sender As Object, e As EventArgs) Handles btnaddproduct.Click
        openimage.Title = "Select Images"
        openimage.InitialDirectory = "D:\"
        openimage.Filter = "Images (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG"
        openimage.RestoreDirectory = True
        openimage.FileName = ""
        openimage.Multiselect = False
        If openimage.ShowDialog = Windows.Forms.DialogResult.OK Then
            productphoto.Image = Image.FromFile(openimage.FileName)
            lblphoto.Visible = False
            productphoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
    Private Sub AddProductfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpurchasedate.MaxDate = Date.Today
        txtpurchasedate.MinDate = Date.Today.AddMonths(-2)
        txtexpiredate.MaxDate = Date.Today.AddYears(2)
        txtexpiredate.MinDate = txtexpiredate.MaxDate.AddMonths(-16)
    End Sub


    Private Sub btnaddnewproduct_Click(sender As Object, e As EventArgs) Handles btnaddnewproduct.Click
        Try
            If txtproductname.Text = Nothing Or txtsuppliername.Text = Nothing Or txtsupplierphone.Text = Nothing Or txtsupplieremail.Text = Nothing Or txtproductcategory.Text = Nothing Or txtproductdescription.Text = Nothing Or txtpurchase.Text = Nothing Or txtproductprice.Text = Nothing Or txtproductquantity.Value = Nothing Or txtproductquantity.Value = Nothing Or txtexpiredate.Text = Nothing Or txttotalamount.Text = Nothing Or txtpurchasedate.Text = Nothing Then
                MsgBox("Please Enter All Values")
            Else
                cmd = New SqlCommand("INSERT INTO stocksmst
           (p_image
           ,p_name
           ,supplier_name
           ,supplier_phone
           ,supplier_email
           ,productcategory
           ,description
           ,purchaseprice
           ,price
           ,quantity
           ,fixedquantity
           ,expiredate
           ,totalprice
           ,purchasedate)
     VALUES
           (@profile,'" & txtproductname.Text & "','" & txtsuppliername.Text & "','" & txtsupplierphone.Text & "','" & txtsupplieremail.Text & "','" & txtproductcategory.Text & "','" & txtproductdescription.Text & "'," & txtpurchase.Text & "," & txtproductprice.Text & "," & txtproductquantity.Value & "," & txtproductquantity.Value & ",'" & txtexpiredate.Text & "','" & txttotalamount.Text & "','" & txtpurchasedate.Text & "')", con)

                Dim ms As New MemoryStream
                Dim bmpimage As New Bitmap(productphoto.Image)
                bmpimage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim data As Byte() = ms.GetBuffer

                Dim p = New SqlParameter("@profile", SqlDbType.Image)
                p.Value = data
                cmd.Parameters.Add(p)
                con.Open()
                If cmd.ExecuteNonQuery Then
                    MsgBox("Saved Successfully")
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

    End Sub

    Private Sub txtproductname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtproductname.KeyPress
        Dim allowchar As String = "abcdefghijklmnopqrstuvwxyz"
        If Not allowchar.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtsuppliername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsuppliername.KeyPress
        Dim allowchar As String = "abcdefghijklmnopqrstuvwxyz"
        If Not allowchar.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True
        End If
    End Sub

    Private Sub txtsupplierphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsupplierphone.KeyPress
        Dim allownos As String = "0123456789"
        If Not allownos.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtproductprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtproductprice.KeyPress
        Dim allownos As String = "0123456789"
        Dim allowsymbols As String = "."
        If Not allownos.Contains(e.KeyChar.ToString) And Not allowsymbols.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpurchase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpurchase.KeyPress
        Dim allownos As String = "0123456789"
        Dim allowsymbols As String = "."
        If Not allownos.Contains(e.KeyChar.ToString) And Not allowsymbols.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txttotalamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttotalamount.KeyPress

        Dim allownos As String = "0123456789"
        Dim allowsymbols As String = "."
        If  Not allownos.Contains(e.KeyChar.ToString) And Not allowsymbols.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtproductdescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtproductdescription.KeyPress
        Dim allowchar As String = "abcdefghijklmnopqrstuvwxyz"
        Dim allownos As String = "0123456789"
        Dim allowsymbols As String = "."
        If Not allowchar.Contains(e.KeyChar.ToString) And Not allownos.Contains(e.KeyChar.ToString) And Not allowsymbols.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtsupplieremail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsupplieremail.KeyPress
        Dim allowchar As String = "abcdefghijklmnopqrstuvwxyz"
        Dim allownos As String = "0123456789"
        Dim allowsymbols As String = "@."

        If Not allownos.Contains(e.KeyChar.ToString) And Not allowchar.Contains(e.KeyChar.ToString) And Not allowsymbols.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnproductclear_Click(sender As Object, e As EventArgs) Handles btnproductclear.Click
        openchildform(New AddProductfrm)
    End Sub
End Class