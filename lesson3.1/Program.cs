using System;

namespace lesson3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы");
            int matrix = int.Parse(Console.ReadLine()); /* Число из string преобразовываем в int и создаем переменную matrix
                                                          с этим значением*/
            int k = 0;                                  // Счётчик;
            int[,] mas = new int[matrix, matrix];       // Создаем двумерный массив;

            Random random = new Random();

            for (int i = 0; i < matrix; i++)            /*Цикл, проходящий по строкам; Инициализатор i=0, Условие i<matrix, Итератор i++
                                                        */
            {
                for (int j = 0; j < matrix; j++)        //Цикл, проходящий по столбцам;
                {
                    if (i == j) mas[i, j] = k;          //Заполнятся будут те элементы,номера строк и столбцов которых равны(Диагональ). 
                    k = random.Next(100);               // Уже после определения нужного элемента массива, вносим в него рандомное число 0т 0 до 100;
                    Console.Write(mas[i, j] + " ");       //Вывод вдоль строки. 
                }

                k++;                                    //Увеличение переменной на 1. 
                Console.WriteLine();                     //Переход на новую строку после заполнения предыдущей. 
            }
            Console.ReadKey();
        }
    }
}
