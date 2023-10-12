using System;
class Program { 
    static void Main(string[] args) {
        int input_number = int.Parse(Console.ReadLine());
        if (input_number <= 0) {
            Console.WriteLine($"NO");
            Console.WriteLine($"2");            
        } else {
            if (input_number%2==0) {
                Console.WriteLine($"YES");
            } else {
                Console.WriteLine($"NO");
            }
            Console.WriteLine($"{(input_number|1)+1}");
        }
    }
}