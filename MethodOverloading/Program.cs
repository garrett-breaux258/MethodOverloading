using System;

namespace MethodOverloading
{
    class Program
    {
        public int add (int x, int y)
        {
            return x + y;
        }

        public double add (double x, double y)
        {
            return x + y;

        }

        public string add (int x, int y, bool isDollars)
        {
            var sum = x + y;
            if (isDollars==true && sum <=1)
            {
                return $"You have {sum} dollar";
            }
            else if (isDollars==true && sum>1)
            {
                return $"You have {sum} dollars";
            }
            else
            {
                return sum.ToString();
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Change is weird");
        }
    }
}
