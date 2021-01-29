using System;

namespace lesson3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //САМЫЙ БЫСТРЫЙ СПОСОБ

            string stroka = Console.ReadLine();           //читаем, что напечатали и помещаем это в переменную stroka;
            for (int i = stroka.Length - 1; i >= 0; i--)
            {
                Console.Write(stroka[i]);                // вывод каждого символа строки;
            }


            //СПОСОБ №2 С МАССИВАМИ

            Console.WriteLine("Введите что-нибудь");

            string str = Console.ReadLine();
            char[] newmas = str.ToCharArray();            //строку переводим в массив;

            for (int i = newmas.Length - 1; i >= 0; i--) /*Вывод массива циклом "for". свойство Lenght знает сколько элементов
                                                         * храниться в массиве. -1 чтоб не выйти за границу массива, т.к. Lenght 
                                                         * присваивает в итератор i число элементов начиная с 1 (qwerty-6 элементов)
                                                         * а фактически нумерация элементов в массиве начинается с 0, поэтому Lenght 
                                                         * заранее уменьшаем на 1;*/
            {
                string value = String.Concat(newmas[i]); //Преобразуем массив в строку методом Concat класса String;
                Console.Write(value);                    // Write, а не WriteLine, чтобы вывод был в виде строки, а не столбиком;
            }
            Console.ReadLine();


            //ТРЕТИЙ СПОСОБ.

            string chtoto;
            chtoto = Console.ReadLine();
            char[] sReverse = chtoto.ToCharArray();    //преобразуем строку string в символьный массив;
            Array.Reverse(sReverse);                   //реверсируем массив методом Reverse.Такой метод реверса есть у класса Array;
            chtoto = new string(sReverse);             //обратно переводим массив в строку и выводим на консоль или куда-нить ещё;
            Console.WriteLine(chtoto);
            Console.ReadLine();
        }
    }
}
