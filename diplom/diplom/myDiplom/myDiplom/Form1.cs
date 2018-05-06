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
        public static int Amount_of_country = 3;
        public static int max_life_age = 100;
        public static int amt_educ = 5;
        public matrix tens = new matrix(amt_educ, max_life_age);
        public country temp_country = new country();
        public List<country> Gomer = new List<country>(Amount_of_country);
        public matrix graph = new matrix(3, 3);
        public matrix input = new matrix(10, 3);
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
        public void Arrival_immigrant(country count,matrix temp)
        {
            matrix temptemp = new matrix(count.population.size_first, count.population.size_second);
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k <10; k++)
                    {
                        temptemp.self[i, j] +=count.ch_age.self[i,k]*count.population.self[k,j];
                    }
                }
                if (i==0)
                {
                    temptemp.self[i, 0] = temptemp.self[i, 0] + temptemp.self[i, 1] + temptemp.self[i, 2];
                    temptemp.self[i, 1] = 0.0f;
                    temptemp.self[i, 2] = 0.0f;
                }
            }

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    count.population.self[i, j] =  temptemp.self[i, j];
                }
            }
            /*
            count.population.self[0, 0] = count.population.self[0, 0] + count.population.self[0, 1] + count.population.self[0, 2];
            count.population.self[0, 1] = 0.0f;
            count.population.self[0, 2] = 0.0f;
            */
            for (int i=0;i<count.population.size_first;i++)
                for (int j = 0; j < count.population.size_second; j++)
                {
                    count.population.self[i,j] += Math.Round(temp.self[i,j]);
                }
        }
        public void Change_education(country temp)
        {
            matrix temptemp = new matrix(temp.population.size_first, temp.population.size_second);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        //temp.population.self[i, j] = temp.ch_educ.self[i, k]*temp.population.self[k,j];
                        temptemp.self[i, j] += temp.ch_educ.self[j, k] * temp.population.self[i, k];
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp.population.self[i,j] = Math.Round(temptemp.self[i,j]);
                }
            }
        }
        public void Graph_calc(List<country> Gomer,matrix graph)
        {
            for(int i=0;i<Gomer.Count;i++)
            {
                for(int j=0;j<Gomer.Count;j++)
                {
                    double[] veci = {Gomer[i].power,Gomer[i].technology,Gomer[i].enviroment,Gomer[i].educ_tech,Gomer[i].educ_cult};
                    double[] vecj = { Gomer[j].power, Gomer[j].technology, Gomer[j].enviroment, Gomer[j].educ_tech, Gomer[j].educ_cult };
                    graph.self[i, j] = (indicator_func(Gomer[i].educ_cult,Gomer[j].educ_cult)+ indicator_func(Gomer[i].educ_tech, Gomer[j].educ_tech)+ indicator_func(Gomer[i].enviroment, Gomer[j].enviroment)+ indicator_func(Gomer[i].power, Gomer[j].power)+ indicator_func(Gomer[i].technology, Gomer[j].technology))*normal(veci,vecj)*0.2f/ (indicator_func(Gomer[i].educ_cult, Gomer[j].educ_cult) + indicator_func(Gomer[i].educ_tech, Gomer[j].educ_tech) + indicator_func(Gomer[i].enviroment, Gomer[j].enviroment) + indicator_func(Gomer[i].power, Gomer[j].power) + indicator_func(Gomer[i].technology, Gomer[j].technology+1.0f));
                    if (graph.self[i, j] > 0)
                    {
                        //MessageBox.Show(graph.self[i, j].ToString(), "Graph calc", MessageBoxButtons.OK);
                    }
                    else graph.self[i, j] = 0.0f;
                }
            }
        }
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
        public Form1()
        {
            InitializeComponent();
        }

        private void createNewDistributionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            Form2 newForm = new Form2();
            newForm.Show();*/
        }

        private void addNewCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            add_new_country f = new add_new_country();
            f.Show();
            */
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*show_data f = new show_data();
            f.Show();*/
            /*add_country f = new add_country();
            f.Owner = this;
            f.ShowDialog();*/
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
            /*Here I must create reading data from database to GOmer*/
        }

        private void lastCommentFromMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "We can make cryptographic randomizer for our program using from 'System.Security.Cryptography' class 'RNGCryptoServiceProvider' ", "Comment", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graph_calc(Gomer, graph);
            defeintion_coeff_matrix(Gomer);
            List<matrix> temp = new List<matrix>();
           
            for (int l=0;l<Gomer.Count;l++)
            {
                input = new matrix(10, 3);
                for (int k=0;k<Gomer.Count;k++)
                {
                    if (k == l) continue;
                    for(int i=0;i<10;i++)
                    {
                        for(int j=0;j<3;j++)
                        {
                            
                            input.self[i, j] = Math.Round(graph.self[l, k] * Gomer[l].population.self[i, j] * coeff(i, j));
                            if (input.self[i, j] > Gomer[l].population.self[i, j])
                            {
                                input.self[i, j] = Gomer[l].population.self[i, j];
                                Gomer[l].population.self[i, j] = 0;
                            }
                            else Gomer[l].population.self[i, j] = Gomer[l].population.self[i, j]- input.self[i, j];
                        }
                    }
                }
                temp.Add(input);
            }
            for(int l=0;l<Gomer.Count;l++)
            {
                Arrival_immigrant(Gomer[l],temp[l]);
            }
            MessageBox.Show(Gomer[0].population.self[0, 0].ToString() + "\t" + Gomer[0].population.self[0, 1].ToString() + "\t" + Gomer[0].population.self[0, 2].ToString() + "\n" + Gomer[0].population.self[1, 0].ToString() + "\t" + Gomer[0].population.self[1, 1].ToString() + "\t" + Gomer[0].population.self[1, 2].ToString() + "\n" + Gomer[0].population.self[2, 0].ToString() + "\t" + Gomer[0].population.self[2, 1].ToString() + "\t" + Gomer[0].population.self[2, 2].ToString() + "\n" + Gomer[0].population.self[3, 0].ToString() + "\t" + Gomer[0].population.self[3, 1].ToString() + "\t" + Gomer[0].population.self[3, 2].ToString() + "\n" + Gomer[0].population.self[4, 0].ToString() + "\t" + Gomer[0].population.self[4, 1].ToString() + "\t" + Gomer[0].population.self[4, 2].ToString() + "\n" + Gomer[0].population.self[5, 0].ToString() + "\t" + Gomer[0].population.self[5, 1].ToString() + "\t" + Gomer[0].population.self[5, 2].ToString(), "Result " + Gomer[0].name_country, MessageBoxButtons.OK);
            MessageBox.Show(Gomer[1].population.self[0, 0].ToString() + "\t" + Gomer[1].population.self[0, 1].ToString() + "\t" + Gomer[1].population.self[0, 2].ToString() + "\n" + Gomer[1].population.self[1, 0].ToString() + "\t" + Gomer[1].population.self[1, 1].ToString() + "\t" + Gomer[1].population.self[1, 2].ToString() + "\n" + Gomer[1].population.self[2, 0].ToString() + "\t" + Gomer[1].population.self[2, 1].ToString() + "\t" + Gomer[1].population.self[2, 2].ToString() + "\n" + Gomer[1].population.self[3, 0].ToString() + "\t" + Gomer[1].population.self[3, 1].ToString() + "\t" + Gomer[1].population.self[3, 2].ToString() + "\n" + Gomer[1].population.self[4, 0].ToString() + "\t" + Gomer[1].population.self[4, 1].ToString() + "\t" + Gomer[1].population.self[4, 2].ToString() + "\n" + Gomer[1].population.self[5, 0].ToString() + "\t" + Gomer[1].population.self[5, 1].ToString() + "\t" + Gomer[1].population.self[5, 2].ToString(), "Result " + Gomer[1].name_country, MessageBoxButtons.OK);
            MessageBox.Show(Gomer[2].population.self[0, 0].ToString() + "\t" + Gomer[2].population.self[0, 1].ToString() + "\t" + Gomer[2].population.self[0, 2].ToString() + "\n" + Gomer[2].population.self[1, 0].ToString() + "\t" + Gomer[2].population.self[1, 1].ToString() + "\t" + Gomer[2].population.self[1, 2].ToString() + "\n" + Gomer[2].population.self[2, 0].ToString() + "\t" + Gomer[2].population.self[2, 1].ToString() + "\t" + Gomer[2].population.self[2, 2].ToString() + "\n" + Gomer[2].population.self[3, 0].ToString() + "\t" + Gomer[2].population.self[3, 1].ToString() + "\t" + Gomer[2].population.self[3, 2].ToString() + "\n" + Gomer[2].population.self[4, 0].ToString() + "\t" + Gomer[2].population.self[4, 1].ToString() + "\t" + Gomer[2].population.self[4, 2].ToString() + "\n" + Gomer[2].population.self[5, 0].ToString() + "\t" + Gomer[2].population.self[5, 1].ToString() + "\t" + Gomer[2].population.self[5, 2].ToString(), "Result " + Gomer[2].name_country, MessageBoxButtons.OK);

            /*List<distribution> county = new List<distribution>();*/
            /*
            try
            {
                DialogResult rt=MessageBox.Show("Are you sure that you want run analysis?", "Attention", MessageBoxButtons.YesNo);
                if (rt == DialogResult.Yes)
                {
                    try
                    {
                        string sql = "select * from country";
                        //distribution temp = new distribution();
                        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fyodo\Desktop\diplom-master\diplom\myDiplom\myDiplom\bin\Debug\DATABASE.MDF;Integrated Security=True");
                        //C:\USERS\FYODO\DESKTOP\DIPLOM-MASTER\DIPLOM\MYDIPLOM\MYDIPLOM\DATABASE.MDF
                        //C:\Users\FLoginov\Source\Repos\diplom\diplom\myDiplom\myDiplom\Database.mdf
                        conn.Open();
                        
                        SqlCommand command = new SqlCommand(sql, conn);
                        SqlDataReader reader = command.ExecuteReader();
                        
                        //List<string> data = new List<string>();
                        
                        while (reader.Read())
                        {
                            MessageBox.Show(reader.GetString(0)+" "+reader.GetString(1) ,"data", MessageBoxButtons.OK);
                            //data.Add(reader[0].ToString());
                        }
                        //MessageBox.Show(data[1], "", MessageBoxButtons.OK);
                        
                        reader.Close();
                        conn.Close();
                        Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error", caption: "You have a problem with database connection", buttons: MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("You're right!", "Congratulations", MessageBoxButtons.OK);
                }
            }
            catch
            {

            }
    */
        }
    }
}
