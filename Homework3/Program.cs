//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int value = 0;

Random rnd = new Random();

int[,] array = new int [m, n];

for (int i = 0; i < m; i++)
{
    for (int y = 0; y < n; y++)
    {
        array[i,y] = rnd.Next(1, 10);
        Console.Write(array[i,y] + " ");

    }
    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{
    for (int y = 0; y < n; y++)
    {
        value += array[y, i];
    }
    Console.Write(value/(Convert.ToDouble(m)));
    value = 0;
    Console.WriteLine();
}