//Описати одновимірний масив, уводити з клавіатури значення його елементів та дописувати їх до масиву. Процес завершується уведенням нуля. Вивести суму елементів.
//Describe a single-world array, remove from the keyboard the meaning of each element and add them to the array. The process ends when zero is reached. Enter the sum of elements.
namespace LabFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int size = 1000;
            int num;
            int sum = 0;
            int[] array = new int[size];

            Console.WriteLine("Enter number for array;\n");
            Console.WriteLine("Press 0 to stop;\n");

            for (int i = 0; i < size; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    Console.WriteLine("The sum of the elements of the array is: " + sum);
                }
                array[i] = num;
                sum += num;            
            }            
        }
    }
}