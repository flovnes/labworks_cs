#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        double book = double.Parse(Console.ReadLine());
        double pages = double.Parse(Console.ReadLine());

        System.Console.WriteLine("{0}", Math.Ceiling(book/(pages+pages/3)));
    }
}