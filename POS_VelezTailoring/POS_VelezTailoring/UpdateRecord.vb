Imports System.Runtime.CompilerServices

Public Class UpdateRecord
    ' Store the initial description and overall price
    Private initialDescription As String
    Private initialOverallPrice As String

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
            MsgBox("YOU LEFT A FIELD BLANK! TRY AGAIN.", vbCritical, "VELEZ CREATIONS")
            Return
        End If

        If Not IsNumeric(overallPrice) Or Not IsNumeric(orderPayment) Then
            MsgBox("OVERALL PRICE AND ORDER PAYMENT MUST BE A NUMBER! ", vbCritical, "VELEZ CREATIONS")
            txt_price.Clear()
            txt_pay.Clear()
            Return
        End If

        ' The description is not modified; you can proceed to update the order
        If initialDescription.Equals(description) And initialOverallPrice.Equals(overallPrice) Then
            MsgBox("No changes has been made on the order description.", vbInformation, "VELEZ CREATIONS")
            updateOrder(id, name, status, description, overallPrice, orderPayment, deadline)
            Me.Close()
        End If

        ' The description is modified; you cannot proceed until the overall price is updated
        If Not initialDescription.Equals(description) And initialOverallPrice.Equals(overallPrice) Then
            MsgBox("CHANGES HAS BEEN MADE ON THE ORDER DESCRIPTION. PLEASE UPDATE THE OVERALL PRICE AMOUNT!", vbExclamation, "VELEZ CREATIONS")
            Return
        End If

        ' The description and overall price are all set; you can proceed to update the order
        If Not initialDescription.Equals(description) And Not initialOverallPrice.Equals(overallPrice) Then
            updateOrder(id, name, status, description, overallPrice, orderPayment, deadline)
            Me.Close()
        End If

    End Sub

    ' sets the value for the initiated variable initialDescription
    Public Sub setInitialDescription(ByVal description As String)
        Me.initialDescription = description
    End Sub

    ' sets the value for the initiated variable initialOverallPrice
    Public Sub setInitialOverallPrice(ByVal overallPrice As String)
        Me.initialOverallPrice = overallPrice
    End Sub
End Class
