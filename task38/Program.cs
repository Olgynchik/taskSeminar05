// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.


double[] array = { 1.2, 0.7, -12.3, 4.1, -7.2, -10.2 };
double min = array[0];
double max = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min)
        min = array[i];
    if (array[i] > max)
        max = array[i];
}

double diff = max - min;

Console.WriteLine($"Максимальный элемент: {max}");
Console.WriteLine($"Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами: {diff}");