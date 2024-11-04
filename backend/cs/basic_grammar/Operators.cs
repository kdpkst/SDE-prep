using System;

public class Operators{
    static void Main(string[] args){
        // & bitwise AND
        int x = 5;
        Console.WriteLine("after x &= 3, x = " + Convert.ToString(x &= 3));
        // | bitwise OR
        x = 5;
        Console.WriteLine("after x |= 3, x = " + Convert.ToString(x |= 3));
        // bitwise XOR
        x = 5;
        Console.WriteLine("after x ^= 3, x = " + Convert.ToString(x ^= 3));
        // bitwise complement (2's complement)
        Console.WriteLine("after x = ~3, x = " + Convert.ToString(x = ~3));
        x = 5;
        // left-shift operator
        Console.WriteLine("after x <<= 3, x = " + Convert.ToString(x <<= 3));
        x = 5;
        // right-shift operator
        Console.WriteLine("after x >>= 3, x = " + Convert.ToString(x >>= 3));
            
    }
}
