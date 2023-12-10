// Задача 2.  Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

Console.Write("Введите кол-во элементов: ");
Random random = new Random();
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
            int count = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Количество четных чисел в массиве: " + count);
        
    