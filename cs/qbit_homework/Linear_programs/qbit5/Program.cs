#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        string[] data = Console.ReadLine().Trim().Split();

        double a = double.Parse(data[0]);
        double b = double.Parse(data[1]);
        double c = double.Parse(data[2]);
        double p = (a + b + c)/2.0;

        System.Console.WriteLine("{0:0.####}", 2.0*Math.Sqrt(b*c*p*(p-a))/(b+c));
        System.Console.WriteLine("{0:0.####}", 2.0*Math.Sqrt(a*c*p*(p-b))/(a+c));
        System.Console.WriteLine("{0:0.####}", 2.0*Math.Sqrt(a*b*p*(p-c))/(a+b));
    }
}