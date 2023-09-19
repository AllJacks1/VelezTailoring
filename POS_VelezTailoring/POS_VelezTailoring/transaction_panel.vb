Public Class transaction_panel

    Private Sub save_ordertxt_Click(sender As Object, e As EventArgs) Handles save_ordertxt.Click
        Dim customer_name, customer_number, estimated_time, overall_price, down_payment, prod_type As String
        customer_name = customer_nametxt.Text
        customer_number = customer_numtxt.Text
        estimated_time = etc_dtp.Text
        overall_price = overall_pricetxt.Text
        down_payment = down_paymenttxt.Text
        prod_type = prod_typetxt.Text

        transaction(customer_name, customer_number, prod_type, overall_price, down_payment, estimated_time)
        customer_nametxt.Clear()
        customer_numtxt.Clear()
        etc_dtp.ResetText()
        overall_pricetxt.Clear()
        down_paymenttxt.Clear()
        prod_typetxt.Clear()

    End Sub

    
End Class
