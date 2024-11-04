using System;

public class TypeCasting{
    static void Main(string[] args){
        // implicit casting is done automatically when passing a smaller size type to a larger size type
        int x = 8;
        double y = x;
        Console.WriteLine(x);
        Console.WriteLine(y);

        // Explicit casting must be done manually
        double doubleNum = 10.565;
        int intNum = (int) doubleNum;
        Console.WriteLine(doubleNum);
        Console.WriteLine(intNum);

        // commonly-used type conversion
        bool binary = true;
        Console.WriteLine(Convert.ToString(binary));
        Console.WriteLine(Convert.ToDouble(x));
        Console.WriteLine(Convert.ToInt32(false));
    }
}

