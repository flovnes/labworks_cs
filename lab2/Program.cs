using System.Text;
using System.Globalization;

#nullable disable
        
namespace LabTwo {
    class Program {
        static void block_1() {
            Console.WriteLine("[1 in ] Кількість елементів");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            Console.WriteLine("[1 in ] Введення елементів");
            for (int i = 0; i < n; i++) {
                int num = int.Parse(Console.ReadLine());
                if (num > 0) {
                    count++;
                } else if (num < 0) {
                    count--;
                }
            }
            if (count > 0) {
                Console.WriteLine("[1 out] Додатних чисел на {0} більше.", count);
                Console.WriteLine();
            } else if (count < 0) {
                Console.WriteLine("[1 out] Від'ємних чисел на {0} більше.", -count);
                Console.WriteLine();
            } else {
                Console.WriteLine("[1 out] Додатних і від'ємних чисел порівну.");
                Console.WriteLine();
            }
        }
        static void block_2() {
            int count = 0, num;
            Console.WriteLine("[2 in ] Введення елементів");
            while ((num = int.Parse(Console.ReadLine())) != 0) {
                if (num % 2 == 1) { count++; }
            }
            Console.WriteLine($"[2 out] Було введено {count} непарних чисел.");
            Console.WriteLine();       
        }
        static void block_3() {
            Console.WriteLine("[3 in ] Введення X");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("[3 in ] Введення N");
            int n = int.Parse(Console.ReadLine());
            double negative_if_divisible = Math.Pow(-1, 2 - ((n+2)%3/2));
            double current_sin = Math.Sin((n-1)*x + negative_if_divisible * Math.Sin(x*n));
            if (n > 1) {
                for (int i = n-2; i > 0; i--) {
                    negative_if_divisible = (int)Math.Pow(-1, 2 - (i%3/2));
                    current_sin = Math.Sin(i*x + negative_if_divisible * Math.Sin(current_sin));
                }
            }
            Console.WriteLine($"[3 out] {current_sin}");
            Console.WriteLine();
        }

        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            int choice;
            do {
                Console.WriteLine("Для виконання блоку 1 (Варіант 17) введіть 1.");
                Console.WriteLine("Для виконання блоку 2 (Варіант 29) введіть 2.");
                Console.WriteLine("Для виконання блоку 3 (Варіант 61) введіть 3.");
                Console.WriteLine("Для виходу з програми введіть 0.");
                Console.WriteLine();
                choice = int.Parse(Console.ReadLine());
                switch (choice) {
                    case 1: block_1();
                        break;
                    case 2: block_2();
                        break;
                    case 3: block_3();
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