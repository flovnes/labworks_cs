#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        string[] data = Console.ReadLine().Trim().Split();
        int sum = 0;
        for (int i = 0; i<data.Length; i++) {sum += int.Parse(data[i]);}
        System.Console.WriteLine("{0}", 15-sum);
    }
}