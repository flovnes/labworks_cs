#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string[] data = Console.ReadLine().Trim().Split();

        int start_value = int.Parse(data[0]);
        int div = int.Parse(data[1]);
        int result = 0;

        if ((div - start_value % div) == div || start_value == 0) {
            result = start_value;
        } else {
            if (start_value > 0) {
                result = start_value + (div - start_value % div);
            } else {
                result = start_value + Math.Abs(start_value % div);
            }   
        }

        System.Console.WriteLine("{0}", result);
    }
}
