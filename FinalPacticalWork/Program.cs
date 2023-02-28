using System;
using static System.Console;
using static CreateArray;
using static SelectonArr;

namespace FinalPacticalWork
{
    class Program
    {
        static void Main()
        {
            WriteLine("Задайте длину массива : ");
            int x = Convert.ToInt32(ReadLine());

            string[] arr = Create(x);
            WriteLine(Print(arr));

            
            arr = Select(Change(arr));
            WriteLine("Измененный " + Print(arr));
        }
    }

}   