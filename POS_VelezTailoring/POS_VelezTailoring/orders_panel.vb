Imports System.Data.SQLite

Public Class orders_panel
    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        Dim viewRecord = New view_record
        viewRecord.Show()
        UserControlManager.showOrderView1(viewRecord)
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Database.searchRecord(txt_search.Text, display_orderDGV)
    End Sub


End Class
