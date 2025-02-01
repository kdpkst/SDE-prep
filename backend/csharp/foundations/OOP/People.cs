using System;

public class People{
    //field
    private string name;
    // property
    public string Name{
        get {return this.name;}
        set {this.name = value;}
    }
    // automatic property: compiler will generate a hidden backing field for the property
    // the hidden field is like "private string gender";
    public string Gender{get; set;}
    // automatic property (read-only)
    public string Birthday {get;}

    public People(string birthday, string gender){
        Birthday = birthday;
        Gender = gender;
    }

    public void Walk(){
        Console.WriteLine("people can walk...");
    }
}


public class Students : People
{
    public int Score {get; set;}
    public Students(string birthday, string gender, int score) : base (birthday, gender){
        Score = score;
    }
}

