Imports System.Data.SQLite
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Guna.UI2.WinForms

Module Database

    Public sqlite_conn As New SQLiteConnection("Data Source = " & Application.StartupPath & "\user_tbl.db")
    Dim adapter As SQLiteDataAdapter
    Dim dsset As New DataSet

    'OPENING CONNECTION
    Public Sub open_conn()
        Try
            If sqlite_conn.State = ConnectionState.Closed Then
                sqlite_conn.Open()

            End If
        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message, vbCritical)

        End Try

    End Sub

    'CLOSING CONNECTION
    Public Sub close_conn()
        Try
            If sqlite_conn.State = ConnectionState.Open Then
                sqlite_conn.Close()

            End If
        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message, vbCritical)

        End Try

    End Sub

    'LOGIN
    Public Function user_login(ByVal username As String, ByVal password As String)
        Try
            open_conn()
            Dim sql_command As New SQLiteCommand($"SELECT * FROM user_tbl WHERE `user_name` = '{username}' And `user_password` = '{password}';", sqlite_conn)
            Dim reader As SQLiteDataReader = sql_command.ExecuteReader
            If reader.Read Then
                MsgBox("REGISTERED SUCCESSFULLY", vbInformation, "Velez Tailoring")
                MessageBox.Show("Welcome user: " & reader.GetString(1), "Velez Tailoring")
                Dashboard.Show()
                Form1.Close()
                Return 1
            Else
                MsgBox("YOUR CREDENTIALS DON'T MATCH AN" & vbCrLf & "ACCOUNT IN OUR SYSTEM.", vbCritical, "Velez Tailoring")

                Return 2
            End If
        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message, vbCritical, "Velez Tailoring")
        Finally
            close_conn()
        End Try
        Return 0
    End Function

    'REGISTER ACCOUNT
    Public Sub user_register(ByVal username As String, ByVal password As String)
        Try
            open_conn()
            Dim sql_command As New SQLiteCommand($"INSERT INTO user_tbl (`user_name`,`user_password`) VALUES ('{username}', '{password}');", sqlite_conn)
            sql_command.ExecuteNonQuery()
            MsgBox("REGISTERED SUCCESSFULLY", vbInformation, "Velez Tailoring")

        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message, vbCritical, "Velez Tailoring")
        Finally
            close_conn()

        End Try

    End Sub

    'ADD ORDERS
    Public Sub addOrders(ByVal name As String, ByVal contact_number As String, ByVal product_type As String, ByVal overall_price As Integer, ByVal down_payment As Integer, ByVal estimated_time As String)
        Dim currentDate As DateTime = DateTime.Now
        Dim formattedDate As String = currentDate.ToString("yyyy/MM/dd")


        Try
            open_conn()

            'Insert into customer_tbl and retrieve the auto-incremented customer_id
            Dim sql_command As New SQLiteCommand($"INSERT INTO customer_tbl ('customer_name','customer_number', 'customer_status') VALUES ('{name}','{contact_number}','active'); SELECT last_insert_rowid();", sqlite_conn)
            Dim customer_id As Integer = CInt(sql_command.ExecuteScalar())
            'Insert into product_tbl and retrieve the auto-incremented prod_id
            Dim sql_command2 As New SQLiteCommand($"INSERT INTO product_tbl ('prod_type','prod_price') VALUES ('{product_type}','{overall_price}'); SELECT last_insert_rowid();", sqlite_conn)
            Dim prod_id As Integer = CInt(sql_command2.ExecuteScalar())
            'Insert into orders_tbl using the retrieved customer_id and product_id
            Dim sql_command3 As New SQLiteCommand($"INSERT INTO orders_tbl ('customer_id', 'prod_id', 'order_status', 'order_payment', 'order_date', 'order_deadline') VALUES ('{customer_id}', '{prod_id}', 'unfulfilled', '{down_payment}', '{formattedDate}', '{estimated_time}')", sqlite_conn)
            sql_command3.ExecuteNonQuery()
            MsgBox("TRANSACTION COMPLETE.", vbInformation, "Velez Tailoring")
        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message, vbCritical, "Velez Tailoring")
        Finally
            close_conn()
        End Try
    End Sub

    ''FOR UPDATING ORDERS
    Public Sub updateOrder(ByVal orderIdValue As Integer, ByVal customerName As String, ByVal orderStatus As String, ByVal description As String,
                           ByVal overallPrice As Integer, ByVal orderPayment As Integer, ByVal deadline As String)
        Try
            open_conn()
            Dim sql_command As New SQLiteCommand($"UPDATE customer_tbl SET customer_name = '{customerName}' 
            WHERE customer_id = (SELECT customer_id FROM orders_tbl WHERE order_id = '{orderIdValue}'); ", sqlite_conn)
            sql_command.ExecuteNonQuery()
            Dim sql_command2 As New SQLiteCommand($"Update product_tbl SET prod_type = '{description}', prod_price='{overallPrice}' 
            WHERE prod_id = (SELECT prod_id FROM orders_tbl WHERE order_id = '{orderIdValue}'); ", sqlite_conn)
            sql_command2.ExecuteNonQuery()
            Dim sql_command3 As New SQLiteCommand($"UPDATE orders_Tbl SET order_status = '{orderStatus}', order_payment = '{orderPayment}', order_deadline = '{deadline}' 
            WHERE order_id = '{orderIdValue}' ", sqlite_conn)
            sql_command3.ExecuteNonQuery()
            MsgBox("ORDER UPDATED.", vbInformation, "Velez Tailoring")
            UserControlManager.showOrders()

        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message, vbCritical, "Velez Tailoring")

        Finally
            close_conn()

        End Try

    End Sub

    ''FOR DELETING ORDERS
    Public Sub removeOrder(ByVal orderIdValue As Integer)
        Try
            open_conn()
            Dim sql_command As New SQLiteCommand($"UPDATE customer_tbl SET customer_status = 'inactive' 
            WHERE customer_id = (SELECT customer_id FROM orders_tbl WHERE order_id = '{orderIdValue}'); ", sqlite_conn)
            sql_command.ExecuteNonQuery()
            MsgBox("ORDER REMOVED.", vbInformation, "Velez Tailoring")
            UserControlManager.showOrders()

        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message, vbCritical, "Velez Tailoring")

        Finally
            close_conn()

        End Try

    End Sub

    'FOR DISPLAYING ORDERS
    Public Sub displayOrders(ByVal usercontrol As OrdersPanel)
        Try
            open_conn()
            Dim adapter As New SQLiteDataAdapter("SELECT orders_tbl.order_id as 'Order ID', customer_tbl.customer_name as 'Customer name', orders_tbl.order_status as 'Order status', 
            product_tbl.prod_price as 'Overall price', orders_tbl.order_payment as 'Order payment', orders_tbl.order_date as 'Order date', orders_tbl.order_deadline as 'Order deadline' 
            FROM orders_tbl INNER JOIN customer_tbl ON orders_tbl.customer_id = customer_tbl.customer_id INNER JOIN product_tbl ON orders_tbl.prod_id = product_tbl.prod_id WHERE customer_status = 'active' ", sqlite_conn)
            Dim table As New DataTable
            adapter.Fill(table)
            usercontrol.display_orderDGV.DataSource = table
        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message, vbCritical, "Velez Tailoring")

        Finally
            close_conn()

        End Try

    End Sub

    ''FOR SEARCHING ORDERS
    Public Sub searchOrder(ByVal txtSearch As String, ByVal dgTable As Guna2DataGridView)
        Try
            open_conn()
            Dim searchString As String = txtSearch
            Dim sql As String = "SELECT orders_tbl.order_id as 'Order ID', customer_tbl.customer_name as 'Customer name', orders_tbl.order_status as 'Order status',
        product_tbl.prod_price as 'Overall price', orders_tbl.order_payment as 'Order payment', orders_tbl.order_date as 'Order date', orders_tbl.order_deadline as
        'Order deadline' FROM orders_tbl INNER JOIN customer_tbl ON orders_tbl.customer_id = customer_tbl.customer_id INNER JOIN product_tbl ON orders_tbl.prod_id = 
        product_tbl.prod_id WHERE order_status = 'unfulfilled' AND customer_tbl.customer_name LIKE '%" & searchString & "%'"
            Dim adapter As New SQLiteDataAdapter(sql, sqlite_conn)
            Dim table As New DataTable
            dgTable.DataSource = table
            adapter.Fill(table)
        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message, vbCritical, "Velez Tailoring")

        Finally
            close_conn()
        End Try

    End Sub

    ''TO RETRIEVE ORDER INFOs
    Public Sub SetOrderId(ByVal orderIdValue As Integer, ByVal orderIdtextfield As Guna2TextBox, ByVal statustextfield As Guna2TextBox, ByVal customerNameTextField As Guna2TextBox, ByVal orderDatetextfield As Guna2TextBox,
     ByVal orderDeadtextfield As Guna2TextBox, ByVal orderAllPricetextfield As Guna2TextBox, ByVal descriptionfield As Guna2TextBox, ByVal orderPaymenttextfield As Guna2TextBox, ByVal orderBalanceTextField As Guna2TextBox)
        Try
            open_conn()

            Dim nOrderId, NorderStatus, NorderDate, NorderDeath, Nprod_type, NorderPrice, NorderPay, NcustomerName As String
            Dim query As String = "SELECT orders_tbl.order_id, orders_tbl.order_status, orders_tbl.order_payment, " &
                         "orders_tbl.order_date, orders_tbl.order_deadline, product_tbl.prod_price, product_tbl.prod_type, " &
                         "customer_tbl.customer_name " &
                         "FROM orders_tbl " &
                         "INNER JOIN product_tbl ON orders_tbl.prod_id = product_tbl.prod_id " &
                         "INNER JOIN customer_tbl ON orders_tbl.customer_id = customer_tbl.customer_id " &
                         "WHERE orders_tbl.order_id = " & orderIdValue
            Using command As New SQLiteCommand(query, sqlite_conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    If reader.Read() Then

                        nOrderId = reader("order_id")
                        NorderStatus = reader("order_status").ToString()
                        NcustomerName = reader("customer_name").ToString()

                        NorderDate = reader("order_date").ToString()

                        NorderDeath = reader("order_deadline").ToString()
                        NorderPrice = reader("prod_price").ToString()
                        Nprod_type = reader("prod_type").ToString
                        NorderPay = reader("order_payment").ToString()

                        orderIdtextfield.Text = nOrderId
                        statustextfield.Text = NorderStatus
                        customerNameTextField.Text = NcustomerName
                        orderDatetextfield.Text = NorderDate
                        orderDeadtextfield.Text = NorderDeath
                        orderAllPricetextfield.Text = NorderPrice
                        descriptionfield.Text = Nprod_type
                        orderPaymenttextfield.Text = NorderPay

                        Dim NorderPrices As String = reader("prod_price").ToString()
                        Dim NorderPays As String = reader("order_payment").ToString()
                        Dim price As Double
                        Dim payment As Double
                        If Double.TryParse(NorderPrice, price) AndAlso Double.TryParse(NorderPay, payment) Then
                            Dim result As Double = price - payment
                            orderBalanceTextField.Text = result
                        End If

                    Else

                        MessageBox.Show("No data found.")
                    End If
                End Using
            End Using

        Catch ex As SQLiteException
            MsgBox("Error: " & ex.Message, vbCritical)

        Finally
            close_conn()

        End Try
    End Sub

    Public Sub addpaymentview(ByVal orderIdValue As Integer, ByVal totalPaytextfield As Guna2TextBox, ByVal overallPaytextfield As Guna2TextBox, ByVal orderIdtextfield As Guna2TextBox)
        Try
            open_conn()
            Dim ntotalpay, noverallpay, nOrderId As String
            Dim query As String = "SELECT orders_tbl.order_id,orders_tbl.order_id, orders_tbl.order_payment, product_tbl.prod_price " &
             "FROM orders_tbl " &
             "INNER JOIN product_tbl ON orders_tbl.prod_id = product_tbl.prod_id " &
             "WHERE orders_tbl.order_id = " & orderIdValue

            Using command As New SQLiteCommand(query, sqlite_conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        nOrderId = reader("order_id")
                        ntotalpay = reader("order_payment").ToString()
                        noverallpay = reader("prod_price").ToString()
                        totalPaytextfield.Text = ntotalpay
                        overallPaytextfield.Text = noverallpay
                        orderIdtextfield.Text = nOrderId
                    Else
                        MessageBox.Show("Order not found in the database.")
                    End If
                End Using
            End Using
        Catch ex As SQLiteException
            MessageBox.Show("An error occurred while retrieving payment data: " & ex.Message)
        Finally

            close_conn()
        End Try
    End Sub

    Public Sub addpaymenttotal(ByVal orderIdValue As Integer, ByVal addpaymenttextfield As Double)
        Dim ntotalpay, newtotal As Double
        open_conn()
        Dim query As String = "SELECT order_payment FROM orders_tbl WHERE order_id = " & orderIdValue
        Using command As New SQLiteCommand(query, sqlite_conn)
            Using reader As SQLiteDataReader = command.ExecuteReader()
                If reader.Read() Then
                    ntotalpay = reader("order_payment")
                    newtotal = ntotalpay + addpaymenttextfield
                    Dim query2 As String = "UPDATE orders_tbl SET order_payment = " & newtotal & " WHERE order_id = " & orderIdValue
                    Using updateCommand As New SQLiteCommand(query2, sqlite_conn)
                        Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MsgBox("PAYMENT UPDATED SUCCESSFULLY!", vbInformation, "Velez Tailoring")

                        Else
                            MessageBox.Show("Failed to update payment.")
                        End If
                    End Using
                Else
                    MessageBox.Show("Order not found in the database.")
                End If
            End Using
        End Using
        updatePaymentStatus(orderIdValue)
    End Sub

    Public Sub updatePaymentStatus(ByVal orderIdValue As Integer)
        Try
            open_conn()
            Dim ntotalspay, noverallspay As String
            Dim queryall As String = "SELECT orders_tbl.order_id,orders_tbl.order_id, orders_tbl.order_payment, product_tbl.prod_price " &
             "FROM orders_tbl " &
             "INNER JOIN product_tbl ON orders_tbl.prod_id = product_tbl.prod_id " &
             "WHERE orders_tbl.order_id = " & orderIdValue

            Using command As New SQLiteCommand(queryall, sqlite_conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ntotalspay = reader("order_payment").ToString()
                        noverallspay = reader("prod_price").ToString()


                        If ntotalspay = noverallspay Then
                            Dim query3 As String = "UPDATE orders_tbl SET order_status = 'fulfilled' WHERE order_id = " & orderIdValue

                            Using updateCommand As New SQLiteCommand(query3, sqlite_conn)
                                Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()
                                UserControlManager.showOrders()
                            End Using
                        End If
                    Else
                        MessageBox.Show("Order not found in the database.")
                    End If
                End Using
            End Using
        Catch ex As SQLiteException
            MessageBox.Show("An error occurred while retrieving payment data: " & ex.Message)
        Finally
            close_conn()

        End Try
    End Sub


    Public Sub getDailyIncome(ByVal labeldaily)
        open_conn()
        Dim currentDate As DateTime = DateTime.Now
        Dim formattedDate As String = currentDate.ToString("yyyy/MM/dd")

        Try
            Dim query As String = "SELECT SUM(order_payment) FROM orders_tbl WHERE order_date = '" & formattedDate & "'"
            Using command As New SQLiteCommand(query, sqlite_conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    If reader.Read() Then

                        If Not reader.IsDBNull(0) Then
                            Dim sumValue As Double = reader.GetDouble(0)
                            labeldaily.Text = "₱" & sumValue.ToString()
                        Else
                            labeldaily.text = "₱ 0.00"
                        End If
                    Else
                        MsgBox("No data found for " & formattedDate)
                    End If
                End Using
            End Using
        Catch ex As SQLiteException

            MsgBox("Error: " & ex.Message)
        Finally
            close_conn()

        End Try
    End Sub
    Public Sub getMonthlyIncome(ByVal labelMonthly)
        Try
            open_conn()
            Dim currentDate As DateTime = DateTime.Now
            Dim currentYear As Integer = currentDate.Year
            Dim currentMonth As Integer = currentDate.Month

            ' Format the current year and month as a string in 'yyyy/MM' format
            Dim currentYearMonth As String = $"{currentYear:D4}/{currentMonth:D2}"

            Dim sql_command As New SQLiteCommand($"SELECT SUM(order_payment) FROM orders_tbl WHERE order_date LIKE '{currentYearMonth}%'", sqlite_conn)
            Dim reader As SQLiteDataReader = sql_command.ExecuteReader()
            If reader.Read() Then
                If Not reader.IsDBNull(0) Then
                    Dim sumValue As Double = reader.GetDouble(0)
                    labelMonthly.Text = "₱" & sumValue.ToString()

                Else
                    labelMonthly.Text = "₱ 0.00"
                End If
            Else
                MsgBox("No data found for " & currentYearMonth)
            End If
        Catch ex As SQLiteException
            ' Handle any SQLite exceptions here
        Finally
            close_conn()
        End Try
    End Sub

End Module

