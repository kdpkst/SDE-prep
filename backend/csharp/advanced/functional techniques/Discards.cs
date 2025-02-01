public class Discards {
    static (string, double, int, int, int, int) QueryCityDataForYears(string name, int year1, int year2) {
        int population1 = 0, population2 = 0;
        double area = 0;
        if (name == "New York City") {
            area = 468.48;
            if (year1 == 1960) {
                population1 = 7781984;
            }
            if (year2 == 2010) {
                population2 = 8175133;
            }
            return (name, area, year1, population1, year2, population2);
        }
        return ("",0,0,0,0,0);
    }
 
    static void OutParameter() {
        string[] dateStrings = ["05/01/2018 14:57:32.8", "2018-05-01 14:57:32.8",
                      "2018-05-01T14:57:32.8375298-04:00", "5/01/2018",
                      "5/01/2018 14:57:32.80 -07:00",
                      "1 May 2018 2:57:32.8 PM", "16-05-2018 1:00:32 PM",
                      "Fri, 15 May 2018 20:10:57 GMT"];
        foreach (string dateString in dateStrings) {
            // DateTime.TryParse(String, out DateTime) returns two values
            // 1. a boolean indicating whether the parsing was successful
            // 2. the parsed DateTime value, which must be stored in an out parameter
            // can also use DateTime.TryParse(String, out DateTime variableName) to store return value
            if (DateTime.TryParse(dateString, out _)) {
                Console.WriteLine($"{dateString}: valid");
            }
            else {
                Console.WriteLine($"{dateString}: invalid");
            }
        }
    }

    static void StandaloneDiscard() {
        string? arg = null;
        // ?? is the null-coalescing operator
        // x ?? y -> if x is not null, the result is x. Otherwise, the result is y
        _ = arg ?? throw new ArgumentNullException(paramName: nameof(arg), message: "arg can't be null");
    }

    static void Main() {
        var (_, _, _, pop1, _, pop2) = QueryCityDataForYears("New York City", 1960, 2010);
        Console.WriteLine($"Population change: {pop2 - pop1:N0}");
        
        OutParameter();

        StandaloneDiscard();
    }
}