using System;

public class Operations{
    static void Main(){
        // many Math methods return double data type 
        Console.WriteLine(Math.Min(0, -9));
        Console.WriteLine(Math.Max(10, 9));
        Console.WriteLine(Math.Sqrt(81));
        Console.WriteLine(Math.Pow(5, 3));
        Console.WriteLine(Math.Abs(-4.7));
        // Math.Round(x) rounds x to nearest whole number
        Console.WriteLine(Math.Round(9.5));
    }
}