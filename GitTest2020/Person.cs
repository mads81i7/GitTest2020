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
        public string Address { get; set; }

        public Person(string name, int id, string phoneNo, string address)
        {
            Name = name;
            Id = id;
            PhoneNo = phoneNo;
            Address = address;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
