#nullable disable
using System;
using System.Linq;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        var data = new string[12];
        for (var i = 0; i < 6; i++) {
            string[] input = System.Console.ReadLine().Trim().Split();
            input.CopyTo(data,i*2);
        }
        double x1 = double.Parse(data[10]);
        double x2 = double.Parse(data[11]);
        for (var i = 0; i < 5; i++) {
            double x = double.Parse(data[i*2]);
            if (x>=x1 && x<=x2) 
            { System.Console.WriteLine($"YES"); }
            else 
            { System.Console.WriteLine($"NO"); }
        }
    }
}