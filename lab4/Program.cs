using System;
using System.Text;
using System.Diagnostics;
using System.Text.RegularExpressions;

class lab4
{
    static void Main()
    {
        FormatString();
    }
    static void Forward() {
        var sw = new Stopwatch();
        Console.Write("Введіть n: ");
        int end = int.Parse(Console.ReadLine());
        string str = new string(new char[]{});

        sw.Start();
        for (int i = 1; i <= end; i++) {str += (i + " ");}
        sw.Stop();
        // Console.WriteLine(str);
        Console.WriteLine($"Completed \"Forward()\" for N = {end} in {sw.ElapsedMilliseconds}ms");
    }

    static void Backwards() {
        var sw = new Stopwatch();
        Console.Write("Введіть n: ");
        int end = int.Parse(Console.ReadLine());
        string str = new string(new char[]{});

        sw.Start();
        for (int i = end; i >= 1; i--) {str = i + " " + str;}
        sw.Stop();
        // Console.WriteLine(str);
        Console.WriteLine($"Completed \"Backwards()\" for N = {end} in {sw.ElapsedMilliseconds}ms");
    }

        static void ForwardBuilder() {
        var sw = new Stopwatch();
        Console.Write("Введіть n: ");
        int end = int.Parse(Console.ReadLine());
        StringBuilder str = new StringBuilder();

        sw.Start();
        for (int i = 1; i <= end; i++) {str.Append($"{i} ");}
        sw.Stop();
        // Console.WriteLine(str);
        Console.WriteLine($"Completed \"ForwardBuilder()\" for N = {end} in {sw.ElapsedMilliseconds}ms");
    }

    static void BackwardsBuilder() {
        var sw = new Stopwatch();
        Console.Write("Введіть n: ");
        int end = int.Parse(Console.ReadLine());
        StringBuilder str = new StringBuilder();

        sw.Start();
        for (int i = end; i >= 1; i--) {str.Append($"{i} ");}
        sw.Stop();
        // Console.WriteLine(str);
        Console.WriteLine($"Completed \"BackwardsBuilder()\" for N = {end} in {sw.ElapsedMilliseconds}ms");
    }

    static void FormatString() {
        Console.Write("Введіть рядок: ");
        string str = Console.ReadLine();
        StringBuilder result_letters = new StringBuilder();
        StringBuilder result_numbers = new StringBuilder();
        foreach (char letter in str) {
                if (Char.ToLower(letter) >= 'a' && Char.ToLower(letter) <= 'z') {result_letters.Append(letter);}
                if (letter >= '0' && letter <= '9') {result_numbers.Append(letter);}
        }
        Console.WriteLine(result_letters.Append(result_numbers));
    }
}