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
        public string age { get; set; }
        public string gender { get; set; }
        public string education { get; set; }
        public double culture_tradition { get; set; }
        public double culture_susceptibility { get; set; }
        public int wish_migration { get; set; }
        public int amount { get; set; }

        public distribution()
        {
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

            MessageBox.Show("Amount = " + Convert.ToString(this.amount) + "\n", "Distribution", MessageBoxButtons.OK);
        }
    }

    public class human
    {
        public int age { get; set; }
        public string education { get; set; }
        public double nation_worth { get; set; }
        public double world_worth { get; set; }

        public human()
        {
            this.age = 0;
            this.education = "none";
            this.nation_worth = 0.0f;
            this.world_worth = 0.0f;
        }
        public void print()
        {
            MessageBox.Show("Age=" + age.ToString() + "\n" + "Education" + education + "\n" + "Level of national worth=" + nation_worth.ToString() + "\n" + "Level of world worth" + world_worth.ToString(), "HUMAN", MessageBoxButtons.OK);
        }
        public void growing_up()
        {
            this.age = this.age + 1;
        }
        public void education_level_up()
        {
            if (this.education == "none")
            {
                this.education = "low";
            }
            else if (this.education == "low")
            {
                this.education = "medium";
            }
            else if (this.education == "medium")
            {
                this.education = "high";
            }
        }
        public void change_national_worth(double x)
        {
            this.nation_worth = this.nation_worth + x;
        }
        public void change_world_worth(double x)
        {
            this.world_worth = this.world_worth + x;
        }
    }
    public class country
    {
        public string name_country;
        public int amt_people;
        public List<human> people = new List<human>();
        public double level_of_unemployment;
        public List<per_capita_income> median_income_capital=new List<per_capita_income>();
        /*Далее можно добавить информационое воздействие, или по крайней мере переменную отвечающую за пропаганду*/
        public country(double level)
        {
            this.level_of_unemployment = level;
        }
        public country()
        {
            this.level_of_unemployment = 0.0f;
            this.name_country = "";
            this.amt_people =0;
        }
        public void print()
        {
            MessageBox.Show("AMT="+this.amt_people.ToString()+"\n"+"lvl_unemp="+this.level_of_unemployment.ToString()+"\n",this.name_country,MessageBoxButtons.OK);
        }
    }
    public class per_capita_income
    {
        public double amt;
        public string education;

        public per_capita_income()
        {
            this.amt = 0.0f;
            this.education = "none";
        }
    }
    /*
    public class country_set
    {
        public int amount_of_country;
        public List<string> name_country = new List<string>();
        public country_set(int n)
        {
            this.amount_of_country = n;
        }
        public country_set()
        {
            this.amount_of_country = 0;
        }
    }
    */
}