using System;
namespace Day_5
{
class Program
{
Program()
{
Console.WriteLine("Constructor is called");\\first it will show this
}
~Program()
{
Console.WriteLine("Destructor is called");\\finally it will destruct those programs
}
static void Main(string[] args)
{
Console.WriteLine("I am in main program");\\then it will show this
Program p = new Program();
Console.ReadLine();
}
}
}