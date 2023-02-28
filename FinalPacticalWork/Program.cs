using System;

namespace FinalPacticalWork
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задайте длину массива : ");
            int x = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine(Print(CreateArray(x)));

        }
        public static string[] CreateArray(int size)
        {
            string[] arr = new string[size];
            Console.WriteLine("Хотите сами задать элементы массива?\nВведите:\"y\"-если да и \"n\"-если нет.");
            string z = Convert.ToString(Console.ReadLine());


            for (int i = 0; i < arr.Length; i++)
            {
                if (z == "y")
                {
                    Console.WriteLine($"Введите элемент №{i} : ");
                    arr[i] = Convert.ToString(Console.ReadLine());
                }
                else if (z == "n")
                    arr[i] = Convert.ToString(new Random().Next(-100, 100));
                else
                    Console.WriteLine("Вы ввели что-то не то, попробуйте еще раз!");
            }

            return arr;
        }
        public static string Print(string[] arr) => $"Массив :\n{string.Join(", ", arr)}";
    }

}   