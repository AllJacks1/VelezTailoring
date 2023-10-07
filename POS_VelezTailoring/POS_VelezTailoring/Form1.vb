Imports System.Web.UI.WebControls

Public Class Form1

    Public isValid = False

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Dispose()
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
            If username.Equals("admin") And password.Equals("password123") Then
                MsgBox("Log-in Successful", vbInformation, "Velez Tailoring")
                isValid = True
                Me.DialogResult = DialogResult.OK
                Me.Dispose()
            Else
                MsgBox("YOUR CREDENTIALS DON'T MATCH AN" & vbCrLf & "ACCOUNT IN OUR SYSTEM.", vbCritical, "Velez Tailoring")
            End If
            username_txt.Clear()
            password_txt.Clear()
        End If
    End Sub

End Class
