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
    public partial class Filling_data : Form
    {
        public Filling_data()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 t = this.Owner as Form1;
            country temp = new country("g", 0.5f, 0.5f, 0.5f, 0.5f, 0.5f,t.Gomer.Count+1);
            try
            {
                MessageBox.Show(t.Gomer.Count.ToString(), "AMT", MessageBoxButtons.OK);
                temp.number = t.Gomer.Count;
                temp.name_country = textBox36.Text;
                temp.power = Convert.ToDouble(textBox31.Text);
                temp.technology = Convert.ToDouble(textBox32.Text);
                temp.enviroment = Convert.ToDouble(textBox33.Text);
                temp.educ_tech = Convert.ToDouble(textBox34.Text);
               // temp.educ_cult = Convert.ToDouble(textBox35.Text);
                for (int i = 0; i < 10; i++)
                {
                    temp.pop.self[0 + i, 0, temp.pop.size_third - 1] = Convert.ToInt32(textBox1.Text)/10;
                    temp.pop.self[0 + i, 1, temp.pop.size_third - 1] = Convert.ToInt32(textBox11.Text)/10;
                    temp.pop.self[0 + i, 2, temp.pop.size_third - 1] = Convert.ToInt32(textBox21.Text)/10;
                }
                for (int i = 0; i < 10; i++)
                {
                    temp.pop.self[10 + i, 0, temp.pop.size_third - 1] = Convert.ToInt32(textBox2.Text) / 10;
                    temp.pop.self[10 + i, 1, temp.pop.size_third - 1] = Convert.ToInt32(textBox12.Text) / 10;
                    temp.pop.self[10 + i, 2, temp.pop.size_third - 1] = Convert.ToInt32(textBox22.Text) / 10;
                }
                for (int i = 0; i < 10; i++)
                {
                    temp.pop.self[20 + i, 0, temp.pop.size_third - 1] = Convert.ToInt32(textBox3.Text) / 10;
                    temp.pop.self[20 + i, 1, temp.pop.size_third - 1] = Convert.ToInt32(textBox13.Text) / 10;
                    temp.pop.self[20 + i, 2, temp.pop.size_third - 1] = Convert.ToInt32(textBox23.Text) / 10;
                }
                for (int i = 0; i < 10; i++)
                {
                    temp.pop.self[30 + i, 0, temp.pop.size_third - 1] = Convert.ToInt32(textBox4.Text) / 10;
                    temp.pop.self[30 + i, 1, temp.pop.size_third - 1] = Convert.ToInt32(textBox14.Text) / 10;
                    temp.pop.self[30 + i, 2, temp.pop.size_third - 1] = Convert.ToInt32(textBox24.Text) / 10;
                }
                for (int i = 0; i < 10; i++)
                {
                    temp.pop.self[40 + i, 0, temp.pop.size_third - 1] = Convert.ToInt32(textBox5.Text) / 10;
                    temp.pop.self[40 + i, 1, temp.pop.size_third - 1] = Convert.ToInt32(textBox15.Text) / 10;
                    temp.pop.self[40 + i, 2, temp.pop.size_third - 1] = Convert.ToInt32(textBox25.Text) / 10;
                }
                for (int i = 0; i < 10; i++)
                {
                    temp.pop.self[50 + i, 0, temp.pop.size_third - 1] = Convert.ToInt32(textBox6.Text) / 10;
                    temp.pop.self[50 + i, 1, temp.pop.size_third - 1] = Convert.ToInt32(textBox16.Text) / 10;
                    temp.pop.self[50 + i, 2, temp.pop.size_third - 1] = Convert.ToInt32(textBox26.Text) / 10;
                }


                for (int i = 0; i < 10; i++)
                {
                    temp.pop.self[60 + i, 0, temp.pop.size_third - 1] = Convert.ToInt32(textBox7.Text) / 10;
                    temp.pop.self[60 + i, 1, temp.pop.size_third - 1] = Convert.ToInt32(textBox17.Text) / 10;
                    temp.pop.self[60 + i, 2, temp.pop.size_third - 1] = Convert.ToInt32(textBox27.Text) / 10;
                }


                for (int i = 0; i < 10; i++)
                {
                    temp.pop.self[70 + i, 0, temp.pop.size_third - 1] = Convert.ToInt32(textBox8.Text) / 10;
                    temp.pop.self[70 + i, 1, temp.pop.size_third - 1] = Convert.ToInt32(textBox18.Text) / 10;
                    temp.pop.self[70 + i, 2, temp.pop.size_third - 1] = Convert.ToInt32(textBox28.Text) / 10;
                }

                for (int i = 0; i < 10; i++)
                {
                    temp.pop.self[80 + i, 0, temp.pop.size_third - 1] = Convert.ToInt32(textBox9.Text) / 10;
                    temp.pop.self[80 + i, 1, temp.pop.size_third - 1] = Convert.ToInt32(textBox19.Text) / 10;
                    temp.pop.self[80 + i, 2, temp.pop.size_third - 1] = Convert.ToInt32(textBox29.Text) / 10;
                }

                for (int i = 0; i < 10; i++)
                {
                    temp.pop.self[90 + i, 0, temp.pop.size_third - 1] = Convert.ToInt32(textBox10.Text) / 10;
                    temp.pop.self[90 + i, 1, temp.pop.size_third - 1] = Convert.ToInt32(textBox20.Text) / 10;
                    temp.pop.self[90 + i, 2, temp.pop.size_third - 1] = Convert.ToInt32(textBox30.Text) / 10;
                }

                t.Gomer.Add(temp);
                
                for(int i=0;i<t.Gomer.Count;i++)
                {
                    t.Gomer[i].pop=t.Gomer[i].pop.transform(t.Gomer.Count);
                }
                MessageBox.Show("Country have added sucsessful!", "Ave Maria", MessageBoxButtons.OK);
                


            }
            catch
            {
                MessageBox.Show("Inputing data is wrong: in population box numbers must be integer type", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form for filling data", "Information", MessageBoxButtons.OK);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void howManyCountiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 t = this.Owner as Form1;
            MessageBox.Show("Amount of counties = "+t.Gomer.Count.ToString(), "", MessageBoxButtons.OK);
        }

        private void Filling_data_Load(object sender, EventArgs e)
        {

        }
    }
}
