Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class orderView1
    Private orderId As Integer



    Public Sub SetOrderId(orderIdValue As Integer)

        orderId = orderIdValue
        open_conn()

        Dim nOrderId, NorderStatus As String
        Dim query As String = "SELECT order_id, order_status FROM orders_tbl WHERE order_id = " & orderId
        Using command As New SQLiteCommand(query, sqlite_conn)
            Using reader As SQLiteDataReader = command.ExecuteReader()
                If reader.Read() Then

                    nOrderId = reader("order_id")
                    NorderStatus = reader("order_status").ToString()

                    MessageBox.Show($"Order ID: {nOrderId}, Order Status: {NorderStatus}")

                    Dim text1 As String
                    text1 = "Tite"
                    txt_orderid.Text = text1
                    txt_status.Text = NorderStatus
                Else

                    MessageBox.Show("No data found.")
                End If
            End Using
        End Using



    End Sub



    Private Sub btn_addPayment_Click(sender As Object, e As EventArgs) Handles btn_addPayment.Click
        UserControlManager.showOrderView2(view_record.ActiveForm)
    End Sub

    Private Sub orderView1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim text1 As String
        text1 = "Tite"
        txt_orderid.Text = text1

    End Sub
End Class
