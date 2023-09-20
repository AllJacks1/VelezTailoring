Public Class orderView1
    Private Sub btn_addPayment_Click(sender As Object, e As EventArgs) Handles btn_addPayment.Click
        UserControlManager.showOrderView2(view_record.ActiveForm)
    End Sub
End Class
