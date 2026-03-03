using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoresConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static (double H, double S, double V) RGBparaHSV(int R, int G, int B)
        {
            double r = R / 255.0;
            double g = G / 255.0;
            double b = B / 255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));
            double delta = max - min;

            double h = 0;

            if (delta != 0)
            {
                if (max == r)
                    h = 60 * ((g - b) / delta);
                else if (max == g)
                    h = 60 * ((b - r) / delta) + 120;
                else
                    h = 60 * ((r - g) / delta) + 240;
            }

            if (h < 0)
                h += 360;

            double s = (max == 0) ? 0 : delta / max;
            double v = max;

            return (h, s * 100, v * 100);
        }
       
         private void AtualizarHSV(int r, int g, int b)
        {
            var (h, s, v) = RGBparaHSV(r, g, b);

            Hprc.Text = $"{h:F2}";
            Sprc.Text = $"{s:F2}%";
            Vprc.Text = $"{v:F2}%";
        }
        

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)

        {
            int r = (int)numericUpDown1.Value;
            int g = (int)numericUpDown2.Value;
            int b = (int)numericUpDown3.Value;
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 255;

            panel1.BackColor = Color.FromArgb(r, g, b);
            AtualizarHSV(r, g, b);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Minimum = 0;
            numericUpDown2.Maximum = 255;
            numericUpDown1_ValueChanged(sender, e);
            
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown3.Minimum = 0;
            numericUpDown3.Maximum = 255;
            numericUpDown1_ValueChanged(sender, e);
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 255;
           int r = (int)trackBar1.Value;
           int g = (int)trackBar2.Value;
           int b = (int)trackBar3.Value;
            numericUpDown1.Value = trackBar1.Value;
            panel1.BackColor = Color.FromArgb(r, g, b);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trackBar2.Minimum = 0;
            trackBar2.Maximum = 255;
            trackBar1_Scroll(sender, e);
            numericUpDown2.Value = trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            trackBar3.Minimum = 0;
            trackBar3.Maximum = 255;
            trackBar1_Scroll(sender, e);
            numericUpDown3.Value = trackBar3.Value;
        }

       
    }
}
