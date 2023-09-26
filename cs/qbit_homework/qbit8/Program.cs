#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        string[] data = Console.ReadLine().Trim().Split();

        double a = double.Parse(data[0]);
        double b = double.Parse(data[1]);
        double c = double.Parse(data[2]);

        data = Console.ReadLine().Trim().Split();
        double l = double.Parse(data[0]);
        double w = double.Parse(data[1]);

        double area = 0.85*(2.0*(b*c+a*c)+a*b);
        double roll_area = l*w/1000000;

        System.Console.WriteLine("{0:0.####}", Math.Ceiling(1.1*area/roll_area));
    }
}