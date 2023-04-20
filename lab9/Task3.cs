using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Task3
    {
        public static void Run()
        {
            int num, choice;
            Predicate<int> Is;
            Console.Write("Enter number: ");
            int.TryParse(Console.ReadLine(), out num);
            do
            {
                Console.WriteLine("Enter what to do(1 - show number, 2 - check IsEven, 3 - check IsOdd, 4 - check IsSimple, 5 - check IsFibonacci):");
                int.TryParse(Console.ReadLine(), out  choice);
                switch(choice)
                {
                    case 1:
                        Is = null;
                        break;
                    case 2:
                        Is = IsEven;
                        break;
                    case 3:
                        Is = IsOdd;
                        break;
                    case 4:
                        Is = IsSimple;
                        break;
                    case 5:
                        Is = IsFibonacci;
                        break;
                    default:
                        Is = null;
                        break;
                }
                if (Is == null)
                {
                    Console.WriteLine($"Your number: {num}");
                }
                else
                {
                    Console.WriteLine($"Result: {Is(num)}");
                }
            } while (choice != 0);
        }

        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        public static bool IsOdd(int num)
        {
            return num % 2 == 1;
        }
        public static bool IsSimple(int num)
        {
            byte div = 0;
            for (int i = 1; i < Math.Sqrt(num) && div <= 2; i++) 
            {
                if (num % i == 0)
                    div++;
            }
            return div <= 2;
        }
        public static bool IsFibonacci(int num)
        {
            uint a = 0, b = 1, c = 1, tmp;
            while (a < num)
            {
                tmp = b + c;
                a = b;
                b = c;
                c = tmp;
            }
            return num == a;
        }
    }
}
