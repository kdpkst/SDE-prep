using System;

public class Methods{

    //static means that the method belongs to the Program class and not an object of the Program class
    public static int Addition(int x, int y, int z = 10){
        return x + y + 2 * z;
    }       

    // method overloading: multiple methods can have the same name with different parameters
    public static double Addition(double x, double y){
        return x + y;
    } 

    static void Main(){
        int a = Addition(5, 9, 0);
        Console.WriteLine("a = " + a);

        int b = Addition(5, 9);
        Console.WriteLine("b = " + b);

        int c = Addition(z : 8, x : 10, y : 11);
        Console.WriteLine("c = " + c);

        double d = Addition(3.6, 5.16);
        Console.WriteLine("d = " + d);
    }
}

