//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//
//Например, задан массив:
//
//1 4 7 2
//
//5 9 2 3
//
//8 4 2 4
//
//17 -> такого числа в массиве нет

void SearchElement(int[,] array, int searchIndex, int secondSearchIndex) {
    int result = 0;
            if(searchIndex < 0 || searchIndex > array.GetLength(0) - 1
            && secondSearchIndex < 0 || secondSearchIndex > array.GetLength(1) - 1) {
                System.Console.WriteLine("Такого числа нет в массиве!");
            } else {
                result = array[searchIndex,secondSearchIndex];
                System.Console.WriteLine(result);
            }
        }

int[,] array = {{1,4,7,2},{5,9,2,3},{8,4,2,4}};

SearchElement(array,0,1);
