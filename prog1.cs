using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1212
{
    class Program
    {
        static void Main(string[] args)
        {

            // ============================ DEMO
            // comment
            /*
             * multi line comment
             */


            int a;
            a = 10;
            float f = 5.5f;
            string name = "Itay";
            Console.Write("stay in same line...");
            Console.WriteLine("down line");

            Console.Write("Please enter your name: ");
            string yourName = Console.ReadLine();

            Console.Write("Your name is: ");
            Console.WriteLine(yourName);


            // ====================== TARGIL 1
            Console.Write("Please enter first number: ");
            string xAsString = Console.ReadLine();
            // int is actually Int32
            int x;
            x = Convert.ToInt32(xAsString);

            Console.Write("Please enter second number: ");
            string yAsString = Console.ReadLine();
            // int is actually Int32
            int y;
            y = Convert.ToInt32(yAsString);

            if (x % y == 0)
            {
                // if true -- do this:
                Console.WriteLine("Mithalek lelo sheerit");
            }
            else
            {
                // if false -- do this:
                Console.WriteLine("Mithalek IM sheerit");
            }


            // ====================== TARGIL 2
            //Console.WriteLine(9/2.0);

            Console.Write("Please enter first number: ");
            string x1AsString = Console.ReadLine();
            // int is actually Int32
            int x1;
            x1 = Convert.ToInt32(x1AsString);

            Console.Write("Please enter second number: ");
            string y1AsString = Console.ReadLine();
            // int is actually Int32
            int y1;
            y1 = Convert.ToInt32(y1AsString);

            int sum = x1 + y1;
            Console.Write("Sum = ");
            Console.WriteLine(sum);

            double avg = sum / 2.0;
            Console.Write("AVERAGE =");
            Console.WriteLine(avg);

            // ====================== TARGIL 3
            int sum3 = 0;
            int x3 = 0;

            Console.Write("Please enter number: ");
            string x3AsString = Console.ReadLine();
            x3 = Convert.ToInt32(x3AsString);

            while (x3 >= 0)
            {
                sum3 = sum3 + x3;
                Console.Write("Please enter number: ");
                x3AsString = Console.ReadLine();
                x3 = Convert.ToInt32(x3AsString);
            }
            Console.Write("Sum is ... ");
            Console.WriteLine(sum3);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
