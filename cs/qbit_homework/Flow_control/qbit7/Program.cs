#nullable disable
using System;
using System.Linq;
class Program {
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        var data = new string[11];
        for (var i = 0; i < 6; i++) {
            string[] input = System.Console.ReadLine().Trim().Split();
            input.CopyTo(data,i*2);
        }
        double square_side = double.Parse(data[10]);
        for (var i = 0; i < 5; i++) {
            double x = double.Parse(data[i*2]);
            double y = double.Parse(data[i*2+1]);
            if (Math.Abs(x)+Math.Abs(y)+Math.Abs(Math.Abs(x)-Math.Abs(y))<=square_side) 
            { System.Console.WriteLine($"YES"); }
            else 
            { System.Console.WriteLine($"NO"); }
        }
    }
}