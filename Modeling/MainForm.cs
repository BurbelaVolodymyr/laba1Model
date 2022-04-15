using Modeling.Blocks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modeling
{
    public partial class MainForm : Form
    {
        private LimitBlock xLimit = new LimitBlock(0, 100);

        private Tank Block;

        private double xIn1;
        private double xIn2;
        private double xOut1;

        private double y1;
        private double y2;

        private double time = 0;
        private double dt = 0.1;

        public MainForm()
        {
            InitializeComponent();
            Block = new Tank(dt);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tmModel_Tick(object sender, EventArgs e)
        {
            time += dt;

            y1 = Block.Calc1(xIn1);
            lbZ1.Text = y1.ToString("F2");
            chMainPlot.Series[0].Points.AddXY(time, y1);

            y2 = Block.Calc2(xIn2, xOut1);
            lbZ2.Text = y2.ToString("F2");
            chMainPlot.Series[1].Points.AddXY(time, y2);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmModel.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmModel.Stop();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            xIn1 += 1;
            xIn1 = xLimit.Calc(xIn1);
            tbX.Text = xIn1.ToString("F2");
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            xIn1 -= 1;
            xIn1 = xLimit.Calc(xIn1);
            tbX.Text = xIn1.ToString("F2");
        }

        private void btnX1_Click(object sender, EventArgs e)
        {
            tmModel.Interval = 1000;
        }

        private void btnX10_Click(object sender, EventArgs e)
        {
            tmModel.Interval = 100;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbX_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUp2_Click(object sender, EventArgs e)
        {
            xIn2 += 1;
            xIn2 = xLimit.Calc(xIn2);
            tbX2.Text = xIn2.ToString("F2");
        }

        private void btnDown2_Click(object sender, EventArgs e)
        {
            xIn2 -= 1;
            xIn2 = xLimit.Calc(xIn2);
            tbX2.Text = xIn2.ToString("F2");
        }

        private void btnUp3_Click(object sender, EventArgs e)
        {
            xOut1 += 1;
            xOut1 = xLimit.Calc(xOut1);
            tbX3.Text = xOut1.ToString("F2");
        }

        private void btnDown3_Click(object sender, EventArgs e)
        {
            xOut1 -= 1;
            xOut1 = xLimit.Calc(xOut1);
            tbX3.Text = xOut1.ToString("F2");
        }

        private void lbYCaption_Click(object sender, EventArgs e)
        {

        }

        private void lbY_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void chartX_Click(object sender, EventArgs e)
        {

        }

        private void lbZ2_Click(object sender, EventArgs e)
        {

        }

        private void btnX50_Click(object sender, EventArgs e)
        {
            tmModel.Interval = 20;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
