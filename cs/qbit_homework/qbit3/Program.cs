#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        int radius = int.Parse(Console.ReadLine());
        System.Console.WriteLine("{0:0.####}", Math.PI*Math.Pow((radius),2));
        System.Console.WriteLine("{0:0.####}", 2.0*Math.PI*radius);
    }
}