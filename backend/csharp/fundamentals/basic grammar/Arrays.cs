using System;

public class Arrays{
    static void Main(){
        string[] cars = {"Ferrari", "Lamborghini", "AstonMartin", "Bugatti"};
        Console.WriteLine("Length of the array: " + cars.Length);

        // four ways to create new arrays
        string[] cars1 = new string[4]; 
        // require explicitly use the new keyword when assigning a new array after its declaration
        // cars1 = new string[] {"Volvo", "BMW", "Ford", "Mazda"};
        string[] cars2 = new string[4] {"Volvo", "BMW", "Ford", "Mazda"}; 
        string[] cars3 = new string[] {"Volvo", "BMW", "Ford", "Mazda"};
        string[] cars4 = {"Volvo", "BMW", "Ford", "Mazda"};

        
        // access the array
        for (int i = 0; i < cars2.Length; i++){
            Console.Write(cars2[i] + " ");
        }
        Console.Write("\n");

        // sort the array in an ascending order
        Array.Sort(cars);
        foreach(string car in cars){
            Console.Write(car + " ");
        }
        Console.Write("\n");
        
        int[] numArray = {3, 6, 1, 7, 2, 9};
        Array.Sort(numArray);
        foreach(int e in numArray){
            Console.Write(e + " ");
        }
        Console.WriteLine();
        // int[] numArray = {3, 6, 1, 7, 2, 9};
        // int temp;
        // for (int i = 0; i < numArray.Length; i++){
        //     for (int j = 0; j < numArray.Length-1; j++){
        //         if (numArray[j] > numArray[j+1]){
        //             temp = numArray[j];
        //             numArray[j] = numArray[j+1];
        //             numArray[j+1] = temp;
        //         }
        //     }
        // }
        // foreach(int e in numArray){
        //     Console.Write(e + " ");
        // }
        // Console.WriteLine();

        // some commonly-used methods
        Console.WriteLine("Max of the array: " + numArray.Max());  
        Console.WriteLine("Min of the array: " + numArray.Min()); 
        Console.WriteLine("Sum of the array: " + numArray.Sum()); 
        
        // multidimensional arrays: an array of arrays
        // two-dimentioanl array int[,]; three-dimentional array int[,,]; etc.
        int[,] multiArray = {{1,2,3}, {4,5,6}};
        Console.WriteLine("before change: "+ multiArray[0, 2]);
        multiArray[0,2] = 100;
        Console.WriteLine("after change: " + multiArray[0, 2]);
        // foreach can automatically loop through a multi-dimentional array
        foreach (int e in multiArray){
            Console.Write(string.Concat(e, " "));
        }
        Console.WriteLine("");
        
        // one loop for each dimension if do not use foreach
        for (int i = 0; i < multiArray.GetLength(0); i++){
            for (int j= 0; j < multiArray.GetLength(1); j++){
                Console.Write(string.Concat(multiArray[i, j], " "));
            }
        }
    }
}
