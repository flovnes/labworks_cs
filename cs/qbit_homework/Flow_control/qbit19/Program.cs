using System;
class Program { 
    static void Main(string[] args) {
        for (var i = 0; i < 5; i++) {
            int input_number = int.Parse(Console.ReadLine());
            if (input_number%2==-1 && input_number<0) {
                Console.WriteLine($"YES");
            } else {
                Console.WriteLine($"NO");
            }
        }
    }
}