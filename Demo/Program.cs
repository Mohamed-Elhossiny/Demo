using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declear Variables.

            //string Name = "mohamed said elhossiny";
            //int Age;
            //double deg;
            //bool st;
            //DateTime date;

            // Set Data

            //Name = Console.ReadLine();
            //Age =Convert.ToInt16( Console.ReadLine());
            //deg =Convert.ToDouble( Console.ReadLine());
            //st =Convert.ToBoolean( Console.ReadLine());
            //date =Convert.ToDateTime(Console.ReadLine());


            //var n1 = DateTime;
            //Console.WriteLine(Name);
            //Console.WriteLine(Age);
            //Console.WriteLine(deg);
            //Console.WriteLine(st);
            //Console.WriteLine(date);

            //Logical >,<,==,!=,>=,<==,  or>> || , and>> &&

            // For Loop

            // While

            // Array 

            //int[] nu = new int[5] {10,5,6,2,3};

            int[] nu = new int[5];
            nu[0] = 10;
            nu[1] = 20;
            nu[2] = 30;
            nu[3] = 20;
            nu[4] = 30;

            for (int i = 0; i < nu.Length; i++)
            {
                Console.WriteLine(nu[i]);
            }

            // ArrayList

            List<string> name = new List<string>();

            // name.Add("mohamed");
            //name.Add("ahmed");
            

            Console.WriteLine(name[1]);

            int number = 5;
            bool isEven = number % 2  == 0;
            Console.WriteLine(isEven);

            




             
            Console.ReadLine();
        }
    }
}
