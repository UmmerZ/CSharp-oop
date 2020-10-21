using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            string firstName, lastName;
            int userAge;
            // Default Constructor
            Person defaultPerson = new Person();
            // Partial Constructor
            Person partialPerson = new Person("Test", "Testson");
            // Greedy Constructor
            Person greedyPerson = new Person("Test", "McGreedy", 50);


            Console.Write("Please enter your first name: ");
            person.FirstName = Console.ReadLine().Trim();


            Console.Write("Please enter your last name: ");
            person.LastName = Console.ReadLine().Trim();

            Console.Write("Please enter your age: ");
            try
            {
                person.userAge = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message} Setting to zero.");
                person.userAge = 0;
            }
            Console.WriteLine($"Hello, {person.FirstName} {person.LastName} who is {person.userAge} years old!");


            person.birthday();
            Console.WriteLine($"You just had a birthday, you are now {person.userAge} years old.");
            
        }
        
    }
}
