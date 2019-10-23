<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PlayButton = New System.Windows.Forms.PictureBox()
        Me.PauseButton = New System.Windows.Forms.PictureBox()
        Me.PowerButton = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MuteButton = New System.Windows.Forms.PictureBox()
        Me.RadioABC = New System.Windows.Forms.PictureBox()
        Me.RadioToday = New System.Windows.Forms.PictureBox()
        Me.RadioFoorti = New System.Windows.Forms.PictureBox()
        Me.DhakaFM = New System.Windows.Forms.PictureBox()
        Me.PeoplesRadio = New System.Windows.Forms.PictureBox()
        Me.Facebook = New System.Windows.Forms.PictureBox()
        Me.Website = New System.Windows.Forms.PictureBox()
        Me.About = New System.Windows.Forms.Button()
        Me.RadioNext = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.RadioPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.PlayButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PauseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PowerButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuteButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioABC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioToday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioFoorti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DhakaFM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeoplesRadio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Facebook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Website, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlayButton
        '
        Me.PlayButton.BackColor = System.Drawing.Color.Transparent
        Me.PlayButton.Image = CType(resources.GetObject("PlayButton.Image"), System.Drawing.Image)
        Me.PlayButton.Location = New System.Drawing.Point(29, 145)
        Me.PlayButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(40, 34)
        Me.PlayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PlayButton.TabIndex = 1
        Me.PlayButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PlayButton, "Play")
        '
        'PauseButton
        '
        Me.PauseButton.BackColor = System.Drawing.Color.Transparent
        Me.PauseButton.Image = CType(resources.GetObject("PauseButton.Image"), System.Drawing.Image)
        Me.PauseButton.Location = New System.Drawing.Point(29, 198)
        Me.PauseButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(37, 34)
        Me.PauseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PauseButton.TabIndex = 2
        Me.PauseButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PauseButton, "Pause")
        '
        'PowerButton
        '
        Me.PowerButton.BackColor = System.Drawing.Color.Transparent
        Me.PowerButton.Image = CType(resources.GetObject("PowerButton.Image"), System.Drawing.Image)
        Me.PowerButton.Location = New System.Drawing.Point(29, 248)
        Me.PowerButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PowerButton.Name = "PowerButton"
        Me.PowerButton.Size = New System.Drawing.Size(37, 34)
        Me.PowerButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PowerButton.TabIndex = 3
        Me.PowerButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PowerButton, "Power")
        '
        'MuteButton
        '
        Me.MuteButton.BackColor = System.Drawing.Color.Transparent
        Me.MuteButton.Image = CType(resources.GetObject("MuteButton.Image"), System.Drawing.Image)
        Me.MuteButton.Location = New System.Drawing.Point(32, 87)
        Me.MuteButton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MuteButton.Name = "MuteButton"
        Me.MuteButton.Size = New System.Drawing.Size(37, 34)
        Me.MuteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MuteButton.TabIndex = 5
        Me.MuteButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.MuteButton, "Mute")
        '
        'RadioABC
        '
        Me.RadioABC.BackColor = System.Drawing.Color.Transparent
        Me.RadioABC.Image = CType(resources.GetObject("RadioABC.Image"), System.Drawing.Image)
        Me.RadioABC.Location = New System.Drawing.Point(546, 154)
        Me.RadioABC.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RadioABC.Name = "RadioABC"
        Me.RadioABC.Size = New System.Drawing.Size(152, 58)
        Me.RadioABC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RadioABC.TabIndex = 6
        Me.RadioABC.TabStop = False
        Me.ToolTip1.SetToolTip(Me.RadioABC, "Radio ABC 89.2")
        '
        'RadioToday
        '
        Me.RadioToday.BackColor = System.Drawing.Color.Transparent
        Me.RadioToday.Image = CType(resources.GetObject("RadioToday.Image"), System.Drawing.Image)
        Me.RadioToday.Location = New System.Drawing.Point(546, 76)
        Me.RadioToday.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RadioToday.Name = "RadioToday"
        Me.RadioToday.Size = New System.Drawing.Size(142, 58)
        Me.RadioToday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RadioToday.TabIndex = 7
        Me.RadioToday.TabStop = False
        Me.ToolTip1.SetToolTip(Me.RadioToday, "Radio Today 89.6")
        '
        'RadioFoorti
        '
        Me.RadioFoorti.BackColor = System.Drawing.Color.Transparent
        Me.RadioFoorti.Image = CType(resources.GetObject("RadioFoorti.Image"), System.Drawing.Image)
        Me.RadioFoorti.Location = New System.Drawing.Point(376, 76)
        Me.RadioFoorti.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RadioFoorti.Name = "RadioFoorti"
        Me.RadioFoorti.Size = New System.Drawing.Size(150, 58)
        Me.RadioFoorti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RadioFoorti.TabIndex = 8
        Me.RadioFoorti.TabStop = False
        Me.ToolTip1.SetToolTip(Me.RadioFoorti, "Radio Foorti 88.0")
        '
        'DhakaFM
        '
        Me.DhakaFM.BackColor = System.Drawing.Color.Transparent
        Me.DhakaFM.Image = CType(resources.GetObject("DhakaFM.Image"), System.Drawing.Image)
        Me.DhakaFM.Location = New System.Drawing.Point(376, 154)
        Me.DhakaFM.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DhakaFM.Name = "DhakaFM"
        Me.DhakaFM.Size = New System.Drawing.Size(150, 58)
        Me.DhakaFM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DhakaFM.TabIndex = 9
        Me.DhakaFM.TabStop = False
        Me.ToolTip1.SetToolTip(Me.DhakaFM, "Dhaka FM 90.4")
        '
        'PeoplesRadio
        '
        Me.PeoplesRadio.BackColor = System.Drawing.Color.Transparent
        Me.PeoplesRadio.Image = CType(resources.GetObject("PeoplesRadio.Image"), System.Drawing.Image)
        Me.PeoplesRadio.Location = New System.Drawing.Point(724, 76)
        Me.PeoplesRadio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PeoplesRadio.Name = "PeoplesRadio"
        Me.PeoplesRadio.Size = New System.Drawing.Size(150, 58)
        Me.PeoplesRadio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PeoplesRadio.TabIndex = 10
        Me.PeoplesRadio.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PeoplesRadio, "Peoples Radio 91.6")
        '
        'Facebook
        '
        Me.Facebook.BackColor = System.Drawing.Color.Transparent
        Me.Facebook.Image = CType(resources.GetObject("Facebook.Image"), System.Drawing.Image)
        Me.Facebook.Location = New System.Drawing.Point(780, 412)
        Me.Facebook.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Facebook.Name = "Facebook"
        Me.Facebook.Size = New System.Drawing.Size(48, 25)
        Me.Facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Facebook.TabIndex = 11
        Me.Facebook.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Facebook, "Find me on Facebook")
        '
        'Website
        '
        Me.Website.BackColor = System.Drawing.Color.Transparent
        Me.Website.Image = CType(resources.GetObject("Website.Image"), System.Drawing.Image)
        Me.Website.Location = New System.Drawing.Point(825, 412)
        Me.Website.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Website.Name = "Website"
        Me.Website.Size = New System.Drawing.Size(49, 25)
        Me.Website.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Website.TabIndex = 12
        Me.Website.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Website, "For free apps&tuts")
        '
        'About
        '
        Me.About.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.About.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.About.ForeColor = System.Drawing.Color.Crimson
        Me.About.Location = New System.Drawing.Point(769, 12)
        Me.About.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(105, 29)
        Me.About.TabIndex = 13
        Me.About.Text = "About"
        Me.About.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.About, "Click to show")
        Me.About.UseVisualStyleBackColor = False
        '
        'RadioNext
        '
        Me.RadioNext.BackColor = System.Drawing.Color.Transparent
        Me.RadioNext.Image = CType(resources.GetObject("RadioNext.Image"), System.Drawing.Image)
        Me.RadioNext.Location = New System.Drawing.Point(724, 154)
        Me.RadioNext.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RadioNext.Name = "RadioNext"
        Me.RadioNext.Size = New System.Drawing.Size(150, 58)
        Me.RadioNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RadioNext.TabIndex = 14
        Me.RadioNext.TabStop = False
        Me.ToolTip1.SetToolTip(Me.RadioNext, "Radio Next 93.2")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(376, 232)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Radio Bhumi 92.8")
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(546, 232)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(150, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Radio Padma 99.2")
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.AntiqueWhite
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(724, 232)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(150, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "181.FM Old School HipHop/RNB")
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.Black
        Me.TrackBar1.Location = New System.Drawing.Point(77, 76)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(291, 45)
        Me.TrackBar1.TabIndex = 4
        Me.TrackBar1.Value = 50
        '
        'RadioPlayer
        '
        Me.RadioPlayer.Enabled = True
        Me.RadioPlayer.Location = New System.Drawing.Point(77, 127)
        Me.RadioPlayer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RadioPlayer.Name = "RadioPlayer"
        Me.RadioPlayer.OcxState = CType(resources.GetObject("RadioPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.RadioPlayer.Size = New System.Drawing.Size(291, 225)
        Me.RadioPlayer.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(886, 440)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RadioNext)
        Me.Controls.Add(Me.About)
        Me.Controls.Add(Me.Website)
        Me.Controls.Add(Me.Facebook)
        Me.Controls.Add(Me.PeoplesRadio)
        Me.Controls.Add(Me.DhakaFM)
        Me.Controls.Add(Me.RadioFoorti)
        Me.Controls.Add(Me.RadioToday)
        Me.Controls.Add(Me.RadioABC)
        Me.Controls.Add(Me.MuteButton)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.PowerButton)
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.RadioPlayer)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1124, 478)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BanglaRadio 1.2"
        CType(Me.PlayButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PauseButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PowerButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuteButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioABC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioToday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioFoorti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DhakaFM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeoplesRadio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Facebook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Website, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadioPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PlayButton As PictureBox
    Friend WithEvents PauseButton As PictureBox
    Friend WithEvents PowerButton As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents MuteButton As PictureBox
    Friend WithEvents RadioABC As PictureBox
    Friend WithEvents RadioToday As PictureBox
    Friend WithEvents RadioFoorti As PictureBox
    Friend WithEvents DhakaFM As PictureBox
    Friend WithEvents PeoplesRadio As PictureBox
    Friend WithEvents Facebook As PictureBox
    Friend WithEvents Website As PictureBox
    Friend WithEvents About As Button
    Friend WithEvents RadioNext As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
