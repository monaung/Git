﻿using System;
using System.Collections.Generic;

namespace DynamicLambdaExpression
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        static List<Person> DataSet()
        {
            List<Person> _people = new List<Person>();

            _people.Add(new Person(){ Address =new Address()
                                            { City="Singapore", Number="127", State="Bishan", Street="St 12" , ZipCode="570127"} 
                , Age= 34
                    , FirstName="Mon"
                    , LastName="Aung"
                                    });
            

            return _people;
        }
    }
}