Imports System.Data.SQLite

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
        Dim orderControl = New orders_panel
        Dashboard.btn_orders.Checked = True
        Dashboard.btn_transaction.Checked = False
        Dashboard.btn_sales.Checked = False
        addUserControl(orderControl)
        displayOrders(orderControl)

    End Sub

    Public Sub showTransactions()
        Dim transactionControl = New transaction_panel
        Dashboard.btn_orders.Checked = False
        Dashboard.btn_transaction.Checked = True
        Dashboard.btn_sales.Checked = False
        addUserControl(transactionControl)
    End Sub

    Public Sub showOrderView1(ByVal viewRecord As view_record)
        Dim orderView1 = New orderView1
        viewRecord.order_viewPanel.Controls.Clear()
        viewRecord.order_viewPanel.Controls.Add(orderView1)
        orderView1.BringToFront()
    End Sub
    Public Sub showOrderView2(ByVal viewRecord As view_record)
        Dim orderView2 = New orderView2
        viewRecord.order_viewPanel.Controls.Clear()
        viewRecord.order_viewPanel.Controls.Add(orderView2)
        orderView2.BringToFront()
    End Sub


End Module
