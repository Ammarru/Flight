namespace FlightX
{
    partial class Form1
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
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btStart = new System.Windows.Forms.Button();
			this.edHeight = new System.Windows.Forms.NumericUpDown();
			this.edSpeed = new System.Windows.Forms.NumericUpDown();
			this.edAngle = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.edHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edAngle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.btStart);
			this.panel1.Controls.Add(this.edHeight);
			this.panel1.Controls.Add(this.edSpeed);
			this.panel1.Controls.Add(this.edAngle);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 100);
			this.panel1.TabIndex = 0;
			// 
			// btStart
			// 
			this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btStart.Location = new System.Drawing.Point(264, 21);
			this.btStart.Name = "btStart";
			this.btStart.Size = new System.Drawing.Size(87, 49);
			this.btStart.TabIndex = 6;
			this.btStart.Text = "Start!";
			this.btStart.UseVisualStyleBackColor = true;
			this.btStart.Click += new System.EventHandler(this.btStart_Click);
			// 
			// edHeight
			// 
			this.edHeight.Location = new System.Drawing.Point(71, 69);
			this.edHeight.Name = "edHeight";
			this.edHeight.Size = new System.Drawing.Size(84, 20);
			this.edHeight.TabIndex = 5;
			// 
			// edSpeed
			// 
			this.edSpeed.Location = new System.Drawing.Point(71, 39);
			this.edSpeed.Name = "edSpeed";
			this.edSpeed.Size = new System.Drawing.Size(84, 20);
			this.edSpeed.TabIndex = 4;
			this.edSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// edAngle
			// 
			this.edAngle.Location = new System.Drawing.Point(70, 9);
			this.edAngle.Name = "edAngle";
			this.edAngle.Size = new System.Drawing.Size(85, 20);
			this.edAngle.TabIndex = 3;
			this.edAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Height:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Speed:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Angle:";
			// 
			// chart1
			// 
			chartArea1.AxisX.Maximum = 25D;
			chartArea1.AxisX.Minimum = 0D;
			chartArea1.AxisY.Maximum = 6D;
			chartArea1.AxisY.Minimum = 0D;
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chart1.Location = new System.Drawing.Point(0, 100);
			this.chart1.Name = "chart1";
			series1.BorderWidth = 3;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(800, 350);
			this.chart1.TabIndex = 1;
			this.chart1.Text = "chart1";
			// 
			// timer1
			// 
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(508, 21);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 49);
			this.button1.TabIndex = 7;
			this.button1.Text = "Pause!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(413, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "0 sec";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.edHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edAngle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown edHeight;
        private System.Windows.Forms.NumericUpDown edSpeed;
        private System.Windows.Forms.NumericUpDown edAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
	}
}

