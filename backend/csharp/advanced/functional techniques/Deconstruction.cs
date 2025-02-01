public class Deconstruction {
    static void Main() {
        var p = new Person("John", "Quincy", "Adams", "Boston", "MA");
        var (fName, _, city, _) = p;
        Console.WriteLine($"Hello {fName} of {city}!");
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
    public string State { get; set; }

    public Person(string fname, string mname, string lname,
                    string cityName, string stateName)
    {
        FirstName = fname;
        MiddleName = mname;
        LastName = lname;
        City = cityName;
        State = stateName;
    }
    
    // the method must be named Deconstruct and use out parameters to specify what values will be extracted
    public void Deconstruct(out string fname, out string lname, out string city, out string state) {
        fname = this.FirstName;
        lname = this.LastName;
        city = this.City;
        state = this.State;
    }

    public void Deconstruct(out string fname, out string mname, out string lname) {
        fname = this.FirstName;
        mname = this.MiddleName;
        lname = this.LastName;
    }
}