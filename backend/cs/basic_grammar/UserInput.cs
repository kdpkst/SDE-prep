using System;

public class UserInput{

    static void Main(string[] args){
        // input data type is string
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Received username: " + username);

        Console.Write("Enter an integer: ");
        Console.WriteLine("Received integer: " + Convert.ToString(Console.ReadLine()));
    }
}


