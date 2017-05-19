using System;
namespace DynamicLambdaExpression
{
    public class Person
    {
        public Person()
        {
            this.Address = new Address();
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public Address Address
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }
    }
}
