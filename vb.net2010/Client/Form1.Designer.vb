<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtConnectPortNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtconnectIP = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chksendaudio = New System.Windows.Forms.CheckBox()
        Me.chksendvideo = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVideobitrate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboaudioquality = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtframerate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbovideoformat = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboaudiocomplex = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboaudiodevice = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbovideodevice = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AxVideoChatSender1 = New AxVideoChatSenderLib.AxVideoChatSender()
        Me.lblaudiobitrate = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblvideobitrate = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnstartlisten = New System.Windows.Forms.Button()
        Me.chkreceiveaudio = New System.Windows.Forms.CheckBox()
        Me.chkreceivevideo = New System.Windows.Forms.CheckBox()
        Me.txtlistenportno = New System.Windows.Forms.TextBox()
        Me.btnlistendisconnect = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RadioAspectRatio3 = New System.Windows.Forms.RadioButton()
        Me.RadioAspectRatio2 = New System.Windows.Forms.RadioButton()
        Me.RadioAspectRatio1 = New System.Windows.Forms.RadioButton()
        Me.AxVideoChatReceiver1 = New AxVideoChatReceiverLib.AxVideoChatReceiver()
        Me.btnsnapshot = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtListenIP = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxVideoChatSender1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.AxVideoChatReceiver1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtConnectPortNo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtconnectIP)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.chksendaudio)
        Me.GroupBox1.Controls.Add(Me.chksendvideo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtVideobitrate)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboaudioquality)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtframerate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbovideoformat)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboaudiocomplex)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboaudiodevice)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbovideodevice)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 204)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connect"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(419, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 43)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Disconnect"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(301, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 43)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtConnectPortNo
        '
        Me.txtConnectPortNo.Location = New System.Drawing.Point(221, 159)
        Me.txtConnectPortNo.Name = "txtConnectPortNo"
        Me.txtConnectPortNo.Size = New System.Drawing.Size(58, 21)
        Me.txtConnectPortNo.TabIndex = 22
        Me.txtConnectPortNo.Text = "7000"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(172, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 12)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Port No"
        '
        'txtconnectIP
        '
        Me.txtconnectIP.Location = New System.Drawing.Point(22, 176)
        Me.txtconnectIP.Name = "txtconnectIP"
        Me.txtconnectIP.Size = New System.Drawing.Size(95, 21)
        Me.txtconnectIP.TabIndex = 20
        Me.txtconnectIP.Text = "127.0.0.1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 12)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Connect to IP Address"
        '
        'chksendaudio
        '
        Me.chksendaudio.AutoSize = True
        Me.chksendaudio.Checked = True
        Me.chksendaudio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chksendaudio.Location = New System.Drawing.Point(390, 129)
        Me.chksendaudio.Name = "chksendaudio"
        Me.chksendaudio.Size = New System.Drawing.Size(84, 11)
        Me.chksendaudio.TabIndex = 18
        Me.chksendaudio.Text = "Send Audio Stream"
        Me.chksendaudio.UseVisualStyleBackColor = True
        '
        'chksendvideo
        '
        Me.chksendvideo.AutoSize = True
        Me.chksendvideo.Checked = True
        Me.chksendvideo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chksendvideo.Location = New System.Drawing.Point(267, 129)
        Me.chksendvideo.Name = "chksendvideo"
        Me.chksendvideo.Size = New System.Drawing.Size(84, 11)
        Me.chksendvideo.TabIndex = 17
        Me.chksendvideo.Text = "Send Video Stream"
        Me.chksendvideo.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(215, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 12)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "bits"
        '
        'txtVideobitrate
        '
        Me.txtVideobitrate.Location = New System.Drawing.Point(105, 127)
        Me.txtVideobitrate.Name = "txtVideobitrate"
        Me.txtVideobitrate.Size = New System.Drawing.Size(95, 21)
        Me.txtVideobitrate.TabIndex = 15
        Me.txtVideobitrate.Text = "228000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 12)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Video Bitrate"
        '
        'cboaudioquality
        '
        Me.cboaudioquality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboaudioquality.FormattingEnabled = True
        Me.cboaudioquality.Location = New System.Drawing.Point(542, 91)
        Me.cboaudioquality.Name = "cboaudioquality"
        Me.cboaudioquality.Size = New System.Drawing.Size(94, 20)
        Me.cboaudioquality.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(467, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 12)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Audio Quality"
        '
        'txtframerate
        '
        Me.txtframerate.Location = New System.Drawing.Point(419, 89)
        Me.txtframerate.Name = "txtframerate"
        Me.txtframerate.Size = New System.Drawing.Size(42, 21)
        Me.txtframerate.TabIndex = 11
        Me.txtframerate.Text = "25"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(347, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Frame Rate"
        '
        'cbovideoformat
        '
        Me.cbovideoformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoformat.FormattingEnabled = True
        Me.cbovideoformat.Location = New System.Drawing.Point(105, 86)
        Me.cbovideoformat.Name = "cbovideoformat"
        Me.cbovideoformat.Size = New System.Drawing.Size(222, 20)
        Me.cbovideoformat.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Video Format"
        '
        'cboaudiocomplex
        '
        Me.cboaudiocomplex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboaudiocomplex.FormattingEnabled = True
        Me.cboaudiocomplex.Location = New System.Drawing.Point(440, 51)
        Me.cboaudiocomplex.Name = "cboaudiocomplex"
        Me.cboaudiocomplex.Size = New System.Drawing.Size(127, 20)
        Me.cboaudiocomplex.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(347, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Audio Complexity"
        '
        'cboaudiodevice
        '
        Me.cboaudiodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboaudiodevice.FormattingEnabled = True
        Me.cboaudiodevice.Location = New System.Drawing.Point(105, 53)
        Me.cboaudiodevice.Name = "cboaudiodevice"
        Me.cboaudiodevice.Size = New System.Drawing.Size(222, 20)
        Me.cboaudiodevice.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Audio Device"
        '
        'cbovideodevice
        '
        Me.cbovideodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideodevice.FormattingEnabled = True
        Me.cbovideodevice.Location = New System.Drawing.Point(105, 19)
        Me.cbovideodevice.Name = "cbovideodevice"
        Me.cbovideodevice.Size = New System.Drawing.Size(222, 20)
        Me.cbovideodevice.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Video Device"
        '
        'AxVideoChatSender1
        '
        Me.AxVideoChatSender1.Enabled = True
        Me.AxVideoChatSender1.Location = New System.Drawing.Point(8, 233)
        Me.AxVideoChatSender1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AxVideoChatSender1.Name = "AxVideoChatSender1"
        Me.AxVideoChatSender1.OcxState = CType(resources.GetObject("AxVideoChatSender1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoChatSender1.Size = New System.Drawing.Size(371, 266)
        Me.AxVideoChatSender1.TabIndex = 3
        '
        'lblaudiobitrate
        '
        Me.lblaudiobitrate.AutoSize = True
        Me.lblaudiobitrate.Location = New System.Drawing.Point(399, 329)
        Me.lblaudiobitrate.Name = "lblaudiobitrate"
        Me.lblaudiobitrate.Size = New System.Drawing.Size(11, 12)
        Me.lblaudiobitrate.TabIndex = 32
        Me.lblaudiobitrate.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(399, 304)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(143, 12)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Audio bitrate (bit/sec)"
        '
        'lblvideobitrate
        '
        Me.lblvideobitrate.AutoSize = True
        Me.lblvideobitrate.Location = New System.Drawing.Point(399, 259)
        Me.lblvideobitrate.Name = "lblvideobitrate"
        Me.lblvideobitrate.Size = New System.Drawing.Size(11, 12)
        Me.lblvideobitrate.TabIndex = 30
        Me.lblvideobitrate.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(397, 233)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 12)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Video bitrate (bit/sec)"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(33, 356)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(370, 21)
        Me.TextBox1.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 337)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 12)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "No Video Image"
        '
        'btnstartlisten
        '
        Me.btnstartlisten.Location = New System.Drawing.Point(24, 469)
        Me.btnstartlisten.Name = "btnstartlisten"
        Me.btnstartlisten.Size = New System.Drawing.Size(122, 40)
        Me.btnstartlisten.TabIndex = 37
        Me.btnstartlisten.Text = "Start Listening"
        Me.btnstartlisten.UseVisualStyleBackColor = True
        '
        'chkreceiveaudio
        '
        Me.chkreceiveaudio.AutoSize = True
        Me.chkreceiveaudio.Checked = True
        Me.chkreceiveaudio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkreceiveaudio.Location = New System.Drawing.Point(153, 382)
        Me.chkreceiveaudio.Name = "chkreceiveaudio"
        Me.chkreceiveaudio.Size = New System.Drawing.Size(126, 16)
        Me.chkreceiveaudio.TabIndex = 36
        Me.chkreceiveaudio.Text = "Send Audio Stream"
        Me.chkreceiveaudio.UseVisualStyleBackColor = True
        '
        'chkreceivevideo
        '
        Me.chkreceivevideo.AutoSize = True
        Me.chkreceivevideo.Checked = True
        Me.chkreceivevideo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkreceivevideo.Location = New System.Drawing.Point(29, 382)
        Me.chkreceivevideo.Name = "chkreceivevideo"
        Me.chkreceivevideo.Size = New System.Drawing.Size(126, 16)
        Me.chkreceivevideo.TabIndex = 35
        Me.chkreceivevideo.Text = "Send Video Stream"
        Me.chkreceivevideo.UseVisualStyleBackColor = True
        '
        'txtlistenportno
        '
        Me.txtlistenportno.Location = New System.Drawing.Point(199, 292)
        Me.txtlistenportno.Name = "txtlistenportno"
        Me.txtlistenportno.Size = New System.Drawing.Size(58, 21)
        Me.txtlistenportno.TabIndex = 34
        Me.txtlistenportno.Text = "7000"
        '
        'btnlistendisconnect
        '
        Me.btnlistendisconnect.Enabled = False
        Me.btnlistendisconnect.Location = New System.Drawing.Point(153, 469)
        Me.btnlistendisconnect.Name = "btnlistendisconnect"
        Me.btnlistendisconnect.Size = New System.Drawing.Size(122, 40)
        Me.btnlistendisconnect.TabIndex = 38
        Me.btnlistendisconnect.Text = "Disconnect"
        Me.btnlistendisconnect.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.AxVideoChatReceiver1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnsnapshot)
        Me.GroupBox2.Controls.Add(Me.btnlistendisconnect)
        Me.GroupBox2.Controls.Add(Me.btnstartlisten)
        Me.GroupBox2.Controls.Add(Me.chkreceiveaudio)
        Me.GroupBox2.Controls.Add(Me.chkreceivevideo)
        Me.GroupBox2.Controls.Add(Me.txtlistenportno)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtListenIP)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(671, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(525, 518)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listen"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioAspectRatio3)
        Me.GroupBox6.Controls.Add(Me.RadioAspectRatio2)
        Me.GroupBox6.Controls.Add(Me.RadioAspectRatio1)
        Me.GroupBox6.Location = New System.Drawing.Point(7, 404)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(415, 60)
        Me.GroupBox6.TabIndex = 53
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Aspect Ratio of Max Video Window"
        '
        'RadioAspectRatio3
        '
        Me.RadioAspectRatio3.AutoSize = True
        Me.RadioAspectRatio3.Location = New System.Drawing.Point(183, 23)
        Me.RadioAspectRatio3.Name = "RadioAspectRatio3"
        Me.RadioAspectRatio3.Size = New System.Drawing.Size(65, 16)
        Me.RadioAspectRatio3.TabIndex = 2
        Me.RadioAspectRatio3.Text = "Stretch"
        Me.RadioAspectRatio3.UseVisualStyleBackColor = True
        '
        'RadioAspectRatio2
        '
        Me.RadioAspectRatio2.AutoSize = True
        Me.RadioAspectRatio2.Location = New System.Drawing.Point(103, 23)
        Me.RadioAspectRatio2.Name = "RadioAspectRatio2"
        Me.RadioAspectRatio2.Size = New System.Drawing.Size(47, 16)
        Me.RadioAspectRatio2.TabIndex = 1
        Me.RadioAspectRatio2.Text = "16:9"
        Me.RadioAspectRatio2.UseVisualStyleBackColor = True
        '
        'RadioAspectRatio1
        '
        Me.RadioAspectRatio1.AutoSize = True
        Me.RadioAspectRatio1.Checked = True
        Me.RadioAspectRatio1.Location = New System.Drawing.Point(13, 23)
        Me.RadioAspectRatio1.Name = "RadioAspectRatio1"
        Me.RadioAspectRatio1.Size = New System.Drawing.Size(41, 16)
        Me.RadioAspectRatio1.TabIndex = 0
        Me.RadioAspectRatio1.TabStop = True
        Me.RadioAspectRatio1.Text = "4:3"
        Me.RadioAspectRatio1.UseVisualStyleBackColor = True
        '
        'AxVideoChatReceiver1
        '
        Me.AxVideoChatReceiver1.Enabled = True
        Me.AxVideoChatReceiver1.Location = New System.Drawing.Point(20, 26)
        Me.AxVideoChatReceiver1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AxVideoChatReceiver1.Name = "AxVideoChatReceiver1"
        Me.AxVideoChatReceiver1.OcxState = CType(resources.GetObject("AxVideoChatReceiver1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoChatReceiver1.Size = New System.Drawing.Size(417, 244)
        Me.AxVideoChatReceiver1.TabIndex = 42
        '
        'btnsnapshot
        '
        Me.btnsnapshot.Location = New System.Drawing.Point(295, 469)
        Me.btnsnapshot.Name = "btnsnapshot"
        Me.btnsnapshot.Size = New System.Drawing.Size(122, 40)
        Me.btnsnapshot.TabIndex = 39
        Me.btnsnapshot.Text = "Snapshot"
        Me.btnsnapshot.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(149, 292)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 12)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Port No"
        '
        'txtListenIP
        '
        Me.txtListenIP.Location = New System.Drawing.Point(31, 310)
        Me.txtListenIP.Name = "txtListenIP"
        Me.txtListenIP.Size = New System.Drawing.Size(95, 21)
        Me.txtListenIP.TabIndex = 32
        Me.txtListenIP.Text = "127.0.0.1"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(28, 292)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 12)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Listen From"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 536)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblaudiobitrate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblvideobitrate)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.AxVideoChatSender1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxVideoChatSender1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.AxVideoChatReceiver1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtConnectPortNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtconnectIP As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chksendaudio As System.Windows.Forms.CheckBox
    Friend WithEvents chksendvideo As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtVideobitrate As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboaudioquality As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtframerate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbovideoformat As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboaudiocomplex As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboaudiodevice As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbovideodevice As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AxVideoChatSender1 As AxVideoChatSenderLib.AxVideoChatSender
    Friend WithEvents lblaudiobitrate As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblvideobitrate As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnstartlisten As System.Windows.Forms.Button
    Friend WithEvents chkreceiveaudio As System.Windows.Forms.CheckBox
    Friend WithEvents chkreceivevideo As System.Windows.Forms.CheckBox
    Friend WithEvents txtlistenportno As System.Windows.Forms.TextBox
    Friend WithEvents btnlistendisconnect As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents AxVideoChatReceiver1 As AxVideoChatReceiverLib.AxVideoChatReceiver
    Friend WithEvents btnsnapshot As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtListenIP As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioAspectRatio3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioAspectRatio2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioAspectRatio1 As System.Windows.Forms.RadioButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
