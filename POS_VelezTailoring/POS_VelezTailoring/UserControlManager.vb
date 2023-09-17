Module UserControlManager

    Public Sub addUserControl(userControl As UserControl)
        Dashboard.dashCanvas.Controls.Clear()
        Dashboard.dashCanvas.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub
    Public Sub showSales()
        Dim salesControl = New sales_panel
        Dashboard.btn_orders.Checked = False
        Dashboard.btn_transaction.Checked = False
        Dashboard.btn_sales.Checked = True
        addUserControl(salesControl)
    End Sub

    Public Sub showOrders()
        Dashboard.btn_orders.Checked = True
        Dashboard.btn_transaction.Checked = False
        Dashboard.btn_sales.Checked = False
    End Sub

    Public Sub showTransactions()
        Dashboard.btn_orders.Checked = False
        Dashboard.btn_transaction.Checked = True
        Dashboard.btn_sales.Checked = False
    End Sub


End Module
