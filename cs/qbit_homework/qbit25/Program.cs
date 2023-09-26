#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string[] data = Console.ReadLine().Trim().Split();

        int div = int.Parse(data[0]);
        int mod = int.Parse(data[1]);

        System.Console.WriteLine("{0} {1}", (mod+div*37)/23, (mod+div*37)%23);
    }
}