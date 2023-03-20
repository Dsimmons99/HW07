Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function CalculateFifthYearAmount(ByVal firstYearAmount As Double) As Double
        Return firstYearAmount * 1.2
    End Function
    Private Sub JobListBOX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JobListBOX.SelectedIndexChanged
        If JobListBOX.SelectedItem = "Computer Developers" Then
            FirstYearAmountLBL.Text = "$109,020.00"
            FifthYearAmountLBL.Text = "$" + CalculateFifthYearAmount(CDbl(FirstYearAmountLBL.Text.Replace("$", ""))).ToString("N2")
        ElseIf JobListBOX.SelectedItem = "Computer System Analysts" Then
            FirstYearAmountLBL.Text = "$99,270.00"
            FifthYearAmountLBL.Text = "$" + CalculateFifthYearAmount(CDbl(FirstYearAmountLBL.Text.Replace("$", ""))).ToString("N2")
        ElseIf JobListBOX.SelectedItem = "Computer and Information Systems Managers" Then
            FirstYearAmountLBL.Text = "$159,010.00"
            FifthYearAmountLBL.Text = "$" + CalculateFifthYearAmount(CDbl(FirstYearAmountLBL.Text.Replace("$", ""))).ToString("N2")
        ElseIf JobListBOX.SelectedItem = "Computer Software Engineers, Applications" Then
            FirstYearAmountLBL.Text = "$109,020.00"
            FifthYearAmountLBL.Text = "$" + CalculateFifthYearAmount(CDbl(FirstYearAmountLBL.Text.Replace("$", ""))).ToString("N2")
        End If
    End Sub
End Class
