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

        private void russiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.russiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void show_data_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Russia". При необходимости она может быть перемещена или удалена.
            this.russiaTableAdapter.Fill(this.databaseDataSet.Russia);

        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "select country from Russia";
            //MessageBox.Show(text: "It has be done", caption: "Accept!", buttons: MessageBoxButtons.OK);
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\FLoginov\Source\Repos\diplom\diplom\myDiplom\myDiplom\Database.mdf;Integrated Security=True");
            conn.Open();
            //MessageBox.Show(sql, "", MessageBoxButtons.OK);
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            List<string> data = new List<string>();
            while(reader.Read())
            {
                data.Add(reader[0].ToString());
            }
            MessageBox.Show(data[2], "", MessageBoxButtons.OK);
            reader.Close();
            conn.Close();
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //russiaTableAdapter.Update(databaseDataSet);
        }
    }
}
