#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        int height = int.Parse(Console.ReadLine());
        int cur_height = 0;
        int up = int.Parse(Console.ReadLine());
        int down = int.Parse(Console.ReadLine());

        int count = 0;
        while (true) {
            cur_height += up;
            if (cur_height >= height) {
                count++;
                break;
            } else {
                cur_height -= down;
            }
            count++;
        }
        System.Console.WriteLine("{0}", count);
    }
}