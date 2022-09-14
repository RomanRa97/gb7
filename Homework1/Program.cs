//Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();

double[,] array = new double [m, n];

for (int i = 0; i < m; i++)
{
    for (int y = 0; y < n; y++)
    {
        array[i,y] = rnd.NextDouble()*100;
        Console.Write(array[i,y] + " ");
    }
    Console.WriteLine();
}
