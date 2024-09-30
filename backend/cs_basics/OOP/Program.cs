using System;

public class Program{
    static void Main(string[] args){
        Cars car = new Cars("Ferrari", "V8", "R", 310);
        car.infoPrinter();
        Console.WriteLine("-----------");

        // properties
        People people = new People("2000.01.01");
        people.Name = "James";
        Console.WriteLine(string.Concat(people.Name, " was born on ", people.Birthday));
        Console.WriteLine("-----------");

        // inheritance
        Students stu = new Students("1990.01.01");
        stu.walk();
        Console.WriteLine("-----------");

        // polymorphism
        Animals animal1 = new Animals();
        Animals bird1 = new Birds();
        Animals dog1 = new Dogs();
        animal1.animalSound();
        bird1.animalSound();
        dog1.animalSound();

        Animals animal2 = new Animals();
        Animals bird2 = new Birds();
        Animals dog2 = new Dogs();
        animal2.animalMove();
        bird2.animalMove();
        dog2.animalMove();
        Console.WriteLine("-----------");

    }
    
}