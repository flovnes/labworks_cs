#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string[] data = Console.ReadLine().Trim().Split();
        int decavalue = int.Parse(data[0]);
        int value = int.Parse(data[1]);
        int quantity = int.Parse(data[2]);

        int total = quantity*(decavalue*100 + value);
        

        System.Console.WriteLine("{0} {1}", total/100, total%100);
    }
}