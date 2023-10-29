using System.Text;
using System.Globalization;

#nullable disable
        
namespace LabTwo {
    class Program {
        static double TriangleArea(int Bx, int By, int Cx, int Cy) {
            double area = Math.Abs(Bx*Cy-By*Cx)/2.0; 
            // Console.WriteLine($"C({Cx};{Cy}) > площа: {area:0.0}");
            return area;
        }
        static void FindSmallestArea(int Bx, int By, ref int Cx, ref int Cy, ref double minArea) {
            int start = Math.Min(0, Math.Min(Bx,By)); // min(A(0,0) B(x,y))
            int end = Math.Max(0, Math.Max(Bx,By));
            for (int x = start; x < end; x++)
            {
                for (int y = start; y < end; y++)
                {
                    if (Math.Abs(x*By/Bx - y) <= 2) {
                        double curArea = TriangleArea(Bx,By,x,y);
                        
                        if (curArea < minArea && curArea > 0.0) { minArea = curArea; Cx = x; Cy = y;}
                    }
                }
            }
        }
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");            
            Console.WriteLine("Точка A = (0;0). Введіть точку B: (_;_)");
            string[] input = System.Console.ReadLine().Trim().Split();
            int Bx = int.Parse(input[0]), By = int.Parse(input[1]);
            Console.WriteLine($"Точка B = ({Bx};{By})");
            double minArea = Double.MaxValue;
            int Cx = 0, Cy = 0;
            FindSmallestArea(Bx, By, ref Cx, ref Cy, ref minArea);
            Console.WriteLine($"Для B({Bx};{By}) найменша площа: '{minArea:0.0}' за C({Cx};{Cy})");
        }
    }
}