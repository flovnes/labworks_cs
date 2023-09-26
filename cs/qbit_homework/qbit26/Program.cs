#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        double cm = double.Parse(Console.ReadLine());
        double mm = double.Parse(Console.ReadLine());

        System.Console.WriteLine("{0}", Math.Ceiling(cm*10.0/mm));
    }
}