// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[size];
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    mass[i] = rand.Next(100, 1000);
}
System.Console.WriteLine(string.Join(" ", mass));
int count = 0;
for (int i = 0; i < size; i++)
{
    if (mass[i] % 2 == 0)
    {
        count ++; // count = count + 1
    }
}
System.Console.WriteLine($"Количество четных чисел в массиве: {count} ");