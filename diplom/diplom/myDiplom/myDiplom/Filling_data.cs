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
            country temp = new country("g", 0.5f, 0.5f, 0.5f, 0.5f, 0.5f, 3, 10);
            try
            {
// MessageBox.Show(t.Gomer.Count.ToString(), "AMT", MessageBoxButtons.OK);
                temp.name_country = textBox36.Text;
                temp.power = Convert.ToDouble(textBox31.Text);
                temp.technology = Convert.ToDouble(textBox32.Text);
                temp.enviroment = Convert.ToDouble(textBox33.Text);
                temp.educ_tech = Convert.ToDouble(textBox34.Text);
                temp.educ_cult = Convert.ToDouble(textBox35.Text);
                temp.population.self[0, 0] = Convert.ToInt32(textBox1.Text);
                temp.population.self[1, 0] = Convert.ToInt32(textBox2.Text);
                temp.population.self[2, 0] = Convert.ToInt32(textBox3.Text);
                temp.population.self[3, 0] = Convert.ToInt32(textBox4.Text);
                temp.population.self[4, 0] = Convert.ToInt32(textBox5.Text);
                temp.population.self[5, 0] = Convert.ToInt32(textBox6.Text);
                temp.population.self[6, 0] = Convert.ToInt32(textBox7.Text);
                temp.population.self[7, 0] = Convert.ToInt32(textBox8.Text);
                temp.population.self[8, 0] = Convert.ToInt32(textBox9.Text);
                temp.population.self[9, 0] = Convert.ToInt32(textBox10.Text);
                temp.population.self[0, 1] = Convert.ToInt32(textBox11.Text);
                temp.population.self[1, 1] = Convert.ToInt32(textBox12.Text);
                temp.population.self[2, 1] = Convert.ToInt32(textBox13.Text);
                temp.population.self[3, 1] = Convert.ToInt32(textBox14.Text);
                temp.population.self[4, 1] = Convert.ToInt32(textBox15.Text);
                temp.population.self[5, 1] = Convert.ToInt32(textBox16.Text);
                temp.population.self[6, 1] = Convert.ToInt32(textBox17.Text);
                temp.population.self[7, 1] = Convert.ToInt32(textBox18.Text);
                temp.population.self[8, 1] = Convert.ToInt32(textBox19.Text);
                temp.population.self[9, 1] = Convert.ToInt32(textBox20.Text);
                temp.population.self[0, 2] = Convert.ToInt32(textBox21.Text);
                temp.population.self[1, 2] = Convert.ToInt32(textBox22.Text);
                temp.population.self[2, 2] = Convert.ToInt32(textBox23.Text);
                temp.population.self[3, 2] = Convert.ToInt32(textBox24.Text);
                temp.population.self[4, 2] = Convert.ToInt32(textBox25.Text);
                temp.population.self[5, 2] = Convert.ToInt32(textBox26.Text);
                temp.population.self[6, 2] = Convert.ToInt32(textBox27.Text);
                temp.population.self[7, 2] = Convert.ToInt32(textBox28.Text);
                temp.population.self[8, 2] = Convert.ToInt32(textBox29.Text);
                temp.population.self[9, 2] = Convert.ToInt32(textBox30.Text);
                t.Gomer.Add(temp);
                MessageBox.Show(t.Gomer.Count.ToString(), "AMT", MessageBoxButtons.OK);
                //MessageBox.Show(t.Gomer[0].power.ToString(), "Example", MessageBoxButtons.OK);
                
                
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
    }
}
