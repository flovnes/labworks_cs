using System;

namespace homework_two
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            bool condition_one = Math.Pow(x, 2) + Math.Pow(y, 2) <= 4;
            bool condition_two = y <= 0 && x <= 0;
            bool condition_three = Math.Pow(x-2, 2) + Math.Pow(y-2, 2) <= 4;

            if (condition_one && condition_two) {
              System.Console.WriteLine("YES");
            } 
            else 
            if (condition_one && condition_three) {
              System.Console.WriteLine("YES");
            }
            else {
              System.Console.WriteLine("NO");
            }
        } 
    }
}