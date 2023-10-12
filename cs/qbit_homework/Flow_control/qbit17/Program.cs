using System;
class Program { 
    static void Main(string[] args) {
        for (var i = 0; i < 5; i++) {
            int input_number = int.Parse(Console.ReadLine());
            if (input_number/100 != input_number/10%10 && input_number/10%10 != input_number%10 && input_number/100 != input_number%10) {
                Console.WriteLine($"YES");
            } else {
                Console.WriteLine($"NO");
            }
        }
    }
}