#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        
        string[] data = Console.ReadLine().Trim().Split();

        double p = double.Parse(data[0]);
        double a = double.Parse(data[1]);
        double b = double.Parse(data[2]);
        double ratio = a/b;

        System.Console.WriteLine("{0:0.####}", (ratio*p*p)/(4.0*ratio*ratio+8.0*ratio+4.0));
    }
}