// Лабораторная работа №3.
// Случайно сделал другие номера.
// не уверен в правильности всех математический действий.

using System;
using System.Security.Principal;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
         {
            // NUMBER 1.

            Console.WriteLine("#1");
            
            int b = 5;
            double y;

            for (int x = -10; x <= 10; x += 2)
            {
                y = (Math.Pow(x, 2) + b);
                Console.WriteLine(y);
            }

            // NUMBER 2. 

            Console.WriteLine("#2 ");

            int k = 5; // k первых членнов ар-кой прогрессии.
            int num1 = 0;
            for (int i = 0; i < k; i++)
            {
                num1 += 2;
                Console.WriteLine(num1);
            }

            // NUMBER 3.

            Console.Write("#3 ");

            int mult = 1;

            //Console.Write("Введите первый член прогрессии a1: ");
            //int a1 = int.Parse(Console.ReadLine());

            //Console.Write("Введите шаг прогрессии h: ");
            //int h = int.Parse(Console.ReadLine());

            //Console.Write("Введите кол-во перемножаемых членов m: ");
            //int m = int.Parse(Console.ReadLine());

            int a1 = 12, h = 3, m = 4;

            for (int i = 1; m > i; i++)
            {
                mult = mult * a1;
                a1 = a1 + h;
            }
            Console.WriteLine(mult);

            // NUMBER 4.

            Console.Write("#4 ");

            double an = 0, n = 0;

            for (int i = 1; i <= 20; i++)
            {
                an = n / (n + 1);
                n++;
            }
            Console.WriteLine(an);

            // NUMBER 5.

            Console.Write("#5 ");

            int n1 = 1;
            
            for (int i = 1; i <= 7; i++)
            {
                n1 *= i;   
            }
            Console.WriteLine(n1);

            // NUMBER 8.

            Console.Write("#8 ");

            int x1 = 3;
            double n2 = 0;

            for (int i = 1; i <= 5; i++)
            {
                n2 = (Math.Sin(x1) + Math.Sin(Math.Sin(x1))) * i;
            }
            Console.WriteLine(n2);

            // NUMBER 9.

            Console.Write("#9 ");

            int commonDiv1 = 92, commonDiv2 = 70;

            while (commonDiv1 > 0 && commonDiv2 > 0)
            {
                if (commonDiv1 > commonDiv2)
                {
                    commonDiv1 %= commonDiv2;
                }
                else
                {
                    commonDiv2 %= commonDiv1;
                }
                
            }
            Console.WriteLine(commonDiv1 + commonDiv2);

            // NUMBER 10.

            Console.Write("#10 ");

            double p = 1;

            for (int i = 2; i < 5; i++)
            {
                p = 1 - 1 / Math.Pow(i, 2) * p;
            }
            Console.WriteLine(p);

            // NUMBER 11.

            Console.Write("#11 ");
            
            double Y = 1;

            for (int i = 1; i <= 10; i++)
            {
                Y = Math.Cos(i + Math.Cos(1 + i));
            }

            Console.WriteLine(Y);

            // NUMBER 12.

            Console.Write("#12 ");

            uint k1 = 6;
            int xn = 0;

            for (int i = 1; i <= k1; i++)
            {
                xn = i * (i - 1) + 1 / i; 
            }
            Console.WriteLine(xn);

            // NUMBER 13.

            Console.Write("#13 ");

            int num3 = 251414;
            //Console.WriteLine("Введите число: ");
            //int num3 = int.Parse(Console.ReadLine());

            int k2 = 0; // Кол-во цифр в числе

            while (num3 != 0)
            {
                num3 /= 10;
                k2++;
            }
            Console.WriteLine(k2);

            // NUMBER 16.

            Console.Write("#16 "); // Работает только для не четных чисел.

            int chislo = 7;
            int Y2 = 1;
            int n4 = (chislo + 1) / 2;

            for (int i = 1; i <= n4; i++) 
            {
                Y2 *= (2 * i - 1);
            }
            Console.WriteLine(Y2);

            // NUMBER 18.
            Console.Write("#10 ");

            int y1 = 1;
            int y2 = 0;

            for (int i = 1; i <= 3; i++)
            {
                y1 *= i;
                y2 += y1; 
            }
            Console.WriteLine(y2);
        }
    }
}
