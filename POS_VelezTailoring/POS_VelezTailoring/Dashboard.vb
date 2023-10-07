Public Class Dashboard
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
        Me.Dispose()
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

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserControlManager.showSales()
    End Sub
End Class