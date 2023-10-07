Imports System.Data.SQLite

Public Class OrdersPanel

    Dim login As Form1
    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        If display_orderDGV.SelectedCells.Count > 0 Then
            Dim selectedOrderId As Integer
            If Integer.TryParse(display_orderDGV.SelectedCells(0).Value.ToString(), selectedOrderId) Then
                Dim viewRecord = New ViewRecord
                viewRecord.Show()
                SetOrderId(selectedOrderId, viewRecord.txt_orderid, viewRecord.txt_status, viewRecord.txt_name, viewRecord.txt_date, viewRecord.txt_dead, viewRecord.txt_price, viewRecord.txt_description, viewRecord.txt_pay, viewRecord.txt_balance)
            Else
                MessageBox.Show("Invalid order_id value.")
            End If
        End If
    End Sub


    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Database.searchOrder(txt_search.Text, display_orderDGV)
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim choice = MessageBox.Show("Only The Manager can Update this Information. You need to login your credentials!", "Proper Credentials Needed", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If (choice = 1) Then
            login = New Form1
            AddHandler login.Disposed, AddressOf login_DisposedUpdate
            login.Show()
        End If
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click

        Dim choice2 As DialogResult = MessageBox.Show("Are you sure you want to remove?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        If (choice2 = DialogResult.OK) Then
            Dim choice = MessageBox.Show("Only The Manager can Delete this Information. You need to login your credentials!", "Proper Credentials Needed", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            If (choice = 1) Then
                login = New Form1
                AddHandler login.Disposed, AddressOf login_DisposedRemove
                login.Show()
            End If
        Else
            MessageBox.Show("Operation canceled.")
        End If

    End Sub

    Private Sub login_DisposedUpdate(sender As Object, e As EventArgs)
        If login.DialogResult = DialogResult.OK Then
            getData()
        End If
    End Sub
    Private Sub login_DisposedRemove(sender As Object, e As EventArgs)
        If login.DialogResult = DialogResult.OK Then
            removeData()
        End If
    End Sub

    Public Sub getData()
        If display_orderDGV.SelectedCells.Count > 0 Then
            Dim selectedOrderId As Integer
            If Integer.TryParse(display_orderDGV.SelectedCells(0).Value.ToString(), selectedOrderId) Then
                Dim updateRecord = New UpdateRecord
                updateRecord.Show()
                SetOrderId(selectedOrderId, updateRecord.txt_orderid, updateRecord.txt_status, updateRecord.txt_name, updateRecord.txt_date, updateRecord.txt_dead, updateRecord.txt_price, updateRecord.txt_description, updateRecord.txt_pay, updateRecord.txt_balance)
                Dim desc As String
                desc = updateRecord.txt_description.Text
                MsgBox(desc)
            Else
                MessageBox.Show("Invalid order_id value.")
            End If
        End If
    End Sub

    Public Sub removeData()
        If display_orderDGV.SelectedCells.Count > 0 Then
            Dim selectedOrderId As Integer = display_orderDGV.SelectedCells(0).Value
            removeOrder(selectedOrderId)
        Else
            MessageBox.Show("Invalid order_id value.")
        End If
    End Sub
End Class