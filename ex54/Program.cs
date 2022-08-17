//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

using System.Threading.Channels;
using ArrayExtensions;
Console.WriteLine("Программа построчно сортирует массив по убыванию.");
Console.WriteLine("Сгенерированный массив:");
int[,] array = new int[5,5].SetRnd(0,9);
array.WriteArrayToConsole();
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
SortDescendingByRows(array);
array.WriteArrayToConsole();


void SortDescendingByRows(int[,] arr)
{
    int tmp;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1)-1; j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] < arr[i, k])
                {
                    tmp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = tmp;
                }
            }
        }
    }
}