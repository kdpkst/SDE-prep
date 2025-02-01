public record Order(int Items, decimal Cost);

public class PatternMatching {

    static void NullCheck() {
        int? maybe = 12;
        // expression: obj is Type variableName
        // if obj is of the given Type and not null, the condition evaluates to true.
        // if obj is not of the given Type (or obj is null), the condition evaluates to false.
        if (maybe is int number) {
            Console.WriteLine($"The nullable int 'maybe' has the value {number}");
        }
        else {
            Console.WriteLine("The nullable int 'maybe' doesn't hold a value");
        }
    }

    static string DiscreteValueComp(string command) => 
        // the expression has a return type 
        command switch
        {
            "test" => "system is tesing...",
            "start" => "system is starting...",
            "stop" => "system is stopping...",
            // _ handles any error conditions where `command` doesn't match one of the above values
            _ => throw new ArgumentException("Invalid string value for command", nameof(command))
        };

    static string RelationalPatterns(int tempInCentigrade) =>
        tempInCentigrade switch {
            < 0 => "solid",
            0 => "solid/liquid equilibrium",
            > 0 and < 100 => "liquid",
            100 => "liquid/gas equilibrium",
            > 100 => "gas"
        };

    static decimal MultipleInputs(Order order) => 
        order switch {
            // () is ussed for positional patterns, typically for records or tuples
            (>10, >1000m) => 0.9m,
            (>5, >500m) => 0.85m,
            // {} is used for property patterns to match individual properties of an object
            {Cost: > 300m} => 0.8m,
            null => throw new ArgumentNullException(nameof(order), "Can't calculate discount on null order"),
            // match anything and capture the matched value into the variable
            var regularOrder => 0m
        };

    static decimal ListPatterns(string[,] transactions) {
        decimal balance = 0;
        for (int i = 0; i < transactions.GetLength(0); i++) {
            string[] row = new string[transactions.GetLength(1)];
            for (int j = 0; j < transactions.GetLength(1); j++) {
                row[j] = transactions[i,j];
            }
            // row switch has a return value
            balance += row switch {
                // [] is used for list patterns to match arrays, List<T>, or other types implementing IEnumerable
                [_, "DEPOSIT", _, var amount] => decimal.Parse(amount),
                [_, "WITHDRAWAL", _, var amount] => -decimal.Parse(amount),
                [_, "INTEREST", _, var amount] => decimal.Parse(amount),
                [_, "FEE", _, var amount] => -decimal.Parse(amount),
                _ => throw new InvalidOperationException($"Record {string.Join(", ", row)} is not in the expected format!"),
            };
        }
        return balance;
    }

    static void Main() {
        NullCheck();

        string systemAction = DiscreteValueComp("start");
        Console.WriteLine(systemAction);

        string waterState = RelationalPatterns(100);
        Console.WriteLine(waterState);

        Order order = new Order(10, 800m);
        decimal discount = MultipleInputs(order);
        Console.WriteLine(discount);

        string[,] transactions = {{"01-01-2025", "DEPOSIT", "Initial deposit", "2000"},
                                 {"10-01-2025", "DEPOSIT", "Salary", "10000"},
                                 {"12-01-2025", "WITHDRAWAL", "Debit", "500"},
                                 {"15-01-2025", "FEE", "", "5000"},
                                 {"17-01-2025", "INTEREST", "", "0.65"},
                                };
        decimal balance = ListPatterns(transactions);
        // :C in $"{balance:C}" is a format specifier, formating the value as a currency string
        Console.WriteLine($"{balance:C}");
    }
}