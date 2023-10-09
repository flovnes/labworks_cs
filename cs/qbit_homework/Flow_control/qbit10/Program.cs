#nullable disable
using System;
class Program {
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        var data = new string[8];
        for (var i = 0; i < 2; i++) {
            string[] input = System.Console.ReadLine().Trim().Split();
            input.CopyTo(data,i*4);
        }

        double r1_x1 = double.Parse(data[0]);
        double r1_y1 = double.Parse(data[1]);
        double r1_x2 = double.Parse(data[2]);
        double r1_y2 = double.Parse(data[3]);

        double r2_x1 = double.Parse(data[4]);
        double r2_y1 = double.Parse(data[5]);
        double r2_x2 = double.Parse(data[6]);
        double r2_y2 = double.Parse(data[7]);

        // fix idiot's input
        double r1_first_point_x = Math.Min(r1_x1, r1_x2);
        double r1_second_point_x = Math.Max(r1_x1, r1_x2);
        double r1_first_point_y = Math.Min(r1_y1, r1_y2);
        double r1_second_point_y = Math.Max(r1_y1, r1_y2);

        double r2_first_point_x = Math.Min(r2_x1, r2_x2);
        double r2_second_point_x = Math.Max(r2_x1, r2_x2);
        double r2_first_point_y = Math.Min(r2_y1, r2_y2);
        double r2_second_point_y = Math.Max(r2_y1, r2_y2);

        double x_overlap = Math.Max(0, Math.Min(r1_second_point_x, r2_second_point_x) - Math.Max(r1_first_point_x, r2_first_point_x));
        double y_overlap = Math.Max(0, Math.Min(r1_second_point_y, r2_second_point_y) - Math.Max(r1_first_point_y, r2_first_point_y));
        double overlapArea = x_overlap * y_overlap;

        System.Console.WriteLine($"{overlapArea}");
    }
}