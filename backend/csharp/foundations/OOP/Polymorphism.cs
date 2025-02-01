using System;

public class Animals{
    // if a method is not marked virtual, it cannot be overridden
    public void AnimalSound(){
        Console.WriteLine("the animal makes a sound...");
    }

    // methods must be marked as virtual to allow overriding
    public virtual void AnimalMove(){
        Console.WriteLine("the animal moves...");
    }
}

public class Dogs : Animals{
    public void AnimalSound(){
        Console.WriteLine("bark...");
    }

    public override void AnimalMove(){
        Console.WriteLine("the dog runs...");
    }
}

public class Birds : Animals{
    public void AnimalSound(){
        Console.WriteLine("chirp...");
    }

    public override void AnimalMove(){
        Console.WriteLine("the bird flies...");
    }

}