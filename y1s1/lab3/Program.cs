using System.Text;
using System.Globalization;

#nullable disable

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        Console.WriteLine("Точка A = (0;0). Введіть точку B: (_;_)");
        string[] input = System.Console.ReadLine().Trim().Split();
        long Bx = long.Parse(input[0]), By = long.Parse(input[1]);
        double minArea = Double.MaxValue;
        long Cx = 0, Cy = 0;
        FindSmallestArea(Bx, By, ref Cx, ref Cy, ref minArea);

        Console.WriteLine($"Точка B = ({Bx};{By})");
        Console.WriteLine($"Для B({Bx};{By}) найменша площа: '{minArea:0.0}' за C({Cx};{Cy})");
    }
    static double TriangleArea(long Bx, long By, long Cx, long Cy)
    {
        return Math.Abs(Bx * Cy - By * Cx) / 2.0;
    }
    static void FindSmallestArea(long Bx, long By, ref long Cx, ref long Cy, ref double minArea)
    {
        long end = Math.Abs(Bx);
        long step = end / Bx;
        double ratio = (double)By / (double)Bx;
        long x = 0;
        while (Math.Abs(x) <= end)
        {
            long y = (long)Math.Floor(ratio * (double)x) + 1;
            double curArea = TriangleArea(Bx, By, x, y);
            if (curArea < minArea) { minArea = curArea; Cx = x; Cy = y; }
            x += step;
        }
    }
}