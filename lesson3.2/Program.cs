using System;

namespace lesson3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix =
            {
                { "Иванов","28 32 44 , ivan@mail.ru"},
                { "Петров", "16 56 71 petr@mail.ru"},
                { "Сидоров", "21 30 55 sid@mail.ru"},
                { "Сергеев", "9 01 61 serg@mail.ru"},
                { "Медведев", "5758564A5762 , beer@mail.ru"}
            };

            int height = matrix.GetLength(0);
            int wight = matrix.GetLength(1);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < wight; x++)
                {
                    Console.WriteLine(matrix[y, x]);
                }
            }
        }
    }
}
