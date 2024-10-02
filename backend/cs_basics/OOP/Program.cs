using System;

public class Program{

    static void OOPFundamentals(){
        Cars car = new Cars("Ferrari", "V8", "R", 310);
        car.infoPrinter();
        Console.WriteLine("-----------");
    }

    static void properties(){
        People people = new People("2000.01.01");
        people.Name = "James";
        Console.WriteLine(string.Concat(people.Name, " was born on ", people.Birthday));
        Console.WriteLine("-----------");
    }

    static void inheritance(){
        Students stu = new Students("1990.01.01");
        stu.walk();
        Console.WriteLine("-----------");
    }

    static void polymorphism(){
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

    static void abstraction(){
        Lotus lotus = new Lotus();
        lotus.grow();
        lotus.photosynthesis();
        Console.WriteLine("-----------");
    }

    static void interfaces(){
        Planes plane = new Planes();
        plane.move();
        ElectricCars teslaModelX = new ElectricCars();
        teslaModelX.charge();
    }

    static void enumerations(){
        trafficLight red = trafficLight.RED;
        Console.WriteLine($"Named Constants: {red}");
        
        foreach(Enumerations.DaysOfWeek day in Enum.GetValues(typeof(Enumerations.DaysOfWeek))){
            int dayIndex = (int) day;
            Console.WriteLine($"{day} index: {dayIndex}");
        }
    }

    static void fileOperations(){
        /* 
        AppendText()	Appends text at the end of an existing file
        Copy()	        Copies a file
        Create()	    Creates or overwrites a file
        Delete()	    Deletes a file
        Exists()	    Tests whether the file exists
        ReadAllText()	Reads the contents of a file
        Replace()	    Replaces the contents of a file with the contents of another file
        WriteAllText()	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten
        */

        string filepath = "./../../../OOP/test.txt";
        if (!File.Exists(filepath)){
            string writeText = "long long ago, ...";
            File.WriteAllText("./../../../OOP/test.txt", writeText);

            string readText = File.ReadAllText("./../../../OOP/test.txt");
            Console.WriteLine(readText);
        }
        else {
            Console.WriteLine("file exists...");
        }
    }

    static void exceptions(){
        try{
            int[,] intArray = {{1,2,3}, {2,3,4}, {3,4,5}};
            Console.WriteLine(intArray[10,10]);
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }

        // keyword finally allows code execution after try...catch, regardless of the result
        try{
            string[] strArray = {"a", "b", "c", "d"};
            Console.WriteLine(strArray[5]);
        }
        catch(Exception e){
            Console.WriteLine("something went wrong...");
        }
        finally{
            Console.WriteLine("try...catch finishes");
        }

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 18){
            throw new ArithmeticException("access denied - juvenile");
        }
        else{
            Console.WriteLine("access granted - adult");
        }
    }


    static void Main(string[] args){
        // OOPFundamentals();
        // properties();
        // inheritance();
        // polymorphism();
        // abstraction();
        // interfaces();
        // enumerations();
        // fileOperations();
        exceptions();
    }
    
}