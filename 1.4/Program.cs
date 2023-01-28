//Проініціалізувати двовимірний масив дійсних чисел списком початкових значень, замінити усі нулі середнім арифметичним усіх елементів.
//Initialize a two-dimensional array of real numbers with a list of initial values, replace all zeros with the arithmetic mean of all elements.
using System;

namespace LabFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            int columns = 5;
            int temp = 0;
            int[,] array = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(-3, 4);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------");
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    temp +=array[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] == 0)
                    {
                        array[i, j] = temp;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}