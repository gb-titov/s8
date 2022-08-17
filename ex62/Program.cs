// Задача 62. Заполните спирально массив 4 на 4.


using ArrayExtensions;

Console.WriteLine("Программа создает массив 4х4 по спирали.");
Console.WriteLine();
var array = FillSpiralArray();

array.WriteArrayToConsole();



int[,] FillSpiralArray()
{
    int[,] array = new int[4, 4];
    int rows = array.GetLength(0) - 1;
    int cols = array.GetLength(1) - 1; 
    int num = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < cols; j++)
        {
            array[i, j] = num++;
        }

        for (int k = i; k < rows; k++)
        {
            array[k, rows] = num++;
        }

        for (int l = cols; l > i; l--)
        {
            array[rows, l] = num++;
        }

        for (int m = rows; m > i; m--)
        {
            array[m, i] = num++;
        }

        rows--;
        cols--;
    }

    return array;
}