using System;

public abstract class Plants{
    public abstract void grow();
    public void photosynthesis(){
        Console.WriteLine("absorb carbon dioxide...");
    }
}

public class Lotus : Plants
{
    public override void grow(){
        Console.WriteLine("lotus grows in water...");
    } 
}



