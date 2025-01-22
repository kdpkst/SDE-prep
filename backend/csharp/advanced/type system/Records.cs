// record features:
// 1. value equality: two variables of a record type are equal if the types match and all property and field values compare equal
// 2. immutability: cannot change property or field values of an object after it's instantiated

public record Employees(string Firstname, string LastName) {
    public required string[] PhoneNumber;
};

public class Records {
    static void Main() {
        var phoneNumber = new string[2];
        Employees employee1 = new Employees("Dowdle", "Kerry") {PhoneNumber = phoneNumber};
        Employees employee2 = new Employees("Dowdle", "Kerry") {PhoneNumber = phoneNumber};
        Console.WriteLine(employee1 == employee2); // output: True
        
        // this doesn't affect the equality
        // the reference to the array (i.e., the variable `PhoneNumber`) remains the same
        // only the contents of the array are changed
        employee1.PhoneNumber[0] = "5510";
        Console.WriteLine(employee1 == employee2); // output: True
        Console.WriteLine(ReferenceEquals(employee1, employee2)); // output: False

        // with expression: create a copy of an immutable object with new values
        var employee = employee1 with {Firstname = "Curry"};
        Console.WriteLine(employee);
        Console.WriteLine(employee == employee1); // output false
        
        // created a copy of employee1 with no modifications
        employee = employee1 with {};
        Console.WriteLine(employee == employee1); // output true;
    }
}