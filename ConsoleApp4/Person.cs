using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ShoppingCart ShoppingCart { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() //Kuna igal klassil on oma ToString, siis override kirjutab olemasoleva üle, et saaks kasutada enda ToStringi.
        {
            return FirstName + " " + LastName;
        }
    }
}
