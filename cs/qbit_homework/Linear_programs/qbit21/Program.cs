#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string[] data = Console.ReadLine().Trim().Split();
        int hrs = int.Parse(data[0]);
        int mns = int.Parse(data[1]);
        int scs = int.Parse(data[2]);
        data = Console.ReadLine().Trim().Split();
        int hrs_other = int.Parse(data[0]);
        int mns_other = int.Parse(data[1]);
        int scs_other = int.Parse(data[2]);

        int total = hrs*3600 + mns*60 + scs;
        int total_other = hrs_other*3600 + mns_other*60 + scs_other;
        int difference = Math.Abs(total-total_other);

        System.Console.WriteLine("{0} {1} {2}", difference/3600%24, (difference%3600)/60, (difference%3600)%60);
    }
}