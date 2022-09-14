//Задача 2. Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите строку элемента");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите столбец элемента");
int z = Convert.ToInt32(Console.ReadLine());

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

if (x > m || z > n) Console.WriteLine("Числа в массиве нет");
else
{
    Console.WriteLine(array[x-1, z-1]);
}
