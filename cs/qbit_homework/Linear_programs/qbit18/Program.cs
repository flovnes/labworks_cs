#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string[] data = Console.ReadLine().Trim().Split();
        int decavalue_price = int.Parse(data[0]);
        int value_price = int.Parse(data[1]);
        data = Console.ReadLine().Trim().Split();
        int decavalue = int.Parse(data[0]);
        int value = int.Parse(data[1]);


        int total_price = decavalue_price*100 + value_price;
        int quantity = (decavalue*100 + value)/total_price;
        int left = (decavalue*100 + value) - total_price*quantity;
        
        System.Console.WriteLine("{0}", quantity);
        System.Console.WriteLine("{0} {1}", left/100, left%100);
    }
}