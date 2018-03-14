using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace myDiplom
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static double Function_help_for_age(int x) => -0.25f * x + 1.25f;

        public static double Function_age(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            if (x == 1)
            {
                return 1;
            }
            if (x == 2 || x == 3 || x == 4 || x == 5)
            {
                return Function_help_for_age(x);
            }
            /*Here have to make form of error*/
            return 0;
        }


        public static double Function_education(int x) => x * 1.0f / 2;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            if (textBox1.Text == "") return;
            if (textBox2.Text == "") return;
            if (textBox3.Text == "") return;
            if (textBox4.Text=="")
            {
                MessageBox.Show("Please, Input name country", "Ooops", MessageBoxButtons.OK);
                return;
            }
            distribution temp = new distribution();
            try
            {
                temp.culture_tradition = double.Parse(textBox2.Text);
                temp.culture_susceptibility = double.Parse(textBox3.Text);
                temp.amount = int.Parse(textBox1.Text);
                temp.age = comboBox2.SelectedItem.ToString();
                temp.gender = comboBox1.SelectedItem.ToString();
                temp.education = comboBox3.SelectedItem.ToString();
                temp.wish_migration = int.Parse(comboBox6.SelectedItem.ToString());
                //MessageBox.Show(text: "It has be done", caption: "Accept!", buttons: MessageBoxButtons.OK);
                temp.print();
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FLoginov\Source\Repos\diplom\diplom\myDiplom\myDiplom\Database.mdf;Integrated Security=True");
                conn.Open();
                string sql = "insert into Russia values("+temp.gender+","+temp.education+","+temp.culture_tradition.ToString()+","+temp.culture_susceptibility.ToString()+","+temp.wish_migration.ToString()+","+temp.amount.ToString()+","+temp.age+")";
                MessageBox.Show(sql, "",MessageBoxButtons.OK);
                SqlCommand command = new SqlCommand(sql,conn);
                conn.Close();
                Close();

            }
            catch
            {
                MessageBox.Show(text: "Sorry, you've written unacceptable value into some textbox. Please, try again", caption: "Error!", buttons: MessageBoxButtons.OK);
                //MessageBox.Show("I did it again...", caption: "Oops", buttons: MessageBoxButtons.OK);
            }            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
