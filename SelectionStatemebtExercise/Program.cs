// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var r = new Random();
var favNumber = r.Next(1,100);
Console.WriteLine("Try to guess my favorite number");
var userInput = int.Parse(Console.ReadLine());

if (userInput < favNumber)
{
    Console.WriteLine("too low");
}
else if (userInput > favNumber)
{
    Console.WriteLine("too high");
}

else 
{
    Console.WriteLine("correct!");
}

Console.WriteLine("What is your favorite subject in school?");
string subject = Console.ReadLine();

switch (subject)
{
    case "english":
        Console.WriteLine("Great to hear this!");
        break;
    case "science":
        Console.WriteLine("This was my favorite also!");
        break;
    case "socialstudies":
        Console.WriteLine("Love this, so important!");
        break;
    case "math":
        Console.WriteLine("So glad someone likes this;)!");
        break;
    case "pe":
        Console.WriteLine("Good to keep you healthy!");
        break;
    case "art":
        Console.WriteLine("I loved art too!");
        break;
        default:
        Console.WriteLine("Really! I love that!");
        break;
}




{


}