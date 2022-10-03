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

        }

        private void saveImage_Click(object sender, EventArgs e)
        {

        }

        private void Examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                normal_Pic.Image = image;
            }
        }
    }
}
