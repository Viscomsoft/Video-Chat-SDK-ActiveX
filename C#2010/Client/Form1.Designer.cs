namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtConnectPortNo = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtconnectIP = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.chksendaudio = new System.Windows.Forms.CheckBox();
            this.chksendvideo = new System.Windows.Forms.CheckBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtVideobitrate = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.cboaudioquality = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtframerate = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.cbovideoformat = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.cboaudiocomplex = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.cboaudiodevice = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.cbovideodevice = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.RadioAspectRatio3 = new System.Windows.Forms.RadioButton();
            this.RadioAspectRatio2 = new System.Windows.Forms.RadioButton();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.RadioAspectRatio1 = new System.Windows.Forms.RadioButton();
            this.btnsnapshot = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.axVideoChatReceiver1 = new AxVideoChatReceiverLib.AxVideoChatReceiver();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnlistendisconnect = new System.Windows.Forms.Button();
            this.btnstartlisten = new System.Windows.Forms.Button();
            this.chkreceiveaudio = new System.Windows.Forms.CheckBox();
            this.chkreceivevideo = new System.Windows.Forms.CheckBox();
            this.txtlistenportno = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.txtListenIP = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.lblaudiobitrate = new System.Windows.Forms.Label();
            this.lblvideobitrate = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.axVideoChatSender1 = new AxVideoChatSenderLib.AxVideoChatSender();
            this.GroupBox1.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatSender1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Controls.Add(this.Button1);
            this.GroupBox1.Controls.Add(this.txtConnectPortNo);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.txtconnectIP);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.chksendaudio);
            this.GroupBox1.Controls.Add(this.chksendvideo);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.txtVideobitrate);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.cboaudioquality);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.txtframerate);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.cbovideoformat);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.cboaudiocomplex);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.cboaudiodevice);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.cbovideodevice);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(8, 9);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(642, 204);
            this.GroupBox1.TabIndex = 34;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Connect";
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(419, 152);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(107, 43);
            this.Button2.TabIndex = 24;
            this.Button2.Text = "Disconnect";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(301, 151);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(107, 43);
            this.Button1.TabIndex = 23;
            this.Button1.Text = "Connect";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtConnectPortNo
            // 
            this.txtConnectPortNo.Location = new System.Drawing.Point(221, 159);
            this.txtConnectPortNo.Name = "txtConnectPortNo";
            this.txtConnectPortNo.Size = new System.Drawing.Size(58, 21);
            this.txtConnectPortNo.TabIndex = 22;
            this.txtConnectPortNo.Text = "7000";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(172, 159);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(47, 12);
            this.Label11.TabIndex = 21;
            this.Label11.Text = "Port No";
            // 
            // txtconnectIP
            // 
            this.txtconnectIP.Location = new System.Drawing.Point(22, 176);
            this.txtconnectIP.Name = "txtconnectIP";
            this.txtconnectIP.Size = new System.Drawing.Size(95, 21);
            this.txtconnectIP.TabIndex = 20;
            this.txtconnectIP.Text = "127.0.0.1";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(19, 159);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(131, 12);
            this.Label10.TabIndex = 19;
            this.Label10.Text = "Connect to IP Address";
            // 
            // chksendaudio
            // 
            this.chksendaudio.AutoSize = true;
            this.chksendaudio.Checked = true;
            this.chksendaudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chksendaudio.Location = new System.Drawing.Point(390, 123);
            this.chksendaudio.Name = "chksendaudio";
            this.chksendaudio.Size = new System.Drawing.Size(126, 16);
            this.chksendaudio.TabIndex = 18;
            this.chksendaudio.Text = "Send Audio Stream";
            this.chksendaudio.UseVisualStyleBackColor = true;
            // 
            // chksendvideo
            // 
            this.chksendvideo.AutoSize = true;
            this.chksendvideo.Checked = true;
            this.chksendvideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chksendvideo.Location = new System.Drawing.Point(267, 123);
            this.chksendvideo.Name = "chksendvideo";
            this.chksendvideo.Size = new System.Drawing.Size(126, 16);
            this.chksendvideo.TabIndex = 17;
            this.chksendvideo.Text = "Send Video Stream";
            this.chksendvideo.UseVisualStyleBackColor = true;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(215, 129);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(29, 12);
            this.Label9.TabIndex = 16;
            this.Label9.Text = "bits";
            // 
            // txtVideobitrate
            // 
            this.txtVideobitrate.Location = new System.Drawing.Point(105, 127);
            this.txtVideobitrate.Name = "txtVideobitrate";
            this.txtVideobitrate.Size = new System.Drawing.Size(95, 21);
            this.txtVideobitrate.TabIndex = 15;
            this.txtVideobitrate.Text = "228000";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(16, 127);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(83, 12);
            this.Label8.TabIndex = 14;
            this.Label8.Text = "Video Bitrate";
            // 
            // cboaudioquality
            // 
            this.cboaudioquality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaudioquality.FormattingEnabled = true;
            this.cboaudioquality.Location = new System.Drawing.Point(542, 91);
            this.cboaudioquality.Name = "cboaudioquality";
            this.cboaudioquality.Size = new System.Drawing.Size(94, 20);
            this.cboaudioquality.TabIndex = 13;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(467, 93);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(83, 12);
            this.Label7.TabIndex = 12;
            this.Label7.Text = "Audio Quality";
            // 
            // txtframerate
            // 
            this.txtframerate.Location = new System.Drawing.Point(419, 89);
            this.txtframerate.Name = "txtframerate";
            this.txtframerate.Size = new System.Drawing.Size(42, 21);
            this.txtframerate.TabIndex = 11;
            this.txtframerate.Text = "25";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(347, 91);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(65, 12);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Frame Rate";
            // 
            // cbovideoformat
            // 
            this.cbovideoformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbovideoformat.FormattingEnabled = true;
            this.cbovideoformat.Location = new System.Drawing.Point(105, 86);
            this.cbovideoformat.Name = "cbovideoformat";
            this.cbovideoformat.Size = new System.Drawing.Size(222, 20);
            this.cbovideoformat.TabIndex = 9;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(14, 88);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(77, 12);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Video Format";
            // 
            // cboaudiocomplex
            // 
            this.cboaudiocomplex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaudiocomplex.FormattingEnabled = true;
            this.cboaudiocomplex.Location = new System.Drawing.Point(440, 51);
            this.cboaudiocomplex.Name = "cboaudiocomplex";
            this.cboaudiocomplex.Size = new System.Drawing.Size(127, 20);
            this.cboaudiocomplex.TabIndex = 7;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(347, 53);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(101, 12);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Audio Complexity";
            // 
            // cboaudiodevice
            // 
            this.cboaudiodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaudiodevice.FormattingEnabled = true;
            this.cboaudiodevice.Location = new System.Drawing.Point(105, 53);
            this.cboaudiodevice.Name = "cboaudiodevice";
            this.cboaudiodevice.Size = new System.Drawing.Size(222, 20);
            this.cboaudiodevice.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(14, 56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(77, 12);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Audio Device";
            // 
            // cbovideodevice
            // 
            this.cbovideodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbovideodevice.FormattingEnabled = true;
            this.cbovideodevice.Location = new System.Drawing.Point(105, 19);
            this.cbovideodevice.Name = "cbovideodevice";
            this.cbovideodevice.Size = new System.Drawing.Size(222, 20);
            this.cbovideodevice.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(77, 12);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Video Device";
            // 
            // RadioAspectRatio3
            // 
            this.RadioAspectRatio3.AutoSize = true;
            this.RadioAspectRatio3.Location = new System.Drawing.Point(183, 23);
            this.RadioAspectRatio3.Name = "RadioAspectRatio3";
            this.RadioAspectRatio3.Size = new System.Drawing.Size(65, 16);
            this.RadioAspectRatio3.TabIndex = 2;
            this.RadioAspectRatio3.Text = "Stretch";
            this.RadioAspectRatio3.UseVisualStyleBackColor = true;
            // 
            // RadioAspectRatio2
            // 
            this.RadioAspectRatio2.AutoSize = true;
            this.RadioAspectRatio2.Location = new System.Drawing.Point(103, 23);
            this.RadioAspectRatio2.Name = "RadioAspectRatio2";
            this.RadioAspectRatio2.Size = new System.Drawing.Size(47, 16);
            this.RadioAspectRatio2.TabIndex = 1;
            this.RadioAspectRatio2.Text = "16:9";
            this.RadioAspectRatio2.UseVisualStyleBackColor = true;
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.RadioAspectRatio3);
            this.GroupBox6.Controls.Add(this.RadioAspectRatio2);
            this.GroupBox6.Controls.Add(this.RadioAspectRatio1);
            this.GroupBox6.Location = new System.Drawing.Point(7, 402);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(415, 48);
            this.GroupBox6.TabIndex = 53;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "Aspect Ratio of Max Video Window";
            // 
            // RadioAspectRatio1
            // 
            this.RadioAspectRatio1.AutoSize = true;
            this.RadioAspectRatio1.Checked = true;
            this.RadioAspectRatio1.Location = new System.Drawing.Point(13, 23);
            this.RadioAspectRatio1.Name = "RadioAspectRatio1";
            this.RadioAspectRatio1.Size = new System.Drawing.Size(41, 16);
            this.RadioAspectRatio1.TabIndex = 0;
            this.RadioAspectRatio1.TabStop = true;
            this.RadioAspectRatio1.Text = "4:3";
            this.RadioAspectRatio1.UseVisualStyleBackColor = true;
            // 
            // btnsnapshot
            // 
            this.btnsnapshot.Location = new System.Drawing.Point(295, 469);
            this.btnsnapshot.Name = "btnsnapshot";
            this.btnsnapshot.Size = new System.Drawing.Size(122, 40);
            this.btnsnapshot.TabIndex = 39;
            this.btnsnapshot.Text = "Snapshot";
            this.btnsnapshot.UseVisualStyleBackColor = true;
            this.btnsnapshot.Click += new System.EventHandler(this.btnsnapshot_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.axVideoChatReceiver1);
            this.GroupBox2.Controls.Add(this.GroupBox6);
            this.GroupBox2.Controls.Add(this.TextBox1);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.btnsnapshot);
            this.GroupBox2.Controls.Add(this.btnlistendisconnect);
            this.GroupBox2.Controls.Add(this.btnstartlisten);
            this.GroupBox2.Controls.Add(this.chkreceiveaudio);
            this.GroupBox2.Controls.Add(this.chkreceivevideo);
            this.GroupBox2.Controls.Add(this.txtlistenportno);
            this.GroupBox2.Controls.Add(this.Label17);
            this.GroupBox2.Controls.Add(this.txtListenIP);
            this.GroupBox2.Controls.Add(this.Label16);
            this.GroupBox2.Location = new System.Drawing.Point(669, 3);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(422, 518);
            this.GroupBox2.TabIndex = 39;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Listen";
            // 
            // axVideoChatReceiver1
            // 
            this.axVideoChatReceiver1.Enabled = true;
            this.axVideoChatReceiver1.Location = new System.Drawing.Point(30, 30);
            this.axVideoChatReceiver1.Name = "axVideoChatReceiver1";
            this.axVideoChatReceiver1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatReceiver1.OcxState")));
            this.axVideoChatReceiver1.Size = new System.Drawing.Size(355, 245);
            this.axVideoChatReceiver1.TabIndex = 54;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(33, 356);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(370, 21);
            this.TextBox1.TabIndex = 41;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(31, 337);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 12);
            this.Label3.TabIndex = 40;
            this.Label3.Text = "No Video Image";
            // 
            // btnlistendisconnect
            // 
            this.btnlistendisconnect.Enabled = false;
            this.btnlistendisconnect.Location = new System.Drawing.Point(153, 469);
            this.btnlistendisconnect.Name = "btnlistendisconnect";
            this.btnlistendisconnect.Size = new System.Drawing.Size(122, 40);
            this.btnlistendisconnect.TabIndex = 38;
            this.btnlistendisconnect.Text = "Disconnect";
            this.btnlistendisconnect.UseVisualStyleBackColor = true;
            this.btnlistendisconnect.Click += new System.EventHandler(this.btnlistendisconnect_Click);
            // 
            // btnstartlisten
            // 
            this.btnstartlisten.Location = new System.Drawing.Point(24, 469);
            this.btnstartlisten.Name = "btnstartlisten";
            this.btnstartlisten.Size = new System.Drawing.Size(122, 40);
            this.btnstartlisten.TabIndex = 37;
            this.btnstartlisten.Text = "Start Listening";
            this.btnstartlisten.UseVisualStyleBackColor = true;
            this.btnstartlisten.Click += new System.EventHandler(this.btnstartlisten_Click);
            // 
            // chkreceiveaudio
            // 
            this.chkreceiveaudio.AutoSize = true;
            this.chkreceiveaudio.Checked = true;
            this.chkreceiveaudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkreceiveaudio.Location = new System.Drawing.Point(153, 382);
            this.chkreceiveaudio.Name = "chkreceiveaudio";
            this.chkreceiveaudio.Size = new System.Drawing.Size(126, 16);
            this.chkreceiveaudio.TabIndex = 36;
            this.chkreceiveaudio.Text = "Send Audio Stream";
            this.chkreceiveaudio.UseVisualStyleBackColor = true;
            // 
            // chkreceivevideo
            // 
            this.chkreceivevideo.AutoSize = true;
            this.chkreceivevideo.Checked = true;
            this.chkreceivevideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkreceivevideo.Location = new System.Drawing.Point(29, 382);
            this.chkreceivevideo.Name = "chkreceivevideo";
            this.chkreceivevideo.Size = new System.Drawing.Size(126, 16);
            this.chkreceivevideo.TabIndex = 35;
            this.chkreceivevideo.Text = "Send Video Stream";
            this.chkreceivevideo.UseVisualStyleBackColor = true;
            // 
            // txtlistenportno
            // 
            this.txtlistenportno.Location = new System.Drawing.Point(199, 292);
            this.txtlistenportno.Name = "txtlistenportno";
            this.txtlistenportno.Size = new System.Drawing.Size(58, 21);
            this.txtlistenportno.TabIndex = 34;
            this.txtlistenportno.Text = "7000";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(149, 292);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(47, 12);
            this.Label17.TabIndex = 33;
            this.Label17.Text = "Port No";
            // 
            // txtListenIP
            // 
            this.txtListenIP.Location = new System.Drawing.Point(31, 310);
            this.txtListenIP.Name = "txtListenIP";
            this.txtListenIP.Size = new System.Drawing.Size(95, 21);
            this.txtListenIP.TabIndex = 32;
            this.txtListenIP.Text = "127.0.0.1";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(28, 292);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(71, 12);
            this.Label16.TabIndex = 31;
            this.Label16.Text = "Listen From";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(397, 297);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(143, 12);
            this.Label14.TabIndex = 37;
            this.Label14.Text = "Audio bitrate (bit/sec)";
            // 
            // lblaudiobitrate
            // 
            this.lblaudiobitrate.AutoSize = true;
            this.lblaudiobitrate.Location = new System.Drawing.Point(397, 323);
            this.lblaudiobitrate.Name = "lblaudiobitrate";
            this.lblaudiobitrate.Size = new System.Drawing.Size(11, 12);
            this.lblaudiobitrate.TabIndex = 38;
            this.lblaudiobitrate.Text = "0";
            // 
            // lblvideobitrate
            // 
            this.lblvideobitrate.AutoSize = true;
            this.lblvideobitrate.Location = new System.Drawing.Point(397, 252);
            this.lblvideobitrate.Name = "lblvideobitrate";
            this.lblvideobitrate.Size = new System.Drawing.Size(11, 12);
            this.lblvideobitrate.TabIndex = 36;
            this.lblvideobitrate.Text = "0";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(396, 227);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(143, 12);
            this.Label12.TabIndex = 35;
            this.Label12.Text = "Video bitrate (bit/sec)";
            // 
            // axVideoChatSender1
            // 
            this.axVideoChatSender1.Enabled = true;
            this.axVideoChatSender1.Location = new System.Drawing.Point(24, 227);
            this.axVideoChatSender1.Name = "axVideoChatSender1";
            this.axVideoChatSender1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatSender1.OcxState")));
            this.axVideoChatSender1.Size = new System.Drawing.Size(354, 242);
            this.axVideoChatSender1.TabIndex = 40;
            this.axVideoChatSender1.SendStream += new AxVideoChatSenderLib._DvideochatEvents_SendStreamEventHandler(this.axVideoChatSender1_SendStream);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 528);
            this.Controls.Add(this.axVideoChatSender1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.lblaudiobitrate);
            this.Controls.Add(this.lblvideobitrate);
            this.Controls.Add(this.Label12);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatSender1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtConnectPortNo;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtconnectIP;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.CheckBox chksendaudio;
        internal System.Windows.Forms.CheckBox chksendvideo;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtVideobitrate;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.ComboBox cboaudioquality;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtframerate;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ComboBox cbovideoformat;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox cboaudiocomplex;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cboaudiodevice;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox cbovideodevice;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.RadioButton RadioAspectRatio3;
        internal System.Windows.Forms.RadioButton RadioAspectRatio2;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.RadioButton RadioAspectRatio1;
        internal System.Windows.Forms.Button btnsnapshot;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnlistendisconnect;
        internal System.Windows.Forms.Button btnstartlisten;
        internal System.Windows.Forms.CheckBox chkreceiveaudio;
        internal System.Windows.Forms.CheckBox chkreceivevideo;
        internal System.Windows.Forms.TextBox txtlistenportno;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.TextBox txtListenIP;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label lblaudiobitrate;
        internal System.Windows.Forms.Label lblvideobitrate;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private AxVideoChatReceiverLib.AxVideoChatReceiver axVideoChatReceiver1;
        private AxVideoChatSenderLib.AxVideoChatSender axVideoChatSender1;
    }
}

