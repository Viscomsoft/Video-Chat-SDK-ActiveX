using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void axVideoChatSender1_SendStream(object sender, AxVideoChatSenderLib._DvideochatEvents_SendStreamEvent e)
        {
            lblvideobitrate.Text = e.fVideoBitrate.ToString();
            lblaudiobitrate.Text = e.fAudioBitrate.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int ivideodevicecount;
            int iaudiodevicecount;
            string strApp;
            int iFindIndex;
            int i;

           

            strApp = Application.ExecutablePath;

            iFindIndex = strApp.IndexOf("Examples");

            if (iFindIndex != -1)
            {
                TextBox1.Text = strApp.Substring(0, iFindIndex) + "novideo.bmp";
            }



            ivideodevicecount = axVideoChatSender1.GetVideoDeviceCount();

            for (i = 0; i < ivideodevicecount; i++)
            {

                cbovideodevice.Items.Add(axVideoChatSender1.GetVideoDeviceName((short)i));

            }
            if (cbovideodevice.Items.Count > 0)
                cbovideodevice.SelectedIndex = 0;

            iaudiodevicecount = axVideoChatSender1.GetAudioDeviceCount();

            for (i = 0; i < iaudiodevicecount; i++)
                cboaudiodevice.Items.Add(axVideoChatSender1.GetAudioDeviceName((short)i));

            if (cboaudiodevice.Items.Count > 0)
                cboaudiodevice.SelectedIndex = 0;

            cbovideoformat.Items.Add("160x120");
            cbovideoformat.Items.Add("176x144");
            cbovideoformat.Items.Add("320x240");
            cbovideoformat.Items.Add("352x288");
            cbovideoformat.Items.Add("640x480");
            cbovideoformat.Items.Add("1280x720");
            cbovideoformat.Items.Add("1920x1080");
            cbovideoformat.Items.Add("1920x1280");

            cbovideoformat.SelectedIndex = 4;


            cboaudiocomplex.Items.Add("0");
            cboaudiocomplex.Items.Add("1");
            cboaudiocomplex.Items.Add("2");
            cboaudiocomplex.Items.Add("3");
            cboaudiocomplex.SelectedIndex = 0;



            for (i = 0; i <= 10; i++)
            {


                cboaudioquality.Items.Add(i.ToString());

            }
            cboaudioquality.SelectedIndex = 8;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            axVideoChatSender1.VideoDevice = (short)cbovideodevice.SelectedIndex;

            axVideoChatSender1.AudioDevice = (short)cboaudiodevice.SelectedIndex;


            axVideoChatSender1.VideoFormat = (short)cbovideoformat.SelectedIndex;
            axVideoChatSender1.FrameRate = Convert.ToInt32(txtframerate.Text, 10);
            axVideoChatSender1.VideoBitrate = Convert.ToInt32(txtVideobitrate.Text, 10);
            axVideoChatSender1.AudioComplexity = (short)cboaudiocomplex.SelectedIndex;
            axVideoChatSender1.AudioQuality = (short)cboaudioquality.SelectedIndex;
            axVideoChatSender1.SendAudioStream = chksendaudio.Checked;
            axVideoChatSender1.SendVideoStream = chksendvideo.Checked;

        
            int iResult = axVideoChatSender1.Connect(txtconnectIP.Text, Convert.ToInt32(txtConnectPortNo.Text, 10));

		
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            axVideoChatSender1.Disconnect();
        }

        private void btnstartlisten_Click(object sender, EventArgs e)
        {


            if (RadioAspectRatio1.Checked)
                axVideoChatReceiver1.VideoWindowAspectRatio = 0;
            else if (RadioAspectRatio2.Checked)
                axVideoChatReceiver1.VideoWindowAspectRatio = 1;
            else if (RadioAspectRatio3.Checked)
                axVideoChatReceiver1.VideoWindowAspectRatio = 2;

      
       

            
            axVideoChatReceiver1.ReceiveAudioStream = chkreceiveaudio.Checked;
            axVideoChatReceiver1.ReceiveVideoStream = chkreceivevideo.Checked;
            axVideoChatReceiver1.ReceiverVideoNoVideoImage(TextBox1.Text);

           bool bResult = false;

           bResult = axVideoChatReceiver1.Listen(txtListenIP.Text, Convert.ToInt32(txtConnectPortNo.Text, 10));

           btnstartlisten.Enabled = false;
           btnlistendisconnect.Enabled = true;

        }

        private void btnlistendisconnect_Click(object sender, EventArgs e)
        {
            axVideoChatReceiver1.Disconnect();
            btnstartlisten.Enabled = true;
            btnlistendisconnect.Enabled = false;
        }

        private void btnsnapshot_Click(object sender, EventArgs e)
        {
            SaveFileDialog1.Filter = "JPG File (*.jpg)|*.jpg";

            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                axVideoChatReceiver1.SnapShot(SaveFileDialog1.FileName);
    
        }
    }
}
