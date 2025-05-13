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
            this.newPlay = new System.Windows.Forms.Button();
            this.detect = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.denemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.summaryPage1 = new WindowsFormsApp_EMGUCVBase.SummaryPage();
            this.analytics1 = new WindowsFormsApp_EMGUCVBase.Analytics();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1825, 917);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 33);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newPlay
            // 
            this.newPlay.BackColor = System.Drawing.Color.White;
            this.newPlay.Enabled = false;
            this.newPlay.Location = new System.Drawing.Point(214, 125);
            this.newPlay.Name = "newPlay";
            this.newPlay.Size = new System.Drawing.Size(117, 33);
            this.newPlay.TabIndex = 12;
            this.newPlay.Text = "Start";
            this.newPlay.UseVisualStyleBackColor = false;
            this.newPlay.Click += new System.EventHandler(this.newPlay_Click);
            // 
            // detect
            // 
            this.detect.BackColor = System.Drawing.SystemColors.Window;
            this.detect.Location = new System.Drawing.Point(337, 124);
            this.detect.Name = "detect";
            this.detect.Size = new System.Drawing.Size(117, 33);
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
            this.toolStripMenuItem2,
            this.denemeToolStripMenuItem});
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
            this.toolStripMenuItem3.Margin = new System.Windows.Forms.Padding(0, 135, 0, 0);
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
            // denemeToolStripMenuItem
            // 
            this.denemeToolStripMenuItem.AutoSize = false;
            this.denemeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.denemeToolStripMenuItem.Image = global::WindowsFormsApp_EMGUCVBase.Properties.Resources.summary;
            this.denemeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.denemeToolStripMenuItem.Name = "denemeToolStripMenuItem";
            this.denemeToolStripMenuItem.Size = new System.Drawing.Size(195, 50);
            this.denemeToolStripMenuItem.Text = "Summary";
            this.denemeToolStripMenuItem.Click += new System.EventHandler(this.denemeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(246, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1656, 27);
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
            this.panel2.Controls.Add(this.detect);
            this.panel2.Location = new System.Drawing.Point(22, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 250);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(261, 86);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 20);
            this.textBox4.TabIndex = 24;
            this.textBox4.Text = "Upload Your Video";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(25, 11);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(447, 31);
            this.textBox3.TabIndex = 23;
            this.textBox3.Text = "Start Gaze Tracking";
            // 
            // UploadMedia
            // 
            this.UploadMedia.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UploadMedia.BackgroundImage = global::WindowsFormsApp_EMGUCVBase.Properties.Resources.cloud;
            this.UploadMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UploadMedia.Location = new System.Drawing.Point(25, 66);
            this.UploadMedia.Name = "UploadMedia";
            this.UploadMedia.Size = new System.Drawing.Size(161, 113);
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
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
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
            this.button1.Location = new System.Drawing.Point(375, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.Location = new System.Drawing.Point(277, 125);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 33);
            this.button9.TabIndex = 32;
            this.button9.Text = "Calibration";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(1873, 1017);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 52);
            this.panel3.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp_EMGUCVBase.Properties.Resources.gazeblue;
            this.pictureBox1.Location = new System.Drawing.Point(6, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(75, 0);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(165, 40);
            this.textBox5.TabIndex = 25;
            this.textBox5.Text = "\r\nGaze Tracking Analysis";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.Controls.Add(this.textBox8);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.textBox7);
            this.panel4.Location = new System.Drawing.Point(578, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 250);
            this.panel4.TabIndex = 36;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(211, 86);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(275, 33);
            this.textBox8.TabIndex = 25;
            this.textBox8.Text = "Calibrate the camera before video\r\n\r\n";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp_EMGUCVBase.Properties.Resources.calibcolor;
            this.pictureBox3.Location = new System.Drawing.Point(19, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(161, 113);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(19, 11);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(391, 40);
            this.textBox7.TabIndex = 23;
            this.textBox7.Text = "Calibration\r\n";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Location = new System.Drawing.Point(259, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1138, 313);
            this.panel5.TabIndex = 38;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(259, 368);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1138, 418);
            this.panel6.TabIndex = 39;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel8.Controls.Add(this.textBox9);
            this.panel8.Controls.Add(this.pictureBox4);
            this.panel8.Controls.Add(this.textBox10);
            this.panel8.Location = new System.Drawing.Point(581, 57);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(500, 294);
            this.panel8.TabIndex = 37;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(196, 66);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(271, 134);
            this.textBox9.TabIndex = 25;
            this.textBox9.Text = "1) Calibrate your camera first\r\n2) Upload your video and watch until it ends\r\n3) " +
    "Click \"Detect\" button and wait until your summary is ready\r\n4) Click \"Summary\" t" +
    "o see the detailed analysis\r\n\r\n";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp_EMGUCVBase.Properties.Resources.guide_book;
            this.pictureBox4.Location = new System.Drawing.Point(19, 66);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(161, 113);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(19, 13);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(135, 40);
            this.textBox10.TabIndex = 23;
            this.textBox10.Text = "Guide";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel7.Controls.Add(this.textBox6);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Location = new System.Drawing.Point(22, 57);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(479, 294);
            this.panel7.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(12, 13);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(391, 27);
            this.textBox6.TabIndex = 34;
            this.textBox6.Text = "See detailed summary";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::WindowsFormsApp_EMGUCVBase.Properties.Resources.chart2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(25, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(412, 191);
            this.button2.TabIndex = 25;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // summaryPage1
            // 
            this.summaryPage1.AutoScroll = true;
            this.summaryPage1.Location = new System.Drawing.Point(281, 976);
            this.summaryPage1.Name = "summaryPage1";
            this.summaryPage1.Size = new System.Drawing.Size(36, 36);
            this.summaryPage1.TabIndex = 34;
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
            this.analytics1.Load += new System.EventHandler(this.analytics1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.summaryPage1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.analytics1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Neuro Gaze";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button newPlay;
        private System.Windows.Forms.Button detect;
        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem denemeToolStripMenuItem;
        private SummaryPage summaryPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox10;
    }
}

