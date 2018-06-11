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
            for(int i=0;i<t.Gomer.Count; i++)
            {
                comboBox1.Items.Add(t.Gomer[i].name_country);
            }

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void builtToolStripMenuItem_Click(object sender, EventArgs e)
        {   /*
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
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 t = this.Owner as Form1;
            try
            {
                chart1.Series.Clear();
                chart2.Series.Clear();
                chart3.Series.Clear();
             
                chart4.Series.Clear();

                chart1.Series.Add("Population");
                chart1.Series["Population"].Color = System.Drawing.Color.Blue;
                /*chart1.Series["Population"].Font.Size = System.Windows.Forms.DataVisualization.Charting.DataPointCustomProperties.Font{ };*/
                chart1.Series["Population"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series["Population"].BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.None;

                chart2.Series.Add("Low education");
                chart2.Series["Low education"].Color = System.Drawing.Color.Red;
                chart2.Series["Low education"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                chart2.Series.Add("Medium education");
                chart2.Series["Medium education"].Color = System.Drawing.Color.Green;
                chart2.Series["Medium education"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                chart2.Series.Add("High education");
                chart2.Series["High education"].Color = System.Drawing.Color.Blue;
                chart2.Series["High education"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                chart4.Series.Add("0-10");
                chart4.Series["0-10"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart4.Series.Add("10-20");
                chart4.Series["10-20"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart4.Series.Add("20-30");
                chart4.Series["20-30"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart4.Series.Add("30-40");
                chart4.Series["30-40"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart4.Series.Add("40-50");
                chart4.Series["40-50"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                /*chart4.Series.Add("50-60");
                chart4.Series["50-60"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart4.Series.Add("60-70");
                chart4.Series["60-70"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart4.Series.Add("70-80");
                chart4.Series["70-80"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart4.Series.Add("80-90");
                chart4.Series["40-50"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart4.Series.Add("90-100");
                chart4.Series["90-100"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;*/
            }
            catch
            {
                MessageBox.Show("Error1", "Error", MessageBoxButtons.OK);
            }
            //MessageBox.Show(t.time[0].population.self[0,0].ToString()+'\n'+ t.time[3].population.self[0, 0].ToString(), "temp",MessageBoxButtons.OK);
            //MessageBox.Show(t.time[1].population.self[0, 0].ToString() + '\n' + t.time[4].population.self[0, 0].ToString(), "temp", MessageBoxButtons.OK);
            //MessageBox.Show(t.time[2].population.self[0, 0].ToString() + '\n' + t.time[5].population.self[0, 0].ToString(), "temp", MessageBoxButtons.OK);
            /*
            try
            {*/

            List<string> name_country = new List<string>();
            int ondex = -1;
            for (int i = 0; i < t.Gomer.Count; i++)
            {
                if (comboBox1.SelectedItem.ToString() == t.Gomer[i].name_country)
                {
                    ondex = t.Gomer[i].number;
                }
            }
            if (ondex == -1)
            {
                MessageBox.Show("You don't choose name country", "Error", MessageBoxButtons.OK);
                return;
            }
            name_country.Clear();
            for (int rr = 0; rr < t.Gomer.Count; rr++)
            {
                    name_country.Add(t.Gomer[rr].name_country);
                    chart3.Series.Add(t.Gomer[rr].name_country + " Culture");
                    chart3.Series[t.Gomer[rr].name_country + " Culture"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }
            for (int k = 0; k < t.forgraps.Count; k++)
            {
                MessageBox.Show(t.forgraps[k].number.ToString() + '\n' + t.forgraps[k].population.ToString(), "population", MessageBoxButtons.OK);
            }
            for (int i = 0; i < t.forgraps.Count; i++)
            {
                /*
                for (int i = 0; i < t.time.Count; i++)
                {
                    double[] for_educ = new double[3];
                    double[] for_age = new double[10];
                    double[] for_cult = new double[t.Gomer.Count];
                    double all_popul = 0.0f;

                    for (int ee = 0; ee < for_cult.Length; ee++)
                    {
                        for_cult[ee] = 0.0f;
                    }
                    for (int ee = 0; ee < for_age.Length; ee++)
                    {
                        for_age[ee] = 0.0f;
                    }
                    for (int ee = 0; ee < for_educ.Length; ee++)
                    {
                        for_educ[ee] = 0.0f;
                    }
                    all_popul = 0.0f;

                    if (t.time[i].number == ondex)
                    {
                      

                        for (int j = 0; j < t.time[i].population.size_first; j++)
                        {
                            for_age[j] = 0.0f;
                            for (int k = 0; k < t.time[i].population.size_second; k++)
                            {
                                for_age[j] += t.time[i].population.self[j, k];
                            }
                        }
   
                        for (int k = 0; k < t.time[i].population.size_second; k++)
                        {
                            for_educ[k] = 0.0f;
                            for (int j = 0; j < t.time[i].population.size_first; j++)
                            {
                                for_educ[k] += t.time[i].population.self[j, k];
                            }
                        }
    
                        for (int k = 0; k < t.time[i].population.size_second; k++)
                        {
                            for (int j = 0; j < t.time[i].population.size_first; j++)
                            {
                                all_popul += t.time[i].population.self[j, k];
                            }
                        }

                        for (int k = 0; k < t.time[i].culture.size_culture; k++)
                        {
                            for_cult[k] = 0.0f;
                            for (int j = 0; j < t.time[i].culture.size_age; j++)
                            {
                                for_cult[k] += t.time[i].culture.distrib[k, j];
                            }
                        }
                      */

                if (t.forgraps[i].number == ondex)
                {
                    chart1.Series["Population"].Points.AddXY((Math.Floor((i) * 1.0f / 3)).ToString(), t.forgraps[i].population);
                    chart2.Series["Low education"].Points.AddXY((Math.Floor((i) * 1.0f / 3)).ToString(), t.forgraps[i].educ[0]);
                    chart2.Series["Medium education"].Points.AddXY((Math.Floor((i) * 1.0f / 3)).ToString(), t.forgraps[i].educ[1]);
                    chart2.Series["High education"].Points.AddXY((Math.Floor((i) * 1.0f / 3)).ToString(), t.forgraps[i].educ[2]);
                    for (int j = 0; j < name_country.Count; j++)
                    {
                        chart3.Series[name_country[j] + " Culture"].Points.AddXY((Math.Floor((i) * 1.0f / 3)).ToString(), t.forgraps[i].culture[j]);
                    }
                    chart4.Series["0-10"].Points.AddXY((Math.Floor((i)*1.0f / 3)).ToString(), t.forgraps[i].age[0]);
                    chart4.Series["10-20"].Points.AddXY((Math.Floor((i) * 1.0f / 3)).ToString(), t.forgraps[i].age[1]);
                    chart4.Series["20-30"].Points.AddXY((Math.Floor((i) * 1.0f / 3)).ToString(), t.forgraps[i].age[2]);
                    chart4.Series["30-40"].Points.AddXY((Math.Floor((i) * 1.0f / 3)).ToString(), t.forgraps[i].age[3]);
                    chart4.Series["40-50"].Points.AddXY((Math.Floor((i) * 1.0f / 3)).ToString(), t.forgraps[i].age[4]);

                    //chart4.Series["50-60"].Points.AddXY("50-60", for_age[5]);
                    //chart4.Series["60-70"].Points.AddXY("60-70", for_age[6]);
                    //chart4.Series["70-80"].Points.AddXY("70-80", for_age[7]);
                    //chart4.Series["80-90"].Points.AddXY("80-90", for_age[8]);
                    //chart4.Series["90-100"].Points.AddXY("90-100", for_age[9]);
                }
            }  
                
            /*}
            catch
            {
                MessageBox.Show("Error2", "Error", MessageBoxButtons.OK);
            }*/
            /*
            try
            {
                List<string> name_country = new List<string>();
                //int ondex = -1;
                for (int i = 0; i < t.Gomer.Count; i++)
                {
                    name_country.Add(t.Gomer[i].name_country);
                    chart3.Series.Add(t.Gomer[i].name_country + " Culture");
                    chart3.Series[t.Gomer[i].name_country + " Culture"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                }
                /*
                chart3.Series[name_country[0] + " Culture"].Color = System.Drawing.Color.Black;
                chart3.Series[name_country[1] + " Culture"].Color = System.Drawing.Color.Blue;
                chart3.Series[name_country[2] + " Culture"].Color = System.Drawing.Color.Red;*/
            /*
            for (int i = 0; i < t.Gomer.Count; i++)
            {
                MessageBox.Show(t.dym[i].name_country+'\n'+ t.Gomer[i].name_country, "country", MessageBoxButtons.OK);
                if (comboBox1.SelectedItem.ToString() == t.dym[i].name_country)
                {
                    ondex = i;
                }
            }
            if (ondex==-1)
            {
                MessageBox.Show("You don't choose name country", "Error", MessageBoxButtons.OK);
                return;
            }
            *//*
            for(int i=0;i<t.Gomer.Count;i++)
            {
                MessageBox.Show(t.Gomer[i].name_country +'\n'+t.dym[i].name_country, "country", MessageBoxButtons.OK);
            }*//*
            MessageBox.Show(t.dym.Count.ToString(), "length of dym", MessageBoxButtons.OK);
            MessageBox.Show(t.dym[0].population.ToString()+'\n'+ t.dym[0].number.ToString()+'\n'+ t.dym[0].name_country.ToString(), "", MessageBoxButtons.OKCancel);
            MessageBox.Show(t.dym[1].population.ToString() + '\n' + t.dym[1].number.ToString() + '\n' + t.dym[1].name_country.ToString(), "", MessageBoxButtons.OKCancel);
            MessageBox.Show(t.dym[2].population.ToString() + '\n' + t.dym[2].number.ToString() + '\n' + t.dym[2].name_country.ToString(), "", MessageBoxButtons.OKCancel);
            int ind = 0;
            for (int i = 0; i < t.Gomer.Count; i++)
            {
                if (t.Gomer[i].name_country==comboBox1.SelectedItem.ToString())
                {
                    ind = t.Gomer[i].number;
                }
            }
            for (int i = 0; i < Math.Round(t.dym.Count * 1.0f / 3); i++)
            {
                if (comboBox1.SelectedItem.ToString() == t.dym[i].name_country)
                {
                    chart1.Series["Population"].Points.AddXY((i + 1).ToString(), t.dym[ind+i].population);
                    chart2.Series["Low education"].Points.AddXY((i + 1).ToString(), t.dym[ind+i].educ[0]);
                    chart2.Series["Medium education"].Points.AddXY((i + 1).ToString(), t.dym[ind+i].educ[1]);
                    chart2.Series["High education"].Points.AddXY((i + 1).ToString(), t.dym[ind+i].educ[2]);
                    for (int j = 0; j < name_country.Count; j++)
                    {
                        chart3.Series[name_country[j] + " Culture"].Points.AddXY((i + 1).ToString(), t.dym[ind+i].culture[j]);
                    }
                    chart4.Series["0-10"].Points.AddXY("0-10", t.dym[ind+i].age[0]);
                    chart4.Series["10-20"].Points.AddXY("10-20", t.dym[ind + i].age[1]);
                    chart4.Series["20-30"].Points.AddXY("20-30", t.dym[ind + i].age[2]);
                    chart4.Series["30-40"].Points.AddXY("30-40", t.dym[ind + i].age[3]);
                    chart4.Series["40-50"].Points.AddXY("40-50", t.dym[ind + i].age[4]);
                    chart4.Series["50-60"].Points.AddXY("50-60", t.dym[ind + i].age[5]);
                    chart4.Series["60-70"].Points.AddXY("60-70", t.dym[ind + i].age[6]);
                    chart4.Series["70-80"].Points.AddXY("70-80", t.dym[ind + i].age[7]);
                    chart4.Series["80-90"].Points.AddXY("80-90", t.dym[ind + i].age[8]);
                    chart4.Series["90-100"].Points.AddXY("90-100", t.dym[ind + i].age[9]);
                }
            }

        }
        catch
        {
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
        }*/
        }
    }
}
