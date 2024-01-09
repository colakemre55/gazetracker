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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.PlayMedia = new System.Windows.Forms.Button();
            this.UploadVideo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(874, 654);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(156, 44);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(701, 502);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // PlayMedia
            // 
            this.PlayMedia.Location = new System.Drawing.Point(316, 654);
            this.PlayMedia.Name = "PlayMedia";
            this.PlayMedia.Size = new System.Drawing.Size(156, 44);
            this.PlayMedia.TabIndex = 4;
            this.PlayMedia.Text = "PlayVideo";
            this.PlayMedia.UseVisualStyleBackColor = true;
            this.PlayMedia.Click += new System.EventHandler(this.PlayMedia_Click);
            // 
            // UploadVideo
            // 
            this.UploadVideo.Location = new System.Drawing.Point(591, 654);
            this.UploadVideo.Name = "UploadVideo";
            this.UploadVideo.Size = new System.Drawing.Size(156, 44);
            this.UploadVideo.TabIndex = 5;
            this.UploadVideo.Text = "UploadVideo";
            this.UploadVideo.UseVisualStyleBackColor = true;
            this.UploadVideo.Click += new System.EventHandler(this.UploadVideo_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 913);
            this.Controls.Add(this.UploadVideo);
            this.Controls.Add(this.PlayMedia);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitButton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button PlayMedia;
        private System.Windows.Forms.Button UploadVideo;
        private System.Windows.Forms.Timer timer1;
    }
}

