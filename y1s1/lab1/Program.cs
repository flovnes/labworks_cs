using System;
using System.Text;
using System.Globalization;

#nullable disable
        
namespace LabOne {
    class Program {
        static void problem1() {
            float height = float.Parse(Console.ReadLine());
            System.Console.WriteLine($"{Math.Sqrt(2.0*height/9.81)}");
        }
        static void problem2() {
            float input = float.Parse(Console.ReadLine());
            System.Console.WriteLine($"{Math.Acos(input+Math.Pow(input,2))}");
        }
        static void problem3() {
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
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            int choice;
            do {
                Console.WriteLine("Для виконання блоку 1 введіть 1.");
                Console.WriteLine("Для виконання блоку 2 введіть 2.");
                Console.WriteLine("Для виконання блоку 3 введіть 3.");
                Console.WriteLine("Для виходу з програми введіть 0.");
                Console.WriteLine();
                choice = int.Parse(Console.ReadLine());
                switch (choice) {
                    case 1: problem1();
                        break;
                    case 2: problem2();
                        break;
                    case 3: problem3();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Команда ``{0}`` не розпізнана.", choice);
                        break;
                }
            } while (choice != 0);
        }
    }
}