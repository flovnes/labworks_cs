#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string[] data = Console.ReadLine().Trim().Split();

        int cages = int.Parse(data[0]);
        int rabbits = int.Parse(data[1]);
        int result = 0;

        if (rabbits%cages > 0) {
            result = rabbits/cages+1;
        } else {
            result = rabbits/cages;
        }

        System.Console.WriteLine("{0}", result);
    }
}
