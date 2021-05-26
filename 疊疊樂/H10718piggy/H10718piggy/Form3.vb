Public Class Form3
    Dim A As Boolean = True
    Dim x2, y2 As Integer
    Dim x As Integer = 0
    Dim D As Integer
    Dim index As Integer
    Dim B As Boolean = True
    Dim player1 As New WMPLib.WindowsMediaPlayer
    Dim replay As Integer

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If Timer1.Enabled = True Then
            Return
        End If
        x += 1

        '空白鍵讓豬掉下來
        If e.KeyCode = Keys.Space And A = True And x = 1 Then

            Timer1.Enabled = True
            PictureBox2.Visible = True
            PictureBox2.Top = PictureBox5.Top
            A = True
        End If
        If e.KeyCode = Keys.Space And A = True And x = 2 Then

            Timer1.Enabled = True
            PictureBox2.Visible = True
            PictureBox2.Top = PictureBox5.Top
            A = True
        End If
        If e.KeyCode = Keys.Space And A = True And x = 3 Then

            Timer1.Enabled = True
            PictureBox2.Visible = True
            PictureBox2.Top = PictureBox5.Top
            A = True
        End If
        If e.KeyCode = Keys.Space And A = True And x = 4 Then

            Timer1.Enabled = True
            PictureBox2.Visible = True
            PictureBox2.Top = PictureBox5.Top
            A = True
        End If
        If e.KeyCode = Keys.Space And A = True And x = 5 Then

            Timer1.Enabled = True
            PictureBox2.Visible = True
            PictureBox2.Top = PictureBox5.Top
            A = True
        End If




    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        '豬掉下來每30單位
        PictureBox2.Top += 30

        '得分線(在p5的中心點=p1的中心點)
        Dim checkPic, dispPic As PictureBox

        If x = 1 Then
            checkPic = PictureBox1
            dispPic = PictureBox3
        ElseIf x = 2 Then
            checkPic = PictureBox3
            dispPic = PictureBox4
        ElseIf x = 3 Then
            checkPic = PictureBox4
            dispPic = PictureBox6
        ElseIf x = 4 Then
            checkPic = PictureBox6
            dispPic = PictureBox7
        Else
            checkPic = PictureBox7
            dispPic = PictureBox8
        End If


        If PictureBox2.Left + PictureBox2.Width / 2 > checkPic.Left + 35 And
                PictureBox2.Left + PictureBox2.Width / 2 < checkPic.Left + checkPic.Width - 35 And
            PictureBox2.Top < PictureBox2.Top + checkPic.Height And
            PictureBox2.Top + PictureBox2.Height > checkPic.Top Then

            dispPic.Visible = True
            Timer1.Enabled = False
        End If

        If PictureBox8.Visible = True Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            PictureBox13.Visible = True

        End If


        If PictureBox2.Left + PictureBox2.Width / 2 > PictureBox10.Left And
                PictureBox2.Left + PictureBox2.Width / 2 < PictureBox10.Left + PictureBox10.Width And
                PictureBox2.Top < PictureBox2.Top + PictureBox10.Height And
                PictureBox2.Top + PictureBox2.Height > PictureBox10.Top Then
            PictureBox2.Image = PictureBox9.Image
            Timer1.Enabled = False
            Timer2.Enabled = False
            replay = MsgBox("Game over ! 重玩嗎?"， 32 + 4， "gameover")
            If replay = 6 Then
                player1.close()
                Form1.Show()
                Me.Close()

            Else
                player1.close()
                Me.Close()
                Form1.Close()

            End If
        End If
        If PictureBox2.Left + PictureBox2.Width / 2 > PictureBox11.Left And
                PictureBox2.Left + PictureBox2.Width / 2 < PictureBox11.Left + PictureBox11.Width And
                PictureBox2.Top < PictureBox2.Top + PictureBox11.Height And
                PictureBox2.Top + PictureBox2.Height > PictureBox11.Top Then
            PictureBox2.Image = PictureBox9.Image
            Timer1.Enabled = False
            Timer2.Enabled = False
            replay = MsgBox("Game over ! 重玩嗎?"， 32 + 4， "gameover")
            If replay = 6 Then
                player1.close()
                Form1.Show()
                Me.Close()

            Else
                player1.close()
                Me.Close()
                Form1.Close()

            End If
        End If


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        '爪子移動

        PictureBox5.Left += 60

        '穿牆
        If PictureBox5.Left < 0 - PictureBox5.Width Then
            PictureBox5.Left = Me.Width - 20
        End If
        If PictureBox5.Left > Me.Width - 20 Then
            PictureBox5.Left = 0 - PictureBox5.Width
        End If

        'p2和爪子一起動
        If Timer1.Enabled = False Then
            PictureBox2.Left += 60
            PictureBox2.Top = PictureBox5.Top + PictureBox5.Height
            PictureBox2.Left = PictureBox5.Left + PictureBox5.Width / 2 - PictureBox2.Width / 2
        End If
        If PictureBox2.Left > Me.Width - 20 Then
            PictureBox2.Left = 0 - PictureBox2.Width
        End If






    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player1.URL = My.Application.Info.DirectoryPath & "\Clean Bandit - Solo (feat. Demi Lovato) [Official Video] (1).mp3"
        player1.settings.setMode("loop", True)
    End Sub

    Private Sub Form3_CursorChanged(sender As Object, e As EventArgs) Handles Me.CursorChanged

    End Sub
End Class
