#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        int total = int.Parse(Console.ReadLine())%86400;

        System.Console.WriteLine("{0:0#}:{1:0#}:{2:0#}", total/3600%24, (total%3600)/60, (total%3600)%60);
    }
}