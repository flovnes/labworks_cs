#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string num_one = Console.ReadLine();
        string num_two = Console.ReadLine();
        int sum = int.Parse(num_one) + int.Parse(num_two);

        System.Console.WriteLine("{0}{1}", Spaces(num_one), num_one);
        System.Console.WriteLine("{0}{1}", Spaces(num_two), num_two);
        System.Console.WriteLine("##########");
        System.Console.WriteLine("{0}{1}", Spaces(sum.ToString()), sum);
    }
    static string Spaces(string line) {
        double spaces_needed = 10 - line.Length;
        string spaces = "";
        for (int i = 0; i < spaces_needed; i++)
        {
            spaces += " ";
        }
        return spaces;
    }
}

