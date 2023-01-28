//Task#1
/*Увести речення та вивести в окремих рядках його слова.
Enter a sentence and print its words in separate lines.*/

//Task#2
/*Увести речення, зшити усі слова та вивести на екран.
Enter a sentence, stitch all the words together, and display it on the screen.*/
using System;

namespace LabFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            
            Console.WriteLine("\nTask#1");//task#1
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("\nTask#2");//task#2
            string joinedWords = string.Join("s", words);
            Console.WriteLine(joinedWords);
        }
    }
}