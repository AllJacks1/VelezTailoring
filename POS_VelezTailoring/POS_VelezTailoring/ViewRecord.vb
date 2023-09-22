Public Class ViewRecord
    Private Sub pb_exit_Click(sender As Object, e As EventArgs) Handles pb_exit.Click
        Me.Close()
    End Sub

    Private Sub pb_minimize_Click(sender As Object, e As EventArgs) Handles pb_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_addPayment_Click(sender As Object, e As EventArgs) Handles btn_addPayment.Click
        Dim addPayment = New AddPayment
        addPayment.Show()
    End Sub


End Class