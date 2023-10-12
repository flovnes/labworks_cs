using System;
class Program { 
    static void Main(string[] args) {
        int year_num = int.Parse(Console.ReadLine());
        int next_leap = (year_num|3)+1;
        if (year_num%4==0 && (year_num%100!=0 || year_num%400==0)) {
            Console.WriteLine($"YES");  
            if (next_leap%100 == 0 && next_leap%400 != 0) {
                Console.WriteLine($"{next_leap+4}");
            } else {
                Console.WriteLine($"{next_leap}");
            }      
        } else {
            Console.WriteLine($"NO");    
            if (next_leap%100 == 0 && next_leap%400 != 0) {
                Console.WriteLine($"{next_leap+4}");
            } else {
                Console.WriteLine($"{next_leap}");
            }      
        }  
    }
}