Public Class Gestion_de_datos
    Private Sub btnOperacion_Click(sender As Object, e As EventArgs) Handles btnSuma.Click

        txtRes.Text = Convert.ToInt32(txtn1.Text) + Convert.ToInt32(txtn2.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtRes.Text = Convert.ToInt32(txtn1.Text) - Convert.ToInt32(txtn2.Text)
    End Sub
End Class
