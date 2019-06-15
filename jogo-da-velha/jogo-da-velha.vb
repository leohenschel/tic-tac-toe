Public Class JogodaVelha

    Dim player1, player2 As String
    Dim jogadorDaVez As Integer

    Private Sub BtnNovoJogo_Click(sender As Object, e As EventArgs) Handles BtnNovoJogo.Click

        LblJogador.Text = player1
        jogadorDaVez = 1

        LblJogador.Text = player1
        BtnA1.Text = ""
        BtnA2.Text = ""
        BtnA3.Text = ""
        BtnB1.Text = ""
        BtnB2.Text = ""
        BtnB3.Text = ""
        BtnC1.Text = ""
        BtnC2.Text = ""
        BtnC3.Text = ""


        BtnA1.Enabled = True
        BtnA2.Enabled = True
        BtnA3.Enabled = True
        BtnB1.Enabled = True
        BtnB2.Enabled = True
        BtnB3.Enabled = True
        BtnC1.Enabled = True
        BtnC2.Enabled = True
        BtnC3.Enabled = True




    End Sub

    Private Sub BtnA1_Click(sender As Object, e As EventArgs) Handles BtnA1.Click

        VerificarJogada(BtnA1)

    End Sub

    Private Sub BtnB1_Click(sender As Object, e As EventArgs) Handles BtnB1.Click

        VerificarJogada(BtnB1)

    End Sub

    Private Sub BtnC1_Click(sender As Object, e As EventArgs) Handles BtnC1.Click

        VerificarJogada(BtnC1)

    End Sub

    Private Sub BtnA2_Click(sender As Object, e As EventArgs) Handles BtnA2.Click

        VerificarJogada(BtnA2)


    End Sub

    Private Sub BtnB2_Click(sender As Object, e As EventArgs) Handles BtnB2.Click

        VerificarJogada(BtnB2)

    End Sub

    Private Sub BtnC2_Click(sender As Object, e As EventArgs) Handles BtnC2.Click

        VerificarJogada(BtnC2)

    End Sub

    Private Sub BtnA3_Click(sender As Object, e As EventArgs) Handles BtnA3.Click

        VerificarJogada(BtnA3)


    End Sub

    Private Sub BtnB3_Click(sender As Object, e As EventArgs) Handles BtnB3.Click

        VerificarJogada(BtnB3)

    End Sub

    Private Sub BtnC3_Click(sender As Object, e As EventArgs) Handles BtnC3.Click
        VerificarJogada(BtnC3)
    End Sub

    Private Sub VerificarJogada(botao As Button)
        If (botao.Text = "") Then
            If (jogadorDaVez = 1) Then
                botao.Text = "X"
                VerificarGanhador("X")
                LblJogador.Text = player2
                jogadorDaVez = 2
            Else
                botao.Text = "O"
                VerificarGanhador("O")
                LblJogador.Text = player1
                jogadorDaVez = 1
            End If



        Else
            MessageBox.Show("Opção já escolhida!")
        End If
    End Sub

    Private Sub VerificarGanhador(simbolo As String)

        Dim flagGanhador As Boolean = False

        If (BtnA1.Text = simbolo And BtnA2.Text = simbolo And BtnA3.Text = simbolo) Then
            flagGanhador = True
        ElseIf (BtnB1.Text = simbolo And BtnB2.Text = simbolo And BtnB3.Text = simbolo) Then
            flagGanhador = True

        ElseIf (BtnC1.Text = simbolo And BtnC2.Text = simbolo And BtnC3.Text = simbolo) Then
            flagGanhador = True

        ElseIf (BtnA1.Text = simbolo And BtnB1.Text = simbolo And BtnC1.Text = simbolo) Then
            flagGanhador = True

        ElseIf (BtnA2.Text = simbolo And BtnB2.Text = simbolo And BtnC2.Text = simbolo) Then
            flagGanhador = True

        ElseIf (BtnA3.Text = simbolo And BtnB3.Text = simbolo And BtnC3.Text = simbolo) Then
            flagGanhador = True

        ElseIf (BtnA1.Text = simbolo And BtnB2.Text = simbolo And BtnC3.Text = simbolo) Then
            flagGanhador = True

        ElseIf (BtnC1.Text = simbolo And BtnB2.Text = simbolo And BtnA3.Text = simbolo) Then
            flagGanhador = True
        End If

        If (flagGanhador = True) Then

            MessageBox.Show(LblJogador.Text & "   GANHOUU!!!")
            If (jogadorDaVez = 1) Then
                LblVitoriasPlayer1.Text = LblVitoriasPlayer1.Text + 1
            Else
                LblVitoriasPlayer2.Text = LblVitoriasPlayer2.Text + 1
            End If


            BtnA1.Enabled = False
            BtnA2.Enabled = False
            BtnA3.Enabled = False
            BtnB1.Enabled = False
            BtnB2.Enabled = False
            BtnB3.Enabled = False
            BtnC1.Enabled = False
            BtnC2.Enabled = False
            BtnC3.Enabled = False

        Else
            If (BtnA1.Text <> "" And BtnA2.Text <> "" And BtnA3.Text <> "" And BtnB1.Text <> "" And BtnB2.Text <> "" And BtnB3.Text <> "" And BtnC1.Text <> "" And BtnC2.Text <> "" And BtnC3.Text <> "") Then
                MessageBox.Show("EMPATE!!")
                LblEmpates.Text = LblEmpates.Text + 1
            End If

        End If

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        If (jogadorDaVez = 1) Then
            player1 = InputBox("Digite o nome do JOGADOR 1 ").ToUpper
            LblJogador.Text = player1

        Else
            player2 = InputBox("Digite o nome do JOGADOR 2 ").ToUpper
            LblJogador.Text = player2
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        player1 = InputBox("Digite o nome do JOGADOR 1").ToUpper
        player2 = InputBox("Digite o nome do JOGADOR 2 ").ToUpper

        'JogodaVelha_Load

        LblJogador.Text = player1
        jogadorDaVez = 1
    End Sub
End Class
