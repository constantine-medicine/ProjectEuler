using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinerySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача 1
            //// Если выписать все натуральные числа меньше 10, кратные 3 или 5, то получим 3, 5, 6 и 9.Сумма этих чисел равна 23.
            //// Найдите сумму всех чисел меньше 1000, кратных 3 или 5.

            //int sum = 0;

            //for (int i = 0; i < 1000; i++)
            //{
            //    if (i % 3 ==0 || i % 5 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine($"Сумма всх чисел меньше 1000, кратных 3 или 5 равна {sum}"); 
            #endregion

            #region Задача 2
            //// Каждый следующий элемент ряда Фибоначчи получается при сложении двух предыдущих. Начиная с 1 и 2, первые 10 элементов будут:
            //// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
            //// Найдите сумму всех четных элементов ряда Фибоначчи, которые не превышают четыре миллиона.

            //int[] arrFib = new int[4_000_000];
            //decimal sum = 0;

            //for (int i = 0; i < arrFib.Length; i++)
            //{
            //    arrFib[i] = i + 1;

            //    if (i >= 3)
            //    {
            //        arrFib[i] = arrFib[i - 2] + arrFib[i - 1];
            //    }

            //    if (arrFib[i] % 2 == 0)
            //    {
            //        sum += arrFib[i];
            //    }
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Задача 3
            //// Простые делители числа 13195 - это 5, 7, 13 и 29.
            //// Каков самый большой делитель числа 600851475143, являющийся простым числом?

            //decimal n = 600851475143;
            //int divisibly = 2;
            //int count = 0;

            //while (divisibly < n / 2)
            //{
            //    divisibly++;

            //    if (n % divisibly == 0)
            //    {
            //        for (int i = 2; i <= divisibly; i++)
            //        {
            //            if (divisibly % i == 0)
            //            {
            //                count++;
            //            }
            //        }
            //    }

            //    if (count == 1)
            //    {
            //        Console.WriteLine(divisibly);
            //    }

            //    count = 0;
            //}
            #endregion

            #region Задача 4
            //// Число - палиндром с обеих сторон(справа налево и слева направо) читается одинаково. 
            //// Самое большое число - палиндром, полученное умножением двух двузначных чисел – 9009 = 91 × 99.
            //// Найдите самый большой палиндром, полученный умножением двух трехзначных чисел.

            //List<int> arr = new List<int>();

            //int counter = 0;
            //int lastindex = 6;

            //for (int i = 100; i < 1_000; i++)
            //{
            //    for (int j = 100; j < 1_000; j++)
            //    {
            //        string palindrom = Convert.ToString(i * j);

            //        if (palindrom.Length == 6)
            //        {
            //            for (int k = 0; k < 3; k++)
            //            {
            //                if (palindrom[k] == palindrom[lastindex - 1]) 
            //                {
            //                    counter++; 
            //                }
            //                lastindex--;
            //            }

            //            if (counter == 3)
            //            {
            //                arr.Add(int.Parse(palindrom));
            //            }

            //            counter = 0;
            //            lastindex = 6;
            //        }                  
            //    }
            //}

            //int maxVal = 0;

            //foreach (var item in arr)
            //{
            //    if (item > maxVal)
            //    {
            //        maxVal = item;
            //    }
            //}

            //for (int i = 100; i < 1_000; i++)
            //{
            //    for (int j = 100; j < 1_000; j++)
            //    {
            //        if (i * j == maxVal && counter == 0)
            //        {
            //            Console.WriteLine($"Самый большой палиндром получается при умножении {i} * {j} = {maxVal}");
            //            counter++;
            //        }
            //    }
            //}               
            #endregion

            #region Задача 5
            //// 2520 - самое маленькое число, которое делится без остатка на все числа от 1 до 10.
            //// Какое самое маленькое число делится нацело на все числа от 1 до 20 ?

            //decimal number = 11;
            //int counter = 0;

            //while (true)
            //{
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        if (number % i == 0)
            //        {
            //            counter++;
            //        }
            //    }

            //    if (counter == 10)
            //    {
            //        Console.WriteLine(number);
            //        break;
            //    }

            //    counter = 0;
            //    number++;
            //}
            #endregion

            #region Задача 6
            //// Сумма квадратов первых десяти натуральных чисел равна
            //// 12 + 22 + ... +102 = 385
            //// Квадрат суммы первых десяти натуральных чисел равен
            //// (1 + 2 + ... +10)2 = 552 = 3025
            //// Следовательно, разность между суммой квадратов и квадратом суммы первых десяти натуральных чисел составляет 3025 − 385 = 2640.
            //// Найдите разность между суммой квадратов и квадратом суммы первых ста натуральных чисел.

            //int sumSquare = 0;
            //int sum = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    sumSquare += i * i;
            //    sum += i;
            //}
            //sum = sum * sum;

            //int result = sum - sumSquare;
            //Console.WriteLine(result);
            #endregion

            #region Задача 7
            //// Выписав первые шесть простых чисел, получим 2, 3, 5, 7, 11 и 13.Очевидно, что 6 - ое простое число -13.
            //// Какое число является 10001 - ым простым числом?

            //int number = 1;
            //int counter = 0;
            //int result = 0;

            //while (result < 10_001)
            //{
            //    number++;

            //    for (int i = 1; i <= number; i++)
            //    {
            //        if (number % i == 0)
            //        {
            //            counter++;
            //        }
            //    }

            //    if (counter == 2)
            //    {
            //        result++;
            //    }

            //    counter = 0;
            //}

            //Console.WriteLine(number);
            #endregion

            #region Задача 8
            //// Наибольшее произведение четырех последовательных цифр в нижеприведенном 1000 - значном числе равно 9 × 9 × 8 × 9 = 5832.
            //// Найдите наибольшее произведение тринадцати последовательных цифр в данном числе.

            //string number = File.ReadAllText(@"D:\С#\BinerySearch\number.txt");

            //char[] arrChar = number.ToCharArray();
            //int[] arr = new int[arrChar.Length];

            //for (int i = 0; i < arrChar.Length; i++)
            //{
            //    arr[i] = int.Parse(Convert.ToString(arrChar[i]));
            //}

            //int minCompos = 1;
            //int maxCompos = 0;
            //int element = 0;

            //while (element < arr.Length - 3)
            //{
            //    for (int i = 0; i < 4; i++)
            //    {
            //        minCompos *= arr[element];
            //        element++;
            //    }

            //    if (minCompos > maxCompos)
            //    {
            //        maxCompos = minCompos;
            //    }

            //    minCompos = 1;
            //    element -= 3; 
            //}

            //Console.WriteLine(maxCompos); 
            #endregion

            #region Задача 9
            //// Тройка Пифагора - три натуральных числа a < b < c, для которых выполняется равенство
            //// a2 + b2 = c2
            //// Например, 32 + 42 = 9 + 16 = 25 = 52.
            //// Существует только одна тройка Пифагора, для которой a + b + c = 1000.
            //// Найдите произведение abc.

            //for (int i = 0; i < 450; i++)
            //{
            //    for (int j = 0; j < 450; j++)
            //    {
            //        for (int k = 0; k < 450; k++)
            //        {
            //            if (i < j && j < k)
            //            {
            //                if (i*i + j*j == k*k && i + j + k == 1_000)
            //                {
            //                    Console.Write($"{i} + {j} + {k} = {i + j + k}");
            //                    Console.Write($"\n{i}*{i} + {j}*{j} = {k}*{k}");
            //                }
            //            }
            //        }
            //    }
            //} 
            #endregion

            #region Задача 10
            //// Сумма простых чисел меньше 10 равна 2 + 3 + 5 + 7 = 17.
            //// Найдите сумму всех простых чисел меньше двух миллионов.

            //int counter = 0;
            //decimal sum = 0;

            //for (int i = 2; i < 2_000_000; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            counter++;
            //        }
            //    }

            //    if (counter == 2)
            //    {
            //        sum += i;
            //    }

            //    Console.WriteLine(sum);
            //    counter = 0;
            //}
            //Console.WriteLine(sum); 
            #endregion

            Console.ReadKey();
        }
    }
}
