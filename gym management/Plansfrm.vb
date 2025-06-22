Imports System.Data.SqlClient

Public Class Plansfrm
    Dim con As SqlConnection = New SqlConnection("Data Source=RAO-SAHAB\SQLEXPRESS;Initial Catalog=gymmanagement;Integrated Security=True")
    Dim cmd As SqlCommand
    Private Sub btnplansupdate_Click(sender As Object, e As EventArgs) Handles btnplansupdate.Click
        If txtcardioplans.Text = Nothing Or txtstrengthplans.Text = Nothing Or txtcardiostrengthplans.Text = Nothing Or txtpersonalplans.Text = Nothing Then
            MsgBox("Please Enter All Values")
        Else
            cmd = New SqlCommand("UPDATE gymplansmst SET cardio =" & txtcardioplans.Text & ",strength =" & txtstrengthplans.Text & ",cardioandstrength =" & txtcardiostrengthplans.Text & ",personal = " & txtpersonalplans.Text & " WHERE months ='" & txtmonthsplans.Text & "' ", con)
            con.Open()
            If cmd.ExecuteNonQuery Then
                MsgBox("Update Successfully")
            Else
                MsgBox("Fail")
            End If
            con.Close()
        End If
    End Sub

    Private Sub txtmonthsplans_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtmonthsplans.SelectedIndexChanged
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        cmd = New SqlCommand("select * from gymplansmst WHERE months ='" & txtmonthsplans.Text & "'", con)
        con.Open()
        rd = cmd.ExecuteReader
        rd.Read()
        Try
            If rd.HasRows() Then
                txtcardioplans.Text = rd("cardio")
                txtstrengthplans.Text = rd("strength")
                txtcardiostrengthplans.Text = rd("cardioandstrength")
                txtpersonalplans.Text = rd("personal")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub Plansfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        cmd = New SqlCommand("select * from gymplansmst WHERE months ='" & txtmonthsplans.Text & "'", con)
        con.Open()
        rd = cmd.ExecuteReader
        rd.Read()
        Try
            If rd.HasRows() Then
                txtcardioplans.Text = rd("cardio")
                txtstrengthplans.Text = rd("strength")
                txtcardiostrengthplans.Text = rd("cardioandstrength")
                txtpersonalplans.Text = rd("personal")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub txtcardioplans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcardioplans.KeyPress
        Dim allownos As String = "0123456789"
        Dim allowsymbols As String = "."
        If Not allownos.Contains(e.KeyChar.ToString) And Not allowsymbols.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtstrengthplans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstrengthplans.KeyPress
        Dim allownos As String = "0123456789"
        Dim allowsymbols As String = "."
        If Not allownos.Contains(e.KeyChar.ToString) And Not allowsymbols.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcardiostrengthplans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcardiostrengthplans.KeyPress
        Dim allownos As String = "0123456789"
        Dim allowsymbols As String = "."
        If Not allownos.Contains(e.KeyChar.ToString) And Not allowsymbols.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpersonalplans_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpersonalplans.KeyPress
        Dim allownos As String = "0123456789"
        Dim allowsymbols As String = "."
        If Not allownos.Contains(e.KeyChar.ToString) And Not allowsymbols.Contains(e.KeyChar.ToString) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class