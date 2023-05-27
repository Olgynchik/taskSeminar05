// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// System.Console.WriteLine("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] mass = new int[size];
// Random rand = new Random();
// for (int i = 0; i < size; i++)
// {
//     mass[i] = rand.Next(100, 1000);
// }
// System.Console.WriteLine(string.Join(" ", mass));
// int count = 0;
// for (int i = 0; i < size; i++)
// {
//     if (mass[i] % 2 == 0)
//     {
//         count ++; // count = count + 1
//     }
// }
// System.Console.WriteLine($"Количество четных чисел в массиве: {count} ");

int Text(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int size = Text("Введите размер массива:");
int count = 0;
int[] Massiv(int size, int leftRange, int rightRange)
{
    int[] mass = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        mass[i] = rand.Next(leftRange, rightRange);
        if (mass[i] % 2 == 0)
        {
            count++; // count = count + 1
        } 
    }
    return mass;  
}
int[] Array = Massiv(size, 100, 1000);
System.Console.WriteLine(string.Join(" ", Array));
System.Console.WriteLine($"Количество четных чисел в массиве: {count} "); 
