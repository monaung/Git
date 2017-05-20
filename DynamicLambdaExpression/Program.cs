using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DynamicLambdaExpression
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Person> _person = DataSet();

            var parmExpression = Expression.Parameter(Type.GetType("DynamicLambdaExpression.Person"), "person"); //"person" = (person => person.XXX);

            var constant = Expression.Constant("Mon"); // value

            var property = Expression.Property(parmExpression, "FirstName");

            var expression = Expression.Equal(property, constant); // (persion.FirstName="Mon")

            var lambda = Expression.Lambda<Func<Person, bool>>(expression, parmExpression);

            var compiledLambda = lambda.Compile();

            var result = _person.Where(compiledLambda).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.FirstName);
            }

        }


        static List<Person> DataSet()
        {
            List<Person> _people = new List<Person>();

            _people.Add(new Person()
            {
                Address = new Address()
                {
                    City = "Singapore",
                    Number = "127",
                    State = "Bishan",
                    Street = "St 12",
                    ZipCode = "570127"
                }
                    ,
                Age = 34
                    ,
                FirstName = "Mon"
                    ,
                LastName = "Aung"
            });

            _people.Add(new Person()
            {
                Address = new Address()
                ,
                Age = 34
                ,
                FirstName = "Zeya"
                ,
                LastName = "Thu"
            });


            _people.Add(new Person()
            {
                Address = new Address()
                {
                    City = "Yangon",
                    Number = "39",
                    State = "N Dagon",
                    Street = "St 10",
                    ZipCode = "350786"
                }
                ,
                Age = 34
                ,
                FirstName = "Zeya"
                ,
                LastName = "Thu"
            });


            return _people;
        }
    }
}
