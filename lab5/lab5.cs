using System.Text;
using System.Globalization;

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
                            Console.WriteLine($"Введіть кількість елементів:");
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
            Console.WriteLine($"{solution(array)}");
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
        static int solution(int[] array)
        {
            int aqqum = 0, max = 0, min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= array[max]) { max = i; }
                if (array[i] <= array[min]) { min = i; }
            }
            if (max < min) { (min, max) = (max, min); }
            Console.Write($"Виділені елементи: \" ");
            for (int i = min; i <= max; i++)
            {
                Console.Write($"{array[i]} ");
                aqqum += array[i];
            }
            Console.WriteLine($"\"");

            return aqqum;
        }
    }
}