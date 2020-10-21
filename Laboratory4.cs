using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratory4
{
    class Program
    {
        static void Main(string[] args) //1-5, 8, 9, 11, 12.
        {
            // NUM 1 //

            //Составить программу нахождения суммы (количества) положительных
            //(отрицательных)элементов массива.


            Console.WriteLine("Number 1: ");

            int[] array1 = { 10, 2, -4, 5, -1, 7 };
            int positiveSum = 0;
            int negativeSum = 0;
            int positiveCount = 0;
            int negativeCount = 0;

            Console.WriteLine("Array: ");
            // Array
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(" " + array1[i]);
            }
            Console.WriteLine("\n");

            // Count of positive and negative numbers
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > 0)
                {
                    positiveCount++;
                }
                else
                {
                    negativeCount++;
                }
            }

            // Sum of positive and negative numbers
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > 0)
                {
                    positiveSum += array1[i];
                }
                else
                {
                    negativeSum += array1[i];
                }
            }

            // Answers
            Console.WriteLine("Sum of positive: " + positiveSum);
            Console.WriteLine("Sum of negative: " + negativeSum + "\n");

            Console.WriteLine("Count of positive: " + positiveCount);
            Console.WriteLine("Count of negative: " + negativeCount);



            //NUM 2.

            //Составить программу нахождения суммы (количества) элементов массива стоящих на
            //четных(нечетных) местах.

            Console.WriteLine("\nNumber 2: ");

            int[] array2 = { 0, 4, 12, 333, 5, 2, 6 };

            int evenSum = 0;
            int evenCount = 0;
            int oddSum = 0;
            int oddCount = 0;


            Console.WriteLine("Array: ");
            // Array
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(" " + array2[i]);
            }
            Console.WriteLine("\n");

            // even count
            for (int i = 1; i < array2.Length; i += 2)
            {
                evenCount++;
            }

            // odd index count
            for (int i = 0; i < array2.Length; i += 2)
            {
                oddCount++;
            }

            // even sum
            for (int i = 1; i < array2.Length; i += 2)
            {
                evenSum += array2[i];
            }

            //odd sum
            for (int i = 0; i < array2.Length; i += 2)
            {
                oddSum += array2[i];
            }

            // Answers
            Console.WriteLine("Even count: " + evenCount);
            Console.WriteLine("Odd count: " + oddCount + "\n");

            Console.WriteLine("Even sum: " + evenSum);
            Console.WriteLine("Odd sum: " + oddSum);

            //NUM 3.

            // Составить программу нахождения произведения отрицательных (положительных)
            // элементов массива.
            Console.WriteLine("\nNumber 3:");

            int[] array3 = { -2, 3, -5, 8, 2, -3, 5 };

            int positiveMult = 1;
            int negativeMult = 1;

            Console.WriteLine("Array: ");
            // Array
            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write(" " + array3[i]);
            }
            Console.WriteLine();

            // positive numbers multiplication and negative multiplication
            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i] > 0)
                {
                    positiveMult *= array3[i];
                }
                else
                {
                    negativeMult *= array3[i];
                }
            }
            Console.WriteLine("\nPositive numbers multiplication: " + positiveMult);
            Console.WriteLine("Negative numbers multiplication: " + negativeMult);


            // NUM 4                                                                                             
            Console.WriteLine("\nNumber4:");                                                                                            
                                                                                                      
            int[] array4 = { -2, 0, 3, 4, 5, 0, -5, 10, -4, 0 };
            int positiveCountArray4 = 0;
            int negativeCountArray4 = 0;
            int multipleOfK = 0;
            int k;
            int zeroCount = 0;

            //Console.WriteLine("Enter k: ");
            //k = int.Parse(Console.ReadLine());
            k = 4;

            // Array
            for (int i = 0; i < array4.Length; i++)
            {
                Console.Write(" " + array4[i]);
            }
            Console.WriteLine();

            // Positive and negative count
            for (int i = 0; i < array4.Length; i++)
            {
                if (array4[i] > 0)
                {
                    positiveCountArray4++;
                }
                else
                {
                    negativeCountArray4++;
                }
            }

            // Multiple K count
            for (int i = 0; i < array4.Length; i++)
            {
                if (array4[i] % k == 0)
                {
                    multipleOfK++;
                }
            }

            // Zero count
            for (int i = 0; i < array4.Length; i++)
            {
                if (array4[i] == 0)
                    zeroCount++;
            }



            Console.WriteLine("\nCount of positive numbers: " + positiveCountArray4);
            Console.WriteLine("Count of negative numbers: " + negativeCountArray4);
            Console.WriteLine("Multiples of k: " + multipleOfK);
            Console.WriteLine("Count of zero: " + zeroCount);


            //NUM 5 

            Console.WriteLine("\nNumber 5:");

            //Составить программу нахождения суммы четных (нечетных, кратных n) элементов
            //массива.

            int[] array5 = { 10, 4, 1231, 23, 45, 44, 2 };
            int n = 2;

            int evenSumArray5 = 0;
            int oddSumArray5 = 0;
            int multipleN = 0;

            Console.WriteLine("Array:");
            // Array
            for (int i = 0; i < array5.Length; i++)
            {
                Console.Write(" " + array5[i]);
            }

            // even sum and odd sum; 
            for (int i = 0; i < array5.Length; i++)
            {
                if (array5[i] % 2 == 0)
                {
                    evenSumArray5 += array5[i];
                }
                else
                {
                    oddSumArray5 += array5[i];
                }
            }

            // Multiples N
            for (int i = 0; i < array5.Length; i++)
            {
                if (array5[i] % n == 0)
                {
                    multipleN += array5[i];
                }
            }

            Console.WriteLine("\nSum of even: " + evenSumArray5);
            Console.WriteLine("Sum of odd: " + oddSumArray5);
            Console.WriteLine("Sum of multiples n: " + multipleN);


            // NUM 8 

            Console.WriteLine("\nNumber 8:");

            //Составить программу нахождения максимального среди отрицательных
            //(минимального среди положительных элементов массива).

            int[] array8 = { 10, -2, 12, -3, 4, -199, 122 };

            int minPositive = array8[0];
            int maxNegative = array8[0];
            int maxArray8 = 0;


            Console.WriteLine("Array:");
            // Array 
            for (int i = 0; i < array8.Length; i++)
            {
                Console.Write(" " + array8[i]);
            }
            Console.WriteLine();

            // Max negative
            for (int i = 0; i < array8.Length; i++)
            {
                if (array8[i] < 0)
                {
                    if (array8[i] < maxNegative)
                    {
                        maxNegative = array8[i];
                    }
                }
            }

            // Min positive
            for (int i = 0; i < array8.Length; i++)
            {
                if (array8[i] > 0)
                {
                    if (array8[i] < minPositive)
                    {
                        minPositive = array8[i];
                    }
                }
            }


            //Answers
            Console.WriteLine("Max negative number: " + maxNegative);
            Console.WriteLine("Min positive number: " + minPositive);


            //NUM 9

            Console.WriteLine("\nNumber 9:");

            //Составить программу нахождения двух самых больших (самых маленьких) элементов
            //массива.

            int[] array9 = { 2, 69, 17, 3, 1, 556, 4, 190, 0 };

            int minArray9 = array9[0];
            int min2Array9 = array9[0];
            int maxArray9 = array9[0];
            int max2Array9 = array9[0];


            Console.WriteLine("Array: ");
            //Array
            for (int i = 0; i < array9.Length; i++)
            {
                Console.Write(" " + array9[i]);
            }

            Console.WriteLine();

            // max 
            for (int i = 0; i < array9.Length; i++)
            {
                if (array9[i] > maxArray9)
                {
                    maxArray9 = array9[i];
                }
            }
            for (int i = 0; i < array9.Length; i++)
            {
                if (array9[i] != maxArray9 && array9[i] > max2Array9)
                {
                    max2Array9 = array9[i];
                }
            }

            // min
            for (int i = 0; i < array9.Length; i++)
            {
                if (array9[i] < minArray9)
                {
                    minArray9 = array9[i];
                }
            }
            for (int i = 0; i < array9.Length; i++)
            {
                if (array9[i] != minArray9 && array9[i] < min2Array9)
                {
                    min2Array9 = array9[i];
                }
            }


            Console.WriteLine("\n2 max value: " + maxArray9 + " " + max2Array9);
            Console.WriteLine("2 min value: " + minArray9 + " " + min2Array9);


            // NUM 11

            //Составить программу расположения элементов массива в следующем порядке –
            //положительные, отрицательные и нулевые.

            Console.WriteLine("\nNumber 11: ");

            int[] array11 = { 1, 7, -9, -11, 0, 6, -1, 0, 2 };

            int positive = array11[0];
            int negative = 0;
            int zero = 0;


            Console.WriteLine("Array: "); // не уверен что правильно сделал задание 
            //Array
            for (int i = 0; i < array11.Length; i++)
            {
                Console.Write(" " + array11[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Sorted array: ");

            for (int i = 0; i < array11.Length; i++) // positive numbers
            {
                if (array11[i] > 0)
                {
                    Console.Write(" " + array11[i]);
                }              
            }
            for (int i = 0; i < array11.Length; i++) // negative numbers
            {
                if (array11[i] < 0)
                {
                    Console.Write(" " + array11[i]);
                }
            }
            for (int i = 0; i < array11.Length; i++) // zero numbers
            {
                if (array11[i] == 0)
                {
                    Console.Write(" " + array11[i]);
                }
            }
            Console.WriteLine();




            // NUM 12

            // Составить программу упорядочивания по возрастанию (убыванию) элементов массива

            Console.WriteLine("Number 12: ");

            int[] array12 = { 10, 2, 4, 6, 8, 19, 1, 5 };

            Console.WriteLine("Array: "); // не уверен что правильно сделал задание 
            //Array
            for (int i = 0; i < array12.Length; i++)
            {
                Console.Write(" " + array12[i]);
            }

            Console.WriteLine();

            Array.Sort(array12);

            // Sort array
            Console.WriteLine("Array sorted: "); 
            for (int i = 0; i < array12.Length; i++)
            {
                Console.Write(" " + array12[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Array sorted reverse: ");
            for (int i = array12.Length - 1; i >= 0; i--)
            {
                Console.Write(" " + array12[i]);
            }

            Console.WriteLine();



        }
    }
}
