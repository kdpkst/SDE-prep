public class Lists {

    static void ListOperations() {
        var names = new List<string> {"Kim", "Mark", "Tresa"};
        foreach (var name in names) {
            Console.WriteLine($"Hi, {name.ToUpper()}!");
        }

        names.Add("Jam");
        names.Add("Barry");
        names.Remove("Kim");
        Console.WriteLine();
        foreach (var name in names) {
            Console.WriteLine($"Hi, {name.ToUpper()}!");
        }

        Console.WriteLine();
        // list<T> enables index 
        Console.WriteLine($"my name is {names[0]}");
        Console.WriteLine($"two names added {names[2]} and {names[3]}");
        // Count property returns the list length
        Console.WriteLine($"the list has {names.Count} people in it");
        
        Console.WriteLine();
        // IndexOf returns the index of the item. If the item isn't in the list, IndexOf returns -1.
        int index = names.IndexOf("Jam");
        if (index != -1) {
            Console.WriteLine($"the name {names[index]} is at {index}");
        }

        Console.WriteLine();
        // Sort sorts all the items in their normal order
        names.Sort();
        foreach (var name in names) {
            Console.WriteLine($"Hi, {name.ToUpper()}");
        }
    }

    static void Fibonacci(int length) {
        var fibonacciNumbers = new List<int> {1,1};
        while (fibonacciNumbers.Count < length) {
            int pre1 = fibonacciNumbers[fibonacciNumbers.Count - 1];
            int pre2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            fibonacciNumbers.Add(pre1 + pre2);
        }
        foreach (var number in fibonacciNumbers) {
            Console.Write(number + " ");
        }
    } 

    static void Main() {
        ListOperations();
        Fibonacci(20);
    }
}