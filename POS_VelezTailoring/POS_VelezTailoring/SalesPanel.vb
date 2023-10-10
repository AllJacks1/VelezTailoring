Imports System.Data.SQLite

Public Class SalesPanel

    Private Sub SalesPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDailyIncome(lbl_daily)
        getMonthlyIncome(lbl_month)
    End Sub
End Class
