// See https://aka.ms/new-console-template for more information
//Accepting a string of color and displaying it
Console.WriteLine("Enter a color");
string color = Console.ReadLine();

if (color == "red")
{
    Console.WriteLine("box #1");
}
else if (color == "green")
{
    Console.WriteLine("box #2");
}
else if (color == "black")
{
    Console.WriteLine("box #3");
}
else
{
    Console.WriteLine("unknown");
}