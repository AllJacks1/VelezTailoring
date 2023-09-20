Imports System.Data.SQLite

Public Class orders_panel
    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        Dim viewRecord = New view_record
        viewRecord.Show()
        UserControlManager.showOrderView1(viewRecord)
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            open_conn()
            Dim searchString As String = txt_search.Text
            Dim sql As String = "SELECT orders_tbl.order_id as 'Order ID', customer_tbl.customer_name as 'Customer name', orders_tbl.order_status as 'Order status',
        product_tbl.prod_price as 'Overall price', orders_tbl.order_payment as 'Order payment', orders_tbl.order_date as 'Order date', orders_tbl.order_deadline as
        'Order deadline' FROM orders_tbl INNER JOIN customer_tbl ON orders_tbl.customer_id = customer_tbl.customer_id INNER JOIN product_tbl ON orders_tbl.prod_id = 
        product_tbl.prod_id WHERE order_status = 'unfulfilled' AND customer_tbl.customer_name LIKE '%" & searchString & "%'"

            Dim adapter As New SQLiteDataAdapter(sql, sqlite_conn)

            Dim table As New DataTable
            adapter.Fill(table)
            display_orderDGV.DataSource = table
        Catch ex As Exception

        End Try
    End Sub


End Class
