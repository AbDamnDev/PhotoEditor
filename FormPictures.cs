using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using Emgu.CV.Face;
using Emgu.CV.Stitching;
using Emgu.CV.Dnn;

namespace PhotoEditor
{
    public partial class FormPictures : Form
    {
        Image<Bgr, byte> _inputImage = null;
        //Image<Gray, byte> R = null;
        //Image<Gray, byte> G = null;
        //Image<Gray, byte> B = null;
        //private Mat imageHist = null;
        //private DenseHistogram hist = null;

        public FormPictures()
        {
            InitializeComponent();
        }

        private void resetImage_Click(object sender, EventArgs e)
        {
            //sigue sin actualizar
            using (Bitmap original = new Bitmap(normal_Pic.Image))
            {
                pictureBox2.Image = null;
                if (pictureBox2.Image == null)
                {
                    pictureBox2.Image = (Image)original;
                    pictureBox2.Refresh();
                }
                original.Dispose();
            }
            
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        pictureBox2.Image.Save(saveFileDialog.FileName);
                     
                    }
                }
            }
        }


        private void Examinar_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd=new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                normal_Pic.Image = image;
                pictureBox2.Image = image;

                
                using (Image<Bgr, byte> _inputImage = new Image<Bgr, byte>(ofd.FileName))
                {
                    histogramBox1.ClearHistogram();
                    histogramBox1.FunctionalMode = Emgu.CV.UI.HistogramBox.FunctionalModeOption.Everything;
                    histogramBox1.GenerateHistograms(_inputImage, 256);
                    histogramBox1.Refresh();

                    _inputImage.Dispose();

                }


                  

            }
        }

        private void applyFilter_Click(object sender, EventArgs e)
        {
            if (filtersCombo.SelectedIndex != -1)
            {
                Bitmap temp = null;
                switch (filtersCombo.SelectedItem.ToString())
                {   
                    case "BlancoyNegro":
                        temp= bandnFilter();
                        pictureBox2.Image = (Image)temp;
                        genHistogram(temp);
                        temp.Dispose();
                        break;
                    case "Negativo":
                        temp = negativoFilter();
                        pictureBox2.Image = (Image)temp;
                        genHistogram(temp);
                        temp.Dispose();
                        break;
                    case "Gradiente":
                        //pictureBox2.Image = (Image)gradienteFilter();
                        temp = gradienteFilter();
                        pictureBox2.Image = (Image)temp;
                        genHistogram(temp);
                        temp.Dispose();
                        break;
                    case "Sepia":
                       // pictureBox2.Image = (Image)sepiaFilter();
                        temp = sepiaFilter();
                        pictureBox2.Image = (Image)temp;
                        genHistogram(temp);
                        temp.Dispose();
                        break;
                    case "Escala_de_grises":
                       // pictureBox2.Image = (Image)grayscaleFilter();
                        temp = grayscaleFilter();
                        pictureBox2.Image = (Image)temp;
                        genHistogram(temp);
                        temp.Dispose();
                        break;
                    case "Morado":
                        //pictureBox2.Image = (Image)colorFilter();
                        temp = colorFilter();
                        pictureBox2.Image = (Image)temp;
                        genHistogram(temp);
                        temp.Dispose();
                        break;
                    default:
                    break;
                }
            }
        }
        private void genHistogram(Bitmap bmp)
        {
            using (Image<Bgr, byte> _inputImage = bmp.ToImage<Bgr, byte>())
            {
                //Mat hist = new Mat();
                //float[] ranges = new float[] { 0, 255 };
                //int[] channel = { 0 };
                //int[] histsize = { 256 };

                //VectorOfMat ms = new VectorOfMat();
                //ms.Push(_inputImage);

                //CvInvoke.CalcHist(ms, channel, null, hist, histsize, ranges, false);

                histogramBox1.ClearHistogram();
                histogramBox1.FunctionalMode = Emgu.CV.UI.HistogramBox.FunctionalModeOption.Everything;
                histogramBox1.GenerateHistograms(_inputImage, 256);
                histogramBox1.Refresh();
                //hist.Dispose();
            }


        }
        private void genSpecificHistogram(Bitmap bmp, int chn)
        {
            using (Image<Bgr, byte> _inputImage = bmp.ToImage<Bgr, byte>())
            {
                //Mat hist = new Mat();
                //float[] ranges = new float[] { 0, 255 };
                //int[] channel = { 0 };
                //int[] histsize = { 256 };

                //VectorOfMat ms = new VectorOfMat();

                //ms.Push(_inputImage[chn]);

                //CvInvoke.CalcHist(ms, channel, null, hist, histsize, ranges, false);

                histogramBox1.ClearHistogram();
                histogramBox1.FunctionalMode = Emgu.CV.UI.HistogramBox.FunctionalModeOption.Everything;
                histogramBox1.GenerateHistograms(_inputImage[chn], 256);
                histogramBox1.Refresh();
                //hist.Dispose();
            }

        }
        //funciona
        Bitmap negativoFilter()
        {
            Bitmap bmp = (Bitmap)normal_Pic.Image;

            for (int j=0;j<bmp.Width;j++)
            {
                for (int i = 0; i < bmp.Height; i++)
                {
                    Color color = bmp.GetPixel(j,i);
                    int r=color.R;
                    int g=color.G;
                    int b=color.B;

                    r = (255 - r) * 1;
                    g = (255 - g) * 1;
                    b = (255 - b) * 1;

                    Color finalcolor = Color.FromArgb(r, g, b);
                    bmp.SetPixel(j, i, finalcolor);


                }
            }

            return bmp;
        }
        //funciona
        Bitmap colorFilter()
        {
            Bitmap bmp = (Bitmap)normal_Pic.Image;

            for (int j = 0; j < bmp.Width; j++)
            {
                for (int i = 0; i < bmp.Height; i++)
                {
                    Color color = bmp.GetPixel(j, i);
                    int r = color.R;
                    int g = color.G;
                    int b = color.B;

                    //r = 0;
                    g = 0;
                    //b = (255 - b) * 1;

                    Color finalcolor = Color.FromArgb(r, g, b);
                    bmp.SetPixel(j, i, finalcolor);

                }
            }

            return bmp;
        }
        //funciona
        Bitmap grayscaleFilter()
        {
            Bitmap bmp = (Bitmap)normal_Pic.Image;

            for (int j = 0; j < bmp.Width; j++)
            {
                for (int i = 0; i < bmp.Height; i++)
                {
                    Color color = bmp.GetPixel(j, i);
                    float r = color.R;
                    float g = color.G;
                    float b = color.B;

                    r = r * 0.299f;
                    g = g*0.587f;
                    b = b * 0.114f;
                    float n = r + g + b;
                    Color finalcolor = Color.FromArgb((int)n,(int) n,(int) n);
                    bmp.SetPixel(j, i, finalcolor);

                }
            }

            return bmp;
        }
        //funciona
        Bitmap sepiaFilter()
        {
            Bitmap bmp = (Bitmap)normal_Pic.Image;

            for (int j = 0; j < bmp.Width; j++)
            {
                for (int i = 0; i < bmp.Height; i++)
                {
                    Color color = bmp.GetPixel(j, i);
                    float r = color.R;
                    float g = color.G;
                    float b = color.B;

                    float tr=0.393f*r+ 0.769f*g +0.189f*b;
                    float tg = 0.349f * r + 0.686f * g + 0.168f * b;
                    float tb = 0.272f * r + 0.534f * g + 0.131f * b;
                    r = (tr > 255) ? 255 : tr;
                    g = (tg > 255) ? 255 : tg;
                    b = (tb > 255) ? 255 : tb;

                    Color finalcolor = Color.FromArgb((int)r, (int)g, (int)b);
                    bmp.SetPixel(j, i, finalcolor);

                }
            }

            return bmp;
        }
        //funciona
        Bitmap gradienteFilter()
        {
            Bitmap bmp = (Bitmap)normal_Pic.Image;

            float r1 = 120;
            float g1 = 230;
            float b1 = 120;

            float r2 = 230;
            float g2 = 100;
            float b2 = 230;

            int r;
            int g;
            int b;

            float dr = (r2-r1)/bmp.Width;
            float dg = (g2 - g1) / bmp.Width;
            float db = (b2 - b1) / bmp.Width;

            bmp = grayscaleFilter();


            for (int j = 0; j < bmp.Width; j++)
            {
                for (int i = 0; i < bmp.Height; i++)
                {
                    Color color = bmp.GetPixel(j, i);
                    r = (int)((r1 / 255.0f) * color.R);
                    g = (int)((g1 / 255.0f) * color.G);
                    b = (int)((b1 / 255.0f) * color.B);


                    if (r > 255)
                    {
                        r = 255;
                    }
                    else if(r<0)
                    {
                        r = 0;
                    }
                    if (g> 255)
                    {
                        g= 255;
                    }
                    else if (g < 0)
                    {
                        g = 0;
                    }
                    if (b > 255){
                        b = 255;
                    }else if (b < 0)
                    {
                        b = 0;
                    }

                    Color finalcolor = Color.FromArgb((int)r, (int)g, (int)b);
                    bmp.SetPixel(j, i, finalcolor);

                }

                r1 = r1 + dr;
                g1 = g1 + dg;
                b1 = b1 + db;
            }

            return bmp;
        }
        //funciona
        Bitmap bandnFilter()
        {
            Bitmap bmp = (Bitmap)normal_Pic.Image;

            for (int j = 0; j < bmp.Width; j++)
            {
                for (int i = 0; i < bmp.Height; i++)
                {
                    Color color = bmp.GetPixel(j, i);
                    float r = color.R;
                    float g = color.G;
                    float b = color.B;

                    float comp = (r + g + b )/ 3;
                    int result;
                    if(comp > 127)
                    {
                        result = 255;

                    }else // (comp < 0)
                    {
                        result = 0;
                    }


                    Color finalcolor = Color.FromArgb((int)result, (int)result, (int)result);
                    bmp.SetPixel(j, i, finalcolor);

                }
            }

            return bmp;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != -1)
            {
                Bitmap myimage=null;
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "R":
                        myimage = (Bitmap)pictureBox2.Image;
                        genSpecificHistogram(myimage, 2);
                      
                        break;
                    case "G":
                        myimage = (Bitmap)pictureBox2.Image;
                        genSpecificHistogram(myimage, 1);
                      
                        break;
                    case "B":
                        myimage = (Bitmap)pictureBox2.Image;
                        genSpecificHistogram(myimage, 0);
                       
                        break;
                    case "RGB":
                        myimage = (Bitmap)pictureBox2.Image;
                        genHistogram(myimage);
                        break;
                    default:
                        break;
                }
                myimage.Dispose();
            }
        }

        private void FormPictures_Load(object sender, EventArgs e)
        {

        }
    }
}
