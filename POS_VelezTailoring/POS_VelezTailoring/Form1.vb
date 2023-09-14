Public Class Form1


    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim username, password As String
        username = username_txt.Text
        password = password_txt.Text

        If String.IsNullOrEmpty(username_txt.Text) Then
            MsgBox("Enter your username!", vbCritical, "Velez Tailoring")
        ElseIf String.IsNullOrEmpty(password_txt.Text) Then
            MsgBox("Enter your password!", vbCritical, "Velez Tailoring")
        Else
            user_login(username, password)
            username_txt.Clear()
            password_txt.Clear()

        End If

    End Sub


End Class
