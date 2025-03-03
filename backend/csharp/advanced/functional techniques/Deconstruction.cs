public class Deconstruction {

    public static (string, int, double) QueryCityData(string cityName) {
        if (cityName == "Chong Qing") {
            // (name of the city, population, size in square km)
            return (cityName, 31914300, 82400);
        }
        return ("", 0, 0);
    }

    static void Main() {
        // alternative ways to deconstruct a tuple:
        // 1. var (name, pop, size)  
        // 2. (string name, var pop, var size)
        // 3. deconstruct the tuple into variables already declared
        // 4. mix variable declaration and assignment in a deconstruction
        (string name, int pop, double size) = QueryCityData("Chong Qing");

        var p = new Person("John", "Quincy", "Adams", "Boston", "MA");
        // deconstruct an object
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