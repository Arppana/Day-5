Question-Create a program to display the day properties
1.Year
2.month
3.day
4.hour
5.minute
6.second
7.millisecond
//for a particular date and time
using System;
namespace Day_5
{
class Class3
{
public static void Main()
{
DateTime dt = new DateTime(2021,5,28,3,25,5);
Console.WriteLine(String.Format("{0:MM/dd/yyyy HH:mm:ss}",dt);
Console.ReadLine();
}
}
}
// for current date and time
using System;
namespace Day_5
{
class Class3
{
public static void Main()
{
DateTime dt = DateTime.Now.Date;
Console.WriteLine(dt);
Console.ReadLine;
}
}
}