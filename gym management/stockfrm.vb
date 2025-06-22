Imports System.Data.SqlClient
Imports System.IO
Public Class stockfrm

    Declare Function setprocessworkingsetsize Lib "kernel32.dil" (ByVal process As IntPtr, ByVal minimumworkingsetsize As Integer, ByVal maximumworkingsetsize As Integer) As Integer

    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim dt As New DataTable
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim index As Integer


    Public Sub flushmemory()
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                setprocessworkingsetsize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myprocesses As Process() = Process.GetProcessesByName("ApplicationName")
                Dim myprocess As Process
                For Each myprocess In myprocesses
                    setprocessworkingsetsize(myprocess.Handle, -1, -1)
                Next myprocess
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub stockfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim column1 As New DataGridViewTextBoxColumn()
        column1.HeaderText = "#"
        column1.Name = "proid"
        stockdv.Columns.Add(column1)

        Dim column2 As New DataGridViewImageColumn()
        column2.HeaderText = "IMAGE"
        column2.Name = "pimage"
        stockdv.Columns.Add(column2)

        Dim column3 As New DataGridViewTextBoxColumn()
        column3.HeaderText = "NAME"
        column3.Name = "pname"
        stockdv.Columns.Add(column3)

        Dim column4 As New DataGridViewTextBoxColumn()
        column4.HeaderText = "CATEGORY"
        column4.Name = "productcategory"
        stockdv.Columns.Add(column4)

        Dim column5 As New DataGridViewTextBoxColumn()
        column5.HeaderText = "DESCRIPTION"
        column5.Name = "description"
        stockdv.Columns.Add(column5)

        Dim column6 As New DataGridViewTextBoxColumn()
        column6.HeaderText = "QTY"
        column6.Name = "quantity"
        stockdv.Columns.Add(column6)

        Dim column7 As New DataGridViewTextBoxColumn()
        column7.HeaderText = "MRP"
        column7.Name = "price"
        stockdv.Columns.Add(column7)


        loaddata()
        flushmemory()
        AddHandler Mainfrm.btnsearch.TextChanged, AddressOf btnsearch_TextChanged
    End Sub

    Public Sub btnsearch_TextChanged(sender As Object, e As EventArgs)
        If Mainfrm.menubarclicktxt.Text = "Stock Limit Products List" Then
            loaddata()
            flushmemory()
        End If
    End Sub

    Public Sub loaddata()

        Dim td As Date = Date.Today
        Try
            con.Open()
            dt.Clear()
            stockdv.Columns.Clear()
            stockdv.DataSource = Nothing
            cmd = New SqlCommand("SELECT * FROM stocksmst with (nolock) WHERE p_name LIKE '%" & Mainfrm.btnsearch.Text & "%' and expiredate > '" & td & "' order by p_id", con)
            Dim column1 As New DataGridViewTextBoxColumn()
            column1.HeaderText = "#"
            column1.Name = "proid"
            stockdv.Columns.Add(column1)

            Dim column2 As New DataGridViewImageColumn()
            column2.HeaderText = "IMAGE"
            column2.Name = "pimage"
            stockdv.Columns.Add(column2)

            Dim column3 As New DataGridViewTextBoxColumn()
            column3.HeaderText = "NAME"
            column3.Name = "pname"
            stockdv.Columns.Add(column3)

            Dim column4 As New DataGridViewTextBoxColumn()
            column4.HeaderText = "CATEGORY"
            column4.Name = "productcategory"
            stockdv.Columns.Add(column4)

            Dim column5 As New DataGridViewTextBoxColumn()
            column5.HeaderText = "DESCRIPTION"
            column5.Name = "description"
            stockdv.Columns.Add(column5)

            Dim column6 As New DataGridViewTextBoxColumn()
            column6.HeaderText = "QTY"
            column6.Name = "quantity"
            stockdv.Columns.Add(column6)

            Dim column7 As New DataGridViewTextBoxColumn()
            column7.HeaderText = "MRP"
            column7.Name = "price"
            stockdv.Columns.Add(column7)
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            stockdv.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                stockdv.Rows.Add()
                dr = cmd.ExecuteReader
                dr.Read()
                Dim imgarray() As Byte = dt.Rows(i).Item("p_image")
                Dim ms As New System.IO.MemoryStream(imgarray)
                dr.Close()
                Dim img As Image = Image.FromStream(ms)
                stockdv.Rows(i).Cells("proid").Value = dt.Rows(i).Item("p_id").ToString
                stockdv.Rows(i).Cells("pimage").Value = resizeimage(img, 92, 82)
                stockdv.Rows(i).Cells("pname").Value = dt.Rows(i).Item("p_name").ToString
                stockdv.Rows(i).Cells("productcategory").Value = dt.Rows(i).Item("productcategory").ToString
                stockdv.Rows(i).Cells("description").Value = dt.Rows(i).Item("description").ToString
                stockdv.Rows(i).Cells("price").Value = dt.Rows(i).Item("price").ToString
                stockdv.Rows(i).Cells("quantity").Value = dt.Rows(i).Item("quantity").ToString
                flushmemory()
            Next
            con.Close()
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



End Class