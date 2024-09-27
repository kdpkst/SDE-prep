using System;

public class Program{
    static void Main(string[] args){
        Cars car = new Cars("Ferrari", "V8", "R", 310);
        car.infoPrinter();

        People people = new People("2000.01.01");
        people.Name = "James";
        Console.WriteLine(string.Concat(people.Name, " was born on ", people.Birthday));

        Students stu = new Students("1990.01.01");
        stu.walk();

    }
    
}