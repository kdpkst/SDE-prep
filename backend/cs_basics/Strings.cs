using System;

namespace Strings{

    public class Strings{
        static void Main(string[] args){
            string text = "I am a genius!";
            Console.WriteLine("text length: " + text.Length);
            Console.WriteLine("uppercase text: " + text.ToUpper());
            Console.WriteLine("lowercase text: " + text.ToLower());

            // another way for concatenation
            string txt = "but I am mediocre";
            Console.WriteLine(string.Concat(text, " ", txt));

            // string interpolation usage
            string fullText = $"Hello, {text} Well, {txt}";
            Console.WriteLine(fullText);

            // access strings
            Console.WriteLine(fullText[0]);
            Console.WriteLine(fullText.IndexOf("I"));
            // string.Substring(startIndex, length)
            Console.WriteLine(txt.Substring(3, 7));

            // escape character
            string specialText = "It's \"interesting\"...";
            Console.WriteLine(specialText);
        }

    }
}