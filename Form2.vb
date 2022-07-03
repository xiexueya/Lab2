Public Class frmCalculo
    Dim todo() As String
    Dim par() As String
    Dim impar() As String
    Dim cant As String
    Dim num As String
    Dim sumatoria As Integer
    Dim spar As Integer = 0
    Dim simpar As Integer = 0
    Dim a As Integer = 0
    Dim tomayor As Integer = 0
    Dim tomenor As Integer = 99999
    Dim parmayor As Integer = 0
    Dim parmenor As Integer = 99999
    Dim immayor As Integer = 0
    Dim immenor As Integer = 99999


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim incs As Decimal
        ' Carbono orgánico total (COT)'
        If Carbonoorgánicototal.Text > 0 And Carbonoorgánicototal.Text <= 8 Then
            If Carbonoorgánicototal.Text > 0 And Carbonoorgánicototal.Text <= 2.5 Then
                Rcabonoorgtot.Text = 0
            ElseIf Carbonoorgánicototal.Text > 2.5 And Carbonoorgánicototal.Text <= 5.2 Then
                Rcabonoorgtot.Text = 1
            Else
                Rcabonoorgtot.Text = 2
            End If
            Rcabonoorgtot.BackColor = Color.Red
        End If
        If Carbonoorgánicototal.Text > 8 And Carbonoorgánicototal.Text <= 21.7 Then
            If Carbonoorgánicototal.Text > 8 And Carbonoorgánicototal.Text <= 12.6 Then
                Rcabonoorgtot.Text = 3
            ElseIf Carbonoorgánicototal.Text > 12.6 And Carbonoorgánicototal.Text <= 17.1 Then
                Rcabonoorgtot.Text = 4
            Else
                Rcabonoorgtot.Text = 5
            End If
            Rcabonoorgtot.BackColor = Color.Yellow
        End If
        If Carbonoorgánicototal.Text > 21.7 Then
            If Carbonoorgánicototal.Text > 21.7 And Carbonoorgánicototal.Text <= 26.2 Then
                Rcabonoorgtot.Text = 6
            ElseIf Carbonoorgánicototal.Text > 26.2 And Carbonoorgánicototal.Text <= 30.8 Then
                Rcabonoorgtot.Text = 7
            Else
                Rcabonoorgtot.Text = 8
            End If
            Rcabonoorgtot.BackColor = Color.Green
        End If

        'Carbono orgánico particulado (COP)'
        If Carbonorg.Text > 0 And Carbonorg.Text <= 4 Then
            If Carbonorg.Text > 0 And Carbonorg.Text <= 1.3 Then
                Rcabonoorgpar.Text = 0
            ElseIf Carbonorg.Text > 1.3 And Carbonorg.Text <= 2.7 Then
                Rcabonoorgpar.Text = 1
            Else
                Rcabonoorgpar.Text = 2
            End If
            Rcabonoorgpar.BackColor = Color.Red
        End If
        If Carbonorg.Text > 4 And Carbonorg.Text <= 10.7 Then
            If Carbonorg.Text > 4 And Carbonorg.Text <= 6.2 Then
                Rcabonoorgpar.Text = 3
            ElseIf Carbonorg.Text > 6.2 And Carbonorg.Text <= 8.4 Then
                Rcabonoorgpar.Text = 4
            Else
                Rcabonoorgpar.Text = 5
            End If
            Rcabonoorgpar.BackColor = Color.Yellow
        End If
        If Carbonorg.Text > 10.7 Then
            If Carbonorg.Text > 10.7 And Carbonorg.Text <= 12.9 Then
                Rcabonoorgpar.Text = 6
            ElseIf Carbonorg.Text > 12.9 And Carbonorg.Text <= 15.2 Then
                Rcabonoorgpar.Text = 7
            Else
                Rcabonoorgpar.Text = 8
            End If
            Rcabonoorgpar.BackColor = Color.Green
        End If

        'Nitrógeno total (Nt)'
        If nitrogenotot.Text > 0 And nitrogenotot.Text <= 0.199 Then
            If nitrogenotot.Text > 0 And nitrogenotot.Text <= 0.066 Then
                Rnitrotot.Text = 0
            ElseIf nitrogenotot.Text > 0.066 And nitrogenotot.Text <= 0.132 Then
                Rnitrotot.Text = 1
            Else
                Rnitrotot.Text = 2
            End If
            Rnitrotot.BackColor = Color.Red
        End If
        If nitrogenotot.Text > 0.199 And nitrogenotot.Text <= 0.229 Then
            If nitrogenotot.Text > 0.199 And nitrogenotot.Text <= 0.209 Then
                Rnitrotot.Text = 3
            ElseIf nitrogenotot.Text > 0.209 And nitrogenotot.Text <= 0.219 Then
                Rnitrotot.Text = 4
            Else
                Rnitrotot.Text = 5
            End If
            Rnitrotot.BackColor = Color.Yellow
        End If
        If nitrogenotot.Text > 0.229 Then
            If nitrogenotot.Text > 0.229 And nitrogenotot.Text <= 0.239 Then
                Rnitrotot.Text = 6
            ElseIf nitrogenotot.Text > 0.239 And nitrogenotot.Text <= 0.25 Then
                Rnitrotot.Text = 7
            Else
                Rnitrotot.Text = 8
            End If
            Rnitrotot.BackColor = Color.Green
        End If

        'Reacción del suelo (pH)'
        If Reaccsuelo.Text > 0 Then
            If Reaccsuelo.Text > 0 And Reaccsuelo.Text <= 1.83 Or Reaccsuelo.Text > 12 And Reaccsuelo.Text <= 14 Then
                Rreaccsuel.Text = 0
            ElseIf Reaccsuelo.Text > 1.83 And Reaccsuelo.Text <= 3.66 Or Reaccsuelo.Text > 10.1 And Reaccsuelo.Text <= 12.0 Then
                Rreaccsuel.Text = 1
            ElseIf Reaccsuelo.Text > 3.66 And Reaccsuelo.Text <= 5.5 Or Reaccsuelo.Text > 8.2 And Reaccsuelo.Text <= 10.1 Then
                Rreaccsuel.Text = 2
            End If
            Rreaccsuel.BackColor = Color.Red
        End If
        If Reaccsuelo.Text > 5.5 Then
            If Reaccsuelo.Text > 5.5 And Reaccsuelo.Text <= 5.83 Or Reaccsuelo.Text > 8.1 And Reaccsuelo.Text <= 8.2 Then
                Rreaccsuel.Text = 3
            ElseIf Reaccsuelo.Text > 5.83 And Reaccsuelo.Text <= 6.16 Or Reaccsuelo.Text > 7.7 And Reaccsuelo.Text <= 8.1 Then
                Rreaccsuel.Text = 4
            ElseIf Reaccsuelo.Text > 6.16 And Reaccsuelo.Text <= 6.5 Or Reaccsuelo.Text > 7.5 And Reaccsuelo.Text <= 7.7 Then
                Rreaccsuel.Text = 5
            End If
            Rreaccsuel.BackColor = Color.Yellow
        End If
        If Reaccsuelo.Text > 6.5 Then
            If Reaccsuelo.Text > 6.5 And Reaccsuelo.Text <= 6.7 Or Reaccsuelo.Text > 7.3 And Reaccsuelo.Text <= 7.5 Then
                Rreaccsuel.Text = 6
            ElseIf Reaccsuelo.Text > 6.7 And Reaccsuelo.Text <= 6.9 Or Reaccsuelo.Text > 7.1 And Reaccsuelo.Text <= 7.3 Then
                Rreaccsuel.Text = 7
            ElseIf Reaccsuelo.Text > 6.9 And Reaccsuelo.Text <= 7.1 Then
                Rreaccsuel.Text = 8
            End If
            Rreaccsuel.BackColor = Color.Green
        End If

        'Densidad aparente (Da)'
        If Densiapa.Text < 1.21 Then
            If Densiapa.Text <= 1.17 Then
                Rdendapa.Text = 8
            ElseIf Densiapa.Text > 1.17 And Densiapa.Text <= 1.18 Then
                Rdendapa.Text = 7
            ElseIf Densiapa.Text > 1.18 And Densiapa.Text <= 1.2 Then
                Rdendapa.Text = 6
            End If
            Rdendapa.BackColor = Color.Green
        End If
        If Densiapa.Text <= 1.6 Then
            If Densiapa.Text > 1.2 And Densiapa.Text <= 1.33 Then
                Rdendapa.Text = 5
            ElseIf Densiapa.Text > 1.33 And Densiapa.Text <= 1.46 Then
                Rdendapa.Text = 4
            ElseIf Densiapa.Text > 1.46 And Densiapa.Text <= 1.6 Then
                Rdendapa.Text = 3
            End If
            Rdendapa.BackColor = Color.Yellow
        End If
        If Densiapa.Text > 1.6 Then
            If Densiapa.Text > 1.6 And Densiapa.Text <= 1.7 Then
                Rdendapa.Text = 2
            ElseIf Densiapa.Text > 1.7 And Densiapa.Text <= 1.8 Then
                Rdendapa.Text = 1
            ElseIf Densiapa.Text > 1.8 Then
                Rdendapa.Text = 0
            End If
            Rdendapa.BackColor = Color.Red
        End If

        'Fracción erosionable (FE)'
        If Fraccero.Text <= 29.2 Then
            If Fraccero.Text <= 9.7 Then
                Rfraccero.Text = 8
            ElseIf Fraccero.Text > 9.7 And Fraccero.Text <= 19.5 Then
                Rfraccero.Text = 7
            ElseIf Fraccero.Text > 19.5 And Fraccero.Text <= 29.2 Then
                Rfraccero.Text = 6
            End If
            Rfraccero.BackColor = Color.Green
        End If
        If Fraccero.Text <= 40 Then
            If Fraccero.Text > 29.2 And Fraccero.Text <= 32.8 Then
                Rfraccero.Text = 5
            ElseIf Fraccero.Text > 32.8 And Fraccero.Text <= 36.4 Then
                Rfraccero.Text = 4
            ElseIf Fraccero.Text > 36.4 And Fraccero.Text <= 40 Then
                Rfraccero.Text = 3
            End If
            Rfraccero.BackColor = Color.Yellow
        End If
        If Fraccero.Text > 40 Then
            If Fraccero.Text > 40 And Fraccero.Text <= 43.6 Then
                Rfraccero.Text = 2
            ElseIf Fraccero.Text > 43.6 And Fraccero.Text <= 47.2 Then
                Rfraccero.Text = 1
            ElseIf Fraccero.Text > 47.2 Then
                Rfraccero.Text = 0
            End If
            Rfraccero.BackColor = Color.Red
        End If

        resultado.Text = Convert.ToString(Rcabonoorgpar.Text * 0.21) + (Rcabonoorgpar.Text * 0.2) + (Rnitrotot.Text * 0.18) + (Rreaccsuel.Text * 0.15) + (Rdendapa.Text * 0.15) + (Rfraccero.Text * 0.13)
    End Sub
End Class