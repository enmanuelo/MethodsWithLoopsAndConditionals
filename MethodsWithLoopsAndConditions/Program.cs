using System;

namespace MethodsWithLoopsAndConditions
{
    class Program
    {
        public static void PrintThousand()
        {
            // vvv Long Way vvv

            //var numbers = new List<int>();
            //int num = -1000;

            //while (num <= 1000)
            //{
            //    numbers.Add(num);
            //    num++;
            //}

            //for (int i = 2000; i >= 0; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            // vv CCR vv

            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");
        }
        public static void PrintByThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
        }

        public static void AreEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("These two numbers are equal");
            }
            else
            {
                Console.WriteLine("Not equal!");
            }
        }
        public static void OddOrEven(int num)
        {
            // vv Long way vv
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("This number is even");
            //}
            //else
            //{
            //    Console.WriteLine("This number is odd");
            //}

            // vv CCR vv
            var answer = num % 2 == 0 ? "This number is even" : "This number is odd";
            Console.WriteLine(answer);
        }
        public static void PositiveOrNegative(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("This number is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("This number is negative");
            }
            else
            {
                Console.WriteLine("This number is zero");
            }
        }
        public static void ReadAge(int num)
        {
            if (num >= 18)
            {
                Console.WriteLine("Get to the voting booth!");
            }
            else
            {
                Console.WriteLine($"Try again in {18 - num} years");
            }
        }
        public static void InRange()
        {
            Console.WriteLine("Enter an integer");
            var num = int.Parse(Console.ReadLine());
            if (num >= -10 && num <= 10)
            {
                Console.WriteLine("This number is in the range -10 to 10");
            }
            else
            {
                Console.WriteLine("This number is out of range");
            }
        }
        public static void MultiplicationTable()
        {
            Console.WriteLine("Give an integer for multiplication table");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num}x{i} = {num * i}");
            }
        }

        static void Main(string[] args)
        {
            PrintThousand();
            PrintByThrees();
            AreEqual(4, 4);
            OddOrEven(123);
            PositiveOrNegative(1324);
            ReadAge(12);
            InRange();
            MultiplicationTable();
        }
    }
}

