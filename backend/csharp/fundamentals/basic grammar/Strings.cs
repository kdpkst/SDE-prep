using System;

public class Strings{
    static void Main(){
        string text = "I am a genius!";
        Console.WriteLine("text length: " + text.Length);
        Console.WriteLine("uppercase text: " + text.ToUpper());
        Console.WriteLine("lowercase text: " + text.ToLower());

        // another way for concatenation
        string txt = "but you are mediocre~";
        Console.WriteLine(string.Concat(text, " ", txt));

        // string interpolation usage
        string fullText = $"Hello, {text} Well, {txt}";
        Console.WriteLine(fullText);

        // access strings
        Console.WriteLine(fullText[0]);
        Console.WriteLine(fullText.IndexOf("I"));
        // string.Substring(startIndex, length)
        Console.WriteLine(txt.Substring(3, 7));

        // replace the string
        string sayHello = "hello world";
        sayHello = sayHello.Replace("world", "my love");
        Console.WriteLine(sayHello);

        string lyrics = "i wonder how i wonder why";
        Console.WriteLine(lyrics.Contains("i") && lyrics.Contains("how"));
        Console.WriteLine(lyrics.StartsWith("wonder"));
        Console.WriteLine(lyrics.EndsWith("why"));

        // escape character
        string specialText = "It's \"interesting\"...";
        Console.WriteLine(specialText);
        
        // any of the Trim methods returns a new string but doesn't change the original message
        string greeting = "      Hello World!       ";
        Console.WriteLine($"[{greeting}]");
        string trimmedGreeting = greeting.TrimStart();
        Console.WriteLine($"[{trimmedGreeting}]");
        trimmedGreeting = greeting.TrimEnd();
        Console.WriteLine($"[{trimmedGreeting}]");
        trimmedGreeting = greeting.Trim();
        Console.WriteLine($"[{trimmedGreeting}]");
    }
}
