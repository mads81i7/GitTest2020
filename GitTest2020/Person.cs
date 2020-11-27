using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest2020
{
    public class Person
    {
        public string Name { get; set; }
        public int Id {get; set; }

        public Person(string name, int id)
        {
            Name = name;
            Id = id
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
