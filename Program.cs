using System;
namespace ConsoleApp
{
    class Program
    {
        /*
        Написать программу, которая из имеющегося массива строк формирует 
        массива из строк, длина которых меньше либо равна 3 символа.
        Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
        выполнения алгоритма.
        */
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите размер массива строк");
            int size = Convert.ToInt32(Console.ReadLine());

            string[] array = new string[size];

            FillArray(array);
            PrintArray(array);


            void FillArray(string[] array)
            {
                Console.WriteLine("Инициализация массива...");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Введите {i + 1}й элемент");
                    array[i] = Console.ReadLine();
                }
            }


            void PrintArray(string[] array)
            {
                int rows = array.GetLength(0);

                for (int i = 0; i < rows; i++)
                {

                    Console.Write(array[i] + " ");
                    Console.WriteLine();
                }

                Console.WriteLine();
            }


        }
    }

}