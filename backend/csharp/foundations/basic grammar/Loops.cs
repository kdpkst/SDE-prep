using System;

public class Loops{
    static void Main(string[] args){
        int i = 0;
        while (i < 5){
            Console.WriteLine(i);
            i++;
        }
        Console.WriteLine("------------");
        
        // dowhile loop will always be executed at least once, even if the condition is false
        i = 0;
        do{
            Console.WriteLine(i);
            i++;
        }
        while(i < 5);
        Console.WriteLine("------------");

        // nested for loop: Multiplication Table
        for (int x = 1; x < 10; x++){
            for (int y = 1; y <= x; y++){
                Console.Write($"{x}*{y} = {x*y} ");
            }
            Console.Write("\n");
        }
        Console.WriteLine("------------");
        
        // loop through elements in an array (or other data sets)
        string[] cars = {"Ferrari", "Lamborghini", "AstonMartin", "Bugatti"};
        foreach(string car in cars){
            Console.Write(string.Concat(car, " "));
        }
    }   
}
