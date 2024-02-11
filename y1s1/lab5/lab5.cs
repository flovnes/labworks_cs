using System.Text;
using System.Globalization;
using System.Diagnostics.Metrics;

#nullable disable

namespace LabOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            int[] array;
            Console.WriteLine("Чи бажаєте ви заповнити масив вручну? (y/n): ");
            switch (Console.ReadLine())
            {
                case "y":
                case "Y":
                    Console.WriteLine($"Як ви бажаєте заповнити масив?\n1: \" 4\n     a\n     b\n     c\n     d \"\n\n2: \"a b c d\"\n\nОберіть (1/2): ");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            Console.WriteLine($"Введіть кількість елементів:");
                            array = inputArray(int.Parse(Console.ReadLine()));
                            printArray(array);
                            break;
                        default:
                            array = inputArray();
                            printArray(array);
                            break;
                    }
                    break;
                default:
                    Console.WriteLine($"Введіть кількість елементів:");
                    array = randomArray(int.Parse(Console.ReadLine()));
                    printArray(array);
                    break;
            }
            float avg = solution(array);
            if (avg != 0) { Console.WriteLine($"Середнє арифметичне: {avg}"); }
            else
            {
              Console.WriteLine($"Виділений діапазон пустий");
            }
            Console.WriteLine($"{solution(array)}");
            Console.WriteLine($"PopBalloons input:");
            // string result = PopBalloonsCasual(Console.ReadLine().Trim());
            // Console.WriteLine($"pop casual = \"{result}\"");
            string result = PopBalloons(Console.ReadLine().Trim());
            Console.WriteLine($"pop = \"{result}\"");
        }
        static int[] randomArray(int size)
        {
            Random numGen = new();
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = numGen.Next() % 200 - 100;
            }
            return result;
        }
        static int[] inputArray(int size)
        {
            Console.WriteLine($"Введіть {size} елементів:");
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        static int[] inputArray()
        {
            Console.WriteLine($"Введіть елементи:");
            string[] input = Console.ReadLine().Trim().Split();
            int[] result = new int[input.Length];
            for (int i = 0; i < result.Length; i++)
            {
                if (int.TryParse(input[i], out int q)) { result[i] = q; }
                else { return []; }
            }
            return result;
        }
        static void printArray(int[] array)
        {
            Console.Write(value: $"Твій масив: \" ");
            foreach (int el in array)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine($"\"");
        }
        static float solution(int[] array)
        {
            int aqqum = 0, max = 0, min = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > array[max]) { max = i; }
                if (array[i] < array[min]) { min = i; }
            }
            if (max < min) { (min, max) = (max, min); }

            Console.WriteLine($"Найбільший елемент: {array[max]}");
            Console.WriteLine($"Найменший елемент: {array[min]}");
            if (max-min>2) {
              Console.Write($"Виділені елементи: \" ");
              for (int i = min + 1; i < max; i++)
              {
                  Console.Write($"{array[i]} ");
                  aqqum += array[i];
              }
              Console.WriteLine($"\"");
            } else {
              return 0;
            }

            return (float)aqqum / (max - min + 1);
        }
        // static string PopBalloonsCasual(string balloons) {
        //   do {
        //     for (int i = 0, j = i; i < balloons.Length; i++)
        //     {
        //       int count = 0;
        //       while(j<balloons.Length && balloons[i]==balloons[j]) {count++; j++;}
        //       if (count>=3) {
        //         balloons = balloons.Substring(0, i) + balloons.Substring(j);
        //       }
        //     }
        //   } while (!check(balloons));
        //    return balloons;
        // }
        // static bool check(string balloons) {
        //   for (int i = 0, j = i; i < balloons.Length; i++)
        //   {
        //     int count = 0;
        //     while(j<balloons.Length && balloons[i]==balloons[j]) {count++; j++;}
        //     if (count>=3) {
        //       return false;
        //     }
        //   }
        //   return true;
        // }
        static string PopBalloons(string balloons) {
          int prev = 0;
          for (int start = 0; start < balloons.Length; start++)
          {
            int cur = start, count = 0;
            while(cur < balloons.Length && balloons[start]==balloons[cur]) {count++; cur++;}
            if (count>=3) {
              System.Console.WriteLine($"deleted {balloons.Substring(start, cur-start)}");
              balloons = balloons.Substring(0, start) + balloons.Substring(cur);
              System.Console.WriteLine($"current {balloons}");
              if (start - 1 >= 0) {
                System.Console.WriteLine($"moved Start from {start} to {start-1}");
                cur = start;
                do { cur--; } while (cur > 0 && balloons[start] == balloons[cur]);
                start = cur;
              }
            }
          }
          return balloons;
        }
    }
}
