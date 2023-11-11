using System;
using System.Text;
using System.Diagnostics;
using System.Text.RegularExpressions;

#nullable disable

class lab4
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть n: ");
        int num = int.Parse(Console.ReadLine());
        // Forward(num);
        // Backwards(num);
        ForwardBuilder(num);
        BackwardsBuilder(num);
        Console.WriteLine("Введіть рядок: ");
        FormatString(Console.ReadLine());
    }

    static void Forward(int num) {
        var sw = new Stopwatch();
        string str = new string(new char[]{});

        sw.Start();
        for (int i = 1; i <= num; i++) {str += (i + " ");}
        sw.Stop();
        // Console.WriteLine(str);
        Console.WriteLine($"Completed \"Forward()\" for N = {num} in {sw.ElapsedMilliseconds}ms");
    }

    static void Backwards(int num) {
        var sw = new Stopwatch();
        string str = new string(new char[]{});

        sw.Start();
        for (int i = num; i >= 1; i--) {str = i + " " + str;}
        sw.Stop();
        // Console.WriteLine(str);
        Console.WriteLine($"Completed \"Backwards()\" for N = {num} in {sw.ElapsedMilliseconds}ms");
    }

    static void ForwardBuilder(int num) {
        var sw = new Stopwatch();
        StringBuilder str = new StringBuilder();

        sw.Start();
        for (int i = 1; i <= num; i++) {str.Append($"{i} ");}
        sw.Stop();
        // Console.WriteLine(str);
        Console.WriteLine($"Completed \"ForwardBuilder()\" for N = {num} in {sw.ElapsedMilliseconds}ms");
    }

    static void BackwardsBuilder(int num) {
        var sw = new Stopwatch();
        StringBuilder str = new StringBuilder();

        sw.Start();
        for (int i = num; i >= 1; i--) {str.Append($"{i} ");}
        sw.Stop();
        // Console.WriteLine(str);
        Console.WriteLine($"Completed \"BackwardsBuilder()\" for N = {num} in {sw.ElapsedMilliseconds}ms");
    }

    static void FormatString(string str) {
        StringBuilder result_letters = new StringBuilder();
        StringBuilder result_numbers = new StringBuilder();
        foreach (char letter in str) {
                if (Char.ToLower(letter) >= 'a' && Char.ToLower(letter) <= 'z') {result_letters.Append(letter);}
                if (letter >= '0' && letter <= '9') {result_numbers.Append(letter);}
        }
        Console.WriteLine(result_letters.Append(result_numbers));
    }
}