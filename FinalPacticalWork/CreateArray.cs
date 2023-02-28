using System;
using static System.Console;
public static class CreateArray
{
    public static string[] Create(int size)
    {
        string[] arr = new string[size];
        WriteLine("Хотите сами задать элементы массива?\nВведите:\"y\"-если да и \"n\"-если нет.");
        string z = Convert.ToString(ReadLine());


        for (int i = 0; i < arr.Length; i++)
        {
            if (z == "y")
            {
                WriteLine($"Введите элемент №{i} : ");
                arr[i] = Convert.ToString(ReadLine());
            }
            else if (z == "n")
                arr[i] = Convert.ToString(new Random().Next(-1000, 1001));
            else
                WriteLine("Вы ввели что-то не то, попробуйте еще раз!");
        }
        return arr;
    }
    public static string Print(string[] arr) => $"Массив :\n{string.Join(", ", arr)}";
}