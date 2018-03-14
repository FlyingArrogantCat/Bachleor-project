using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace myDiplom
{
    public partial class add_new_country : Form
    {
        public add_new_country()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =| DataDirectory |\Database.mdf; Integrated Security = True");
                cn.Open();
                string sql = "CREATE TABLE [Database].[" + textBox1.Text + "] ([age] INT NOT NULL, [gender] VARCHAR(50) NOT NULL,[education] VARCHAR(50) NOT NULL,[culture_tradition] FLOAT NOT NULL, [culture_susceptibility] FLOAT NOT NULL, [wish_immigration] INT NOT NULL, [amount] BIGINT NOT NULL )";
                /*SqlCommand command = new SqlCommand(sql);
                sql = "select * from "+ textBox1.Text;
                SqlCommand command1 = new SqlCommand(sql);
                SqlDataReader read = command1.ExecuteReader();*/
                MessageBox.Show("New country has added successed!", "", MessageBoxButtons.OK);
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Creating new country has failed", "Error", MessageBoxButtons.OK);
            }
            /*country s =new country(textBox1.Text);
            Form1 f = new Form1();
            //MessageBox.Show("!!!", "!!!", MessageBoxButtons.OK);
            f.nation.Add(s);*/     
                
            Close();
        }

    }
}
