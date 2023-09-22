Public Class TransactionPanel

    Private Sub save_ordertxt_Click(sender As Object, e As EventArgs) Handles save_ordertxt.Click
        Dim customer_name, customer_number, estimated_time, overall_price, down_payment, prod_type As String
        customer_name = customer_nametxt.Text
        customer_number = customer_numtxt.Text
        estimated_time = etc_dtp.Text
        overall_price = overall_pricetxt.Text
        down_payment = down_paymenttxt.Text
        prod_type = prod_typetxt.Text

        If String.IsNullOrEmpty(customer_nametxt.Text) Or String.IsNullOrEmpty(customer_nametxt.Text) Or String.IsNullOrEmpty(etc_dtp.Text) Or
            String.IsNullOrEmpty(overall_pricetxt.Text) Or String.IsNullOrEmpty(down_paymenttxt.Text) Or String.IsNullOrEmpty(prod_typetxt.Text) Then
            MsgBox("Please fill up all the fields NIGGA!", vbCritical, "VELEZ TAILORING")
        Else
            transaction(customer_name, customer_number, prod_type, overall_price, down_payment, estimated_time)
            customer_nametxt.Clear()
            customer_numtxt.Clear()
            etc_dtp.ResetText()
            overall_pricetxt.Clear()
            down_paymenttxt.Clear()
            prod_typetxt.Clear()
        End If
    End Sub




End Class
