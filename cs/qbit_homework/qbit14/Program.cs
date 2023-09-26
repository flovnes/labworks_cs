#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string[] data = Console.ReadLine().Trim().Split();

        double hrs = double.Parse(data[0]);
        double min = double.Parse(data[1]);
        double sec = double.Parse(data[2]);

        double sum = hrs*30.0+min/2.0+sec/120.0;
        if (sum < 360.0) {
            System.Console.WriteLine("{0:0.####}", sum);
        } else {
            System.Console.WriteLine("{0:0.####}", sum-360.0);
        }
    }
}

