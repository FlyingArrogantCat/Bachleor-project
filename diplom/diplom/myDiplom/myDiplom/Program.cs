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
    /*
    public class tensor
    { возраст от 1 до 100
        число культур= числу стран
         
        public readonly double[,] matrix;
        public int size_second_educ;
        public int size_first_age;
        //public int size_double_second_cult;
        public tensor(int education, int age)
        {
            matrix = new double[size_first_age, size_second_educ];
            try
            {
                double[,] temp = new double[age, culture];
                for (int i = 0; i < age; i++)
                    for (int j = 0; j < education; j++)
                    {
                        temp[i, j] = 0.0f;
                    }
                for (int i = 0; i < education; i++)
                {
                    matrix.Add(temp);
                }
                size_list_educ = education;
                size_double_first_age = age;
                size_double_second_cult = culture;
            }
            catch
            {
                MessageBox.Show("Mistery error! I think, it is fate(British humor detected).", "Error", MessageBoxButtons.OK);
            }
        }

        public List<double> education_distribution()
        {
            List<double> temp = new List<double>();

            for (int i = 0; i < size_list_educ; i++)
            {
                double x = 0.0f;
                for (int j = 0; j < size_double_first_age; j++)
                {
                    for (int k = 0; k < size_double_second_cult; k++)
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
            for (int j = 0; j < size_double_first_age; j++)

            {
                double x = 0.0f;
                for (int i = 0; i < size_list_educ; i++)
                {
                    for (int k = 0; k < size_double_second_cult; k++)
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
            for (int k = 0; k < size_double_second_cult; k++)
            {
                double x = 0.0f;
                for (int i = 0; i < size_list_educ; i++)
                {
                    for (int j = 0; j < size_double_first_age; j++)
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
            for (int k = 0; k < size_double_second_cult; k++)
            {
                for (int i = 0; i < size_list_educ; i++)
                {
                    for (int j = 0; j < size_double_first_age; j++)
                    {
                        z = z + matrix[i][j, k];
                    }
                }
            }
            return z;
        }


    }
    */
    public class culture_distr
    {
        public int size_amt_people;
        public int size_amt_cult;
        public readonly List<double[]> distrib;
        public culture_distr(int a,int b)
        {
            size_amt_people = a;
            size_amt_cult = b;
            distrib = new List<double[]>();
        }
        public int size_people()
        {
            return size_amt_people;
        }
        public int size_culture()
        {
            return size_amt_cult;
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
        public culture_distr culture;
        public matrix population=new matrix(10,3);
        public matrix ch_age = new matrix(10,10);
        public matrix ch_educ = new matrix(3,3);
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
        public country(string name,double power,double tech,double env, double ed_c,double ed_t,/*int amt_cult,*/int amt_ed,int amt_age)
        {
            this.enviroment = env;
            this.name_country = name;
            this.power = power;
            this.technology = tech;
            this.educ_cult = ed_c;
            this.educ_tech = ed_t;
            //this.culture.size_amt_cult = amt_cult;
            this.population = new matrix( amt_age, amt_ed);
        }
        /*
        public void filling_culture()
        {
            int t=0;
            for (int i = 0; i < population.size_first; i++)
                for (int j = 0; j < population.size_second; j++)
                    t += Convert.ToInt16(population.self[i, j]);
            culture.distrib = new matrix(t, culture.size_amt_cult);
        }
        */
    }
    public class matrix
    {
        public readonly double[,] self;
        public int size_first;
        public int size_second;
        /*public matrix()
        {
            size_first = 0;
            size_second = 0;
            self = new double[size_first,size_second];
        }*/
        public matrix(int first_size,int second_size)
        {
            size_first = first_size;
            size_second = second_size;
            self = new double[size_first, size_second];
            for (int i = 0; i < size_first; i++)
                for (int j = 0; j < size_second; j++)
                {
                    self[i, j] = 0.0f;
                }
        }
        /*
        public matrix(double number,int size)
        {
            size_first = size;
            size_second = size;
            self = new double[size_first, size_second];
            for(int i=0;i< size_first; i++)
                for(int j=0;j< size_second; j++)
                {
                    self[i, j] = Convert.ToDouble(number);
                }
        }
        */
    }
    
}