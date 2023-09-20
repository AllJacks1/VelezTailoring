Public Class view_record
    Private Sub pb_exit_Click(sender As Object, e As EventArgs) Handles pb_exit.Click
        Me.Close()
    End Sub

    Private Sub pb_minimize_Click(sender As Object, e As EventArgs) Handles pb_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub order_viewPanel_Paint(sender As Object, e As PaintEventArgs) Handles order_viewPanel.Paint

    End Sub
End Class