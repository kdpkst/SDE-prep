using System;

public class People{
    private string name;
    // property
    public string Name{
        get {return this.name;}
        set {this.name = value;}
    }
    private int age;
    // automatic property
    public int Age {get; set;}
    private string gender;
    // automatic property (read-only)
    public string Birthday {get;}

    public People(string birthday){
        Birthday = birthday;
    }

    public void walk(){
        Console.WriteLine("people can walk...");
    }

}


public class Students : People
{
    public Students(string birthday) : base(birthday){
    }

}