Public Class ViewRecord
    Private Sub pb_exit_Click(sender As Object, e As EventArgs) Handles pb_exit.Click
        Me.Close()
    End Sub

    Private Sub pb_minimize_Click(sender As Object, e As EventArgs) Handles pb_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_addPayment_Click(sender As Object, e As EventArgs) Handles btn_addPayment.Click
        Dim addPayment = New AddPayment
        Dim orderIdValue As Integer = Integer.Parse(txt_orderid.Text)
        addPayment.Show()
        addpaymentview(orderIdValue, addPayment.txt_totalPayment, addPayment.txt_overallPayment, addPayment.txt_orderid)
        Me.Close()
    End Sub
End Class