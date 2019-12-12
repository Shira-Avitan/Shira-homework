using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSA
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter number");
             //int a = int.Parse(Console.ReadLine());
             string Assint = Console.ReadLine();
             int a = Convert.ToInt32(Assint);
             Console.WriteLine("Enter number");
             //int b = int.Parse(Console.ReadLine());
             string second = Console.ReadLine();
             int b = Convert.ToInt32(second);

             if (a % b == 0)
             {
                 Console.WriteLine("divides");
             }
             else
             {
                 Console.WriteLine("does not divides");
             }


             Console.WriteLine("pleae enter number");
             string num1 = Console.ReadLine();
             int x = Convert.ToInt32(num1);
             Console.WriteLine("pleae enter second number");
             string num2 = Console.ReadLine();
             int y = Convert.ToInt32(num2);
             int sum = x + y;
             Console.Write("sum =");
             Console.WriteLine(sum);

             double avg = sum / 2.0;
             Console.Write("average = ");
             Console.WriteLine(avg);
             

            int sum3 = 0;
            int num3 = 0;

            Console.WriteLine("enter number");
            string num3Asstring = Console.ReadLine();
            num3 = Convert.ToInt32(num3Asstring);

            while ( num3 >= 0)
            {
                sum3 = sum3 + num3;
                Console.WriteLine("enter number");
                num3Asstring = Console.ReadLine();
                num3 = Convert.ToInt32(num3Asstring);
            }
            Console.Write("sum = ");
            Console.WriteLine(sum3);
            

            int secret = 0;
            int guess = 0;
            int i = 1;

            Console.WriteLine("enter a secret number");
            string s = Console.ReadLine();
            secret = Convert.ToInt32(s);

            Console.WriteLine("guess a number");
            string g = Console.ReadLine();
            guess = Convert.ToInt32(g);

            while (secret != guess)
            {
                i++;

                if (guess > secret)
                {
                    Console.WriteLine("too big");

                    Console.WriteLine("guess another number");
                    g = Console.ReadLine();
                    guess = Convert.ToInt32(g);
                }
                else
                {
                    Console.WriteLine("too small");

                    Console.WriteLine("guess another number");
                    g = Console.ReadLine();
                    guess = Convert.ToInt32(g);
                }
            }
            Console.WriteLine("bingo");
            Console.Write("number of tries-");
            Console.WriteLine(i);
        }
    }
}





