#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string[] data = Console.ReadLine().Trim().Split();
        double marbles = double.Parse(data[0]);
        double icicles = double.Parse(data[1]);

        System.Console.WriteLine("{0}", Math.Ceiling(marbles/3.0)+Math.Ceiling(icicles/4.0));
    }
}