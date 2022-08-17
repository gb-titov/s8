//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


using ArrayExtensions;


Console.WriteLine("Программа для произведения массивов.");
var firstArray = new int[3, 2].SetRnd(0, 9);
Console.WriteLine("Первый массив:");
firstArray.WriteArrayToConsole();
Console.WriteLine();


var secondArray = new int[2, 3].SetRnd(0, 9);
Console.WriteLine("Второй массив:");
secondArray.WriteArrayToConsole();
Console.WriteLine();


var newArray = Multiply(firstArray, secondArray);

if (newArray == null)
    Console.WriteLine("Невозможно выполнить произведение, размерности массивов не совпадают");
else
{
    Console.WriteLine("Произведение:");
    newArray.WriteArrayToConsole();
    Console.WriteLine();
}



int[,] Multiply(int[,] first, int[,] second)
{
    if (!IsLengthEqual(first, second))
        return null;

    int firstRows = first.GetLength(0);
    int firstCols = first.GetLength(1);
    int secondCols = second.GetLength(1);
    int secondRows = second.GetLength(0);
    var newArray = new int[firstRows, secondCols];
    
    for (int i = 0; i < firstRows; i++)
    {
        for (int j = 0; j < secondCols; j++)
        {
            for (int k = 0; k < secondRows; k++)
            {
                newArray[i, j] += first[i, k] * second[k, j];
            }
        }
    }

    return newArray;
}

bool IsLengthEqual(int[,] first, int[,] second) =>
    (first.GetLength(0) == second.GetLength(1));

