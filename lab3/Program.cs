using System.Text;
using System.Globalization;
class Program {
    static void Main(string[] args) {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");  

        Console.WriteLine("Точка A = (0;0). Введіть точку B: (_;_)");
        string[] input = System.Console.ReadLine().Trim().Split();
        int Bx = int.Parse(input[0]), By = int.Parse(input[1]);
        double minArea = Double.MaxValue;
        int Cx = 0, Cy = 0;
        FindSmallestArea(Bx, By, ref Cx, ref Cy, ref minArea);

        Console.WriteLine($"Точка B = ({Bx};{By})");
        Console.WriteLine($"Для B({Bx};{By}) найменша площа: '{minArea:0.0}' за C({Cx};{Cy})");
    }
    static double TriangleArea(int Bx, int By, int Cx, int Cy) {
        return Math.Abs(Bx*Cy-By*Cx)/2.0;
    }
    static void FindSmallestArea(int Bx, int By, ref int Cx, ref int Cy, ref double minArea) {
        int end = Math.Abs(Bx);
        int step = end/Bx;
        double ratio = (double)By/(double)Bx;
        for (int x = 0; Math.Abs(x) <= end; x += step) {
            int y = (int)Math.Floor(ratio * (double)x) + 1;
            double curArea = TriangleArea(Bx,By,x,y);
            if (curArea < minArea) { minArea = curArea; Cx = x; Cy = y; }
        }
    }
}