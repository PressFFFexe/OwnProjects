//Створити функцію з двома параметрами-посиланнями, яка збільшує один параметр на 1 та зменшує другий на 2.
//Create a function with two parameter-enablements, so that one parameter increases by 1 and the other parameter changes by 2.
using System;

namespace LabFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            project(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        private static void project(ref int a, ref int b)
        {
            a += 1;
            b -= 2;
        }
    }
}