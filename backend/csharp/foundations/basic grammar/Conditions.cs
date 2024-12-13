using System;

public class Conditions{
    static void Main(string[] args){
        Console.Write("Enter current time: ");
        int time = Convert.ToInt32(Console.ReadLine());
        if (time >= 1 && time <= 9){
            Console.WriteLine("sleep");
        }
        else if (time > 9 && time <= 18){
            Console.WriteLine("work");
        }
        else if (time > 18 && time <= 24){
            Console.WriteLine("entertainment");
        }
        else {
            Console.WriteLine("invalid input");
        }

        // Ternary Operator
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        string result = (age >= 18) ? "eligible to vote" : "not old enough";
        Console.WriteLine(result);
        // Console.WriteLine((age >= 18) ? "eligible to vote" : "not old enough");

        Console.Write("Enter the day of the week: ");
        int day = Convert.ToInt32(Console.ReadLine());
        switch (day) {  
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;   
            default:
                Console.WriteLine("Invalid Input");
                break;         
        }
    }   
}
