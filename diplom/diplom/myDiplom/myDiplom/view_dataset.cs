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
    public partial class view_dataset : Form
    {
        public view_dataset()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 main = this.Owner as Form1;
                if (main != null)
                {
                    per_capita_income temp = new per_capita_income();
                    try
                    {
                        temp.amt = Convert.ToInt16(textBox3.Text);
                        temp.education = comboBox1.Text;
                        main.temp_pci.Add(temp);
                    }
                    catch
                    {
                        MessageBox.Show("Error", "", MessageBoxButtons.OK);
                        return;
                    }                    
                }
            }
            catch
            {
                MessageBox.Show("Error: form is not main", "", MessageBoxButtons.OK);
            }
        }

        private void view_dataset_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                try
                {
                    main.temp_country.level_of_unemployment = Convert.ToDouble(textBox1.Text);
                    main.temp_country.median_income_capital=main.temp_pci;
                    main.temp_country.name_country = textBox4.Text;
                    main.temp_country.amt_people = Convert.ToInt32(textBox2.Text);
                    main.Gomer.Add(main.temp_country);
                    main.temp_country.print();

                }
                catch
                {
                    MessageBox.Show("Input correct data", "Error", MessageBoxButtons.OK);
                }

            }
        }
    }
}
