//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



using ArrayExtensions;


Console.WriteLine("Программа для генерации и вывода трехмерного массива.");

int[,,] array = new int[2,2,2].SetUniqTwoDigit();

var arrLength = GetArrayLength(array);
Console.WriteLine($"Размер массива: ({arrLength.x},{arrLength.y},{arrLength.z})");
Console.WriteLine();
array.WriteArrayToConsole(true);

(int x, int y, int z) GetArrayLength(int[,,] arr) => (arr.GetLength(0), arr.GetLength(1), arr.GetLength(2));
