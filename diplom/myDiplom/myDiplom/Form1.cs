using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Data.SqlClient;

namespace myDiplom
{
    //public static List<string> mass_of_country; /*= new List<string>() { "Russia", "Finland" }*/
    public partial class Form1 : Form
    {
        //public static int Amount_of_country = 3;
        public static int max_life_age = 100;
        public static int amt_educ = 3;
        public matrix tens = new matrix(amt_educ, max_life_age);
        public country temp_country = new country();
        public List<country> Gomer = new List<country>();
        public matrix graph = new matrix(3, 3);
        public matrix3d input = new matrix3d(100, 3,1);
        //public matrix output = new matrix(10, 3);
        public void computing_matrix_change(List<country> Gomer)
        {
            for(int i=0;i<Gomer.Count;i++)
            {
                //Gomer[i].ch_age.self ={ };
            }
        }
    
        public int indicator_func(double a,double b)
        {
            int k = 0; 
            if (a>b)
            {
                k = 1;
                return k;
            }
            else
            {
                k = 0;
                return k;
            }
        }
        public double coeff(int a,int b)
        {
            return 1.0f*((-1)*(a*a-10*a+16)*indicator_func(a,2)*indicator_func(8,a)/(5*1.8f))*(b*1.0f/3);
        }
        public double normal(double[] x,double[] y)
        {
            double temp = 0.0f;
            for(int i=0;i<x.Length;i++)
            {
                temp += (x[i] - y[i]) * (x[i] - y[i]);
            }
            temp += Math.Sqrt(temp);
            return temp;
        }

        /// Arrival migrant process
        /// 
        public void Arrival_immigrant(country count,matrix3d temp)
        {
            matrix3d temptemp = new matrix3d(count.pop.size_first, count.pop.size_second,count.pop.size_third);

            for (int i = 0; i < count.pop.size_third; i++)
            {
                for (int j = 0; j < count.pop.size_second; j++)
                {
                    for (int k = 0; k < count.pop.size_first; k++)
                    {
                        for (int l = 0; l < count.pop.size_first; l++)
                        {
                            temptemp.self[k, j, i] += count.ch_age.self[k, l] * count.pop.self[l, j, i];
                        }
                    }
                }
            }
            for (int i = 0; i < count.pop.size_third; i++)
            {
                temptemp.self[0, 0,i] = temptemp.self[0, 0, i] + temptemp.self[0, 1, i] + temptemp.self[0, 2, i];
                temptemp.self[0, 1,i] = 0.0f;
                temptemp.self[0, 2,i] = 0.0f;
            }
                
          
            for(int k=0;k<temptemp.size_third;k++)
            for (int j = 0; j < temptemp.size_second; j++)
            {
                for (int i = 0; i < temptemp.size_first; i++)
                {
                    count.pop.self[i, j,k] =  temptemp.self[i, j,k];
                }
            }


            for (int i = 0; i < count.pop.size_first; i++)
                for (int j = 0; j < count.pop.size_second; j++)
                    for (int k = 0; k < count.pop.size_third; k++)
                    {

                        count.pop.self[i, j,k] += temp.self[i, j,k];
                    }
        }

        /// Education process
        /// 
        public void Change_education(country temp)
        {
            matrix3d temptemp = new matrix3d(temp.pop.size_first, temp.pop.size_second, temp.pop.size_third);

            for (int i = 0; i < temp.pop.size_first; i++)
            {
                for (int k = 0; k < temp.pop.size_third; k++)
                {
                    for (int j = 0; j < temp.pop.size_second; j++)
                    { 
                        for (int l = 0; l < temp.pop.size_second; l++)
                        {
                            temptemp.self[i, j, k] += temp.ch_educ.self[l, j] * temp.pop.self[i,l,k];
                        }
                    }
                }
            }
            for (int i = 0; i < temp.pop.size_first; i++)
            {
                for (int j = 0; j < temp.pop.size_second; j++)
                {
                    for (int k = 0; k < temp.pop.size_third; k++)
                    {
                        temp.pop.self[i, j,k] = temptemp.self[i, j,k];
                    }
                }
            }
        }
        
        ///  Assimilation process
        
        public void Assimilation_process(country temp)
        {
            for(int i=0;i<temp.pop.size_first;i++)
                for(int j=0;j<temp.pop.size_second;j++)
                    for(int k=0;k<temp.pop.size_third;k++)
                        for(int l=0;l<temp.pop.size_third;l++)
                        {

                        }
        }


        /// graph matrix coefficient defenition 

