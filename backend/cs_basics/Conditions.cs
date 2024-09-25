using System;

namespace Conditions{
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
        }   
    }
}