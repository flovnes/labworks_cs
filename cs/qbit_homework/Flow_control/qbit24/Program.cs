using System;
class Program { 
    static void Main(string[] args) {
        for (var i = 0; i < 5; i++) {
            int result = 0;
            int input_number = int.Parse(Console.ReadLine());         
            if (Math.Abs(input_number)%2==1 || (input_number>0 && count_period(input_number) == 3)) {
            Console.WriteLine($"YES");
            } else { 
            Console.WriteLine($"NO");
            }  
        }
    }
    
    static int count_period(int num) {
    	int count = 1;
    	while (num>=10) {
	    	num = num / 10;
	    	count++;
    	}
    	return count;
    }
}