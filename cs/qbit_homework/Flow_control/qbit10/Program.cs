using System;
class Program {
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string[] input1 = System.Console.ReadLine().Trim().Split();
        string[] input2 = System.Console.ReadLine().Trim().Split();

        double x1 = double.Parse(input1[0]);
        double y1 = double.Parse(input1[1]);
        double x2 = double.Parse(input1[2]);
        double y2 = double.Parse(input1[3]);
        double x3 = double.Parse(input2[0]);
        double y3 = double.Parse(input2[1]);
        double x4 = double.Parse(input2[2]);
        double y4 = double.Parse(input2[3]);

        double rect1_x_left = Math.Min(x1, x2);
        double rect1_x_right = Math.Max(x1, x2);
        double rect2_x_left = Math.Min(x3, x4);
        double rect2_x_right = Math.Max(x3, x4);
        double rect1_y_left = Math.Min(y1, y2);
        double rect1_y_right = Math.Max(y1, y2);
        double rect2_y_left = Math.Min(y3, y4);
        double rect2_y_right = Math.Max(y3, y4);

        x = min(rect1_x_right, rect2_x_right) - max(rect1_x_left, rect2_x_left)
        if x < 0 {
            x = 0
        }
        y = min(rect1_y_right, rect2_y_right) - max(rect1_y_left, rect2_y_left)
        if y < 0 {
            y = 0
        }
        double overlapArea = x * y;

        System.Console.WriteLine($"{overlapArea}");
    }
}