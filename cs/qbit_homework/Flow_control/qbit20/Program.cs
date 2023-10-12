using System;
class Program { 
    static void Main(string[] args) {
        int input_number = int.Parse(Console.ReadLine());
        if (count_period(input_number) == 3) {
            Console.WriteLine($"{input_number/100}");          
        } else {
            Console.WriteLine($"{input_number%10}");
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

