#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        string[] data = Console.ReadLine().Trim().Split();

        double point1_x = double.Parse(data[0]);
        double point1_y = double.Parse(data[1]);
        double point2_x = double.Parse(data[2]);
        double point2_y = double.Parse(data[3]);

        System.Console.WriteLine("{0:0.####}", Math.Sqrt(Math.Pow(point1_x-point2_x, 2.0) + Math.Pow((point1_y-point2_y), 2.0)));
    }
}