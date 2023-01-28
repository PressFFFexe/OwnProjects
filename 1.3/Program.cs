//Проініціалізувати двовимірний масив дійсних чисел списком початкових значень, замінити усі нулі одиницями, а від'ємні значення – нулями.
//Initialize a two-dimensional array of real numbers with a list of initial values, replace all zeros with ones, and negative values with zeros.
using System;

namespace LabFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 5; 
            int columns = 5;
            int[,] array = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0;j< columns;j++)
                {
                    array[i, j] = random.Next(-10,11);
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
                    if (array[i,j]==0)
                    {
                        array[i,j] = 1;
                    }
                    else if (array[i,j]<0)
                    {
                        array[i,j] = 0;
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