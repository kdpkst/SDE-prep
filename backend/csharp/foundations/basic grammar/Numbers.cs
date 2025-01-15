using System;

public class Numbers {
    static void Main() {
        // the range of int & overflow example
        int maxInt = int.MaxValue;
        int minInt = int.MinValue;
        Console.WriteLine($"the range of integers is {minInt} to {maxInt}");
        int overflow = maxInt + 3;
        Console.WriteLine($"an example of overflow {overflow}");

        // the range of double
        double maxDouble = double.MaxValue;
        double minDouble = double.MinValue;
        Console.WriteLine($"The range of double is {minDouble} to {maxDouble}");

        // decimal type: smaller range but greater precision than double
        decimal min = decimal.MinValue;
        decimal max = decimal.MaxValue;
        Console.WriteLine($"The range of the decimal type is {min} to {max}");
        
        // The M suffix on the numbers indicates that a constant uses the decimal type
        decimal c = 1.0M;
        decimal d = 3.0M;
        Console.WriteLine(c / d);
        double a = 1.0;
        double b = 3.0;
        Console.WriteLine(a / b);
    }
}