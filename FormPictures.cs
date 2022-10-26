using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEditor
{
    public partial class FormPictures : Form
    {
        public FormPictures()
        {
            InitializeComponent();
        }

        private void resetImage_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = normal_Pic.Image;
        }

        private void saveImage_Click(object sender, EventArgs e)
        {

        }

        private void Examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                normal_Pic.Image = image;
                pictureBox2.Image = image;
            }
        }

        private void applyFilter_Click(object sender, EventArgs e)
        {
            if (filtersCombo.SelectedIndex != 0)
            {
                switch (filtersCombo.SelectedItem.ToString())
                {
                    case "Blanco y negro":
                        pictureBox2.Image = (Image)blackandwhiteFilter();
                        break;
                    case "Negativo":
                        pictureBox2.Image = (Image)negativoFilter();
                        break;
                    case "Dividir":
                        break;
                    case "Sepia":
                        pictureBox2.Image = (Image)sepiaFilter();
                        break;
                    case "Escala de grises":
                        pictureBox2.Image = (Image)grayscaleFilter();
                        break;
                    case "Morado":
                        pictureBox2.Image = (Image)colorFilter();
                        break;
                    default:
                    break;
                }
            }
        }

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

                    Color finalcolor = Color.FromArgb((int)r,(int) g,(int) b);
                    bmp.SetPixel(j, i, finalcolor);

                }
            }

            return bmp;
        }
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

        Bitmap blackandwhiteFilter()
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
                    float result = (comp > 128) ? 255 : 0;

                    Color finalcolor = Color.FromArgb((int)result, (int)result, (int)result);
                    bmp.SetPixel(j, i, finalcolor);

                }
            }

            return bmp;
        }
    }
}
