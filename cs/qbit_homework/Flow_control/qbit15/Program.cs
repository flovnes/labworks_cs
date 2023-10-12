using System;
class Program { 
    static void Main(string[] args) {
        int input_number = int.Parse(Console.ReadLine());
        if (input_number%2==0) {
            System.Console.WriteLine("{0:0.####}", input_number*input_number);
        } else {
            System.Console.WriteLine("{0:0.####}", input_number-1);
        }
    }
}