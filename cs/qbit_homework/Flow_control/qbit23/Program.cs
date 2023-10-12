using System;
class Program { 
    static void Main(string[] args) {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine($"{Math.Pow(Math.Max(num1,Math.Max(num2,num3)),2)}");    
        Console.WriteLine($"{Math.Pow(Math.Min(num1,Math.Min(num2,num3)),2)}");             
    }
}