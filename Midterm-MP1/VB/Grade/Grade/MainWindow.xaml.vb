Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim average As Single
        Dim prelimGrade, midtermGrade, finalsGrade As Single
        If txtPrelim.Text = "" Or txtMidterm.Text = "" Or txtFinals.Text = "" Then
            txtPrelim.Text = 0
            txtMidterm.Text = 0
            txtFinals.Text = 0
        End If
        prelimGrade = Convert.ToSingle(txtPrelim.Text)
        midtermGrade = Convert.ToSingle(txtMidterm.Text)
        finalsGrade = Convert.ToSingle(txtFinals.Text)
        average = (prelimGrade + midtermGrade + finalsGrade) / 3
        lblAverage.Content = average
        If average >= 75 Then
            lblRemarks.Content = ":)"
        Else
            lblRemarks.Content = ":("
        End If
        lblA.Visibility = Visibility.Visible
        lblAverage.Visibility = Visibility.Visible
        lblR.Visibility = Visibility.Visible
        lblRemarks.Visibility = Visibility.Visible

    End Sub
End Class
