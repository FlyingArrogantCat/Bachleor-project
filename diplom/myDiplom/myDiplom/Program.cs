using myDiplom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myDiplom
{
    //List<string> mass_of_country = new List<string>() { "Russia", "Finland" };
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
// public List<string> mass_of_country = new List<string>() { "Russia", "Finland" };
        }
        //public List<string> mass_of_country = new List<string>() { "Russia", "Finland" };
    }
    class distribution
    {
        public string country;
        public string age;
        public string gender;
        public string education;
        public double culture_tradition;
        public double culture_susceptibility;
        public int wish_migration;
        public int amount;

        public distribution()
        {
            this.country = "name";
            this.age = "0-18";
            this.gender = "none";
            this.education = "none";
            this.culture_susceptibility = 0.0f;
            this.culture_tradition = 0.0f;
            this.wish_migration = 0;
            this.amount = 0;
        }
        public void print()
        {
        
            MessageBox.Show( "Amount = "+Convert.ToString(this.amount)+"\n", "Distribution", MessageBoxButtons.OK);
        }

    }


    /*Idea - keep all data how distribution in vector of class <distribution>*/
    /*
    public class country
    {
        List<distribution> list = new List<distribution>();
        public string name_country;

        public country(string name)
        {
            name_country = name;
        }
    }
    */
}
