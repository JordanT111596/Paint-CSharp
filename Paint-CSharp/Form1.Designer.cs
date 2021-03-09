
namespace Paint_CSharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.redPic = new System.Windows.Forms.PictureBox();
            this.bluePic = new System.Windows.Forms.PictureBox();
            this.yellowPic = new System.Windows.Forms.PictureBox();
            this.greenPic = new System.Windows.Forms.PictureBox();
            this.blackPic = new System.Windows.Forms.PictureBox();
            this.whitePic = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.colorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitePic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.colorPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1546, 1069);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Gray;
            this.colorPanel.Controls.Add(this.whitePic);
            this.colorPanel.Controls.Add(this.blackPic);
            this.colorPanel.Controls.Add(this.greenPic);
            this.colorPanel.Controls.Add(this.yellowPic);
            this.colorPanel.Controls.Add(this.bluePic);
            this.colorPanel.Controls.Add(this.redPic);
            this.colorPanel.Location = new System.Drawing.Point(1202, 12);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(332, 48);
            this.colorPanel.TabIndex = 0;
            // 
            // redPic
            // 
            this.redPic.BackColor = System.Drawing.Color.Red;
            this.redPic.Location = new System.Drawing.Point(28, 3);
            this.redPic.Name = "redPic";
            this.redPic.Size = new System.Drawing.Size(45, 42);
            this.redPic.TabIndex = 0;
            this.redPic.TabStop = false;
            this.redPic.Click += new System.EventHandler(this.redPic_Click);
            // 
            // bluePic
            // 
            this.bluePic.BackColor = System.Drawing.Color.Blue;
            this.bluePic.Location = new System.Drawing.Point(79, 3);
            this.bluePic.Name = "bluePic";
            this.bluePic.Size = new System.Drawing.Size(45, 42);
            this.bluePic.TabIndex = 1;
            this.bluePic.TabStop = false;
            this.bluePic.Click += new System.EventHandler(this.bluePic_Click);
            // 
            // yellowPic
            // 
            this.yellowPic.BackColor = System.Drawing.Color.Yellow;
            this.yellowPic.Location = new System.Drawing.Point(130, 3);
            this.yellowPic.Name = "yellowPic";
            this.yellowPic.Size = new System.Drawing.Size(45, 42);
            this.yellowPic.TabIndex = 2;
            this.yellowPic.TabStop = false;
            this.yellowPic.Click += new System.EventHandler(this.yellowPic_Click);
            // 
            // greenPic
            // 
            this.greenPic.BackColor = System.Drawing.Color.Green;
            this.greenPic.Location = new System.Drawing.Point(181, 3);
            this.greenPic.Name = "greenPic";
            this.greenPic.Size = new System.Drawing.Size(45, 42);
            this.greenPic.TabIndex = 3;
            this.greenPic.TabStop = false;
            this.greenPic.Click += new System.EventHandler(this.greenPic_Click);
            // 
            // blackPic
            // 
            this.blackPic.BackColor = System.Drawing.Color.Black;
            this.blackPic.Location = new System.Drawing.Point(232, 3);
            this.blackPic.Name = "blackPic";
            this.blackPic.Size = new System.Drawing.Size(45, 42);
            this.blackPic.TabIndex = 4;
            this.blackPic.TabStop = false;
            this.blackPic.Click += new System.EventHandler(this.blackPic_Click);
            // 
            // whitePic
            // 
            this.whitePic.BackColor = System.Drawing.Color.White;
            this.whitePic.Location = new System.Drawing.Point(283, 3);
            this.whitePic.Name = "whitePic";
            this.whitePic.Size = new System.Drawing.Size(45, 42);
            this.whitePic.TabIndex = 1;
            this.whitePic.TabStop = false;
            this.whitePic.Click += new System.EventHandler(this.whitePic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 1069);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.colorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.redPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.PictureBox whitePic;
        private System.Windows.Forms.PictureBox blackPic;
        private System.Windows.Forms.PictureBox greenPic;
        private System.Windows.Forms.PictureBox yellowPic;
        private System.Windows.Forms.PictureBox bluePic;
        private System.Windows.Forms.PictureBox redPic;
    }
}

