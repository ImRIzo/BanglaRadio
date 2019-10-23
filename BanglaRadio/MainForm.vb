Public Class MainForm
    'Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles RadioPlayer.Enter

    'End Sub

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    'Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 

    'End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        RadioPlayer.settings.volume = TrackBar1.Value
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        RadioPlayer.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PauseButton.Click
        RadioPlayer.Ctlcontrols.pause()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PowerButton.Click
        RadioPlayer.Ctlcontrols.stop()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles MuteButton.Click
        RadioPlayer.settings.volume = 0
    End Sub

    Private Sub RadioABC_Click(sender As Object, e As EventArgs) Handles RadioABC.Click
        RadioPlayer.URL = ("http://ample-zeno-12.radiojar.com/6a28tbx6vewtv?rj-ttl=5&rj-token=AAABZDIBoBlxmh_p7v7kV6HOfTjk_uTrUqzN0TxZ0-neWANtn52Ucg")
    End Sub

    Private Sub RadioToday_Click(sender As Object, e As EventArgs) Handles RadioToday.Click
        RadioPlayer.URL = ("https://goo.gl/ZXJZob")
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles RadioFoorti.Click
        RadioPlayer.URL = ("http://119.148.23.88:1021")
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles DhakaFM.Click
        RadioPlayer.URL = ("http://118.179.219.244:8000/")
    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles PeoplesRadio.Click
        RadioPlayer.URL = ("http://87.98.216.129:14498")
    End Sub

    Private Sub RadioNext_Click(sender As Object, e As EventArgs) Handles RadioNext.Click
        RadioPlayer.URL = ("http://ample-zeno-06.radiojar.com/syy6bqqegd5tv?rj-ttl=5&rj-token=AAABXQJxiXL5gDDoTYE6TfuXAGnrukgMna0MLPD5N1TxKbcE9ncvLg")
    End Sub

    Private Sub PictureBox1_Click_4(sender As Object, e As EventArgs) Handles PictureBox1.Click
        RadioPlayer.URL = ("http://noasrv.caster.fm:10182/live")
    End Sub

    Private Sub PictureBox2_Click_2(sender As Object, e As EventArgs) Handles PictureBox2.Click
        RadioPlayer.URL = ("http://sirius.shoutca.st:9055/padma.mp3")
    End Sub

    Private Sub PictureBox3_Click_2(sender As Object, e As EventArgs) Handles PictureBox3.Click
        RadioPlayer.URL = ("http://relay.181.fm:8068/")
    End Sub








    Private Sub PictureBox1_Click_3(sender As Object, e As EventArgs) Handles Facebook.Click
        Process.Start("https://facebook.com/ImRizo")
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles Website.Click
        Process.Start("https://rizowan.github.io")
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        AboutBox.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

End Class
