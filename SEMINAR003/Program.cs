Console.Clear();
Console.Write ("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];

for(int i =0; i< array.Length; i++)
    array[i] = new Random().Next(0,11);

for(int i =0; i< array.Length; i++)
    Console.Write(array[i] + " ");

Console.WriteLine();
Console.WriteLine(string.Join (" , ", array));