        public void Graph_calc(List<country> Gomer,matrix graph)
        {
            for(int i=0;i<Gomer.Count;i++)
            {
                for(int j=0;j<Gomer.Count;j++)
                {
                    double[] veci = {Gomer[i].power,Gomer[i].technology,Gomer[i].enviroment,Gomer[i].educ_tech/*,Gomer[i].educ_cult*/};
                    double[] vecj = { Gomer[j].power, Gomer[j].technology, Gomer[j].enviroment, Gomer[j].educ_tech/*, Gomer[j].educ_cult */};
                    graph.self[i, j] = (/*indicator_func(Gomer[i].educ_cult,Gomer[j].educ_cult)+*/ indicator_func(Gomer[i].educ_tech, Gomer[j].educ_tech)+ indicator_func(Gomer[i].enviroment, Gomer[j].enviroment)+ indicator_func(Gomer[i].power, Gomer[j].power)+ indicator_func(Gomer[i].technology, Gomer[j].technology))*normal(veci,vecj)*0.2f/ (/*indicator_func(Gomer[i].educ_cult, Gomer[j].educ_cult) + */indicator_func(Gomer[i].educ_tech, Gomer[j].educ_tech) + indicator_func(Gomer[i].enviroment, Gomer[j].enviroment) + indicator_func(Gomer[i].power, Gomer[j].power) + indicator_func(Gomer[i].technology, Gomer[j].technology+1.0f));
                    if (graph.self[i, j] > 0)
                    {
                        //MessageBox.Show(graph.self[i, j].ToString(), "Graph calc", MessageBoxButtons.OK);
                    }
                    else graph.self[i, j] = 0.0f;
                }
            }
        }

        /// oter matrix coefficient defenition 
        public void defeintion_coeff_matrix(List<country> Gomer)
        {
            for(int i=0;i<Gomer.Count;i++)
            {
                for(int j=0;j<Gomer[i].ch_age.size_first;j++)
                {
                    for(int k = 0; k < Gomer[i].ch_age.size_second; k++)
                    {
                        if (j-1 == k)
                            Gomer[i].ch_age.self[j, k] = 0.95f;
                        if (j == 0)
                            Gomer[i].ch_age.self[j, k] = 0.3f*(-k*k+9*k-8)*indicator_func(k*1.0f,1.0f)*indicator_func(8.0f,k*1.0f)/12;
                        
                    }
                }
            }
            for (int i = 0; i < Gomer.Count; i++)
            {
                for (int j = 0; j < Gomer[i].ch_educ.size_first; j++)
                {
                    for (int k = 0; k < Gomer[i].ch_educ.size_second; k++)
                    {
                        if(j==k)
                            Gomer[i].ch_educ.self[j, k] = 0.8f;
                        if(j-1==k)
                            Gomer[i].ch_educ.self[j, k] = 0.2f;
                        Gomer[i].ch_educ.self[Gomer[i].ch_educ.size_first - 1, Gomer[i].ch_educ.size_second - 1] = 1.0f;
                    }
                }
            }
        }

 
        /// WTF?

        public Form1()
        {
            InitializeComponent();
        }

        private void createNewDistributionToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void addNewCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// Add data

        private void showDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filling_data f = new Filling_data();
            f.Owner = this;
            f.ShowDialog();
        }

        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loginov Fyodor 471b group MIPT", "Info",MessageBoxButtons.OK);
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Diplom project","Info",MessageBoxButtons.OK);
        }

        private void mainIdeaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void lastCommentFromMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "We can make cryptographic randomizer for our program using from 'System.Security.Cryptography' class 'RNGCryptoServiceProvider' ", "Comment", MessageBoxButtons.OK);
        }

        /// Main process
        /// 
        private void button1_Click(object sender, EventArgs e)
        {
            Graph_calc(Gomer, graph);
            defeintion_coeff_matrix(Gomer);
            List<matrix3d> temp = new List<matrix3d>();
           
            for (int l=0;l<Gomer.Count;l++)
            {
                input = new matrix3d(100, 3,Gomer.Count);
                for (int k=0;k<Gomer.Count;k++)
                {
                    if (k == l) continue;
                    for(int i=0;i<Gomer[l].pop.size_first;i++)
                    {
                        for(int j=0;j< Gomer[l].pop.size_second; j++)
                        {
                            for (int m = 0; m < Gomer[l].pop.size_third; m++)
                            {

                                input.self[i, j,m] = graph.self[l, k] * Gomer[l].pop.self[i, j,m] * coeff(i, j);
                                if (input.self[i, j, m] > Gomer[l].pop.self[i, j,m])
                                {
                                    input.self[i, j, m] = Gomer[l].pop.self[i, j,m];
                                    Gomer[l].pop.self[i, j,m] = 0;
                                }
                                else Gomer[l].pop.self[i, j,m] = Gomer[l].pop.self[i, j,m] - input.self[i, j,m];
                            }
                        }
                    }
                }
                temp.Add(input);
            }
            for(int l=0;l<Gomer.Count;l++)
            {
                Arrival_immigrant(Gomer[l],temp[l]);
            }

          
            
        }
    }
}
