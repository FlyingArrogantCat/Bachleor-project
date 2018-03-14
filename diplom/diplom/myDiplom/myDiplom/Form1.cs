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
        List<distribution> nation = new List<distribution>();
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
            show_data f = new show_data();
            f.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<distribution> county = new List<distribution>();
            try
            {
                DialogResult rt=MessageBox.Show("Are you sure that you want run analysis?", "Attention", MessageBoxButtons.YesNo);
                if (rt == DialogResult.Yes)
                {
                    try
                    {
                        string sql = "select * from Russia";
                        distribution temp = new distribution();
                        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fyodo\Desktop\diplom-master\diplom\myDiplom\myDiplom\bin\Debug\DATABASE.MDF;Integrated Security=True");
                        //C:\USERS\FYODO\DESKTOP\DIPLOM-MASTER\DIPLOM\MYDIPLOM\MYDIPLOM\DATABASE.MDF
                        //C:\Users\FLoginov\Source\Repos\diplom\diplom\myDiplom\myDiplom\Database.mdf
                        conn.Open();
                        
                        SqlCommand command = new SqlCommand(sql, conn);
                        SqlDataReader reader = command.ExecuteReader();
                        
                        //List<string> data = new List<string>();
                        
                        while (reader.Read())
                        {
                            MessageBox.Show(reader.GetString(0)+" "+reader.GetString(1) /*+ " " + reader.GetString(2) + " " + reader.GetString(3) +" " + reader.GetString(4) + " " + reader.GetString(5) + " " + reader.GetString(6) + " " + reader.GetString(7)*/,"data", MessageBoxButtons.OK);
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
        }
    }
}
