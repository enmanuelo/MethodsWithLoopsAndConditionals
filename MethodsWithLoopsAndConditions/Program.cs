using System;

namespace MethodsWithLoopsAndConditions
{
    class Program
    {
        public static void PrintAbsThousand()
        {
            var numbers = new List<int>();
            int num = -1000;

            while (num <= 1000)
            {
                numbers.Add(num);
                num++;
            }

            for (int i = 2000; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

        }
        public static void PrintByThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
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
            if (num % 2 == 0)
            {
                Console.WriteLine("This number is even");
            }
            else
            {
                Console.WriteLine("This number is odd");
            }
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
            Console.WriteLine($"{num}x1= {num*1}");
            Console.WriteLine($"{num}x2= {num * 2}");
            Console.WriteLine($"{num}x3= {num * 3}");
            Console.WriteLine($"{num}x4= {num * 4}");
            Console.WriteLine($"{num}x5= {num * 5}");
            Console.WriteLine($"{num}x6= {num * 6}");
            Console.WriteLine($"{num}x7= {num * 7}");
            Console.WriteLine($"{num}x8= {num * 8}");
            Console.WriteLine($"{num}x9= {num * 9}");
            Console.WriteLine($"{num}x10= {num * 10}");
            Console.WriteLine($"{num}x11= {num * 11}");
            Console.WriteLine($"{num}x12= {num * 12}");
        }

        static void Main(string[] args)
        {
            PrintAbsThousand();
            Console.WriteLine("");
            PrintByThrees();
            Console.WriteLine("");
            AreEqual(4, 4);
            OddOrEven(123);
            PositiveOrNegative(1324);
            ReadAge(12);
            InRange();
            MultiplicationTable();
        }
    }
}

