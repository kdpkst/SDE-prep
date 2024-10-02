using System;

interface IVehicles{
    void move();
    void stop();
}

interface IElectric{
    void charge();
}

public class Planes : IVehicles{
    public void move(){
        Console.WriteLine("the plane is flying...");
    }

    public void stop(){
        Console.WriteLine("the plane has stopped...");
    }
}

public class ElectricCars : IVehicles, IElectric{
    public void move(){
        Console.WriteLine("the electric car is moving...");
    }

    public void stop(){
        Console.WriteLine("the electric car has stopped...");
    }
    
    public void charge(){
        Console.WriteLine("the electric car is charging...");
    }
}

