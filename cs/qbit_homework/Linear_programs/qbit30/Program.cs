#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        double deg = double.Parse(Console.ReadLine());
    
        System.Console.WriteLine("{0} {1}", Math.Floor(deg/30.0), Math.Floor(deg%30.0*2.0));
    }
}
