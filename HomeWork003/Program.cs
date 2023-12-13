// Задача 1. Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, 
//значения которых лежат в отрезке [20,90].
int[] arr = new int[10];
            Random random = new Random();
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                arr[i] = random.Next(1, 101);
                if (arr[i] >= 20 && arr[i] <= 90)
                {
                    count++;
                }
            }

            Console.WriteLine(String.Join(", ", arr));
            Console.WriteLine(count);


//Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
using System;

 
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10]{1, 8, 43, 4, 55, 60, 3, 2, 1, 3};
            int count = 0;
 
            for (int i = 0; i < 10; i++)
            {
                if ((a[i] % 2) == 0)
                    count++;
            }
            Console.Write(count);
            Console.ReadKey();
        }
    }
}
// Решение для рандомных чисел
//         {
//            Console.WriteLine("Исходный массив:");
//           Random random = new Random();
//            int[] array = new int[10]; 
//
//        for (int i = 0; i < array.Length; i++)
//   {
//        array[i] = new Random().Next();
//   }
//           int count = 0;
//
//        for (int i = 0; i < array.Length; i++)
//           {
//             array[i] = new Random().Next();
//              Console.Write(array[i]  + " ");
//}
//            for (int i = 0; i < 10; i++)
//            {
 //               if ((array[i] % 2) == 0)
 //                   count++;
 //           }
 //           Console.WriteLine(count);
 //           Console.ReadKey();
 //       }
 //   }
//}


// Задача 3. Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива.
//Создали массив
Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[];

//Заполнение массива
void mas(int a)
{
Random rand = new Random();
for (int i = 0; i < a; i++)
{
randomArray[i] = rand.NextDouble();
Console.Write($"{randomArray[i]:F2} ");
}

}

double raz(double[] randomArray)
{
double min = randomArray[0];
double max = randomArray[0];
int i = 1;
while (i < randomArray.Length)
{
if (max<randomArray[i])
max = randomArray[i];
if (min>randomArray[i])
min = randomArray[i];
i = i + 1;
}
return max-min;
}

mas(a);
Console.Write($"\n Разница между максимальным и минимальным элементами массива: {raz(randomArray):F2}");


//Задача 4.Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
//Размер массива должен быть равен количеству цифр. Дано натуральное число в диапазоне от 1 до 100 000. 
//Нам нужно создать массив, состоящий из цифр этого числа. 
//При этом старший разряд числа будет располагаться на 0-м индексе массива, а младший разряд - на последнем индексе. 
//Размер массива должен быть равен количеству цифр в числе.
using System;

class Program
{
    static void Main()
    {
        int number = 12345;
        string numberString = number.ToString();
        int[] digits = new int[numberString.Length];
        
        for (int i = 0; i < numberString.Length; i++)
        {
            digits[i] = int.Parse(numberString[i].ToString());
        }
        
        Array.Reverse(digits); // чтобы старший разряд был на 0-м индексе
        
        Console.WriteLine("Массив цифр числа:");
        foreach (int digit in digits)
        {
            Console.Write(digit + " ");
        }
    }
}