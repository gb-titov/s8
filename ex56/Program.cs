//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


using ArrayExtensions;



Console.WriteLine("Программа для нахождения строки массива с наименьшей суммой элементов.");
Console.WriteLine("Сгенерированный массив:");
var array = new int[2,4].SetRnd(0,9);
array.WriteArrayToConsole();

int rowNum = FindRowWithMinSum(array);

Console.WriteLine($"{rowNum} строка с наименьшей суммой элементов.");



int FindRowWithMinSum(int[,] arr)
{
    int currentSum = 0;
    int minSum =int.MaxValue;
    int rowNum = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            currentSum += arr[i, j];
        }

        if (currentSum < minSum)
        {
            rowNum = i;
            minSum = currentSum;
        }
        currentSum = 0;
    }

    return rowNum + 1;
}
