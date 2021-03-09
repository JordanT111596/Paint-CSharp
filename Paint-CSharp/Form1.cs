using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_CSharp
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = mainPanel.CreateGraphics();
        }

        private void redPic_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
        }
    }
}
