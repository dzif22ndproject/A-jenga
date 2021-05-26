Public Class Form2
    Dim x As Boolean = True


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox2.Top = 30
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '左右
        If e.KeyCode = Keys.Left Then
            PictureBox2.Left -= 10
        End If
        If e.KeyCode = Keys.Right Then
            PictureBox2.Left += 10
        End If
        '穿牆
        If PictureBox2.Left < 0 - PictureBox2.Width Then
            PictureBox2.Left = Me.Width - 20
        End If
        If PictureBox2.Left > Me.Width - 20 Then
            PictureBox2.Left = 0 - PictureBox2.Width
        End If



        If e.KeyCode = Keys.Space And x = True Then
            Timer1.Enabled = True
            PictureBox2.Left = PictureBox1.Left + PictureBox1.Width / 2 - PictureBox2.Width / 2
            x = False
        End If

    End Sub
End Class