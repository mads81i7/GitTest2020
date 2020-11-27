using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest2020
{
    public class Person
    {
        public string Name { get; set; }
        public int Id {get; set; }
        public string PhoneNo { get; set; }

        public Person(string name, int id, string phoneNo)
        {
            Name = name;
            Id = id;
            PhoneNo = phoneNo;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
