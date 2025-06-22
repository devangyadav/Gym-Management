Imports System.Data.SqlClient
Imports System.IO
Public Class gymequipmentfrm

    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim dr As SqlDataReader

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim expirydate As Date
        Try
            If txtequipname.Text = Nothing Or txtequipquantity.Text = Nothing Or txtpurchasedate.Text = Nothing Or txtamount.Text = Nothing Then
                MsgBox("please enter value")
            Else
                expirydate = DateTime.Now.AddMonths(2)
                cmd = New SqlCommand("INSERT INTO gymequipmentmst (equipmentimage,equipmentname,quntity,date,amount) VALUES (@equipimg,'" & txtequipname.Text & "','" & txtequipquantity.Text & "','" & txtpurchasedate.Text & "','" & txtamount.Text & "')", con)
                Dim ms As New MemoryStream
                Dim bmpimage As New Bitmap(equipmentphoto.Image)
                bmpimage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim data As Byte() = ms.GetBuffer

                Dim p As New SqlParameter("@equipimg", SqlDbType.Image)
                p.Value = data
                cmd.Parameters.Add(p)
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
            con.Open()
            cmd = New SqlCommand("SELECT * FROM gymequipmentmst order by id", con)
            dt = New DataTable
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            gymequipdv.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                dr = cmd.ExecuteReader
                dr.Read()
                Dim imgarray() As Byte = dt.Rows(i).Item("equipmentimage")
                Dim ms As New System.IO.MemoryStream(imgarray)
                dr.Close()
                Dim img As Image = Image.FromStream(ms)

                gymequipdv.Rows.Add()
                gymequipdv.Rows(i).Cells("no").Value = dt.Rows(i).Item("id").ToString
                gymequipdv.Rows(i).Cells("equipimage").Value = resizeimage(img, 92, 82)
                gymequipdv.Rows(i).Cells("equipname").Value = dt.Rows(i).Item("equipmentname").ToString
                gymequipdv.Rows(i).Cells("equipquan").Value = dt.Rows(i).Item("quntity").ToString
                gymequipdv.Rows(i).Cells("buydate").Value = Format(CDate(dt.Rows(i).Item("date")), "d")
                gymequipdv.Rows(i).Cells("amount").Value = dt.Rows(i).Item("amount").ToString
            Next
            con.Close()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
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

    Private Sub gymequipmentfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpurchasedate.MaxDate = Date.Today
        txtpurchasedate.MinDate = Date.Today.AddMonths(-1)
        showdataingv()
    End Sub

    Private Sub btnaddproduct_Click(sender As Object, e As EventArgs) Handles btnaddproduct.Click
        openimage.Title = "Select Images"
        openimage.InitialDirectory = "D:\"
        openimage.Filter = "Images (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG"
        openimage.RestoreDirectory = True
        openimage.FileName = ""
        openimage.Multiselect = False
        If openimage.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblphoto.Visible = False
            equipmentphoto.Image = Image.FromFile(openimage.FileName)
            equipmentphoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub
End Class