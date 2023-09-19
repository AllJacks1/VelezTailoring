Public Class orders_panel
    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        Dim viewRecord = New view_record
        viewRecord.Show()
        UserControlManager.showOrderView1(viewRecord)
    End Sub
End Class
