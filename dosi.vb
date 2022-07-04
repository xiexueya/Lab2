Public Class Dosi




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        PRINCIPAL.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Carbonoorgánicototal_TextChanged(sender As Object, e As EventArgs) Handles caudal.TextChanged

    End Sub


    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'Calcular el total por hectareas 
        dp.Text = Convert.ToString((caudal.Text * 3.2 * lh.Text * 167) / (dh.Text * lh.Text))

        'Clcular el total de la superficie actual
        dtp.Text = Convert.ToString((dp.Text * sup.Text * lh.Text * dh.Text) / 10000)

        'Calcular la cantidad de agua adecuada

        va.Text = Convert.ToString((d100.Text / 100) * dtp.Text)

    End Sub

    Private Sub dp_TextChanged(sender As Object, e As EventArgs)
        dp.ReadOnly = True
    End Sub

    Private Sub Dosi_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtp_TextChanged(sender As Object, e As EventArgs)
        dtp.ReadOnly = True
    End Sub

    Private Sub va_TextChanged(sender As Object, e As EventArgs)
        va.ReadOnly = True
    End Sub
End Class