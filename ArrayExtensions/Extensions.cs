namespace ArrayExtensions
{
    public static class Extensions
    {
        public static int[,] SetRnd(this int[,] array, int min, int max)
        {
            var rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(min, max + 1);
                }
            }
            return array;
        }

        public static int[,,] SetUniqTwoDigit(this int[,,] array)
        {
            int num = 10;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = num++;
                        if (num == 100) 
                            num = 10;
                    }
                    
                }
            }
            return array;
        }

        public static double[,] SetRnd(this double[,] array, int mnozh = 1)
        {
            var rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int znak = rnd.Next(0, 2) == 1 ? -1 : 1;
                    array[i, j] = rnd.NextDouble() * mnozh * znak;
                }
            }

            return array;
        }




        #region WriteToConsole


        public static void WriteArrayToConsole(this int[,,] array, bool withIndex = false)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        var index = withIndex ? $"({j},{i},{k})" : string.Empty;
                        Console.Write($"{array[j,i,k]}{index}");
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void WriteArrayToConsole(this double[,] array, int round = 2)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(Math.Round(array[i, j], 2) + " ");
                }

                Console.WriteLine();
            }
        }
        public static void WriteArrayToConsole(this double[] array, int round = 2)
        {
            Console.Write($"[{array[0]}");

            for (int i = 1; i < array.Length; i++)
            {
                Console.Write($", {Math.Round(array[i], round)}");
            }
            Console.WriteLine("]");
        }

        public static void WriteArrayToConsole(this int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j], 4}");
                }

                Console.WriteLine();
            }
        }

        #endregion


    }
}