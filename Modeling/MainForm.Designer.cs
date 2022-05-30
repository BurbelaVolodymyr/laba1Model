namespace Modeling
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbX = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.chMainPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbZ1 = new System.Windows.Forms.Label();
            this.lbYCaption = new System.Windows.Forms.Label();
            this.tmModel = new System.Windows.Forms.Timer(this.components);
            this.btnX1 = new System.Windows.Forms.Button();
            this.btnX10 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbXCaption = new System.Windows.Forms.Label();
            this.lbXCaption2 = new System.Windows.Forms.Label();
            this.lbYCaption2 = new System.Windows.Forms.Label();
            this.lbZ2 = new System.Windows.Forms.Label();
            this.btnDown2 = new System.Windows.Forms.Button();
            this.btnUp2 = new System.Windows.Forms.Button();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.lbXCaption3 = new System.Windows.Forms.Label();
            this.btnDown3 = new System.Windows.Forms.Button();
            this.btnUp3 = new System.Windows.Forms.Button();
            this.tbX3 = new System.Windows.Forms.TextBox();
            this.btnX50 = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lbCaptionSetPoint = new System.Windows.Forms.Label();
            this.btnDown4 = new System.Windows.Forms.Button();
            this.btnUp4 = new System.Windows.Forms.Button();
            this.tbSetPoint = new System.Windows.Forms.TextBox();
            this.lbKCaption = new System.Windows.Forms.Label();
            this.btnDown5 = new System.Windows.Forms.Button();
            this.btnUp5 = new System.Windows.Forms.Button();
            this.tbK = new System.Windows.Forms.TextBox();
            this.lbTiCaption = new System.Windows.Forms.Label();
            this.btnDown6 = new System.Windows.Forms.Button();
            this.btnUp6 = new System.Windows.Forms.Button();
            this.tbTi = new System.Windows.Forms.TextBox();
            this.lbTdCaption = new System.Windows.Forms.Label();
            this.btnDown7 = new System.Windows.Forms.Button();
            this.btnUp7 = new System.Windows.Forms.Button();
            this.tbTd = new System.Windows.Forms.TextBox();
            this.chPlotX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chMainPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chPlotX)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(799, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 60);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Crimson;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(915, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(110, 60);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(891, 176);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(61, 22);
            this.tbX.TabIndex = 2;
            this.tbX.TextChanged += new System.EventHandler(this.tbX_TextChanged);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(958, 175);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(34, 23);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = ">";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(851, 175);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(34, 23);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "<";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // chMainPlot
            // 
            this.chMainPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            chartArea1.Name = "chMainArea";
            this.chMainPlot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chMainPlot.Legends.Add(legend1);
            this.chMainPlot.Location = new System.Drawing.Point(12, 311);
            this.chMainPlot.Name = "chMainPlot";
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "chMainArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.MarkerSize = 7;
            series1.Name = "Z1";
            series2.BorderColor = System.Drawing.Color.White;
            series2.ChartArea = "chMainArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.MarkerSize = 7;
            series2.Name = "Z2";
            this.chMainPlot.Series.Add(series1);
            this.chMainPlot.Series.Add(series2);
            this.chMainPlot.Size = new System.Drawing.Size(689, 430);
            this.chMainPlot.TabIndex = 5;
            this.chMainPlot.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lbZ1
            // 
            this.lbZ1.AutoSize = true;
            this.lbZ1.Location = new System.Drawing.Point(633, 416);
            this.lbZ1.Name = "lbZ1";
            this.lbZ1.Size = new System.Drawing.Size(28, 17);
            this.lbZ1.TabIndex = 6;
            this.lbZ1.Text = "0.0";
            this.lbZ1.Click += new System.EventHandler(this.lbY_Click);
            // 
            // lbYCaption
            // 
            this.lbYCaption.AutoSize = true;
            this.lbYCaption.Location = new System.Drawing.Point(598, 416);
            this.lbYCaption.Name = "lbYCaption";
            this.lbYCaption.Size = new System.Drawing.Size(29, 17);
            this.lbYCaption.TabIndex = 7;
            this.lbYCaption.Text = "Z1:";
            this.lbYCaption.Click += new System.EventHandler(this.lbYCaption_Click);
            // 
            // tmModel
            // 
            this.tmModel.Interval = 1000;
            this.tmModel.Tick += new System.EventHandler(this.tmModel_Tick);
            // 
            // btnX1
            // 
            this.btnX1.Location = new System.Drawing.Point(941, 87);
            this.btnX1.Name = "btnX1";
            this.btnX1.Size = new System.Drawing.Size(51, 23);
            this.btnX1.TabIndex = 8;
            this.btnX1.Text = "x1";
            this.btnX1.UseVisualStyleBackColor = true;
            this.btnX1.Click += new System.EventHandler(this.btnX1_Click);
            // 
            // btnX10
            // 
            this.btnX10.Location = new System.Drawing.Point(998, 88);
            this.btnX10.Name = "btnX10";
            this.btnX10.Size = new System.Drawing.Size(51, 23);
            this.btnX10.TabIndex = 9;
            this.btnX10.Text = "x10";
            this.btnX10.UseVisualStyleBackColor = true;
            this.btnX10.Click += new System.EventHandler(this.btnX10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbXCaption
            // 
            this.lbXCaption.AutoSize = true;
            this.lbXCaption.Location = new System.Drawing.Point(796, 179);
            this.lbXCaption.Name = "lbXCaption";
            this.lbXCaption.Size = new System.Drawing.Size(40, 17);
            this.lbXCaption.TabIndex = 11;
            this.lbXCaption.Text = "Xin1:";
            // 
            // lbXCaption2
            // 
            this.lbXCaption2.AutoSize = true;
            this.lbXCaption2.Location = new System.Drawing.Point(796, 220);
            this.lbXCaption2.Name = "lbXCaption2";
            this.lbXCaption2.Size = new System.Drawing.Size(40, 17);
            this.lbXCaption2.TabIndex = 17;
            this.lbXCaption2.Text = "Xin2:";
            // 
            // lbYCaption2
            // 
            this.lbYCaption2.AutoSize = true;
            this.lbYCaption2.Location = new System.Drawing.Point(598, 445);
            this.lbYCaption2.Name = "lbYCaption2";
            this.lbYCaption2.Size = new System.Drawing.Size(29, 17);
            this.lbYCaption2.TabIndex = 16;
            this.lbYCaption2.Text = "Z2:";
            // 
            // lbZ2
            // 
            this.lbZ2.AutoSize = true;
            this.lbZ2.Location = new System.Drawing.Point(633, 445);
            this.lbZ2.Name = "lbZ2";
            this.lbZ2.Size = new System.Drawing.Size(28, 17);
            this.lbZ2.TabIndex = 15;
            this.lbZ2.Text = "0.0";
            this.lbZ2.Click += new System.EventHandler(this.lbZ2_Click);
            // 
            // btnDown2
            // 
            this.btnDown2.Location = new System.Drawing.Point(851, 216);
            this.btnDown2.Name = "btnDown2";
            this.btnDown2.Size = new System.Drawing.Size(34, 23);
            this.btnDown2.TabIndex = 14;
            this.btnDown2.Text = "<";
            this.btnDown2.UseVisualStyleBackColor = true;
            this.btnDown2.Click += new System.EventHandler(this.btnDown2_Click);
            // 
            // btnUp2
            // 
            this.btnUp2.Location = new System.Drawing.Point(958, 217);
            this.btnUp2.Name = "btnUp2";
            this.btnUp2.Size = new System.Drawing.Size(34, 23);
            this.btnUp2.TabIndex = 13;
            this.btnUp2.Text = ">";
            this.btnUp2.UseVisualStyleBackColor = true;
            this.btnUp2.Click += new System.EventHandler(this.btnUp2_Click);
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(891, 217);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(61, 22);
            this.tbX2.TabIndex = 12;
            // 
            // lbXCaption3
            // 
            this.lbXCaption3.AutoSize = true;
            this.lbXCaption3.Location = new System.Drawing.Point(796, 261);
            this.lbXCaption3.Name = "lbXCaption3";
            this.lbXCaption3.Size = new System.Drawing.Size(49, 17);
            this.lbXCaption3.TabIndex = 23;
            this.lbXCaption3.Text = "Xout1:";
            // 
            // btnDown3
            // 
            this.btnDown3.Location = new System.Drawing.Point(851, 257);
            this.btnDown3.Name = "btnDown3";
            this.btnDown3.Size = new System.Drawing.Size(34, 23);
            this.btnDown3.TabIndex = 20;
            this.btnDown3.Text = "<";
            this.btnDown3.UseVisualStyleBackColor = true;
            this.btnDown3.Click += new System.EventHandler(this.btnDown3_Click);
            // 
            // btnUp3
            // 
            this.btnUp3.Location = new System.Drawing.Point(958, 258);
            this.btnUp3.Name = "btnUp3";
            this.btnUp3.Size = new System.Drawing.Size(34, 23);
            this.btnUp3.TabIndex = 19;
            this.btnUp3.Text = ">";
            this.btnUp3.UseVisualStyleBackColor = true;
            this.btnUp3.Click += new System.EventHandler(this.btnUp3_Click);
            // 
            // tbX3
            // 
            this.tbX3.Location = new System.Drawing.Point(891, 258);
            this.tbX3.Name = "tbX3";
            this.tbX3.Size = new System.Drawing.Size(61, 22);
            this.tbX3.TabIndex = 18;
            // 
            // btnX50
            // 
            this.btnX50.Location = new System.Drawing.Point(1058, 88);
            this.btnX50.Name = "btnX50";
            this.btnX50.Size = new System.Drawing.Size(51, 23);
            this.btnX50.TabIndex = 24;
            this.btnX50.Text = "x50";
            this.btnX50.UseVisualStyleBackColor = true;
            this.btnX50.Click += new System.EventHandler(this.btnX50_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRestart.Location = new System.Drawing.Point(1147, 12);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(110, 60);
            this.btnRestart.TabIndex = 25;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lbCaptionSetPoint
            // 
            this.lbCaptionSetPoint.AutoSize = true;
            this.lbCaptionSetPoint.Location = new System.Drawing.Point(920, 134);
            this.lbCaptionSetPoint.Name = "lbCaptionSetPoint";
            this.lbCaptionSetPoint.Size = new System.Drawing.Size(65, 17);
            this.lbCaptionSetPoint.TabIndex = 29;
            this.lbCaptionSetPoint.Text = "SetPoint:";
            // 
            // btnDown4
            // 
            this.btnDown4.Location = new System.Drawing.Point(991, 131);
            this.btnDown4.Name = "btnDown4";
            this.btnDown4.Size = new System.Drawing.Size(34, 23);
            this.btnDown4.TabIndex = 28;
            this.btnDown4.Text = "<";
            this.btnDown4.UseVisualStyleBackColor = true;
            this.btnDown4.Click += new System.EventHandler(this.btnDown4_Click);
            // 
            // btnUp4
            // 
            this.btnUp4.Location = new System.Drawing.Point(1098, 131);
            this.btnUp4.Name = "btnUp4";
            this.btnUp4.Size = new System.Drawing.Size(34, 23);
            this.btnUp4.TabIndex = 27;
            this.btnUp4.Text = ">";
            this.btnUp4.UseVisualStyleBackColor = true;
            this.btnUp4.Click += new System.EventHandler(this.btnUp4_Click);
            // 
            // tbSetPoint
            // 
            this.tbSetPoint.Location = new System.Drawing.Point(1031, 132);
            this.tbSetPoint.Name = "tbSetPoint";
            this.tbSetPoint.Size = new System.Drawing.Size(61, 22);
            this.tbSetPoint.TabIndex = 26;
            this.tbSetPoint.TextChanged += new System.EventHandler(this.tbSetPoint_TextChanged);
            // 
            // lbKCaption
            // 
            this.lbKCaption.AutoSize = true;
            this.lbKCaption.Location = new System.Drawing.Point(1071, 178);
            this.lbKCaption.Name = "lbKCaption";
            this.lbKCaption.Size = new System.Drawing.Size(21, 17);
            this.lbKCaption.TabIndex = 33;
            this.lbKCaption.Text = "K:";
            // 
            // btnDown5
            // 
            this.btnDown5.Location = new System.Drawing.Point(1112, 174);
            this.btnDown5.Name = "btnDown5";
            this.btnDown5.Size = new System.Drawing.Size(34, 23);
            this.btnDown5.TabIndex = 32;
            this.btnDown5.Text = "<";
            this.btnDown5.UseVisualStyleBackColor = true;
            this.btnDown5.Click += new System.EventHandler(this.btnDown5_Click);
            // 
            // btnUp5
            // 
            this.btnUp5.Location = new System.Drawing.Point(1219, 174);
            this.btnUp5.Name = "btnUp5";
            this.btnUp5.Size = new System.Drawing.Size(34, 23);
            this.btnUp5.TabIndex = 31;
            this.btnUp5.Text = ">";
            this.btnUp5.UseVisualStyleBackColor = true;
            this.btnUp5.Click += new System.EventHandler(this.btnUp5_Click);
            // 
            // tbK
            // 
            this.tbK.Location = new System.Drawing.Point(1152, 175);
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(61, 22);
            this.tbK.TabIndex = 30;
            this.tbK.TextChanged += new System.EventHandler(this.tbK_TextChanged);
            // 
            // lbTiCaption
            // 
            this.lbTiCaption.AutoSize = true;
            this.lbTiCaption.Location = new System.Drawing.Point(1071, 220);
            this.lbTiCaption.Name = "lbTiCaption";
            this.lbTiCaption.Size = new System.Drawing.Size(24, 17);
            this.lbTiCaption.TabIndex = 37;
            this.lbTiCaption.Text = "Ti:";
            // 
            // btnDown6
            // 
            this.btnDown6.Location = new System.Drawing.Point(1112, 216);
            this.btnDown6.Name = "btnDown6";
            this.btnDown6.Size = new System.Drawing.Size(34, 23);
            this.btnDown6.TabIndex = 36;
            this.btnDown6.Text = "<";
            this.btnDown6.UseVisualStyleBackColor = true;
            this.btnDown6.Click += new System.EventHandler(this.btnDown6_Click);
            // 
            // btnUp6
            // 
            this.btnUp6.Location = new System.Drawing.Point(1219, 216);
            this.btnUp6.Name = "btnUp6";
            this.btnUp6.Size = new System.Drawing.Size(34, 23);
            this.btnUp6.TabIndex = 35;
            this.btnUp6.Text = ">";
            this.btnUp6.UseVisualStyleBackColor = true;
            this.btnUp6.Click += new System.EventHandler(this.btnUp6_Click);
            // 
            // tbTi
            // 
            this.tbTi.Location = new System.Drawing.Point(1152, 217);
            this.tbTi.Name = "tbTi";
            this.tbTi.Size = new System.Drawing.Size(61, 22);
            this.tbTi.TabIndex = 34;
            this.tbTi.TextChanged += new System.EventHandler(this.tbTi_TextChanged);
            // 
            // lbTdCaption
            // 
            this.lbTdCaption.AutoSize = true;
            this.lbTdCaption.Location = new System.Drawing.Point(1071, 262);
            this.lbTdCaption.Name = "lbTdCaption";
            this.lbTdCaption.Size = new System.Drawing.Size(29, 17);
            this.lbTdCaption.TabIndex = 41;
            this.lbTdCaption.Text = "Td:";
            // 
            // btnDown7
            // 
            this.btnDown7.Location = new System.Drawing.Point(1112, 258);
            this.btnDown7.Name = "btnDown7";
            this.btnDown7.Size = new System.Drawing.Size(34, 23);
            this.btnDown7.TabIndex = 40;
            this.btnDown7.Text = "<";
            this.btnDown7.UseVisualStyleBackColor = true;
            this.btnDown7.Click += new System.EventHandler(this.btnDown7_Click);
            // 
            // btnUp7
            // 
            this.btnUp7.Location = new System.Drawing.Point(1219, 258);
            this.btnUp7.Name = "btnUp7";
            this.btnUp7.Size = new System.Drawing.Size(34, 23);
            this.btnUp7.TabIndex = 39;
            this.btnUp7.Text = ">";
            this.btnUp7.UseVisualStyleBackColor = true;
            this.btnUp7.Click += new System.EventHandler(this.btnUp7_Click);
            // 
            // tbTd
            // 
            this.tbTd.Location = new System.Drawing.Point(1152, 259);
            this.tbTd.Name = "tbTd";
            this.tbTd.Size = new System.Drawing.Size(61, 22);
            this.tbTd.TabIndex = 38;
            // 
            // chPlotX
            // 
            this.chPlotX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chPlotX.BorderlineWidth = 5;
            chartArea2.Name = "ChartArea1";
            this.chPlotX.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chPlotX.Legends.Add(legend2);
            this.chPlotX.Location = new System.Drawing.Point(707, 311);
            this.chPlotX.Name = "chPlotX";
            this.chPlotX.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerSize = 7;
            series3.Name = "XIn1";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.MarkerSize = 7;
            series4.Name = "XIn2";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.MarkerSize = 7;
            series5.Name = "XOut1";
            this.chPlotX.Series.Add(series3);
            this.chPlotX.Series.Add(series4);
            this.chPlotX.Series.Add(series5);
            this.chPlotX.Size = new System.Drawing.Size(608, 430);
            this.chPlotX.TabIndex = 42;
            this.chPlotX.Text = "chart1";
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.Color.Orange;
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuto.Location = new System.Drawing.Point(1031, 12);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(110, 60);
            this.btnAuto.TabIndex = 43;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 753);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.chPlotX);
            this.Controls.Add(this.lbTdCaption);
            this.Controls.Add(this.btnDown7);
            this.Controls.Add(this.btnUp7);
            this.Controls.Add(this.tbTd);
            this.Controls.Add(this.lbTiCaption);
            this.Controls.Add(this.btnDown6);
            this.Controls.Add(this.btnUp6);
            this.Controls.Add(this.tbTi);
            this.Controls.Add(this.lbKCaption);
            this.Controls.Add(this.btnDown5);
            this.Controls.Add(this.btnUp5);
            this.Controls.Add(this.tbK);
            this.Controls.Add(this.lbCaptionSetPoint);
            this.Controls.Add(this.btnDown4);
            this.Controls.Add(this.btnUp4);
            this.Controls.Add(this.tbSetPoint);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnX50);
            this.Controls.Add(this.lbXCaption3);
            this.Controls.Add(this.btnDown3);
            this.Controls.Add(this.btnUp3);
            this.Controls.Add(this.tbX3);
            this.Controls.Add(this.lbXCaption2);
            this.Controls.Add(this.lbYCaption2);
            this.Controls.Add(this.lbZ2);
            this.Controls.Add(this.btnDown2);
            this.Controls.Add(this.btnUp2);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.lbXCaption);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnX10);
            this.Controls.Add(this.btnX1);
            this.Controls.Add(this.lbYCaption);
            this.Controls.Add(this.lbZ1);
            this.Controls.Add(this.chMainPlot);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "Simple Model";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chMainPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chPlotX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.DataVisualization.Charting.Chart chMainPlot;
        private System.Windows.Forms.Label lbZ1;
        private System.Windows.Forms.Label lbYCaption;
        private System.Windows.Forms.Timer tmModel;
        private System.Windows.Forms.Button btnX1;
        private System.Windows.Forms.Button btnX10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbXCaption;
        private System.Windows.Forms.Label lbXCaption2;
        private System.Windows.Forms.Label lbYCaption2;
        private System.Windows.Forms.Label lbZ2;
        private System.Windows.Forms.Button btnDown2;
        private System.Windows.Forms.Button btnUp2;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.Label lbXCaption3;
        private System.Windows.Forms.Button btnDown3;
        private System.Windows.Forms.Button btnUp3;
        private System.Windows.Forms.TextBox tbX3;
        private System.Windows.Forms.Button btnX50;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lbCaptionSetPoint;
        private System.Windows.Forms.Button btnDown4;
        private System.Windows.Forms.Button btnUp4;
        private System.Windows.Forms.TextBox tbSetPoint;
        private System.Windows.Forms.Label lbKCaption;
        private System.Windows.Forms.Button btnDown5;
        private System.Windows.Forms.Button btnUp5;
        private System.Windows.Forms.TextBox tbK;
        private System.Windows.Forms.Label lbTiCaption;
        private System.Windows.Forms.Button btnDown6;
        private System.Windows.Forms.Button btnUp6;
        private System.Windows.Forms.TextBox tbTi;
        private System.Windows.Forms.Label lbTdCaption;
        private System.Windows.Forms.Button btnDown7;
        private System.Windows.Forms.Button btnUp7;
        private System.Windows.Forms.TextBox tbTd;
        private System.Windows.Forms.DataVisualization.Charting.Chart chPlotX;
        private System.Windows.Forms.Button btnAuto;
    }
}

