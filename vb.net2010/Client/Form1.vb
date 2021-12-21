Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim iVideoCount As Integer
        Dim iAudioCount As Integer
        Dim strApp As String
        Dim iFIndIndex As Integer

        strApp = Application.ExecutablePath

        iFindIndex = strApp.IndexOf("Examples")

        If iFindIndex <> -1 Then
            strApp = strApp.Substring(0, iFindIndex) + "novideo.bmp"
        End If

        TextBox1.Text = strApp


        iVideoCount = AxVideoChatSender1.GetVideoDeviceCount

        For i = 0 To iVideoCount - 1
            cbovideodevice.Items.Add(AxVideoChatSender1.GetVideoDeviceName(i))
        Next

        If cbovideodevice.Items.Count > 0 Then
            cbovideodevice.SelectedIndex = 0
        End If

        iAudioCount = AxVideoChatSender1.GetAudioDeviceCount

        For i = 0 To iAudioCount - 1
            cboaudiodevice.Items.Add(AxVideoChatSender1.GetAudioDeviceName(i))
        Next

        If cboaudiodevice.Items.Count > 0 Then
            cboaudiodevice.SelectedIndex = 0
        End If

        cbovideoformat.Items.Add("160x120")
        cbovideoformat.Items.Add("176x144")
        cbovideoformat.Items.Add("320x240")
        cbovideoformat.Items.Add("352x288")
        cbovideoformat.Items.Add("640x480")
        cbovideoformat.Items.Add("1280x720")
        cbovideoformat.Items.Add("1920x1080")
        cbovideoformat.Items.Add("1920x1280")


        cbovideoformat.SelectedIndex = 4



        cboaudiocomplex.Items.Add("0")
        cboaudiocomplex.Items.Add("1")
        cboaudiocomplex.Items.Add("2")
        cboaudiocomplex.Items.Add("3")
        cboaudiocomplex.SelectedIndex = 0


        For i = 0 To 10
            cboaudioquality.Items.Add(i.ToString())

        Next


        cboaudioquality.SelectedIndex = 8
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AxVideoChatSender1.VideoDevice = cbovideodevice.SelectedIndex
        AxVideoChatSender1.AudioDevice = cboaudiodevice.SelectedIndex
        AxVideoChatSender1.VideoFormat = cbovideoformat.SelectedIndex
        AxVideoChatSender1.FrameRate = txtframerate.Text
        AxVideoChatSender1.VideoBitrate = Convert.ToInt32(txtVideobitrate.Text)
        AxVideoChatSender1.AudioComplexity = cboaudiocomplex.SelectedIndex
        AxVideoChatSender1.AudioQuality = cboaudioquality.SelectedIndex
        AxVideoChatSender1.SendAudioStream = chksendaudio.Checked
        AxVideoChatSender1.SendVideoStream = chksendvideo.Checked


        Dim iresult As Integer
        iresult = AxVideoChatSender1.Connect(txtconnectIP.Text, Convert.ToInt32(txtConnectPortNo.Text))

    End Sub

    Private Sub AxVideoChatSender1_SendStream(sender As System.Object, e As AxVideoChatSenderLib._DvideochatEvents_SendStreamEvent) Handles AxVideoChatSender1.SendStream
        lblvideobitrate.Text = e.fVideoBitrate
        lblaudiobitrate.Text = e.fAudioBitrate
    End Sub

  
    Private Sub btnstartlisten_Click(sender As System.Object, e As System.EventArgs) Handles btnstartlisten.Click
        Dim bResult As Boolean
        AxVideoChatReceiver1.ReceiveAudioStream = chkreceiveaudio.Checked
        AxVideoChatReceiver1.ReceiveVideoStream = chkreceivevideo.Checked
        AxVideoChatReceiver1.ReceiverVideoNoVideoImage(TextBox1.Text)

        If RadioAspectRatio1.Checked Then
            AxVideoChatReceiver1.VideoWindowAspectRatio = 0
        ElseIf RadioAspectRatio2.Checked Then

            AxVideoChatReceiver1.VideoWindowAspectRatio = 1
        ElseIf RadioAspectRatio3.Checked Then
            AxVideoChatReceiver1.VideoWindowAspectRatio = 2
        End If



        bResult = AxVideoChatReceiver1.Listen(txtListenIP.Text, Convert.ToInt32(txtlistenportno.Text, 10))

        btnstartlisten.Enabled = False
        btnlistendisconnect.Enabled = True
    End Sub

    Private Sub btnlistendisconnect_Click(sender As System.Object, e As System.EventArgs) Handles btnlistendisconnect.Click
        AxVideoChatReceiver1.Disconnect()
        btnstartlisten.Enabled = True
        btnlistendisconnect.Enabled = False

    End Sub

    Private Sub btnsnapshot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsnapshot.Click
        SaveFileDialog1.Filter = "JPG File (*.jpg)|*.jpg"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            AxVideoChatReceiver1.SnapShot(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        AxVideoChatSender1.Disconnect()
    End Sub
End Class
