using System;

public abstract class Plants{
    public abstract void Grow();
    public void Photosynthesis(){
        Console.WriteLine("absorb carbon dioxide...");
    }
}

public class Lotus : Plants{
    public override void Grow(){
        Console.WriteLine("lotus grows in water...");
    } 
}



