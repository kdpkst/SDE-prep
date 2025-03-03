using System;

interface IVehicles{
    void Move();
    void Stop();
}

interface IElectric{
    void Charge();
}

public class Planes : IVehicles{
    public void Move(){
        Console.WriteLine("the plane is flying...");
    }

    public void Stop(){
        Console.WriteLine("the plane has stopped...");
    }
}

public class ElectricCars : IVehicles, IElectric{
    public void Move(){
        Console.WriteLine("the electric car is moving...");
    }

    public void Stop(){
        Console.WriteLine("the electric car has stopped...");
    }
    
    public void Charge(){
        Console.WriteLine("the electric car is charging...");
    }
}

