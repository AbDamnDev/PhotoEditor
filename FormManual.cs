using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhotoEditor
{
    public partial class FormManual : Form
    {
        public FormManual()
        {
            InitializeComponent();
            //Path.Combine(Directory.GetCurrentDirectory(),\resources\MANUAL DE USUARIO PHOTO3DITOR.pdf);
            string path = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\\manual.pdf");
            //path.Remove(100, 14);
            axAcroPDF1.src= path;
            //System.Diagnostics.Process.Start(path);
        }

          
    }
}
