#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        string[] data = Console.ReadLine().Trim().Split();

        double a = double.Parse(data[0]);
        double b = double.Parse(data[1]);
        double c = double.Parse(data[2]);

        System.Console.WriteLine("{0:0.####}", 0.5*Math.Sqrt(2.0*Math.Pow(b,2)+2.0*Math.Pow(c,2)-Math.Pow(a,2)));
        System.Console.WriteLine("{0:0.####}", 0.5*Math.Sqrt(2.0*Math.Pow(a,2)+2.0*Math.Pow(c,2)-Math.Pow(b,2)));
        System.Console.WriteLine("{0:0.####}", 0.5*Math.Sqrt(2.0*Math.Pow(a,2)+2.0*Math.Pow(b,2)-Math.Pow(c,2)));
    }
}