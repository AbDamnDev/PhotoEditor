using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.IO;
using Emgu.Util;
using Emgu.CV;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.Flann;
using Emgu.CV.Cuda;
using System.Runtime.InteropServices;
using Emgu.CV.CvEnum;
using Emgu.CV.OCR;
//using ClosedXML.Excel;
using Emgu.CV.UI;
//using EmgucvDemo.Models;
using Emgu.CV.ML;
using Emgu.CV.ML.MlEnum;
using System.Runtime.InteropServices.WindowsRuntime;
using Emgu.CV.Face;
using Emgu.CV.Stitching;
using Emgu.CV.Dnn;

namespace PhotoEditor
{
    

    public partial class FormVideo : Form
    {
        private bool isRendering = false;
        private VideoCapture videoCapture;
        private int actualFrame = 0;
        private double framesQuantity = 0;
        private double fps = 0;

        Image<Bgr, byte> filter = null;
        Mat matrix = new Mat();


        public String videopath = "";
        public FormVideo()
        {
            InitializeComponent();
        }

        private void FormVideo_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
        }

        private void Examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog  ofn1=new OpenFileDialog();
            ofn1.Title = "Selecciona un video"; // El título de mi ventana
            ofn1.Filter = "All Media Files (*.mp4)|*.mp4|All files (*.*)|*.*"; // De esta forma solo se pueden seleccionar videos y gifs
            if (isRendering || videoCapture != null)
            {
                isRendering = false;
                videoCapture = null;
                actualFrame = 0;
            }

            DialogResult = ofn1.ShowDialog();
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
               this.textBox_path.Text= ofn1.FileName;
                videoCapture = new VideoCapture(ofn1.FileName);
                Mat m = new Mat();
                videoCapture.Read(m);
                pictureBox2.Image=m.ToBitmap();

                framesQuantity = videoCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount);
                fps = videoCapture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);


            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
           
            axWindowsMediaPlayer1.URL = textBox_path.Text;
            //axWindowsMediaPlayer1.
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void btn_applyFilter_Click(object sender, EventArgs e)
        {
            isRendering = true;
            ReadAllFrames();

        }
        private async void ReadAllFrames()
        {
            axWindowsMediaPlayer1.Visible = false;
            actualFrame = 0;
            while (isRendering && actualFrame < framesQuantity)
            {
                actualFrame += 1;
                videoCapture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, actualFrame);
                videoCapture.Read(matrix);
                Bitmap wrkbitmap = matrix.ToBitmap();
                if (wrkbitmap != null)
                {
                    switch (comboBox1.SelectedIndex)
                    {
                        //morado
                        case 2:
                            //Bitmap processed=Filters.grayFilter(wrkbitmap);
                            //Image<Bgr, byte> myImage = wrkbitmap.ToImage<Bgr, byte>();
                            //filter = wrkbitmap.ToImage<Bgr, byte>(); 
                            filter = Filters.colorFilter(wrkbitmap).ToImage<Bgr, byte>();
                            break;

                        case 1:
                            
                            //Image<Bgr, byte> myImage = Filters.grayFilter(wrkbitmap).ToImage<Bgr, byte>();
                            filter = Filters.grayFilter(wrkbitmap).ToImage<Bgr, byte>();
                            break;

                        case 3:
                            filter = Filters.sepiaFilter(wrkbitmap).ToImage<Bgr, byte>();
                            break;

                        case 0:
                            filter = Filters.negativeFilter(wrkbitmap).ToImage<Bgr, byte>();
                            break;

                        case 4:
                            filter = Filters.gradienteFilter(wrkbitmap).ToImage<Bgr, byte>();
                            break;

                        case 5:
                            filter = Filters.blackAndWhiteFilter(wrkbitmap).ToImage<Bgr, byte>();
                            break;

                        case 6:
                            filter = Filters.mirrorFilter(wrkbitmap).ToImage<Bgr, byte>();
                            break;

                        case 7:
                            filter = Filters.redFilter(wrkbitmap).ToImage<Bgr, byte>();
                            break;

                        case 8:
                            filter = Filters.greenFilter(wrkbitmap).ToImage<Bgr, byte>();
                            break;

                        case 9:
                            filter = Filters.blueFilter(wrkbitmap).ToImage<Bgr, byte>();
                            break;

                        case 10:
                            filter = Filters.changeColor(wrkbitmap).ToImage<Bgr, byte>();
                            break;

                        case 11:
                            filter = Filters.noiseFilter(wrkbitmap).ToImage<Bgr, byte>();
                            break;

                    }
                    if (pictureBox2.Image != null)
                    {
                        pictureBox2.Image.Dispose();
                    }
                    pictureBox2.Image = (Image)filter.ToBitmap();
                    await Task.Delay(500 / Convert.ToInt32(fps));
                }
                matrix.Dispose();
                wrkbitmap.Dispose();
                filter.Dispose();
            }
        }

        private void FormVideo_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoCapture.Stop();
            videoCapture.Dispose();
            pictureBox2.Image.Dispose();
            filter.Dispose();
            matrix.Dispose();
            axWindowsMediaPlayer1.Dispose();
        }
    }
}
