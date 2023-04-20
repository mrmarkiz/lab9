using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public delegate void DelegateTask1(string text);

    class Task1
    {
        public static void Run()
        {
            Console.WriteLine("Enter text to work with:");
            string input = Console.ReadLine();
            int choice;
            DelegateTask1 delegateTask1;
            do
            {
                Console.WriteLine("Enter what to do(1 - show text, 2 - show in uppercase, 3 - show in lowercase, 4 - show distinct words):");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        delegateTask1 = Show;
                        break;
                    case 2:
                        delegateTask1 = ToUpper;
                        break;
                    case 3:
                        delegateTask1 = ToLower;
                        break;
                    case 4:
                        delegateTask1 = DistinctWords;
                        break;
                    default:
                        delegateTask1 = null;
                        break;
                }
                if (delegateTask1 != null)
                {
                    Console.WriteLine("Result:");
                    delegateTask1(input);
                }
                else
                {
                    Console.WriteLine("Error occured try again");
                }
                Console.WriteLine();
            } while (choice != 0);
        }

        public static void Show(string text)
        {
            Console.WriteLine(text);
        }

        public static void ToUpper(string text)
        {
            foreach(char ch in  text)
            {
                Console.Write(char.ToUpper(ch));
            }
        }

        public static void ToLower(string text)
        {
            foreach (char ch in text)
            {
                Console.Write(char.ToLower(ch));
            }
        }

        public static void DistinctWords(string text)
        {
            string[] arr = text.Split(' ', ',', '.', ';', ':', '-');
            string[] words = arr.Distinct().ToArray();
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
