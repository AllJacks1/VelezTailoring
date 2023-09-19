﻿Imports System.Data.SQLite

Module Database

    Public sqlite_conn As New SQLiteConnection("Data Source = " & Application.StartupPath & "\user_tbl.db")
    Dim adapter As SQLiteDataAdapter

    Public Sub open_conn()
        Try
            If sqlite_conn.State = ConnectionState.Closed Then
                sqlite_conn.Open()

            End If
        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message, vbCritical)

        End Try
    End Sub
    Public Sub close_conn()
        Try
            If sqlite_conn.State = ConnectionState.Open Then
                sqlite_conn.Close()

            End If
        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message, vbCritical)

        End Try
    End Sub

    Public Sub user_login(ByVal username As String, ByVal password As String)
        Try
            open_conn()
            Dim sql_command As New SQLiteCommand($"SELECT * FROM user_tbl WHERE `user_name` = '{username}' And `user_password` = '{password}';", sqlite_conn)
            Dim reader As SQLiteDataReader = sql_command.ExecuteReader
            If reader.Read Then
                MsgBox("REGISTERED SUCCESSFULLY", vbInformation)
                MessageBox.Show("Welcome user: " & reader.GetString(1), "Velez Tailoring")
                Dashboard.Show()
                Form1.Close()
            Else
                MsgBox("YOUR CREDENTIALS DON'T MATCH AN" & vbCrLf & "ACCOUNT IN OUR SYSTEM.", vbCritical, "Velez Tailoring")

            End If
        Catch ex As SQLiteException
        Finally
            close_conn()
        End Try


    End Sub

    Public Sub user_register(ByVal username As String, ByVal password As String)
        Try
            open_conn()
            Dim sql_command As New SQLiteCommand($"INSERT INTO user_tbl (`user_name`,`user_password`) VALUES ('{username}', '{password}');", sqlite_conn)
            sql_command.ExecuteNonQuery()
            MsgBox("REGISTERED SUCCESSFULLY", vbInformation)

        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message, vbCritical)
        Finally
            close_conn()

        End Try
    End Sub

    'TRANSACTION

    Public Sub transaction(ByVal name As String, ByVal contact_number As String, ByVal product_type As String, ByVal overall_price As Integer, ByVal down_payment As Integer, ByVal estimated_time As String)
        Try
            open_conn()

            'Insert into customer_tbl and retrieve the auto-incremented customer_id
            Dim sql_command As New SQLiteCommand($"INSERT INTO customer_tbl ('customer_name','customer_number') VALUES ('{name}','{contact_number}'); SELECT last_insert_rowid();", sqlite_conn)
            Dim customer_id As Integer = CInt(sql_command.ExecuteScalar())

            'Insert into product_tbl and retrieve the auto-incremented prod_id
            Dim sql_command2 As New SQLiteCommand($"INSERT INTO product_tbl ('prod_type','prod_price') VALUES ('{product_type}','{overall_price}'); SELECT last_insert_rowid();", sqlite_conn)
            Dim prod_id As Integer = CInt(sql_command2.ExecuteScalar())

            'Insert into orders_tbl using the retrieved customer_id and product_id
            Dim sql_command3 As New SQLiteCommand($"INSERT INTO orders_tbl ('customer_id', 'prod_id', 'order_status', 'order_payment', 'order_date', 'order_deadline') VALUES ('{customer_id}', '{prod_id}', 'unfulfilled', '{down_payment}', '{Date.Now}', '{estimated_time}')", sqlite_conn)
            sql_command3.ExecuteNonQuery()

            MsgBox("TRANSACTION COMPLETE.", vbInformation)
        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message, vbCritical)
        Finally
            close_conn()
        End Try
    End Sub
    Public Sub displayOrders(ByVal usercontrol As orders_panel)
        Try
            open_conn()
            Dim adapter As New SQLiteDataAdapter("SELECT orders_tbl.order_id as 'Order ID',customer_tbl.customer_name as 'Customer name', orders_tbl.order_status as 'Order status', product_tbl.prod_price as 'Overall price',orders_tbl.order_payment as 'Order payment', orders_tbl.order_date as 'Order date', orders_tbl.order_deadline as 'Order deadline' 
            FROM orders_tbl INNER JOIN customer_tbl ON orders_tbl.customer_id = customer_tbl.customer_id INNER JOIN product_tbl ON orders_tbl.prod_id = product_tbl.prod_id WHERE order_status = 'unfulfilled'", sqlite_conn)
            Dim table As New DataTable
            adapter.Fill(table)
            usercontrol.display_orderDGV.DataSource = table
        Catch ex As SQLiteException

        Finally
            close_conn()

        End Try
    End Sub


End Module
