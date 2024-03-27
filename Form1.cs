#define DISPLAY_FPS

using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        Bin bin = new Bin();
        bool imageLoaded = false;
        public static Form1 It;

        public Form1()
        {
            InitializeComponent();
            It = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
#if DISPLAY_FPS
            Application.Idle += Application_Idle;
#endif
        }

        private void OpenImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Binary Files|*.bin";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                imageLoaded = bin.readBIN(str);
                if (!imageLoaded)
                    return;
                trackBarLyr.Maximum = Bin.Z;
                View.SetupView(glControl1.Width, glControl1.Height);
                glControl1.Invalidate();
            }
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (imageLoaded)
            {
                if (radioButtonQuads.Checked)
                    View.DrawQuads(trackBarLyr.Value - 1);
                else if (radioButtonTexture.Checked)
                    View.DrawTexture(trackBarLyr.Value - 1);
                else
                    View.DrawQuadStrip(trackBarLyr.Value - 1);
                glControl1.SwapBuffers();
            }
        }

        private void trackBarMin_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarMin.Value > trackBarMax.Value)
                trackBarMax.Value = trackBarMin.Value+1;
            textBoxMin.Text = trackBarMin.Value.ToString();
            View.minimum = trackBarMin.Value;
            glControl1_Paint(sender, null);
        }

        private void trackBarMax_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarMin.Value > trackBarMax.Value)
                trackBarMin.Value = trackBarMax.Value-1;
            textBoxMax.Text = trackBarMax.Value.ToString();
            View.maximum = trackBarMax.Value;
            glControl1_Paint(sender, null);
        }

        public (int, int) GetMinMax()
        {
            return (trackBarMin.Value, trackBarMax.Value);
        }

        private void trackBarLyr_ValueChanged(object sender, EventArgs e)
        {
            textBoxLyr.Text = trackBarLyr.Value.ToString();
            glControl1_Paint(sender, null);
        }
        private void radioButtonQuads_Click(object sender, EventArgs e)
        {
            glControl1_Paint(sender, null);
        }

        private void radioButtonTexture_Click(object sender, EventArgs e)
        {
            glControl1_Paint(sender, null);
        }

        private void radioButtonQuadsStrip_Click(object sender, EventArgs e)
        {
            glControl1_Paint(sender, null);
        }

#if DISPLAY_FPS
        void Application_Idle(object sender, EventArgs e)
        {
            while (glControl1.IsIdle)
            {
                displayFPS();
                glControl1.Invalidate();
            }
        }

        int frameCount;
        DateTime NextFPSUpdate = DateTime.Now.AddSeconds(1);

        void displayFPS()
        {
            if (DateTime.Now >= NextFPSUpdate)
            {
                this.Text = String.Format("tomogram visualizer (fps: {0})", frameCount);
                NextFPSUpdate = DateTime.Now.AddSeconds(1);
                frameCount = 0;
            }
            frameCount++;
        }
#endif
        /*
        private void Form1_Resize(object sender, EventArgs e)
        {
            int size = Math.Min(Size.Width-250, Size.Height-100);
            glControl1.Size = new Size(size, size);
        }*/
    }
}

//using namespace OpenTK;

//using namespace OpenTK.Graphics.OpenGL;