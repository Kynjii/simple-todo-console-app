using System.Linq.Expressions;

Console.WriteLine("Hello!");

Console.WriteLine("Input your first number");
string firstResponse = Console.ReadLine();
int firstNumber = int.Parse(firstResponse);

Console.WriteLine("Input your second number");
string secondResponse = Console.ReadLine();
int secondNumber = int.Parse(secondResponse);

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]subtract numbers");
Console.WriteLine("[M]ultiply numbers");

string userChoice = Console.ReadLine();

string op = "";
int result = 0;

switch (userChoice)
{
    case "a":
        op = " + ";
        result = firstNumber + secondNumber;
        break;
    case "s":
        op = " - ";
        result = firstNumber - secondNumber;
        break; 
    case "m":
        op = " - ";
        result = firstNumber - secondNumber;
        break;
}

if (op == "" && result == 0)
{
    Console.WriteLine("Invalid letter");
} else
{
    Console.WriteLine(firstNumber + op + secondNumber + " = " + result);
}

Console.WriteLine("Press any key to close.");

Console.ReadKey();