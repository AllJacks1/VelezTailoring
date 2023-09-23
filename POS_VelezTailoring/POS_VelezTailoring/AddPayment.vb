Public Class AddPayment
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Dispose()

    End Sub

    Private Sub pb_exit_Click(sender As Object, e As EventArgs) Handles pb_exit.Click
        Me.Close()

    End Sub

    Private Sub pb_minimize_Click(sender As Object, e As EventArgs) Handles pb_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class