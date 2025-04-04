using System;

Console.WriteLine("Hello, Bruker! skriv inn brukernavnet ditt og fortsett med å trykke enter.");

var input = Console.ReadLine(); // Read user input
Console.WriteLine($"Your name: {input}"); // Output the name

var component = new MyComponent();
if (!string.IsNullOrEmpty(input))
{
	component.GreetUser(input); // Call the GreetUser method
}
else
{
	Console.WriteLine("Invalid input. Please restart the program and enter a valid name.");
}

Console.WriteLine("let´s add two numbers. Enter the first number:");
var firstInput = Console.ReadLine();
if (!int.TryParse(firstInput, out var firstNumber))
{
	Console.WriteLine("Invalid input. Please restart the program and enter a valid number.");
	return;
}

Console.WriteLine("Enter the second number:");
var secondInput = Console.ReadLine();
if (!int.TryParse(secondInput, out var secondNumber))
{
	Console.WriteLine("Invalid input. Please restart the program and enter a valid number.");
	return;
}

int result = component.Add(firstNumber, secondNumber); // Call the Add method
Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {result}"); // Output the result

Console.WriteLine("Press any key to exit...");