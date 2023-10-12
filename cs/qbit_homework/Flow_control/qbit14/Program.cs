using System;
class Program { 
    static void Main(string[] args) {
        for (var i = 0; i < 5; i++) {
            int result = 0;
            int input_number = int.Parse(Console.ReadLine());
            if (condition_1(Math.Abs(input_number))) { result++; }
            if (condition_2(Math.Abs(input_number))) { result++; }
            if (condition_3(Math.Abs(input_number))) { result++; }
            if (result == 1) {
                Console.WriteLine($"YES");
            } else {
                Console.WriteLine($"NO");
            }
        }
    }
    static bool condition_1(int num) {
        int[] values = new int[4] { num/1000%10, num/100%10, num/10%10, num%10 };
            return ((values[0] != values[1] && values[0] != values[2] && values[0] != values[3] &&
                    values[1] != values[2] && values[1] != values[3] &&
                    values[2] != values[3]) &&
                    count_period(num) == 4);
    }
    static bool condition_2(int num) {
        return (num%10 == 3 || num%10 == 6 || num%10 == 9);
    }
    static bool condition_3(int num) {
        int[] values = new int[2] { num/10%10, num%10 };
        return ((values[0] == 0 || values[1] == 0) && count_period(num) == 3);
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