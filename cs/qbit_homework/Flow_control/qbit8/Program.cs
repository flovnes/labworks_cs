#nullable disable
using System;
using System.Linq;
class Program {
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        var data = new string[14];
        for (var i = 0; i < 6; i++) {
            string[] input = System.Console.ReadLine().Trim().Split();
            input.CopyTo(data,i*2);
        }
        double x1 = double.Parse(data[10]);
        double y1 = double.Parse(data[11]);
        double x2 = double.Parse(data[12]);
        double y2 = double.Parse(data[13]);
        for (var i = 0; i < 5; i++) {
            double x = double.Parse(data[i*2]);
            double y = double.Parse(data[i*2+1]);

            if (x>=x2 && x<=x1 && y>=y2 && y<=y1) 
            { System.Console.WriteLine($"YES"); }
            else 
            { System.Console.WriteLine($"NO"); }
        }
    }
}