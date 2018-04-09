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
    public partial class add_country : Form
    {
        public add_country()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            try
            {
                Form1 main = this.Owner as Form1;
                if (main != null)
                {
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
            }*/
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
                    main.temp_country.name_country =textBox1.Text.ToLower();
                    main.temp_country.power=Convert.ToDouble(textBox2.Text);
                    main.temp_country.enviroment = Convert.ToDouble(textBox3.Text);
                    main.temp_country.technology = Convert.ToDouble(textBox4.Text);
                    main.temp_country.educ_cult = Convert.ToDouble(textBox5.Text);
                    main.temp_country.educ_tech = Convert.ToDouble(textBox6.Text);
                    for (int i=0;i<main.Gomer.Count;i++)
                    {
                        if(main.Gomer[i].name_country.ToLower()!=textBox1.Text.ToLower())
                        {
                            continue;
                        }
                        else
                        {
                            MessageBox.Show("This name country already exists. Choose other name.","Error",MessageBoxButtons.OK);
                            return;
                        }
                    }
                    main.Gomer.Add(main.temp_country);
                    DialogResult temp = MessageBox.Show("Do you want to add one more country?","",MessageBoxButtons.YesNo);
                    if (temp==DialogResult.Yes)
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                    }
                    else
                    {
                        Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Input correct data", "Error", MessageBoxButtons.OK);
                }

            }
        }
    }
}
