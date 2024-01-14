Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'this clears the options and resets the raio button to default
        txtName.Text = String.Empty
        txtYears.Text = String.Empty
        lblSalary.Text = String.Empty
        rad1.Checked = True

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim strName As String
        Dim decYears As Decimal
        Dim intSales As Integer
        Dim decTotal As Decimal
        'declaring my variables, the calculation only works with decimals not integers because of the 0.02 multiplier which is necessary for the bonus

        Integer.TryParse(txtYears.Text, decYears)
        'this assigns the years variable to the years employed text box

        If txtName.Text = "" Then
            MsgBox("Please enter your name")
        Else
            strName = txtName.Text
        End If
        'this makes sure a name is entered

        If Not Integer.TryParse(txtYears.Text, decYears) Or decYears < -1 Then
            MsgBox("Please enter a valid number")
            txtYears.Text = String.Empty
        End If
        'this makes sure a whole and valid number is entered. 

        decTotal = 1500
        decYears *= 0.02
        'the 0.02 multiplier mentioned earlier
        decTotal *= decYears
        decTotal += 1500
        'this is the equation for making the salary without the radio button bonus

        Select Case True
            Case rad1.Checked
                decTotal += 0
            Case rad2.Checked
                decTotal += 250
            Case rad3.Checked
                decTotal += 750
            Case rad4.Checked
                decTotal += 1200
        End Select
        'this determines what radio button is clicked and adds the appropriate bonus to the total from the calculation

        lblSalary.Text = decTotal.ToString("C2")
        'this puts the total into the label

        lblNametot.Text = strName & ", your total salary is:"
        'this text points the user to their total salary
    End Sub
End Class
