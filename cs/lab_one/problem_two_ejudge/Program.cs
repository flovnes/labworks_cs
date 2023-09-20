using System;
class Program
{
    static void Main(string[] args)
    {
        float input = float.Parse(Console.ReadLine());
        System.Console.WriteLine($"{Math.Acos(input+Math.Pow(input,2))}");
    } 
}
