using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(String[] args)
    {
        // Read a full line of input from stdin and save it to our variable, inputString.
        String inputString = Console.ReadLine();

        // Print a string literal saying "Hello, World." to the stdout.
        Console.WriteLine("Hello, World.");

        // Prints the contents of inputString to stdout.
        Console.WriteLine(inputString);
    }
}