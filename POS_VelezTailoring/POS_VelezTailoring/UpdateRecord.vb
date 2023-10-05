Public Class UpdateRecord
    Private initialDescription As String ' Store the initial description

    Private Sub UpdateRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Store the initial value of description when the form is loaded
        initialDescription = txt_description.Text
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Dispose()
    End Sub

    Private Sub pb_exit_Click(sender As Object, e As EventArgs) Handles pb_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim id, name, status, description, overallPrice, orderPayment, deadline As String
        id = txt_orderid.Text
        name = txt_name.Text
        status = txt_status.Text

        description = txt_description.Text
        overallPrice = txt_price.Text
        orderPayment = txt_pay.Text
        deadline = txt_dead.Text


        If String.IsNullOrEmpty(txt_name.Text) Or String.IsNullOrEmpty(txt_status.Text) Or String.IsNullOrEmpty(txt_price.Text) Or String.IsNullOrEmpty(txt_pay.Text) Or String.IsNullOrEmpty(txt_dead.Text) Then
            MsgBox("YOU LEFT A FIELD BLANK! TRY AGAIN.", vbCritical, "Velez Tailoring")
            If initialDescription = description Then
                ' Description has been modified
                MsgBox("UPDATE OVERALL PRICE", vbExclamation, "Velez Tailoring")
            Else
                updateOrder(id, name, status, description, overallPrice, orderPayment, deadline)

            End If
        ElseIf Not IsNumeric(overallPrice) Or Not IsNumeric(orderPayment) Then
            MsgBox("OVERALL PRICE AND ORDER PAYMENT MUST BE A NUMBER! ", vbCritical, "VELEZ TAILORING")
            txt_price.Clear()
            txt_pay.Clear()

        Else
            ' The description is not modified; you can proceed to update the order
            updateOrder(id, name, status, description, overallPrice, orderPayment, deadline)

            Me.Close()
        End If
    End Sub
End Class
