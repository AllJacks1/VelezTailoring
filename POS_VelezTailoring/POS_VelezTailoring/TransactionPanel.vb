﻿Public Class TransactionPanel

    Private Sub save_ordertxt_Click(sender As Object, e As EventArgs) Handles save_ordertxt.Click
        Dim customer_name, customer_number, estimated_time, overall_price, down_payment, prod_type As String
        customer_name = customer_nametxt.Text
        customer_number = customer_numtxt.Text
        estimated_time = etc_dtp.Text
        overall_price = overall_pricetxt.Text
        down_payment = down_paymenttxt.Text
        prod_type = prod_typetxt.Text

        If String.IsNullOrEmpty(customer_nametxt.Text) Or String.IsNullOrEmpty(customer_numtxt.Text) Or String.IsNullOrEmpty(etc_dtp.Text) Or
            String.IsNullOrEmpty(overall_pricetxt.Text) Or String.IsNullOrEmpty(down_paymenttxt.Text) Or String.IsNullOrEmpty(prod_typetxt.Text) Then
            MsgBox("Please fill up all the fields NIGGA!", vbCritical, "VELEZ TAILORING")
        ElseIf Not IsNumeric(overall_price) Or Not IsNumeric(overall_price) Or Not IsNumeric(customer_numtxt) Then
            MsgBox("INVALID INPUT! MUST BE A NUMBER", vbCritical, "VELEZ TAILORING")
            customer_nametxt.Clear()
            customer_numtxt.Clear()
            etc_dtp.ResetText()
            overall_pricetxt.Clear()
            down_paymenttxt.Clear()
            prod_typetxt.Clear()
        Else
            addOrders(customer_name, customer_number, prod_type, overall_price, down_payment, estimated_time)
            customer_nametxt.Clear()
            customer_numtxt.Clear()
            etc_dtp.ResetText()
            overall_pricetxt.Clear()
            down_paymenttxt.Clear()
            prod_typetxt.Clear()
        End If
    End Sub

    Private Sub etc_dtp_ValueChanged(sender As Object, e As EventArgs) Handles etc_dtp.ValueChanged

    End Sub
End Class
