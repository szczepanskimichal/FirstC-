// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Bruker! skriv inn brukernavnet ditt og fortsett med å trykke enter.");

var input = Console.ReadLine();
Console.WriteLine($"Your name: {input}");
Console.WriteLine("Takk for at du skrev inn navnet ditt!");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
// This is a simple C# console application that prompts the user for input and then displays it back to them.
// It also waits for a key press before exiting, allowing the user to see the output before the console window closes.
// The program uses the Console class to read input from the user and write output to the console.
// The first line writes "Hello, World!" to the console.
// The second line reads a line of input from the user and stores it in the variable 'input'.
// The third line writes the input back to the console, prefixed with "You entered: ".
