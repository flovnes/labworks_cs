#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string[] data = Console.ReadLine().Trim().Split();

        double a = double.Parse(data[0]);
        double b = double.Parse(data[1]);
        double c = double.Parse(data[2]);
        double t = double.Parse(data[3]);

        double area = 2.0*(a*b+b*c+a*c);

        System.Console.WriteLine("{0:0.####}", Math.Ceiling(area*t*0.1));
    }
}