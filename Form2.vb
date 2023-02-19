Public Class Form2
    Private Const _cdecCostPerNight As Decimal = 79D
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNights.Clear()
        lblTotalCost.Text = ""
        txtNights.Focus()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lnlName.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblTotalCost.Click

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim strNumberofNights As String
        Dim intEnterNumberofNights As Integer
        Dim decTotalCostOfStay As Decimal

        strNumberofNights = txtNights.Text
        intEnterNumberofNights = Convert.ToInt32(strNumberofNights)
        decTotalCostOfStay = intEnterNumberofNights * _cdecCostPerNight
        lblTotalCost.Text = decTotalCostOfStay.ToString("C")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNights.Clear()
        lblTotalCost.Text = ""
        txtNights.Focus()
    End Sub
End Class