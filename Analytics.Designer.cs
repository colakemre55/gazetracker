namespace WindowsFormsApp_EMGUCVBase
{
    partial class Analytics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.FrameNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.objectsDetected = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detectedObjects = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.detectedFramesPictureBox = new System.Windows.Forms.PictureBox();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.detectedFramesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FrameNumber,
            this.objectsDetected,
            this.detectedObjects});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(866, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(353, 388);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // FrameNumber
            // 
            this.FrameNumber.Text = "Frame Number";
            this.FrameNumber.Width = 80;
            // 
            // objectsDetected
            // 
            this.objectsDetected.Text = "No. of Obj Detected";
            this.objectsDetected.Width = 150;
            // 
            // detectedObjects
            // 
            this.detectedObjects.Text = "Detected Objects";
            this.detectedObjects.Width = 200;
            // 
            // button2
            // 
            this.button2.Image = global::WindowsFormsApp_EMGUCVBase.Properties.Resources.next_page;
            this.button2.Location = new System.Drawing.Point(776, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 100);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::WindowsFormsApp_EMGUCVBase.Properties.Resources.previous_page;
            this.button1.Location = new System.Drawing.Point(40, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 100);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // detectedFramesPictureBox
            // 
            this.detectedFramesPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.detectedFramesPictureBox.Location = new System.Drawing.Point(95, 29);
            this.detectedFramesPictureBox.Name = "detectedFramesPictureBox";
            this.detectedFramesPictureBox.Size = new System.Drawing.Size(654, 431);
            this.detectedFramesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.detectedFramesPictureBox.TabIndex = 21;
            this.detectedFramesPictureBox.TabStop = false;
            this.detectedFramesPictureBox.Click += new System.EventHandler(this.detectedFramesPictureBox_Click);
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.metroTrackBar1.ForeColor = System.Drawing.Color.RosyBrown;
            this.metroTrackBar1.Location = new System.Drawing.Point(40, 486);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(768, 56);
            this.metroTrackBar1.TabIndex = 22;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.ValueChanged += new System.EventHandler(this.metroTrackBar1_ValueChanged);
            this.metroTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.metroTrackBar1);
            this.Controls.Add(this.detectedFramesPictureBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Analytics";
            this.Size = new System.Drawing.Size(1525, 981);
            this.Load += new System.EventHandler(this.Analytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detectedFramesPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FrameNumber;
        private System.Windows.Forms.ColumnHeader objectsDetected;
        private System.Windows.Forms.ColumnHeader detectedObjects;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox detectedFramesPictureBox;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
    }
}
