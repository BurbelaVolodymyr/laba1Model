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
        private ControlSystem system;

        //private double xIn1;
        //private double xIn2;
        //private double xOut1;

        //private double y1;
        //private double y2;


        private double dt = 0.1;

        public MainForm()
        {
            InitializeComponent();
            //Block = new Tank(dt);
            system = new ControlSystem(dt);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tmModel_Tick(object sender, EventArgs e)
        {
            system.Calc();


            //y1 = Block.Calc1(xIn1);
            //lbZ1.Text = y1.ToString("F2");
            //chMainPlot.Series[0].Points.AddXY(time, y1);

            //y2 = Block.Calc2(xIn2, xOut1);
            //lbZ2.Text = y2.ToString("F2");
            //chMainPlot.Series[1].Points.AddXY(time, y2);
            DisplayInputValues();

            lbZ1.Text = system.y1.ToString("F2");
            lbZ2.Text = system.y2.ToString("F2");
            chMainPlot.Series[0].Points.AddXY(system.Time, system.y1);
            chMainPlot.Series[1].Points.AddXY(system.Time, system.y2);      

            chPlotX.Series[0].Points.AddXY(system.Time, system.Input1);
            chPlotX.Series[1].Points.AddXY(system.Time, system.Input2);
            chPlotX.Series[2].Points.AddXY(system.Time, system.Output1);

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
            system.Input1 += 1;
            tbX.Text = system.Input1.ToString("F2");
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            system.Input1 -= 1;
            tbX.Text = system.Input1.ToString("F2");
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
            system.Input2 += 1;
            tbX2.Text = system.Input2.ToString("F2");
        }

        private void btnDown2_Click(object sender, EventArgs e)
        {
            system.Input2 -= 1;
            tbX2.Text = system.Input2.ToString("F2");
        }

        private void btnUp3_Click(object sender, EventArgs e)
        {
            system.Output1 += 1;
            tbX3.Text = system.Output1.ToString("F2");
        }

        private void btnDown3_Click(object sender, EventArgs e)
        {
            system.Output1 -= 1;
            tbX3.Text = system.Output1.ToString("F2");
        }

        private void lbYCaption_Click(object sender, EventArgs e)
        {

        }

        private void lbY_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayManualMode();
            DisplayPIDValues();
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

        private void btnDown4_Click(object sender, EventArgs e)
        {
            system.SetPoint -= 1;
            tbSetPoint.Text = system.SetPoint.ToString("F2");
        }

        private void btnUp4_Click(object sender, EventArgs e)
        {
            system.SetPoint += 1;
            tbSetPoint.Text = system.SetPoint.ToString("F2");
        }

        private void btnDown5_Click(object sender, EventArgs e)
        {
            system.K -= 1;
            tbK.Text = system.K.ToString("F2");
        }

        private void btnUp5_Click(object sender, EventArgs e)
        {
            system.K += 1;
            tbK.Text = system.K.ToString("F2");
        }

        private void btnDown6_Click(object sender, EventArgs e)
        {
            system.Ti -= 1;
            tbTi.Text = system.Ti.ToString("F2");
        }

        private void btnUp6_Click(object sender, EventArgs e)
        {
            system.Ti += 1;
            tbTi.Text = system.Ti.ToString("F2");
        }

        private void btnDown7_Click(object sender, EventArgs e)
        {
            system.Td -= 1;
            tbTd.Text = system.Td.ToString("F2");
        }

        private void btnUp7_Click(object sender, EventArgs e)
        {
            system.Td += 1;
            tbTd.Text = system.Td.ToString("F2");
        }

        private void tbTi_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            if (Double.TryParse(tbTi.Text, out val))
            {
                system.Ti = val;
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            system.ManualMode = !system.ManualMode;

            var button = (Button)sender;
            if (btnAuto.Text == "Auto" )
            {
                button.BackColor = Color.Yellow;
                button.ForeColor = Color.Black;
            }
            else
            {
                button.BackColor = Color.Orange;
                button.ForeColor = Color.Black;
            }

            DisplayManualMode();
        }

        private void DisplayManualMode()
        {
            btnAuto.Text = system.ManualMode ? "Manual" : "Auto";
            btnDown.Enabled = system.ManualMode;
            btnUp.Enabled = system.ManualMode;
            tbX.Enabled = system.ManualMode;
        }

        private void DisplayPIDValues()
        {
            tbSetPoint.Text = system.SetPoint.ToString("F2");
            tbK.Text = system.K.ToString("F2");
            tbTi.Text = system.Ti.ToString("F2");
            tbTd.Text = system.Td.ToString("F2");
            DisplayInputValues();
        }

        private void DisplayInputValues()
        {
            tbX.Text = system.Input1.ToString("F2");
            tbX2.Text = system.Input2.ToString("F2");
            tbX3.Text = system.Output1.ToString("F2");
        }

        private void tbSetPoint_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            if (Double.TryParse(tbSetPoint.Text, out val))
            {
                system.SetPoint = val;
            }
        }

        private void tbK_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            if (Double.TryParse(tbK.Text, out val))
            {
                system.K = val;
            }
        }
    }
}
