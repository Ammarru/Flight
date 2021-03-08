using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightX
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		bool clicked = false;
		const double dt = 0.01;
		const double g = 9.81;

		double a;
		double v0;
		double y0;

		double maximumHeight;
		double totalTime;
		double maximumWidth;
		double t;
		double x;
		double y;

		private void btStart_Click(object sender, EventArgs e)
		{
			if (!clicked)
			{
				a = (double)edAngle.Value;
				v0 = (double)edSpeed.Value;
				y0 = (double)edHeight.Value;

				t = 0;
				x = 0;
				y = y0;
				maximumHeight = (Math.Sin(a * Math.PI / 180.0) * v0 * Math.Sin(a * Math.PI / 180.0) * v0) / (2.0 * g) + y0;
				totalTime = (Math.Sin(a * Math.PI / 180.0) * v0 + Math.Sqrt(Math.Sin(a * Math.PI / 180.0) * v0 * Math.Sin(a * Math.PI / 180.0) * v0 + 2.0 * g * (maximumHeight))) / g;
				maximumWidth = totalTime * Math.Cos(a * Math.PI / 180.0) * v0;
				chart1.Series[0].Points.Clear();
				chart1.Series[0].Points.AddXY(x, y);
				chart1.ChartAreas[0].AxisX.Maximum = maximumWidth;
				chart1.ChartAreas[0].AxisY.Maximum = maximumHeight;
				//we can convert to int to make the grapgh look better, but in some cases the arch weould get out of the view. 
				//chart1.ChartAreas[0].AxisX.Maximum = (int)maximumWidth;
				//chart1.ChartAreas[0].AxisY.Maximum = (int)maximumHeight;

				timer1.Start();
			}
			else
			{

				chart1.Series[0].Points.AddXY(x, y);

				timer1.Start();
			}

		}

		private void timer1_Tick(object sender, EventArgs e)
		{

			t = t + dt;
			x = v0 * Math.Cos(a * Math.PI / 180) * t;
			y = y0 + v0 * Math.Sin(a * Math.PI / 180) * t - g * t * t / 2;
			chart1.Series[0].Points.AddXY(x, y);
			label4.Text = $"{t} sec";


			if (y <= 0)
			{
				timer1.Stop();
				clicked = false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			clicked = true;
			timer1.Stop();
		}
	}
}
