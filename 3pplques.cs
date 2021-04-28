1.Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects.
2.To do this, first create a Person class that has a Name property of type string, a constructor that receives the name as a parameter, a destructor that assigns the name to empty and overwrites the ToString () method.
3.End the program by reading the people and executing the ToString () method on screen.

using System;
 

 //first create a person class has a Name property of type string
    public class Person
    {
        public string Name { get; set; }
 //constructor that receives name as parameter
        public Person(string name)
        {
            Name = name;
        }
 
        
 //a destructor that assigns name to empty
        ~Person()
        {
            Name = string.Empty;
        }
		public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
		public static void Main(string[] args)
    {
       //prompts user for 3 names and stores them in arry of person type objects
        int total = 3;
        Person[] persons = new Person[total];
 //end pgm by reading d ppl
        for (int i = 0; i < total; i++)
        {
            persons[i] = new Person(Console.ReadLine());
        }
 //executing tostring() method on screen
        for (int i = 0; i < total; i++)
        {
            Console.WriteLine(persons[i].ToString());
        }
    }
	}

