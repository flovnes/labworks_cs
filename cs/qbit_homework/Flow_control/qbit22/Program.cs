using System;
class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string[] input = System.Console.ReadLine().Trim().Split();
        int num1 = int.Parse(input[0]);
        int num2 = int.Parse(input[1]);
        if (num1>num2) {
            Console.WriteLine($"{num1*num1}");
            Console.WriteLine($"{num2*num2}");      
        } else {
            Console.WriteLine($"{num2*num2}");             
            Console.WriteLine($"{num1*num1}");
        }
    }
}

