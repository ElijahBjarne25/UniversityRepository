/*
 * Лабораторная работа № 2. 
 * Михайлюк Илья Владимирович, группа ОБ-7351-20.
 */ 

using System;


namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // NUMBER 1. 

            int num1 = -3;

            if (num1 > 0)
            {
                num1 += 1;
            }
            Console.WriteLine("#1  " + num1);

            // NUMBER 2.

            int num2 = 10;

            if (num2 > 0)
            {
                num2 += 1;
            }
            else
            {
                num2 -= 2;
            }
            Console.WriteLine("#2  " + num2);

            // NUMBER 3.

            int num3 = -22;

            if (num3 > 0)
            {
                num3 += 1;
            }
            else if (num3 < 0)
            {
                num3 -= 2;
            }
            else
            {
                num3 = 10;
            }
            Console.WriteLine("#3  " + num3);

            // NUMBER 4.

            int num41, num42, num43;
            int p = 0;
            num41 = 3; num42 = -12; num43 = 22;

            Console.Write("#4  ");

            if (num41 > 0)
            {
                p += 1;
            }
            if (num42 > 0)
            {
                p += 1;
            }
            if (num43 > 0)
            {
                p += 1;
            }
            Console.WriteLine("положительных чисел: " + p);

            // NUMBER 5.

            int num51, num52, num53;
            int p1 = 0, m = 0;
            num51 = -10; num52 = 10; num53 = -300;

            Console.Write("#5  ");

            if (num51 > 0)
            {
                p1 += 1;
            }
            else
            {
                m += 1;
            }
            if (num52 > 0)
            {
                p1 += 1;
            }
            else
            {
                m += 1;
            }
            if (num53 > 0)
            {
                p1 += 1;
            }
            else
            {
                m += 1;
            }
            Console.WriteLine("положительных чисел: " + p1 + ", отрицательных: " + m);

            // NUMBER 6.

            int num61, num62;
            num61 = 10; num62 = 15;

            Console.Write("#6  ");

            if (num61 > num62)
            {
                Console.WriteLine(num61);
            }
            else
            {
                Console.WriteLine(num62);
            }

            // NUMBER 7.

            int num71, num72; // Не понял саму задачу, но пусть порядковый номер num71 = 1, a num72 = 2.
            num71 = 12324; num72 = 1555;

            Console.Write("#7  ");

            if (num71 < num72)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("2");
            }

            // NUMBER 8.

            int num81, num82;
            num81 = 1; num82 = 5;

            Console.Write("#8  ");

            if (num61 > num62)
            {
                Console.WriteLine(num81 + " " + num82);
            }
            else
            {
                Console.WriteLine(num82 + " " + num81);
            }

            // NUMBER 9.

            int a, b; // в а должно быть меньшее, а в b большее.

            Console.Write("#9  ");

            a = 12; b = 1;

            if (a > b)
            {
                Console.WriteLine("a = " + b + ", " + "b = " + a);
            }
            else
            {
                Console.WriteLine("a = " + a + " " + "b = " + b);
            }

            // NUMBER 10.

            Console.Write("#10  ");

            a = 2; b = 3;
            int sum = a + b;

            if (a > b || a < b)
            {
                Console.WriteLine("a = " + sum + ", b = " + sum);
            }
            else
            {
                Console.WriteLine("a = " + 0 + ", b = " + 0);
            }

            // NUMBER 11.

            Console.Write("#11  ");

            a = 19; b = 19;

            if (a > b || a < b)
            {
                if (a > b)
                {
                    Console.WriteLine("a = " + a + ", b = " + a);
                }
                else
                {
                    Console.WriteLine("a = " + b + ", b = " + b);
                }
            }
            else
            {
                Console.WriteLine("a = " + 0 + ", b = " + 0);
            }

            // NUMBER 12.

            Console.Write("#12  ");

            int num121, num122, num123;
            num121 = 10; num122 = 4; num123 = 222;

            if (num121 < num122 && num121 < num123)
            {
                Console.WriteLine(num121);
            }
            else if (num122 < num121 && num122 < num123)
            {
                Console.WriteLine(num122);
            }
            else
            {
                Console.WriteLine(num123);
            }

            // NUMBER 13.

            Console.Write("#13  ");

            int num131, num132, num133;
            num131 = 18; num132 = 19; num133 = 17;

            if ((num131 > num132 && num131 < num133) || (num132 > num131 && num131 > num133))
            {
                Console.WriteLine(num131);
            }
            else if ((num131 > num132 && num132 > num133) || (num133 > num132 && num132 > num131))
            {
                Console.WriteLine(num132);
            }
            else
            {
                Console.WriteLine(num133);
            }

            // NUMBER 14. 

            Console.Write("#14  ");

            int max, min;
            int num141, num142, num143;
            num141 = 12; num142 = 15; num143 = 18;

            // Наибольшее число.
            if (num141 > num142 && num141 > num143)
            {
                max = num141;
            }
            else if (num142 > num141 && num142 > num143)
            {
                max = num142;
            }
            else
            {
                max = num143;
            }

            // Наименьшее число.
            if (num141 < num142 && num141 < num143)
            {
                min = num141;
            }
            else if (num142 < num141 && num142 < num143)
            {
                min = num142;
            }
            else
            {
                min = num143;
            }

            Console.WriteLine(min + " " + max);

            // NUMBER 15.

            Console.Write("#15  ");

            int num151, num152, num153;
            num151 = 2; num152 = 5; num153 = 1;

            if (num151 > num152)
            {
                if (num152 > num153)
                {
                    sum = num151 + num152;
                }
                else
                {
                    sum = num151 + num153;
                }
            }
            else if (num152 > num151)
            {
                if (num151 > num153)
                {
                    sum = num152 + num151;
                } 
                else
                {
                    sum = num152 + num153;
                }
            }
            else if (num153 > num151)
            {
                if (num151 > num152)
                {
                    sum = num153 + num151;
                }
                else
                {
                    sum = num153 + num152;
                }
            }
            Console.WriteLine(sum);

            // NUMBER 16. 

            Console.Write("#16  ");
            
            int c;
            a = 10; b = 9; c = 12;

            if (a < b && b < c)
            {
                a *= 2;
                b *= 2;
                c *= 2;
            }
            else
            {
                a = -a;
                b = -b;
                c = -c;
            }
            Console.WriteLine(a + " " + b + " " + c);

            // NUMBER 17.
            Console.Write("#17  ");

            a = 8; b = 9; c = 10;

            if ((a < b && b < c) || (a > b && b > c))
            {
                a *= 2;
                b *= 2;
                c *= 2;
            }
            else
            {
                a = -a;
                b = -b;
                c = -c;
            }
            Console.WriteLine(a + " " + b + " " + c);

            // NUMBER 18.

            Console.Write("#18  ");

            int first, second, third;
            first = 1; second = 19; third = 19;

            if (first == second)
            {
                Console.WriteLine("3");
            }
            else if (first == third)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("1");
            }

            // NUMBER 19.

            Console.Write("#19  ");

            int fourth;
            first = 19; second = 19; third = 1; fourth = 19;

            if (first == second && second == third)
            {
                Console.WriteLine("4");
            }
            else if (first == second && second == fourth)
            {
                Console.WriteLine("3");
            }
            else if (first == third && third == fourth)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("1");
            }
        }
    }
}
