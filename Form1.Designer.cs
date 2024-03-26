namespace Lab2
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
            this.glControl1 = new OpenTK.GLControl();
            this.trackBarMin = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBarMax = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.trackBarLyr = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLyr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLyr)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(13, 41);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(680, 680);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // trackBarMin
            // 
            this.trackBarMin.Location = new System.Drawing.Point(795, 88);
            this.trackBarMin.Maximum = 2000;
            this.trackBarMin.Name = "trackBarMin";
            this.trackBarMin.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarMin.Size = new System.Drawing.Size(56, 633);
            this.trackBarMin.TabIndex = 3;
            this.trackBarMin.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarMin.ValueChanged += new System.EventHandler(this.trackBarMin_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenImageButton_Click);
            // 
            // trackBarMax
            // 
            this.trackBarMax.Location = new System.Drawing.Point(833, 88);
            this.trackBarMax.Maximum = 2000;
            this.trackBarMax.Name = "trackBarMax";
            this.trackBarMax.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarMax.Size = new System.Drawing.Size(56, 633);
            this.trackBarMax.TabIndex = 6;
            this.trackBarMax.TickFrequency = 1000;
            this.trackBarMax.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarMax.ValueChanged += new System.EventHandler(this.trackBarMax_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(793, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(844, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "max";
            // 
            // textBoxMin
            // 
            this.textBoxMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxMin.Location = new System.Drawing.Point(782, 60);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.ReadOnly = true;
            this.textBoxMin.Size = new System.Drawing.Size(50, 22);
            this.textBoxMin.TabIndex = 9;
            this.textBoxMin.Text = "0";
            this.textBoxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMax
            // 
            this.textBoxMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMax.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxMax.Location = new System.Drawing.Point(835, 60);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.ReadOnly = true;
            this.textBoxMax.Size = new System.Drawing.Size(50, 22);
            this.textBoxMax.TabIndex = 10;
            this.textBoxMax.Text = "0";
            this.textBoxMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackBarLyr
            // 
            this.trackBarLyr.Location = new System.Drawing.Point(711, 88);
            this.trackBarLyr.Maximum = 1;
            this.trackBarLyr.Minimum = 1;
            this.trackBarLyr.Name = "trackBarLyr";
            this.trackBarLyr.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarLyr.Size = new System.Drawing.Size(56, 633);
            this.trackBarLyr.TabIndex = 11;
            this.trackBarLyr.TickFrequency = 0;
            this.trackBarLyr.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarLyr.Value = 1;
            this.trackBarLyr.ValueChanged += new System.EventHandler(this.trackBarLyr_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "layer";
            // 
            // textBoxLyr
            // 
            this.textBoxLyr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLyr.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxLyr.Location = new System.Drawing.Point(711, 60);
            this.textBoxLyr.Name = "textBoxLyr";
            this.textBoxLyr.ReadOnly = true;
            this.textBoxLyr.Size = new System.Drawing.Size(50, 22);
            this.textBoxLyr.TabIndex = 13;
            this.textBoxLyr.Text = "0";
            this.textBoxLyr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 733);
            this.Controls.Add(this.textBoxLyr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarLyr);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarMax);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.trackBarMin);
            this.Controls.Add(this.glControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "tomogram visualizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLyr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.TrackBar trackBarMin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBarMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TrackBar trackBarLyr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLyr;
    }
}

