#nullable disable
using System;
class Program { 
    static void Main(string[] args) {
        for (var i = 0; i < 5; i++) {
            int result = 0;
            int input_number = int.Parse(Console.ReadLine());
            if (input_number%3==0) { result++; }
            if (input_number%2==0 || input_number%5==0) { result--; }
            switch (result) {
                case 1: Console.WriteLine($"YES");
                    break;
                default: Console.WriteLine($"NO");
                    break;
            }  
        }
    }
}