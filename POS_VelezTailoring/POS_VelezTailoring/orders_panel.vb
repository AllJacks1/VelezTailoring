Imports System.Data.SQLite

Public Class orders_panel
    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click

        If display_orderDGV.SelectedCells.Count > 0 Then

            Dim selectedOrderId As Integer
            If Integer.TryParse(display_orderDGV.SelectedCells(0).Value.ToString(), selectedOrderId) Then

                Dim viewRecord = New view_record
                viewRecord.Show()
                UserControlManager.showOrderView1(viewRecord, selectedOrderId)


            Else
                MessageBox.Show("Invalid order_id value.")
            End If
        End If


    End Sub


    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Database.searchRecord(txt_search.Text, display_orderDGV)
    End Sub


End Class
