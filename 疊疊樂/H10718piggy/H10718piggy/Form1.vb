Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("遊戲說明:1.按下空白鍵讓豬掉下來 2.把豬疊高(提示:豬要往後一點再按歐!!) 3.疊高6隻豬即可獲勝 4.掉下來就失敗了! ")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form3.Show()

    End Sub
End Class
