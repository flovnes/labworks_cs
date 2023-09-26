﻿#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string[] data = Console.ReadLine().Trim().Split();
        int hrs = int.Parse(data[0]);
        int mns = int.Parse(data[1]);
        int scs = int.Parse(data[2]);

        int total = hrs*3600 + mns*60 + scs;

        System.Console.WriteLine("{0} {1} {2}",(total+1)/3600%24, ((total+1)%3600)/60, ((total+1)%3600)%60);
    }
}