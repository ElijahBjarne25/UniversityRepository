using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace UnivLab2
{
    class Program
    {
        static void Main(string[] args)
        {

            //--------------------------------------//
            // Number 1.                            //
            //--------------------------------------//

            int num1;

            //num1 = Console.ReadLine();
            num1 = 30;

            Console.Write("№1 = ");

            if (num1 > 0)
            {
                Console.WriteLine(++num1);
            }
            else
            {
                Console.WriteLine(num1);
            }

            //--------------------------------------//
            // Number 2.                            //
            //--------------------------------------//

            int num2;

            //num2 = Console.ReadLine();
            num2 = -20;

            Console.Write("№2 = ");

            if (num2 > 0)
            {
                Console.WriteLine(++num2);
            }
            else
            {
                Console.WriteLine(num2 -= 2);
            }

            //--------------------------------------//
            // Number 3.                            //
            //--------------------------------------//

            int num3;

            //num3 = Console.Readline();
            num3 = 5;

            Console.Write("№3 = ");

            if (num3 > 0)
            {
                Console.WriteLine(++num3);
            }
            else if (num3 < 0)
            {
                Console.WriteLine(num3 -= 2);
            }
            else
            {
                Console.WriteLine(num3 = 10);
            }

            //--------------------------------------//
            // Number 4.                            //
            //--------------------------------------//

            int num41, num42, num43;

            /* num41 = Console.ReadLine();
             * num42 = Console.ReadLine();
             * num43 = Console.ReadLine();
             */

            num41 = -3; num42 = 8; num43 = 0; // 0 не является отрицательным или положительным числом

            Console.Write("№4 = ");
            
            if (num41 > 0 && num42 > 0 && num43 > 0)
            {
                Console.WriteLine("3");
            }
            else if ((num41 > 0 && num42 > 0) || (num41 > 0 && num43 > 0) || (num42 > 0 && num43 > 0))
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("1");
            }

            //---------------------------------------//
            // Number 5.                             //
            //---------------------------------------//

            // Даны три целых числа. Найти количество положительных и количество
            // отрицательных чисел в исходном наборе.

            int num51, num52, num53;
            int p = 0, m = 0, i; 

            /* num51 = Console.ReadLine();
             * num52 = Console.ReadLine();
             * num53 = Console.ReadLine();
             */

            num51 = -3; num52 = 4; num53 = 2;

            Console.Write("№5 = ");

            
                
        }
    }
}
