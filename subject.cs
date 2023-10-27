
using System;

using System;

public class system
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public system(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person("John", "Doe");
        Console.WriteLine($"Person: {person.FirstName} {person.LastName}");
    }
}