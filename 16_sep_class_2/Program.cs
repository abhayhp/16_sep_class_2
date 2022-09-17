using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_sep_class_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manager m1 = new Manager("A", 45000, 2000,800);
            //m1.CalculateSalary();
            //Console.WriteLine(m1);

            //Empl e1 = new Empl("E", 40000, 1000);
            //e1.CalculateSalary();
            //Console.WriteLine(e1);

            //Empl e2 = new Manager("M2", 45000, 2000, 800);
            //e2.CalculateSalary();
            //Console.WriteLine(e2);

            SalesManager sm1 = new SalesManager("sm1", 46000, 400, 300, 400);
            sm1.CalculateSalary();
            Console.WriteLine(sm1);


        }
    }
}
