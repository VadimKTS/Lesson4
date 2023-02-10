namespace Lesson4HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// Task 1 ------------------------------------------------------------------

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.Write($"{i} ");
            //    } 
            //}


            //// Task 2 ------------------------------------------------------------------

            //for (int i = 5; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //// Task 3 ------------------------------------------------------------------

            //Console.WriteLine("Введите целое положительное число:");
            //var number = Convert.ToInt32(Console.ReadLine());
            //var summary = 0;
            //for (int i = 0; i < number; i++)
            //{
            //    summary = summary + i;
            //}
            //Console.WriteLine($"Сумма чисел от 1 до {number} = {summary}");

            //// Task 4 ------------------------------------------------------------------

            //int number = 7;
            //while (number < 100) 
            //{
            //    Console.Write($" {number} ");
            //    number += 7;
            //}


            //// Task 5 ------------------------------------------------------------------

            //int counter = 0;
            //var number = 0;
            //do
            //{
            //    counter++;
            //    Console.Write($"{number}, ");
            //    number -= 5;
            //} while (counter <= 9);


            //// Task 6 ------------------------------------------------------------------

            //for (int i = 10; i <= 20; i++)
            //{
            //    Console.WriteLine("Квадрат числа " + i + " = " + Math.Pow(i, 2)); // Конкатенация
            //}


            //// Arrays -------------------------------------------------------------------------------------------------
            ////---------------------------------------------------------------------------------------------------------


            //// Task 0 ------------------------------------------------------------------

            //int[] arrayZero = { 12, 85, 4, 9, 35, 7, 16, 4 };
            //Console.WriteLine("Введите число:");
            //int number = Int32.Parse(Console.ReadLine());
            //int counter = 0;
            //foreach (int i in arrayZero)
            //{
            //    if (i == number)
            //    {
            //        counter++;
            //    }
            //}
            //if (counter != 0)
            //{ Console.WriteLine($"В массиве присутствует число {number}"); }
            //else
            //{
            //    Console.WriteLine($"В массиве отсутствует число {number}");
            //}


            //// Task 1 ------------------------------------------------------------------

            //int[] arrayOne = { 12, 85, 4, 9, 35, 7, 16, 4 };

            ////foreach (int i in arrayOne)                // исходный массив для проверки
            ////{
            ////    Console.Write($"{i} ");
            ////}

            //Console.WriteLine("\nВведите число, которое нужно удалить из массива:");
            //int number = Int32.Parse(Console.ReadLine());
            //int counter = 0;
            //for (int i = 0; i < arrayOne.Length; i++)
            //{
            //    if (arrayOne[i] == number)
            //    {
            //        Array.Clear(arrayOne, i, 1);
            //        counter++;
            //    }
            //}
            //if (counter != 0)
            //{ Console.WriteLine($"Число {number} удалено из массива"); }
            //else { Console.WriteLine($"В массиве отсутствует число {number}"); }

            ////foreach (int i in arrayOne)                 // измененный массив для проверки
            ////{
            ////    Console.Write($"{i} ");
            ////}


            //// Task 2 ------------------------------------------------------------------

            //Console.WriteLine("Введите желаемый размер массива:");
            //int arrayTwoLenth = Convert.ToInt32(Console.ReadLine());
            //int[] arrayTwo = new int[arrayTwoLenth];
            //Random randomVariabel = new Random();
            //for (int i = 0; i < arrayTwo.Length; i++)
            //{
            //    arrayTwo[i] = randomVariabel.Next(1, 100);
            //    Console.Write($"{arrayTwo[i]} ");
            //}
            //var minValue = arrayTwo[0];
            //var averageValue = 0;
            //var maxValue = arrayTwo[0];

            //foreach (var item in arrayTwo)
            //{
            //    if (minValue > item) { minValue = item; }
            //    if (maxValue < item) { maxValue = item; }
            //    averageValue += item;
            //}
            //averageValue = averageValue / arrayTwo.Length;
            //Console.WriteLine($"\nМинимальное значение: {minValue}\nСреднее значение: {averageValue}\nМаксимальное значение: {maxValue}");


            //// Task 3 ------------------------------------------------------------------

            //int[] arrayThreeFirst = { 1, 2, 3, 4, 50 };
            //int[] arrayThreeSecond = { 6, 7, 8, 9, 12 };
            //var averageValueFirst = 0;
            //var averageValueSecond = 0;

            //foreach (int i in arrayThreeFirst)
            //{
            //    Console.Write($"{i}   ");
            //    averageValueFirst += i;
            //}
            //averageValueFirst = averageValueFirst / arrayThreeFirst.Length;
            //Console.WriteLine("");

            //foreach (int i in arrayThreeSecond)
            //{
            //    Console.Write($"{i}   ");
            //    averageValueSecond += i;
            //}
            //averageValueSecond = averageValueSecond / arrayThreeSecond.Length;
            //Console.WriteLine("");

            //if (averageValueFirst < averageValueSecond)
            //{
            //    Console.WriteLine($"Среднее арифметическое значение первого массива меньше чем второго. {averageValueFirst} < {averageValueSecond}");
            //}
            //else if (averageValueFirst > averageValueSecond)
            //{
            //    Console.WriteLine($"Среднее арифметическое значение первого массива больше чем второго. {averageValueFirst} > {averageValueSecond}");
            //}
            //else
            //{
            //    Console.WriteLine($"Средние арифметические значение обоих массивов равны: {averageValueFirst} = {averageValueSecond}");
            //}





            //// Additional tasks----------------------------------------------------------------------------------------
            ////---------------------------------------------------------------------------------------------------------


            //// Task 1 ------------------------------------------------------------------

            //int[] fibonacciSequence = new int[11]; 
            //fibonacciSequence[0] = 0;
            //fibonacciSequence[1] = 1;

            //for (int n = 2; n < fibonacciSequence.Length; n++)
            //{
            //    fibonacciSequence[n] = fibonacciSequence[n - 2] + fibonacciSequence[n - 1];
            //}
            //foreach (int i in fibonacciSequence)                 
            //{
            //    Console.Write($"{i} ");
            //}


            //// Task 2 ------------------------------------------------------------------

            //Console.WriteLine("Введите сумму вклада: ");
            //float summary = float.Parse(Console.ReadLine());
            //Console.WriteLine("Введите срок вклада в месяцах: ");
            //int period = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= period; i++)
            //{
            //    summary += summary * 0.07f;
            //}
            //Console.WriteLine($"После {period} месяцев сумма вклада составит {summary}"); 


            //// Task 3 ------------------------------------------------------------------
            //// Calculator

            //// Task 4 ------------------------------------------------------------------

            //inputNAgain:
            //Console.WriteLine("Введите размер массива n больше 5 и меньше, либо равно 10:");
            //int lengthrandomArray = Convert.ToInt32(Console.ReadLine());

            //if (lengthrandomArray <= 5 || lengthrandomArray > 10)
            //{
            //    Console.WriteLine($"Введенное значение размера массива <<{ lengthrandomArray }>> не попадает в диапазон 5>n<=10");
            //    goto inputNAgain;
            //}
            //Random randomVariable = new Random();
            //int[] randomArray = new int[ lengthrandomArray ];
            //int counterEvenNumbers = 0;


            //for ( int i = 0; i < lengthrandomArray; i++)
            //{
            //    randomArray[i] = randomVariable.Next(1, 100);
            //    if (randomArray[i] % 2 == 0) { counterEvenNumbers++; }    // счетчик четных чисел для указания длинны второго массива

            //}

            //foreach ( int i in randomArray )   // Вывод на экран первого массива
            //{
            //    Console.Write($"{i} ");
            //}

            //int[] evenNumbers = new int[counterEvenNumbers];
            //int i2 = 0;
            //for ( int i = 0; i < lengthrandomArray; i++ )
            //{
            //    if ( randomArray[i] % 2 == 0 )
            //    {
            //        evenNumbers[i2] = randomArray[i];
            //        i2++;
            //    }
            //}

            //Console.WriteLine();
            //foreach (int i in evenNumbers)   // Вывод на экран второго массива
            //{
            //    Console.Write($"{i} ");
            //}


            //// Task 5 ------------------------------------------------------------------

            //int[] defaultArray= { 11, 52, 33, 54, 86, 23, 87 };
            //foreach (int i in defaultArray)   
            //{
            //    Console.Write($"{i}   ");
            //}

            //Console.WriteLine();
            //for (int i = 0; i < defaultArray.Length; i++)
            //{
            //    if ( i % 2 != 0 )
            //    {
            //        defaultArray[i] = 0;
            //        Console.Write(" ");
            //    }
            //    Console.Write($"{defaultArray[i]}   ");
            //}



            //// Task 6 ------------------------------------------------------------------




            //// Task 7 ------------------------------------------------------------------



        }
    }
}