/*
 * 18.12.2020 1:05 AM 
 * Лабораторная работа номер 5.
 * Михайлюк Илья.
 * группа ОБ-7351-20.
 * Номера: 1-4, 19, 20.
 */


using System;
using System.Text;

namespace Laboratory5
{
    class Program
    {
        static void Main(string[] args)
        {

            //NUMBER 1.
            Console.WriteLine("NUMBER 1");
            int n1;

            Console.Write("Enter even length of the string: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            string[] num1Array = new string[n1];

            for (int i = n1/2; num1Array.Length > i; i++)
            {
                Console.Write("C1 ");
                Console.Write("C2 ");

            }
            Console.WriteLine("\n");

            //NUMBER 2.
            Console.WriteLine("NUMBER 2.");

            string num2Str = "LiveNotOnEvil";
            Console.WriteLine(num2Str);

            for (int i = num2Str.Length - 1; i >= 0; i--)
            {
                Console.Write(num2Str[i]);
            }
            Console.WriteLine("\n");

            //NUMBER 3. 
            Console.WriteLine("NUMBER 3.");

            string num3S = "HelloWorld";
            int num3N = 15;

            Console.Write("Word: " + num3S);
            Console.WriteLine(" (" + num3S.Length + ")");
            Console.WriteLine("Number: " + num3N);

            if (num3S.Length > num3N)
            {
                for (int i = num3N; i < num3S.Length;  i++)
                {
                    Console.Write(num3S[i]);
                }
                Console.WriteLine();
            }
            else
            {
                int a = 0;
                int b = num3N - num3S.Length;
                while (b > a)
                {
                    a++;
                    Console.Write(".");
                }
                Console.WriteLine(num3S);              
            }
            Console.WriteLine();

            //NUMBER 4.
            Console.WriteLine("NUMBER 4.");

            int num4N1, num4N2;
            string num4S1, num4S2;

            num4N1 = 7;
            num4N2 = 5;

            num4S1 = "TheMoonIsGorgeous";
            num4S2 = "AllWeNeedIsLight";

            int a1 = num4S2.Length - num4N2;

            Console.WriteLine("First sentence: " + num4S1);
            Console.WriteLine("Second sentence: " + num4S2);
            Console.Write("First + Second = ");

            for (int i = 0; i < num4N1; i++)
            {
                Console.Write(num4S1[i]);              
            }
            for (int j = a1; j < num4S2.Length; j++)
            {
                Console.Write(num4S2[j]);
            }
            Console.WriteLine("\n");

            //NUMBER 19.
            Console.WriteLine("NUMBER 19.");

            Console.WriteLine("I DO NOT NOW HOW TO SOLVE IT"); // РЕШИТЬ!!!!!!! 

            Console.WriteLine();

            //NUMBER 20.
            Console.WriteLine("NUMBER 20.");

            StringBuilder num20S = new StringBuilder("* * ? % № !");
            Console.WriteLine("Original: " + num20S);

            for (int i = 0; i < num20S.Length; i++)
            {
                num20S.Replace(" ", "$");
                Console.Write(num20S[i]);
            }
            Console.WriteLine();
            
        }       
    }
}
