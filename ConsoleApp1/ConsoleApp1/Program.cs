using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1   
            Console.Write(12);
            Console.Write("  ");
            Console.Write(13);
            Console.Write("  ");
            Console.WriteLine(14);
            //2
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);
            //3
            int santimeters = int.Parse(Console.ReadLine());
            Console.WriteLine(santimeters/100);
            //4
            int SumOfDays = 243;
            Console.WriteLine(SumOfDays / 7);
            //5
            int number = 23;
            Console.WriteLine("amount of tens: ");
            Console.WriteLine(number/10);
            Console.WriteLine("amount of units: ");
            Console.WriteLine(number/1);
            Console.WriteLine("sum of numeral: ");
            Console.WriteLine((number/10)+(number%10));
            Console.WriteLine("sum of mult: ");
            Console.WriteLine((number / 10) * (number % 10));
            //6
            bool A=true, B=false, C=false, D;
            Console.WriteLine(D = A | B);
            Console.WriteLine(D = A & B);
            Console.WriteLine(D = B | C);
            //7
            int circle = int.Parse(Console.ReadLine());
            int square = int.Parse(Console.ReadLine());
            if(Math.PI*Math.Pow(circle, 2)>Math.Pow(square, 2))
            {
                Console.WriteLine("\"S\" of Circle if larger");
            }
            else
            {
                Console.WriteLine("\"S\" of Square if larger");
            }
            //8
            Console.WriteLine("First material V and m is: ");
            int firstV = int.Parse(Console.ReadLine());
            int firstM = int.Parse(Console.ReadLine());
            Console.WriteLine("Second material V and m is: ");
            int secondV = int.Parse(Console.ReadLine());
            int secondM = int.Parse(Console.ReadLine());
            if(firstM/ firstV > secondM / secondV)
            {
                Console.WriteLine("Density of First material is more");
            }
            else
            {
                Console.WriteLine("Density of Second material is more");
            }
            //9
            Console.WriteLine("First electrical chain R and U is: ");
            int firstR = int.Parse(Console.ReadLine());
            int firstU = int.Parse(Console.ReadLine());
            Console.WriteLine("Second electrical chain R and V is: ");
            int secondR = int.Parse(Console.ReadLine());
            int secondU = int.Parse(Console.ReadLine());
            if (firstU / firstR > secondU / secondR)
            {
                Console.WriteLine("Current of Second electrical chain is lower");
            }
            else
            {
                Console.WriteLine("Current of First electrical chain is lower");
            }
            //10
            for(int i =20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }
            int b = int.Parse(Console.ReadLine());
            if (b > 10)
            {
                for(int i = 10; i <= b; i++)
                {
                   Console.WriteLine(Math.Pow(i, 2));
                }
            }
            int a = int.Parse(Console.ReadLine());
            if (a < 50)
            {
                for (int i = a; i < 50; i++)
                {
                    Console.WriteLine(Math.Pow(i, 3));
                }
            }
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (b > a)
            {
                for(int i = a; i <= b; i++)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
