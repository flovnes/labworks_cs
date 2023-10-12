using System;
class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string[] data = Console.ReadLine().Trim().Split();
        Console.WriteLine($"{check_triangle(data)}");
    }
    
    static string check_triangle(string[] sides) {
        double a = double.Parse(sides[0]);
        double b = double.Parse(sides[1]);
        double c = double.Parse(sides[2]);
        if ( a<=0 || b<=0 || c<=0 ) {
            return "Incorrect data.";
        } 
        if ( a+b>c && a+c>b && b+c>a )  {
            int count = 0;
            if (a==b) { count++; }
            if (b==c) { count++; }
            if (a==c) { count++; }
            switch (count) {
                case 0: 
                    return "Sided triangle.";
                    break;
                case 1: 
                    return "Isosceles triangle.";
                    break;
                default:
                    return "Equilateral triangle.";
                    break;
            }
        }
        return "Triangle does not exist.";
    }
}