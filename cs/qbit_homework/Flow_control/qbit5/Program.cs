#nullable disable
using System;
class Program { 
    static void Main(string[] args) {
            string[] data = Console.ReadLine().Trim().Split();
            double a = double.Parse(data[0]);
            double b = double.Parse(data[1]);
            double c = double.Parse(data[2]);
            double p = (a+b+c)/2;
            if ( a*a+b*b!=c*c) 
            { System.Console.WriteLine($"{2.0*p}"); }
            else
            { System.Console.WriteLine($"{Math.Sqrt(p*(p-a)*(p-b)*(p-c))}"); }
    }
}