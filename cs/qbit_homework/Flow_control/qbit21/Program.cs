using System;
class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        double input_number = Math.Abs(double.Parse(Console.ReadLine()));
        if (input_number == Math.Floor(input_number)) {
            Console.WriteLine($"{digit_sum((int)input_number)}");          
        } else {
            Console.WriteLine($"{Math.Sqrt(input_number)}");
        }
    }
    static int digit_sum(int num) {
        int sum = 0;
        while (num>0) {
            sum += num%10;
            num /= 10;
        }
        return sum;
    }
}