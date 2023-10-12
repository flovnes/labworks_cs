#nullable disable
using System;
class Program { 
    static void Main(string[] args) {
        for (var i = 0; i < 5; i++) {
            int uncompleted_conditions = 0;

            int input_number = int.Parse(Console.ReadLine());

            if (input_number>=0) {
                 uncompleted_conditions++; 
            }
            
            if (input_number > 100) {
            int last_digit = input_number%10;
            int penultimate_digit = input_number/10%10;

            if (last_digit == 0 || penultimate_digit != 0) {
                uncompleted_conditions++; 
            }     
            }

            if (input_number%3==0 || input_number%5==0) {
                 uncompleted_conditions++;
            }

            if (uncompleted_conditions == 1) {
                Console.WriteLine($"YES");
            }
            else {
                Console.WriteLine($"NO");
            } 
        }
    }
}
