Imports System.Data.SQLite

Public Class SalesPanel
    Private Sub btn_todayEarningsDetail_Click(sender As Object, e As EventArgs) Handles btn_todayEarningsDetail.Click
        Dim choice = MessageBox.Show("Only The Manager can View this Information. You need to login your credentials!", "Proper Credentials Needed", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If (choice = 1) Then
            Form1.Show()
        End If
    End Sub

    Private Sub btn_monthEarningsDetail_Click(sender As Object, e As EventArgs) Handles btn_monthEarningsDetail.Click
        Form1.Show()
    End Sub

    Private Sub SalesPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        test(lbl_daily)
    End Sub


End Class
