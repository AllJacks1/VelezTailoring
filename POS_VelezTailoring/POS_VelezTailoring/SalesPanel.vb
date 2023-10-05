Imports System.Data.SQLite

Public Class SalesPanel
    Private Sub btn_todayEarningsDetail_Click(sender As Object, e As EventArgs) 
        Dim choice = MessageBox.Show("Only The Manager can View this Information. You need to login your credentials!", "Proper Credentials Needed", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If (choice = 1) Then
            Form1.Show()
        End If
    End Sub

    Private Sub btn_monthEarningsDetail_Click(sender As Object, e As EventArgs) 
        Form1.Show()
    End Sub

    Private Sub SalesPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDailyIncome(lbl_daily)
        getMonthlyIncome(lbl_month)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lbl_month.Click

    End Sub

    Private Sub lbl_daily_Click(sender As Object, e As EventArgs) Handles lbl_daily.Click

    End Sub
End Class
