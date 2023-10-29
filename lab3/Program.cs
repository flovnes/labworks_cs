using System.Text;
using System.Globalization;
#nullable disable
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
        if (Bx > 0) {
            for (int x = 1; x < Bx/2; x++)
            {
                int y = (int)Math.Floor((double)By/(double)Bx*(double)x)+1;
                double curArea = TriangleArea(Bx,By,x,y);
                if (curArea < minArea) { minArea = curArea; Cx = x; Cy = y;}
            }
        } else {
            for (int x = Bx/2; x--> 1;)
            {
                int y = (int)Math.Floor((double)By/(double)Bx*(double)x)+1;
                double curArea = TriangleArea(Bx,By,x,y);
                if (curArea < minArea) { minArea = curArea; Cx = x; Cy = y;}
            }
        }

    }
}