
using System;
using static System.Console;

namespace IntroCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");

            int number = int.Parse(ReadLine());

            Console.WriteLine($" The value got inserted is {number} ");
            Console.WriteLine(" The value got inserted is {0}",number);
            Console.WriteLine(" The value got inserted is "+number);

            WriteLine("Enter two strings to get concatenated !!!");

            string s1 = ReadLine();
            string s2 = ReadLine();
            Console.WriteLine("the concatenated strings are = "+s1+s2);
        }
    }
}
