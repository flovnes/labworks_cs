using System;
class Program { 
    static void Main(string[] args) {
        for (var i = 0; i < 5; i++) {
            long completed_conditions = 0;
            long input_number = long.Parse(Console.ReadLine());
            if (count_period(Math.Abs(input_number))==3) { completed_conditions++; }
            if (Math.Abs(input_number)%2==0 && input_number<0) { completed_conditions++; }
            if (Math.Abs(input_number)%3==0 && Math.Abs(input_number)%5!=0) { completed_conditions++; }
            if (completed_conditions == 0) {
                Console.WriteLine($"YES");
            } else {
                Console.WriteLine($"NO");
            }
        }
    }
    
    static long count_period(long num) {
    	long count = 1;
    	while (num>=10) {
	    	num = num / 10;
	    	count++;
    	}
    	return count;
    }
}