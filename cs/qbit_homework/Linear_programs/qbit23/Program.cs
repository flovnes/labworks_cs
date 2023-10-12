#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        int day = int.Parse(Console.ReadLine());

        int result = 0;
        if ((day + 5)%7 == 0) {
            result = 7;
        } else {
            result = (day+5)%7;
        }

        System.Console.WriteLine("{0}", result);
    }
}