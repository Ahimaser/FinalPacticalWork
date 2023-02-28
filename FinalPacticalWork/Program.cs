using System;
using static System.Console;
using static CreateArray;

namespace FinalPacticalWork
{
    class Program
    {
        static void Main()
        {
            WriteLine("Задайте длину массива : ");
            int x = Convert.ToInt32(ReadLine());

            WriteLine(Print(Create(x)));

        }
    }

}   