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
using AForge.Vision.Motion;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace PhotoEditor
{
    public partial class FormCamera : Form
    {
        MotionDetector Detector;
        float nivelDeDeteccion;
        Bitmap bmp=null;
        Rectangle[] rectangles;
        public FormCamera()
        {
            InitializeComponent();
            Detector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionBorderHighlighting());
            nivelDeDeteccion = 0;
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
            //videoCaptureDevice.NewFrame += new NewFrameEventHandler(VideoCaptureDevice_NewFrame);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        public delegate void SetTBTextCallback(string text);
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                //if (eventArgs.Frame != null)


                //Image oldImage = PB_webcam.Image;

                bmp = (Bitmap)eventArgs.Frame.Clone();


                //nivelDeDeteccion = Detector.ProcessFrame((Bitmap)eventArgs.Frame);

                //nivelDeDeteccion = Detector.ProcessFrame(bmp);
               
                faceRecognition(ref bmp);

                //var @delegate = new SetTBTextCallback(updatePeopleText);
                //var @delegate2 = new SetTBTextCallback(updateMovementText);
                //new Task(() => this.label1.BeginInvoke(@delegate, rectangles.Length.ToString())).Start();
               // new Task(() => this.label1.BeginInvoke(@delegate2, "movimiento")).Start();

                if (PB_webcam.Image != null)
                {
                    PB_webcam.Image.Dispose();
                }
                PB_webcam.Image = bmp;
                //bmp.Dispose();
                //if (oldImage != null) { oldImage.Dispose(); }
                eventArgs.Frame.Dispose();


            }
            catch (Exception ex)
            {
                videoCaptureDevice.SignalToStop();
                MessageBox.Show("Camera Settings Frame Feed - Error: \n\n" + ex.Message, "Error");
            }
            
            //throw new NotImplementedException();
        }
        private void faceRecognition(ref Bitmap bmp)
        {
            int i = 0;
            using (Image<Bgr, byte> grayImage = bmp.ToImage<Bgr, byte>())
            {
                rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);

                foreach (Rectangle rectangle in rectangles)
                {
                    i++;
                    using (Graphics graphics = Graphics.FromImage(bmp))
                    {
                        using (SolidBrush solidBrush = new SolidBrush(Color.Yellow))
                        {
                            using (Font font = new Font("Arial", 30.0f))
                            {
                                using (Pen pen = new Pen(Color.Yellow, 3))
                                {
                                    graphics.DrawRectangle(pen, rectangle);
                                    graphics.DrawString("Persona" + i, font, solidBrush, rectangle.Location);
                                }
                            }
                        }
                    }

                }
                //bmp = grayImage.ToBitmap();
            }
           

        }
        private void FormCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
               
                videoCaptureDevice.NewFrame -= new NewFrameEventHandler(VideoCaptureDevice_NewFrame); // as sugested
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice = null;
                //PB_webcam.Image.Dispose();
                //bmp.Dispose();
                //videoCaptureDevice.Stop();
            }
        }
        private void updateMovementText(String mystring)
        {
            
            this.textBox2.Text = (nivelDeDeteccion != 0) ? "Con "+mystring : "Sin "+mystring;
            
        }
        private void updatePeopleText(String mystring)
        {
            this.textBox1.Text = mystring;
        }

    }
}
