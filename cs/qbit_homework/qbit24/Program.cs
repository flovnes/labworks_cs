#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string[] data = Console.ReadLine().Trim().Split();

        int yearday = int.Parse(data[0]);
        int weekday = int.Parse(data[1]);
        int result = 0;
        if ((yearday + weekday - 1)%7 == 0) {
            result = 7;
        } else {
            result = (yearday + weekday - 1)%7;
        }

        System.Console.WriteLine("{0}", result);
    }
}