
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.pinkPic = new System.Windows.Forms.PictureBox();
            this.purplePic = new System.Windows.Forms.PictureBox();
            this.orangePic = new System.Windows.Forms.PictureBox();
            this.whitePic = new System.Windows.Forms.PictureBox();
            this.blackPic = new System.Windows.Forms.PictureBox();
            this.greenPic = new System.Windows.Forms.PictureBox();
            this.yellowPic = new System.Windows.Forms.PictureBox();
            this.bluePic = new System.Windows.Forms.PictureBox();
            this.redPic = new System.Windows.Forms.PictureBox();
            this.clearPic = new System.Windows.Forms.PictureBox();
            this.resetLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.colorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pinkPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purplePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.titleLabel);
            this.mainPanel.Controls.Add(this.colorPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1370, 749);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(125, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(660, 28);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Jordan\'s C# Paint! Click on a box to change the pen color!";
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Gray;
            this.colorPanel.Controls.Add(this.resetLabel);
            this.colorPanel.Controls.Add(this.clearPic);
            this.colorPanel.Controls.Add(this.pinkPic);
            this.colorPanel.Controls.Add(this.purplePic);
            this.colorPanel.Controls.Add(this.orangePic);
            this.colorPanel.Controls.Add(this.whitePic);
            this.colorPanel.Controls.Add(this.blackPic);
            this.colorPanel.Controls.Add(this.greenPic);
            this.colorPanel.Controls.Add(this.yellowPic);
            this.colorPanel.Controls.Add(this.bluePic);
            this.colorPanel.Controls.Add(this.redPic);
            this.colorPanel.Location = new System.Drawing.Point(820, 12);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(538, 48);
            this.colorPanel.TabIndex = 0;
            // 
            // pinkPic
            // 
            this.pinkPic.BackColor = System.Drawing.Color.DeepPink;
            this.pinkPic.Location = new System.Drawing.Point(334, 3);
            this.pinkPic.Name = "pinkPic";
            this.pinkPic.Size = new System.Drawing.Size(45, 42);
            this.pinkPic.TabIndex = 7;
            this.pinkPic.TabStop = false;
            this.pinkPic.Click += new System.EventHandler(this.pinkPic_Click);
            // 
            // purplePic
            // 
            this.purplePic.BackColor = System.Drawing.Color.Purple;
            this.purplePic.Location = new System.Drawing.Point(283, 3);
            this.purplePic.Name = "purplePic";
            this.purplePic.Size = new System.Drawing.Size(45, 42);
            this.purplePic.TabIndex = 6;
            this.purplePic.TabStop = false;
            this.purplePic.Click += new System.EventHandler(this.purplePic_Click);
            // 
            // orangePic
            // 
            this.orangePic.BackColor = System.Drawing.Color.Orange;
            this.orangePic.Location = new System.Drawing.Point(232, 3);
            this.orangePic.Name = "orangePic";
            this.orangePic.Size = new System.Drawing.Size(45, 42);
            this.orangePic.TabIndex = 5;
            this.orangePic.TabStop = false;
            this.orangePic.Click += new System.EventHandler(this.orangePic_Click);
            // 
            // whitePic
            // 
            this.whitePic.BackColor = System.Drawing.Color.White;
            this.whitePic.Location = new System.Drawing.Point(436, 3);
            this.whitePic.Name = "whitePic";
            this.whitePic.Size = new System.Drawing.Size(45, 42);
            this.whitePic.TabIndex = 1;
            this.whitePic.TabStop = false;
            this.whitePic.Click += new System.EventHandler(this.whitePic_Click);
            // 
            // blackPic
            // 
            this.blackPic.BackColor = System.Drawing.Color.Black;
            this.blackPic.Location = new System.Drawing.Point(385, 3);
            this.blackPic.Name = "blackPic";
            this.blackPic.Size = new System.Drawing.Size(45, 42);
            this.blackPic.TabIndex = 4;
            this.blackPic.TabStop = false;
            this.blackPic.Click += new System.EventHandler(this.blackPic_Click);
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
            // clearPic
            // 
            this.clearPic.BackColor = System.Drawing.Color.White;
            this.clearPic.Location = new System.Drawing.Point(487, 3);
            this.clearPic.Name = "clearPic";
            this.clearPic.Size = new System.Drawing.Size(45, 42);
            this.clearPic.TabIndex = 2;
            this.clearPic.TabStop = false;
            this.clearPic.Click += new System.EventHandler(this.clearPic_Click_1);
            // 
            // resetLabel
            // 
            this.resetLabel.AutoSize = true;
            this.resetLabel.BackColor = System.Drawing.Color.White;
            this.resetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetLabel.ForeColor = System.Drawing.Color.Red;
            this.resetLabel.Location = new System.Drawing.Point(490, 18);
            this.resetLabel.Name = "resetLabel";
            this.resetLabel.Size = new System.Drawing.Size(40, 12);
            this.resetLabel.TabIndex = 2;
            this.resetLabel.Text = "RESET";
            this.resetLabel.Click += new System.EventHandler(this.clearPic_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.colorPanel.ResumeLayout(false);
            this.colorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pinkPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purplePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPic)).EndInit();
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
        private System.Windows.Forms.PictureBox pinkPic;
        private System.Windows.Forms.PictureBox purplePic;
        private System.Windows.Forms.PictureBox orangePic;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label resetLabel;
        private System.Windows.Forms.PictureBox clearPic;
    }
}

