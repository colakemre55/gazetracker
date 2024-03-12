namespace WindowsFormsApp_EMGUCVBase
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
            this.components = new System.ComponentModel.Container();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.newPlay = new System.Windows.Forms.Button();
            this.detect = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.UploadMedia = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.analytics1 = new WindowsFormsApp_EMGUCVBase.Analytics();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(757, 584);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 50);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(1265, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(432, 339);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // newPlay
            // 
            this.newPlay.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.newPlay.Enabled = false;
            this.newPlay.Location = new System.Drawing.Point(322, 260);
            this.newPlay.Name = "newPlay";
            this.newPlay.Size = new System.Drawing.Size(150, 50);
            this.newPlay.TabIndex = 12;
            this.newPlay.Text = "Start";
            this.newPlay.UseVisualStyleBackColor = false;
            this.newPlay.Click += new System.EventHandler(this.newPlay_Click);
            // 
            // detect
            // 
            this.detect.BackColor = System.Drawing.SystemColors.Window;
            this.detect.Location = new System.Drawing.Point(534, 584);
            this.detect.Name = "detect";
            this.detect.Size = new System.Drawing.Size(150, 50);
            this.detect.TabIndex = 14;
            this.detect.Text = "Detect";
            this.detect.UseVisualStyleBackColor = false;
            this.detect.Click += new System.EventHandler(this.detect_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(246, 1033);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AutoSize = false;
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Image = global::WindowsFormsApp_EMGUCVBase.Properties.Resources.home;
            this.toolStripMenuItem3.Margin = new System.Windows.Forms.Padding(0, 185, 0, 0);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(239, 50);
            this.toolStripMenuItem3.Text = "Home";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Image = global::WindowsFormsApp_EMGUCVBase.Properties.Resources.analytics;
            this.toolStripMenuItem2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 50);
            this.toolStripMenuItem2.Text = "Analytics";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.Image = global::WindowsFormsApp_EMGUCVBase.Properties.Resources.home;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 50);
            this.toolStripMenuItem1.Text = "    Home";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(246, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1656, 200);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(45, 162);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(393, 35);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "Analysis by Eye Tracking Applications";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(35, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 49);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "Gaze Tracking";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.newPlay);
            this.panel2.Controls.Add(this.UploadMedia);
            this.panel2.Location = new System.Drawing.Point(291, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 348);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(305, 219);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(167, 35);
            this.textBox4.TabIndex = 24;
            this.textBox4.Text = "Upload Your Video Here";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(25, 21);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(393, 66);
            this.textBox3.TabIndex = 23;
            this.textBox3.Text = "Start Tracking";
            // 
            // UploadMedia
            // 
            this.UploadMedia.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UploadMedia.BackgroundImage = global::WindowsFormsApp_EMGUCVBase.Properties.Resources.upload2;
            this.UploadMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UploadMedia.Location = new System.Drawing.Point(273, 116);
            this.UploadMedia.Name = "UploadMedia";
            this.UploadMedia.Size = new System.Drawing.Size(220, 97);
            this.UploadMedia.TabIndex = 22;
            this.UploadMedia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UploadMedia.UseVisualStyleBackColor = false;
            this.UploadMedia.Click += new System.EventHandler(this.UploadMedia_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(436, 976);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(418, 45);
            this.progressBar1.TabIndex = 23;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 650);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 72);
            this.button2.TabIndex = 25;
            this.button2.Text = "analytics temp bttn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 529);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 83);
            this.button3.TabIndex = 26;
            this.button3.Text = "fullscreenplay";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // analytics1
            // 
            this.analytics1.BackColor = System.Drawing.SystemColors.Window;
            this.analytics1.ForeColor = System.Drawing.Color.White;
            this.analytics1.Location = new System.Drawing.Point(259, 936);
            this.analytics1.Name = "analytics1";
            this.analytics1.Size = new System.Drawing.Size(129, 85);
            this.analytics1.TabIndex = 21;
            this.analytics1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.analytics1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.detect);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Neuro Gaze";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button newPlay;
        private System.Windows.Forms.Button detect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button UploadMedia;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private Analytics analytics1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

