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
            this.exitButton = new System.Windows.Forms.Button();
            this.UploadVideo = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.newPlay = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.detect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(781, 853);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(156, 44);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // UploadVideo
            // 
            this.UploadVideo.Location = new System.Drawing.Point(550, 853);
            this.UploadVideo.Name = "UploadVideo";
            this.UploadVideo.Size = new System.Drawing.Size(156, 44);
            this.UploadVideo.TabIndex = 5;
            this.UploadVideo.Text = "UploadVideo";
            this.UploadVideo.UseVisualStyleBackColor = true;
            this.UploadVideo.Click += new System.EventHandler(this.UploadVideo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(61, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(506, 310);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(657, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(515, 310);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // newPlay
            // 
            this.newPlay.Location = new System.Drawing.Point(301, 849);
            this.newPlay.Name = "newPlay";
            this.newPlay.Size = new System.Drawing.Size(174, 52);
            this.newPlay.TabIndex = 12;
            this.newPlay.Text = "newPlay";
            this.newPlay.UseVisualStyleBackColor = true;
            this.newPlay.Click += new System.EventHandler(this.newPlay_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(781, 403);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(391, 399);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // detect
            // 
            this.detect.Location = new System.Drawing.Point(106, 846);
            this.detect.Name = "detect";
            this.detect.Size = new System.Drawing.Size(161, 59);
            this.detect.TabIndex = 14;
            this.detect.Text = "Detect";
            this.detect.UseVisualStyleBackColor = true;
            this.detect.Click += new System.EventHandler(this.detect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 913);
            this.Controls.Add(this.detect);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.newPlay);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.UploadVideo);
            this.Controls.Add(this.exitButton);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button UploadVideo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button newPlay;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button detect;
    }
}

