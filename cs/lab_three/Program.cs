using System.Text;
using System.Globalization;

#nullable disable
        
namespace LabTwo {
    class Program {
        static double TriangleArea(int Bx, int By, int Cx, int Cy) {
            return(Math.Abs(Bx*Cy-Bx*Cy)/2.0); 
        }
        static void FindSmallestArea(int ref Cx, int ref Cy, int ref minArea) {
            string[] input = System.Console.ReadLine().Trim().Split();
            int start = Math.Min(0, Math.Min(Bx,By)); // min(A(0,0) B(x,y))
            int end = Math.Max(0, Math.Max(Bx,By));
            int Bx = input[0], By = input[1];

            Console.WriteLine($"Точка B = ({Bx};{By})");
            
            for (int x = start; x < end; x++)
            {
                for (int y = start; y < end; y++)
                {
                    if (Math.Abs(Cx*By/Bx - Cy) <= 2) {
                        double curArea = triangle_area(Bx,By,x,y);
                        if (curArea < minArea && curArea > 0.0) { minArea = curArea; Cx = x; Cy = y;}
                    }
                }
            }
        }
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");            
            Console.WriteLine("Точка A = (0;0). Введіть точку B: (_;_)");
            double minArea = double::MAX;
            int Cx = 0, Cy = 0;
            FindSmallestArea(ref Cx, ref Cy, ref minArea);
            Console.WriteLine($"Найменша площа трикутника ABC дорівнює {minArea:0.01} одиниць квадратних з точками A(0;0) B({Bx};{By}) C({Cx};{Cy})");
        }
    }
}