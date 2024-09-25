using System;

namespace Variables{
    public class Variables{
        static void Main(string[] args){
            // common data types in cs 
            char letter = 'a';
            Console.WriteLine(letter);
            string text1 = "this is text1";
            Console.WriteLine(text1);
            int x = 5;
            Console.WriteLine(x);
            long longInteger = 948394928492322432L;
            Console.WriteLine(longInteger);
            float floatNum = 3.343433F;
            Console.WriteLine(floatNum);
            double doubleNum = 2.14628787843D;
            Console.WriteLine(doubleNum);
            // floating numbers can be scientific numbers. e.g., 12 multiplies 10 to the power of 4
            double scientificNum = 12e4d;
            Console.WriteLine(scientificNum);
            bool binary;
            binary = false;
            Console.WriteLine(binary);

            // constant value cannot be reassigned to another value
            const int VELOCITY_OF_LIGHT = 299792458;
            Console.WriteLine(VELOCITY_OF_LIGHT);

            // concatenation and number addition
            string text2 = "this is text2";
            Console.WriteLine(text1 + " " + text2);
            int y = 10;
            Console.WriteLine(x + y);

            // using comma-separated list to declare multiple variables with the same type
            int a = 1, b = 2, c = 3;
            Console.WriteLine(a - b + c);

        }
    }
}
