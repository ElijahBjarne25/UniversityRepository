/*
 * Вариант 8. 
 * Михайлюк Илья. Группа ОБ-7351-20.
 */


using System;

namespace ControlWorkIT
{
    class Program
    {
        static void Main(string[] args)
        {
            // НОМЕР 1 / NUMBER 1. // 

            Console.WriteLine("НОМЕР 1: ");

            double y1, x, z, a;
            double num1, num2;

            // Ввод числа x
            Console.WriteLine("Введите число x: ");
            x = double.Parse(Console.ReadLine());

            // Ввод числа z
            Console.WriteLine("Введите число z: ");
            z = double.Parse(Console.ReadLine());

            // Ввод числа a
            Console.WriteLine("Введите число a: ");
            a = double.Parse(Console.ReadLine());

            // Формула и ее расчет 
            num1 = Math.Cos(x);
            num2 = Math.Sqrt(Math.Pow(z, 5) - a);
            y1 = (num1 - num2) / (2 * z);

            // Вывод ответа, т.е. числа y1
            Console.WriteLine("Ответ = " + y1);

            ////////////////////////////////////////////

            // НОМЕР 2 / NUMBER 2 // 

            Console.WriteLine();
            Console.WriteLine("НОМЕР 2: ");

            double a2, b2, i2;
            double ans2;

            // Ввод числа a
            Console.WriteLine("Введите число a: ");
            a2 = double.Parse(Console.ReadLine());

            // Ввод числа b
            Console.WriteLine("Введите число b: ");
            b2 = double.Parse(Console.ReadLine());

            // Ввод числа i
            Console.WriteLine("Введите число i: ");
            i2 = double.Parse(Console.ReadLine());

            if (i2 < 10) //Если i < 10
            {
                ans2 = a2 * Math.Pow(i2, 3) + b2 * i2;
                Console.WriteLine("Ответ = " + ans2);
            }
            else if (i2 > 10) //Если i > 10
            {
                ans2 = Math.Sqrt(a2 * Math.Pow(i2, 2) + b2) / i2 + Math.Abs(b2);
                Console.WriteLine("Ответ = " + ans2);
            }
            else //Если i = 10
            {
                ans2 = (Math.Sqrt(a2) + Math.Sqrt(b2)) * i2;
                Console.WriteLine("Ответ = " + ans2);
            }

            ////////////////////////////////////////////

            // НОМЕР 3 / NUMBER 3 // 

            Console.WriteLine();
            Console.WriteLine("НОМЕР 3: ");

            double y3;
            double x3, c3, a3;

            // Для нумерации ответов  
            a3 = 0;

            // Ввод числа x
            Console.WriteLine("Введите x: ");
            x3 = int.Parse(Console.ReadLine());

            // Ввод числа c
            Console.WriteLine("Введите c: ");
            c3 = int.Parse(Console.ReadLine());

            // Основной цикл программы (3-го задания)
            for (int i = 3; i <= 18; i += 3)
            {
                y3 = (Math.Pow(x3, 4) + Math.Pow(c3, 3)) / (Math.Abs(i + c3));

                Console.Write("Ответ: ");
                Console.WriteLine(++a3 + ": " + y3);
            }

            ////////////////////////////////////////////

            // НОМЕР 4 / NUMBER 4 // 

            Console.WriteLine();
            Console.WriteLine("НОМЕР 4: ");

            int k4, ans4;

            // Ввод числа k
            Console.WriteLine("Введите k: ");
            k4 = int.Parse(Console.ReadLine());

            ans4 = 0;

            // Основной цикл пограммы (4-го номера)
            for (int i = 1; i <= 15; i++)
            {
                ans4 += k4 + 3 * i;
            }
            Console.WriteLine("Ответ = " + ans4);


            // НОМЕР 5. / NUMBER 5. //

            Console.WriteLine();
            Console.WriteLine("НОМЕР 5");

            int even = 0;

            int[] Array1 = new int[] { 10, 2, 30, 4, 15, 26, 1, 8, 9, 1 };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < Array1.Length; i++)
            {
                Console.Write(" " + Array1[i]);
                
            }

            Console.WriteLine();

            int MaxValue = Array1[0];
            for (int i = 1; i < Array1.Length; ++i)
            {
                if ((Array1[i] % 2 == 1) && (MaxValue < Array1[i]))
                {
                    MaxValue = Array1[i];

                }

            }

            for (int i = 0; i < Array1.Length; i++)
            {
                if (Array1[i] % 2 == 0)
                {
                    even++;
                }
            }
            Console.WriteLine("Наибольшее из нечетных чисел: " + MaxValue);
            Console.WriteLine("Количество четных чисел: " + even);


            // НОМЕР 6. / NUMBER 6. //

            Console.WriteLine();
            Console.WriteLine("НОМЕР 6");
            int min = 0;
            const int m = 2, n = 3; 
            int[,] ArrayMat = new int [m, n]
            { 
                { 4, 3, 8 },
                { 2, 7, 1 } 
            };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                    Console.Write(" " + ArrayMat[i, j]);
                Console.WriteLine();
            }
                       
        }
    }
}
