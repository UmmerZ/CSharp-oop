using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace OOP
{
    class Person
    {
        public string FirstName { get; set; }

        private string _lastName;
        private int _age;

        public string LastName
        {
            get
            {

                return _lastName;

            }
            set

            {
                _lastName = value;
            }
        }
             public int userAge
        {
            get
            {
                
                return _age; 
               


            }

            set

            {
                if (userAge < 0)
                { 
                    throw new Exception("Not a valid age.please try again");
                }
                _age = value;
                
                
            }
        }
        public void birthday()
        {
            userAge += 1;
        }
        public Person()
        {
            FirstName = "John";
            LastName = "Doe";
            userAge = 20;
        }

        // Partial Constructror - Takes parameters for some properties, and defaults others.
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            userAge = 20;
        }

        // Greedy Constructor - Takes paramaters for all properties.
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            userAge = age;
        }
    }
}