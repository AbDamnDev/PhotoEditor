using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace PhotoEditor
{
    public partial class FormCamera : Form
    {
        public FormCamera()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void FormCamera_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);   
            foreach(FilterInfo filterInfo in filterInfoCollection)
            {
                cb_webcamslist.Items.Add(filterInfo);
            }
            cb_webcamslist.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
           
        }

        private void btn_webcamstart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice=new VideoCaptureDevice(filterInfoCollection[cb_webcamslist.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += new NewFrameEventHandler(VideoCaptureDevice_NewFrame);
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (PB_webcam.Image!=null)
            {
                PB_webcam.Image.Dispose();
            }
            PB_webcam.Image = (Bitmap)eventArgs.Frame.Clone();

        }

        private void FormCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.SignalToStop();
            }
        }
    }
}
