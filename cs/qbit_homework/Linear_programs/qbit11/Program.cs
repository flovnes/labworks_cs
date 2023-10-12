#nullable disable
using System;

class Program { 
    static void Main(string[] args) {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        string team1 =  Console.ReadLine();
        string team1_score = Console.ReadLine();
        string team2 =  Console.ReadLine();
        string team2_score = Console.ReadLine();

        double spaces_needed = 12 - team1.Length;
        string spaces = " ";
        for (int i = 1; i < spaces_needed; i++)
        {
            spaces += " ";
        }

        System.Console.WriteLine("{0}{1} : {2}", spaces, team1, team2);
        spaces_needed = 12 - team1_score.Length;
        spaces = " ";
        for (int i = 1; i < spaces_needed; i++)
        {
            spaces += " ";
        }
        System.Console.WriteLine("{0}{1} : {2}", spaces, team1_score, team2_score);
    }
}