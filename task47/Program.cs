//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//
//m = 3, n = 4.
//
//0,5 7 -2 -0,2
//
//1 -3,3 8 -9,9
//
//8 7,8 -7,1 9


double[,] GenerationDoubleArray() {

    System.Console.WriteLine("Введите размеры двумерного массива!");

    System.Console.Write("Введите m: ");
    int m = Convert.ToInt32(System.Console.ReadLine());

    System.Console.Write("Введите n: ");
    int n = Convert.ToInt32(System.Console.ReadLine());

    double[,] array = new double[m,n];
    Random random = new Random();
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            array[i,j] = random.NextDouble() + random.Next(0,101);
        }
    }
    
    return array;
}

double[,] array = GenerationDoubleArray();
