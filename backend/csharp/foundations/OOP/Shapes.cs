using System;

// sealed keyword prevents inheritance
public sealed class Shapes{
    public string brand;
    public int price;

}


// uncommenting the code below will report the error -- 'Circles': cannot derive from sealed type 'Shapes'
// public class Circles : Shapes{
// }



