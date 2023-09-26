#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        
        string[] data = Console.ReadLine().Trim().Split();

        double v1 = double.Parse(data[0]);
        double v2 = double.Parse(data[1]);
        double v3 = double.Parse(data[2]);
        double v4 = double.Parse(data[3]);

        System.Console.WriteLine("{0:0.####}",  (v1+v2)/2.0);
        System.Console.WriteLine("{0:0.####}",  (2.0*v3*v4)/((v3+v4)));
    }
}