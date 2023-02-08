//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void ArithmeticMeanInArray(int[,] array) {
    for (int c = 0; c < array.GetLength(1); c++) {
        double result = 0;
        for (int r = 0; r < array.GetLength(0); r++) {
            result += array[r,c];
        }
        System.Console.WriteLine(result / 3);
    } 
}


int[,] array = {{1,4,7,2},{5,9,2,3},{8,4,2,4}};
ArithmeticMeanInArray(array);

