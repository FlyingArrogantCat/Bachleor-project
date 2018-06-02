using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myDiplom
{
    public partial class graphs : Form
    {
        public graphs()
        {
            InitializeComponent();
        }

        private void graphs_Load(object sender, EventArgs e)
        {
            Form1 t = this.Owner as Form1;
            label1.Text = t.Gomer[0].name_country;
            label2.Text = t.Gomer[1].name_country;
            label3.Text = t.Gomer[2].name_country;

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void builtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 t = this.Owner as Form1;
            try
            {
                chart1.Series.Add("Population");
                chart1.Series["Population"].Color = System.Drawing.Color.Blue;
                chart1.Series["Population"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                chart5.Series.Add("Population");
                chart5.Series["Population"].Color = System.Drawing.Color.Blue;
                chart5.Series["Population"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                chart9.Series.Add("Population");
                chart9.Series["Population"].Color = System.Drawing.Color.Blue;
                chart9.Series["Population"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

                chart2.Series.Add("Low education");
                chart2.Series["Low education"].Color = System.Drawing.Color.Red;
                chart2.Series["Low education"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                chart6.Series.Add("Low education");
                chart6.Series["Low education"].Color = System.Drawing.Color.Red;
                chart6.Series["Low education"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                chart10.Series.Add("Low education");
                chart10.Series["Low education"].Color = System.Drawing.Color.Red;
                chart10.Series["Low education"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

                chart2.Series.Add("Medium education");
                chart2.Series["Medium education"].Color = System.Drawing.Color.Green;
                chart2.Series["Medium education"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                chart6.Series.Add("Medium education");
                chart6.Series["Medium education"].Color = System.Drawing.Color.Green;
                chart6.Series["Medium education"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                chart10.Series.Add("Medium education");
                chart10.Series["Medium education"].Color = System.Drawing.Color.Green;
                chart10.Series["Medium education"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

                chart2.Series.Add("High education");
                chart2.Series["High education"].Color = System.Drawing.Color.Blue;
                chart2.Series["High education"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                chart6.Series.Add("High education");
                chart6.Series["High education"].Color = System.Drawing.Color.Blue;
                chart6.Series["High education"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                chart10.Series.Add("High education");
                chart10.Series["High education"].Color = System.Drawing.Color.Blue;
                chart10.Series["High education"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

                List<string> name_country = new List<string>();

                for (int i = 0; i < t.Gomer.Count; i++)
                {
                    name_country.Add(t.Gomer[i].name_country);
                    chart3.Series.Add(t.Gomer[i].name_country + " Culture");
                    chart3.Series[t.Gomer[i].name_country + " Culture"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    chart7.Series.Add(t.Gomer[i].name_country + " Culture");
                    chart7.Series[t.Gomer[i].name_country + " Culture"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    chart11.Series.Add(t.Gomer[i].name_country + " Culture");
                    chart11.Series[t.Gomer[i].name_country + " Culture"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

                }
                chart3.Series[name_country[0] + " Culture"].Color = System.Drawing.Color.Black;
                chart7.Series[name_country[0] + " Culture"].Color = System.Drawing.Color.Black;
                chart11.Series[name_country[0] + " Culture"].Color = System.Drawing.Color.Black;

                chart3.Series[name_country[1] + " Culture"].Color = System.Drawing.Color.Blue;
                chart7.Series[name_country[1] + " Culture"].Color = System.Drawing.Color.Blue;
                chart11.Series[name_country[1] + " Culture"].Color = System.Drawing.Color.Blue;

                chart3.Series[name_country[2] + " Culture"].Color = System.Drawing.Color.Red;
                chart7.Series[name_country[2] + " Culture"].Color = System.Drawing.Color.Red;
                chart11.Series[name_country[2] + " Culture"].Color = System.Drawing.Color.Red;
                //MessageBox.Show(t.dym[0].population.Count.ToString(), "amt t.dym[0].population.Count", MessageBoxButtons.OK);
                for (int i = 0; i < Math.Round(t.dym[0].population.Count*1.0f/3); i++)
                {
                    chart1.Series["Population"].Points.AddXY((i+1).ToString(),t.dym[0].population[3 * i]);
                    chart5.Series["Population"].Points.AddXY((i + 1).ToString(), t.dym[1].population[3 * i]);
                    chart9.Series["Population"].Points.AddXY((i + 1).ToString(), t.dym[2].population[3 * i]);

                    chart2.Series["Low education"].Points.AddXY((i + 1).ToString(), t.dym[0].educ[3 * i][0]);
                    chart6.Series["Low education"].Points.AddXY((i + 1).ToString(), t.dym[1].educ[3 * i][0]);
                    chart10.Series["Low education"].Points.AddXY((i + 1).ToString(), t.dym[2].educ[3 * i][0]);

                    chart2.Series["Medium education"].Points.AddXY((i + 1).ToString(), t.dym[0].educ[3 * i][1]);
                    chart6.Series["Medium education"].Points.AddXY((i + 1).ToString(), t.dym[1].educ[3 * i][1]);
                    chart10.Series["Medium education"].Points.AddXY((i + 1).ToString(), t.dym[2].educ[3 * i][1]);

                    chart2.Series["High education"].Points.AddXY((i + 1).ToString(), t.dym[0].educ[3 * i][2]);
                    chart6.Series["High education"].Points.AddXY((i + 1).ToString(), t.dym[1].educ[3 * i][2]);
                    chart10.Series["High education"].Points.AddXY((i + 1).ToString(), t.dym[2].educ[3 * i][2]);

                    chart3.Series[name_country[0] + " Culture"].Points.AddXY((i + 1).ToString(), t.dym[0].culture[3 * i][0]);
                    chart7.Series[name_country[0] + " Culture"].Points.AddXY((i + 1).ToString(), t.dym[1].culture[3 * i][0]);
                    chart11.Series[name_country[0] + " Culture"].Points.AddXY((i + 1).ToString(), t.dym[2].culture[3 * i][0]);

                    chart3.Series[name_country[1] + " Culture"].Points.AddXY((i + 1).ToString(), t.dym[0].culture[3 * i][1]);
                    chart7.Series[name_country[1] + " Culture"].Points.AddXY((i + 1).ToString(), t.dym[1].culture[3 * i][1]);
                    chart11.Series[name_country[1] + " Culture"].Points.AddXY((i + 1).ToString(), t.dym[2].culture[3 * i][1]);

                    chart3.Series[name_country[2] + " Culture"].Points.AddXY((i + 1).ToString(), t.dym[0].culture[3 * i][2]);
                    chart7.Series[name_country[2] + " Culture"].Points.AddXY((i + 1).ToString(), t.dym[1].culture[3 * i][2]);
                    chart11.Series[name_country[2] + " Culture"].Points.AddXY((i + 1).ToString(), t.dym[2].culture[3 * i][2]);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
