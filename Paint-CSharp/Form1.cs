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
        //initializes the graphics panel used to hold user drawing
        Graphics g;
        //initializes x and y variables to be used for pen location later
        int x = -1;
        int y = -1;
        //a boolean to keep track of whether the pen is moving or not
        bool moving = false;
        //initializes the pen for drawing
        Pen pen;

        public Form1()
        {
            InitializeComponent();
            //creates the canvas when the form is started
            g = mainPanel.CreateGraphics();
            //creates smoother lines when drawing
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //initalizes pen with a starting color of black and a size of 5 pixels
            pen = new Pen(Color.Black, 5);
            //rounds pen line when drawing
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void redPic_Click(object sender, EventArgs e)
        {
            //grabs the option's background color then changes the pen to red
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }
        private void bluePic_Click(object sender, EventArgs e)
        {
            //grabs the option's background color then changes the pen to blue
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void yellowPic_Click(object sender, EventArgs e)
        {
            //grabs the option's background color then changes the pen to yellow
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void greenPic_Click(object sender, EventArgs e)
        {
            //grabs the option's background color then changes the pen to green
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void blackPic_Click(object sender, EventArgs e)
        {
            //grabs the option's background color then changes the pen to black
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void whitePic_Click(object sender, EventArgs e)
        {
            //grabs the option's background color then changes the pen to white (for eraser purposes)
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }
        private void orangePic_Click(object sender, EventArgs e)
        {
            //grabs the option's background color then changes the pen to orange
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void purplePic_Click(object sender, EventArgs e)
        {
            //grabs the option's background color then changes the pen to purple
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pinkPic_Click(object sender, EventArgs e)
        {
            //grabs the option's background color then changes the pen to pink (techincally HotPink)
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }
        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //the boolean flips to true as the pen begins to move upon the user's mouse down
            moving = true;
            //the x value of the pen is the same as the cursor's x value
            x = e.X;
            //the y value of the pen is the same as the cursor's y value
            y = e.Y;
            //the cursor changes to a cross when drawing for easier, more precise movements
            mainPanel.Cursor = Cursors.Cross;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            //only if the pen is moving and the x and y values are valid
            if (moving && x != -1 && y != -1)
            {
                //a line begins to form based on the location of the user's cursor
                g.DrawLine(pen, new Point(x, y), e.Location);
                //the x value of the pen is the same as the cursor's x value
                x = e.X;
                //the y value of the pen is the same as the cursor's y value
                y = e.Y;
            }
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            //when the user mouse is up, the pen is no longer moving
            moving = false;
            //the x value changes to -1 to reset
            x = -1;
            //the y value changes to -1 to reset
            y = -1;
            //the cursor changes back to a normal mouse pointer cursor
            mainPanel.Cursor = Cursors.Default;
        }

        private void clearPic_Click_1(object sender, EventArgs e)
        {
            //when the clear box is hit, the entire canvas is wiped and changed back to the beginning white color
            g.Clear(Color.White);
        }
    }
}
