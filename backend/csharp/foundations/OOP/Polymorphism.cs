using System;

public class Animals{
    public void animalSound(){
        Console.WriteLine("the animal makes a sound...");
    }

    public virtual void animalMove(){
        Console.WriteLine("the animal moves...");
    }
}

public class Dogs : Animals{
    public void animalSound(){
        Console.WriteLine("bark...");
    }

    public override void animalMove(){
        Console.WriteLine("the dog runs...");
    }

}

public class Birds : Animals{
    public void animalSound(){
        Console.WriteLine("chirp...");
    }

    public override void animalMove(){
        Console.WriteLine("the bird flies...");
    }

}