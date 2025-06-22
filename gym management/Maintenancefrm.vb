Public Class Maintenancefrm


    Private currentform As Form = Nothing

    Public Sub openchildform(childform As Form)
        If currentform IsNot Nothing Then
            currentform.Close()
        End If
        currentform = childform
        currentform.TopLevel = False
        currentform.FormBorderStyle = FormBorderStyle.None
        currentform.Dock = DockStyle.Fill
        maintenancepanel.Controls.Add(childform)
        maintenancepanel.Tag = childform
        childform.BringToFront()
        childform.Show()
    End Sub

    Private Sub btnplansupdate_Click(sender As Object, e As EventArgs) Handles btnplansupdate.Click
        Accleftpanel.Visible = False

        electribillleftpanel.Visible = False
        updateplanleftpanel.Visible = True
        gymequipleftpanel.Visible = False
        Mainfrm.menubarclicktxt.Text = "Update Plans Price"
        openchildform(New Plansfrm)
    End Sub

    Private Sub btnstockmanage_Click(sender As Object, e As EventArgs) Handles btnstockmanage.Click
        Accleftpanel.Visible = True
        electribillleftpanel.Visible = False
        updateplanleftpanel.Visible = False
        gymequipleftpanel.Visible = False
        Mainfrm.menubarclicktxt.Text = "Add Product"
        openchildform(New AddProductfrm)
    End Sub

    Private Sub Maintenancefrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnstockmanage.PerformClick()
    End Sub

    Private Sub btnelectricitybills_Click(sender As Object, e As EventArgs) Handles btnelectricitybills.Click
        Accleftpanel.Visible = False
        electribillleftpanel.Visible = True
        updateplanleftpanel.Visible = False
        gymequipleftpanel.Visible = False
        Mainfrm.menubarclicktxt.Text = "Electricity Bills"
        openchildform(New gymelectricitybill)
    End Sub

    Private Sub btngymequipment_Click(sender As Object, e As EventArgs) Handles btngymequipment.Click
        Accleftpanel.Visible = False
        electribillleftpanel.Visible = False
        updateplanleftpanel.Visible = False
        gymequipleftpanel.Visible = True
        Mainfrm.menubarclicktxt.Text = "Gym Equipment"
        openchildform(New gymequipmentfrm)
    End Sub
End Class