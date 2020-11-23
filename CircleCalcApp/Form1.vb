Public Class Form1

    'Declarations
    Const PI As Double = Math.PI
    Dim Radius, Area, Circumference As Decimal

    'Subroutine For Calculating The Area
    Private Sub BTNCalcArea_Click(sender As Object, e As EventArgs) Handles BTNCalcArea.Click
        'Store The User Input For Radius
        Radius = TBIRadius.Text

        'Calculate The Area Of The Circle
        Area = Math.Round(PI * Radius * Radius, 2)

        'Output The Answer
        TBOResult.Text = Area & " cm"
    End Sub


    'Subroutine For Calculating The Circumference
    Private Sub BTNCalcCircumference_Click(sender As Object, e As EventArgs) Handles BTNCalcCircumference.Click
        'Get The User Input For Radius
        Radius = TBIRadius.Text

        'Calculate The Circumference
        Circumference = Math.Round(2 * PI * Radius, 2)

        'Output The Resultant Value For Circumference
        TBOResult.Text = Circumference & " cm"
    End Sub

End Class
