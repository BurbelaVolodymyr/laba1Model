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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            ((System.ComponentModel.ISupportInitialize)(this.chMainPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(721, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 60);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Crimson;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(831, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(104, 60);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(880, 128);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(61, 22);
            this.tbX.TabIndex = 2;
            this.tbX.TextChanged += new System.EventHandler(this.tbX_TextChanged);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(947, 127);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(34, 23);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = ">";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(840, 127);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(34, 23);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "<";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // chMainPlot
            // 
            this.chMainPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "chMainArea";
            this.chMainPlot.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chMainPlot.Legends.Add(legend3);
            this.chMainPlot.Location = new System.Drawing.Point(12, 311);
            this.chMainPlot.Name = "chMainPlot";
            series5.BorderColor = System.Drawing.Color.White;
            series5.ChartArea = "chMainArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "Z1";
            series6.BorderColor = System.Drawing.Color.White;
            series6.ChartArea = "chMainArea";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Blue;
            series6.Legend = "Legend1";
            series6.Name = "Z2";
            this.chMainPlot.Series.Add(series5);
            this.chMainPlot.Series.Add(series6);
            this.chMainPlot.Size = new System.Drawing.Size(1040, 430);
            this.chMainPlot.TabIndex = 5;
            this.chMainPlot.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lbZ1
            // 
            this.lbZ1.AutoSize = true;
            this.lbZ1.Location = new System.Drawing.Point(837, 245);
            this.lbZ1.Name = "lbZ1";
            this.lbZ1.Size = new System.Drawing.Size(28, 17);
            this.lbZ1.TabIndex = 6;
            this.lbZ1.Text = "0.0";
            this.lbZ1.Click += new System.EventHandler(this.lbY_Click);
            // 
            // lbYCaption
            // 
            this.lbYCaption.AutoSize = true;
            this.lbYCaption.Location = new System.Drawing.Point(785, 245);
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
            this.btnX1.Location = new System.Drawing.Point(804, 87);
            this.btnX1.Name = "btnX1";
            this.btnX1.Size = new System.Drawing.Size(51, 23);
            this.btnX1.TabIndex = 8;
            this.btnX1.Text = "x1";
            this.btnX1.UseVisualStyleBackColor = true;
            this.btnX1.Click += new System.EventHandler(this.btnX1_Click);
            // 
            // btnX10
            // 
            this.btnX10.Location = new System.Drawing.Point(861, 88);
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
            this.lbXCaption.Location = new System.Drawing.Point(785, 131);
            this.lbXCaption.Name = "lbXCaption";
            this.lbXCaption.Size = new System.Drawing.Size(40, 17);
            this.lbXCaption.TabIndex = 11;
            this.lbXCaption.Text = "Xin1:";
            // 
            // lbXCaption2
            // 
            this.lbXCaption2.AutoSize = true;
            this.lbXCaption2.Location = new System.Drawing.Point(785, 172);
            this.lbXCaption2.Name = "lbXCaption2";
            this.lbXCaption2.Size = new System.Drawing.Size(40, 17);
            this.lbXCaption2.TabIndex = 17;
            this.lbXCaption2.Text = "Xin2:";
            // 
            // lbYCaption2
            // 
            this.lbYCaption2.AutoSize = true;
            this.lbYCaption2.Location = new System.Drawing.Point(785, 274);
            this.lbYCaption2.Name = "lbYCaption2";
            this.lbYCaption2.Size = new System.Drawing.Size(29, 17);
            this.lbYCaption2.TabIndex = 16;
            this.lbYCaption2.Text = "Z2:";
            // 
            // lbZ2
            // 
            this.lbZ2.AutoSize = true;
            this.lbZ2.Location = new System.Drawing.Point(837, 274);
            this.lbZ2.Name = "lbZ2";
            this.lbZ2.Size = new System.Drawing.Size(28, 17);
            this.lbZ2.TabIndex = 15;
            this.lbZ2.Text = "0.0";
            this.lbZ2.Click += new System.EventHandler(this.lbZ2_Click);
            // 
            // btnDown2
            // 
            this.btnDown2.Location = new System.Drawing.Point(840, 168);
            this.btnDown2.Name = "btnDown2";
            this.btnDown2.Size = new System.Drawing.Size(34, 23);
            this.btnDown2.TabIndex = 14;
            this.btnDown2.Text = "<";
            this.btnDown2.UseVisualStyleBackColor = true;
            this.btnDown2.Click += new System.EventHandler(this.btnDown2_Click);
            // 
            // btnUp2
            // 
            this.btnUp2.Location = new System.Drawing.Point(947, 169);
            this.btnUp2.Name = "btnUp2";
            this.btnUp2.Size = new System.Drawing.Size(34, 23);
            this.btnUp2.TabIndex = 13;
            this.btnUp2.Text = ">";
            this.btnUp2.UseVisualStyleBackColor = true;
            this.btnUp2.Click += new System.EventHandler(this.btnUp2_Click);
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(880, 169);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(61, 22);
            this.tbX2.TabIndex = 12;
            // 
            // lbXCaption3
            // 
            this.lbXCaption3.AutoSize = true;
            this.lbXCaption3.Location = new System.Drawing.Point(785, 213);
            this.lbXCaption3.Name = "lbXCaption3";
            this.lbXCaption3.Size = new System.Drawing.Size(49, 17);
            this.lbXCaption3.TabIndex = 23;
            this.lbXCaption3.Text = "Xout1:";
            // 
            // btnDown3
            // 
            this.btnDown3.Location = new System.Drawing.Point(840, 209);
            this.btnDown3.Name = "btnDown3";
            this.btnDown3.Size = new System.Drawing.Size(34, 23);
            this.btnDown3.TabIndex = 20;
            this.btnDown3.Text = "<";
            this.btnDown3.UseVisualStyleBackColor = true;
            this.btnDown3.Click += new System.EventHandler(this.btnDown3_Click);
            // 
            // btnUp3
            // 
            this.btnUp3.Location = new System.Drawing.Point(947, 210);
            this.btnUp3.Name = "btnUp3";
            this.btnUp3.Size = new System.Drawing.Size(34, 23);
            this.btnUp3.TabIndex = 19;
            this.btnUp3.Text = ">";
            this.btnUp3.UseVisualStyleBackColor = true;
            this.btnUp3.Click += new System.EventHandler(this.btnUp3_Click);
            // 
            // tbX3
            // 
            this.tbX3.Location = new System.Drawing.Point(880, 210);
            this.tbX3.Name = "tbX3";
            this.tbX3.Size = new System.Drawing.Size(61, 22);
            this.tbX3.TabIndex = 18;
            // 
            // btnX50
            // 
            this.btnX50.Location = new System.Drawing.Point(921, 88);
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
            this.btnRestart.Location = new System.Drawing.Point(941, 12);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(104, 60);
            this.btnRestart.TabIndex = 25;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 753);
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
    }
}

