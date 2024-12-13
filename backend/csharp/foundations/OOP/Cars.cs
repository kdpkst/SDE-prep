using System;

/*
Access Modifier: 
public	   The code is accessible for all classes
private	   The code is only accessible within the same class
protected  The code is accessible within the same class, or in a class that is inherited from that class
internal   The code is only accessible within its own assembly, but not from another assembly
*/
public class Cars{
    // By default, all members of a class are private if do not specify an access modifier
    public string brand;
    public string engine;
    public string color;
    public int maxSpeed;

    // constructors can also be overloaded by using different numbers of parameters
    public Cars(string brand, string engine, string color, int maxSpeed){
        this.brand = brand;
        this.color = color;
        this.engine = engine;
        this.maxSpeed = maxSpeed;
    }

    public void infoPrinter(){
        Console.WriteLine("Detailed Info:");
        Console.WriteLine("brand name: " + this.brand + " | engine: " + this.engine + " | color: " + this.color + " | max speed: " + this.maxSpeed);
    }

}