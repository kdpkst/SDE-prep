using System;

public class Enumerations{
    // can assign your own enum values, and the next items will update their numbers accordingly
    public enum DaysOfWeek{
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday = 10,
        Saturday,
        Sunday
    }
}

// enum can be inside or outside a class
enum trafficLight{
    RED,
    GREEN,
    YELLOW
}
