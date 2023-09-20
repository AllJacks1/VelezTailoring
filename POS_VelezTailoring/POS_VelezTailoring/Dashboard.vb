Public Class Dashboard
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_sales_Click(sender As Object, e As EventArgs) Handles btn_sales.Click
        UserControlManager.showSales()
    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click
        UserControlManager.showOrders()


    End Sub

    Private Sub btn_transaction_Click(sender As Object, e As EventArgs) Handles btn_transaction.Click
        UserControlManager.showTransactions()
    End Sub


End Class