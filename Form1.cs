﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab2
{
    public partial class Form1 : Form
    {
        Bin bin = new Bin();
        bool imageLoaded = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Binary Files|*.bin";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                bin.readBIN(str);
                trackBarLyr.Maximum = Bin.Z;
                View.SetupView(glControl1.Width, glControl1.Height);
                imageLoaded = true;
                glControl1.Invalidate();
            }
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (imageLoaded)
            {
                View.DrawQuads(trackBarLyr.Value-1);
                glControl1.SwapBuffers();
            }
        }

        private void trackBarMax_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBarMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBarLyr_ValueChanged(object sender, EventArgs e)
        {
            textBoxLyr.Text = trackBarLyr.Value.ToString();
            glControl1_Paint(sender, null);
        }
    }
}

//using namespace OpenTK;

//using namespace OpenTK.Graphics.OpenGL;