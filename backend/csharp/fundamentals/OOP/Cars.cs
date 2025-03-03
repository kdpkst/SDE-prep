using System;

/*
Access Modifier (By default, all members of a class are private if do not specify an access modifier): 
public	            Access is not restricted
private	            Access is limited to the containing type
protected           Access is limited to the containing class or types derived from the containing class
internal            Access is limited to the current assembly 
                    (an assembly is a compiled output file, either a .dll or .exe, which contains program's compiled code)
protected internal  Access is limited to the current assembly or types derived from the containing class
private protected   Access is limited to the containing class or types derived from the containing class within the current assembly
*/

public class Cars{
    
    string brand;
    string engine;
    string color;
    int maxSpeed;

    // constructors can also be overloaded by using different numbers of parameters
    public Cars(string brand, string engine, string color, int maxSpeed){
        this.brand = brand;
        this.color = color;
        this.engine = engine;
        this.maxSpeed = maxSpeed;
    }

    public void InfoPrinter(){
        Console.WriteLine("Detailed Info:");
        Console.WriteLine("brand name: " + this.brand + " | engine: " + this.engine + " | color: " + this.color + " | max speed: " + this.maxSpeed);
    }

}