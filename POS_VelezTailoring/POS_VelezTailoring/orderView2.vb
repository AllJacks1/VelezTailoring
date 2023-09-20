Public Class orderView2
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        'UserControlManager.showOrderView1(view_record.ActiveForm, )
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim choice = MessageBox.Show("Are you sure that the information entered is correct?", "Add Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (choice = DialogResult.Yes) Then
            MsgBox("Information is saved!")
            'UserControlManager.showOrderView1(view_record.ActiveForm)
        End If
    End Sub

    Private Sub orderView2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
