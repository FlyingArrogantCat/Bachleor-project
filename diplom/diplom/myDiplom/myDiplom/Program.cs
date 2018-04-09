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
 
    public class tensor
    { /*возраст от 1 до 100
        число культур= числу стран
         */
        public readonly List<double[,]> matrix;
        public int size_list;
        public int size_double_first;
        public int size_double_second;
        public tensor(int education, int age, int culture)
        {
            matrix = new List<double[,]>(education);
            try
            {
                double[,] temp = new double[age, culture];
                for (int i = 0; i < age; i++)
                    for (int j = 0; j < culture; j++)
                    {
                        temp[i, j] = 0.0f;
                    }
                for (int i = 0; i < education; i++)
                {
                    matrix.Add(temp);
                }
                size_list = education;
                size_double_first = age;
                size_double_second = culture;
            }
            catch
            {
                MessageBox.Show("Mistery error! I think, it is fate(British humor detected).", "Error", MessageBoxButtons.OK);
            }
        }
        public List<double> education_distribution()
        {
            List<double> temp = new List<double>();

            for (int i = 0; i < size_list; i++)
            {
                double x = 0.0f;
                for (int j = 0; j < size_double_first; j++)
                {
                    for (int k = 0; k < size_double_second; k++)
                    {
                        x = x + matrix[i][j, k];
                    }
                }
                temp.Add(x);
            }
            return temp;
        }
        public List<double> age_distribution()
        {
            List<double> temp = new List<double>();
            for (int j = 0; j < size_double_first; j++)

            {
                double x = 0.0f;
                for (int i = 0; i < size_list; i++)
                {
                    for (int k = 0; k < size_double_second; k++)
                    {
                        x = x + matrix[i][j, k];
                    }
                }
                temp.Add(x);
            }
            return temp;
        }
        public List<double> culture_distribution()
        {
            List<double> temp = new List<double>();
            for (int k = 0; k < size_double_second; k++)
            {
                double x = 0.0f;
                for (int i = 0; i < size_list; i++)
                {
                    for (int j = 0; j < size_double_first; j++)
                    {
                        x = x + matrix[i][j, k];
                    }
                }
                temp.Add(x);
            }
            return temp;
        }
        public double population()
        {
            double z = 0.0f;
            for (int k = 0; k < size_double_second; k++)
            {
                for (int i = 0; i < size_list; i++)
                {
                    for (int j = 0; j < size_double_first; j++)
                    {
                        z = z + matrix[i][j, k];
                    }
                }
            }
            return z;
        }

    }
    public class country
    {
        public string name_country;
        public double power;
        public double technology;
        public double enviroment;
        public double educ_cult;
        public double educ_tech;
        public readonly tensor population;
        //public List<per_capita_income> median_income_capital=new List<per_capita_income>();

        public country()
        {
            this.enviroment = 0.0f;
            this.name_country = "";
            this.power = 0.0f;
            this.technology = 0.0f;
            this.educ_cult = 0.0f;
            this.educ_tech = 0.0f;
        }
        public country(string name,double power,double tech,double env, double ed_c,double ed_t,int amt_cult,int amt_ed,int amt_age)
        {
            this.enviroment = env;
            this.name_country = name;
            this.power = power;
            this.technology = tech;
            this.educ_cult = ed_c;
            this.educ_tech = ed_t;
            this.population = new tensor(amt_ed, amt_age, amt_cult);
        }
    }
    public class matrix
    {
        public readonly double[,] self;
        public int size_first;
        public int size_second;
        public matrix()
        {
            size_first = 0;
            size_second = 0;
            self = new double[size_first,size_second];
        }
        public matrix(int first,int second)
        {
            size_first = first;
            size_second = second;
            self = new double[size_first, size_second];
        }
    }
}