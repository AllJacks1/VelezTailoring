
Module UserControlManager

    Public Sub addUserControl(userControl As UserControl)
        Dashboard.dashCanvas.Controls.Clear()
        Dashboard.dashCanvas.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub
    Public Sub showSales()
        Dim salesControl = New SalesPanel
        Dashboard.btn_orders.Checked = False
        Dashboard.btn_transaction.Checked = False
        Dashboard.btn_sales.Checked = True
        addUserControl(salesControl)
    End Sub

    Public Sub showOrders()
        Dim orderControl = New OrdersPanel
        Dashboard.btn_orders.Checked = True
        Dashboard.btn_transaction.Checked = False
        Dashboard.btn_sales.Checked = False
        addUserControl(orderControl)
        displayOrders(orderControl)

    End Sub

    Public Sub showTransactions()
        Dim transactionControl = New TransactionPanel
        Dashboard.btn_orders.Checked = False
        Dashboard.btn_transaction.Checked = True
        Dashboard.btn_sales.Checked = False
        addUserControl(transactionControl)
    End Sub

End Module
