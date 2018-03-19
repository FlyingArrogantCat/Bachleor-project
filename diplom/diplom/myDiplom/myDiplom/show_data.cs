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
    public partial class show_data : Form
    {
        public show_data()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void countryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.russiaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.databaseDataSet);
                databaseDataSet.AcceptChanges();
            }

            catch
            {
                MessageBox.Show("Update failed");
            }
        }

        private void show_data_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Russia". При необходимости она может быть перемещена или удалена.
            this.russiaTableAdapter.Fill(this.databaseDataSet.Russia);

        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select country from Russia";
                //MessageBox.Show(text: "It has be done", caption: "Accept!", buttons: MessageBoxButtons.OK);
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FLoginov\Source\Repos\diplom\diplom\myDiplom\myDiplom\Database.mdf;Integrated Security=True");
                //C:\USERS\FYODO\DESKTOP\DIPLOM-MASTER\DIPLOM\MYDIPLOM\MYDIPLOM\DATABASE.MDF
                //C:\Users\FLoginov\Source\Repos\diplom\diplom\myDiplom\myDiplom\Database.mdf
                conn.Open();
                //MessageBox.Show(sql, "", MessageBoxButtons.OK);
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                List<string> data = new List<string>();
                while (reader.Read())
                {
                    data.Add(reader[0].ToString());
                }
                MessageBox.Show(data[1], "", MessageBoxButtons.OK);
                reader.Close();
                conn.Close();
                Close();
            }
            catch
            {
                MessageBox.Show("Error", caption: "You have a problem with database connection", buttons: MessageBoxButtons.OK);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //russiaTableAdapter.Update(databaseDataSet);

            
        }

        private void generalDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
