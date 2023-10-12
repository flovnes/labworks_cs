#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        int quantity = int.Parse(Console.ReadLine());
        double molecules = quantity*249.5/3;
        double clone = molecules;
        int count = 0;
        while (clone >= 10) {
            clone /= 10;
            count++;
        }
        molecules = molecules / Math.Pow(10, count);
        count += 23;

        System.Console.WriteLine("{0} {1:0.###}e+{2}", quantity*4990, molecules, count);
    }
}

