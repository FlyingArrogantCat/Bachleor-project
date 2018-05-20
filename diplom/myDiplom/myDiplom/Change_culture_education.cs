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
    public partial class Change_culture_education : Form
    {
        public Change_culture_education()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 t = this.Owner as Form1;
            int index = 0;
            for (int i = 0; i < t.Gomer.Count; i++)
            {
                if (t.Gomer[i].name_country == this.comboBox1.SelectedItem.ToString())
                {
                    index = i;
                }
            }
            try
            {
                t.Gomer[index].culture.education[0] = Convert.ToDouble(this.textBox1.Text);
                t.Gomer[index].culture.education[1] = Convert.ToDouble(this.textBox2.Text);
                t.Gomer[index].culture.education[2] = Convert.ToDouble(this.textBox3.Text);
            }
            catch
            {
                MessageBox.Show("You have tried to input incorrect data","Error",MessageBoxButtons.OK);
            }
        }

        private void Change_culture_education_Load(object sender, EventArgs e)
        {
            Form1 t = this.Owner as Form1;
            for (int i = 0; i < t.Gomer.Count; i++)
            {
                this.comboBox1.Items.Add(t.Gomer[i].name_country);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
