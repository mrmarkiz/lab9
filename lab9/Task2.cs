using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public delegate double DelegateTask2(double a, double b);

    class Task2
    {
        public static void Run()
        {
            int choice, a, b;
            string[] input;
            DelegateTask2 operation;
            do
            {
                Console.Write("Enter numbers: ");
                input = Console.ReadLine().Split(' ');
                while (input.Length < 2)
                    input = input.Append("0").ToArray();
                int.TryParse(input[0], out a);
                int.TryParse(input[1], out b);
                Console.WriteLine("Enter what to do(1 - add, 2 - substract, 3 - multiply, 4 - divide): ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            operation = Add;
                            break;
                        case 2:
                            operation = Substract;
                            break;
                        case 3:
                            operation = Multiply;
                            break;
                        case 4:
                            operation = Divide;
                            break;
                        default:
                            operation = null;
                            break;
                    }
                    if (operation != null)
                        Console.WriteLine($"Result: {operation(a, b)}\n");
                    else
                        Console.WriteLine();
                }
            } while (choice != 0);
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Substract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return (double)a / b;
        }
    }
}
