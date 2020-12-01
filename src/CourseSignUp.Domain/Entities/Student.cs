using CourseSignUp.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.Entities
{
    public class Student : AEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; private set; }

        public void SetAddress(Address address)
        {
            if (!address.ValidNumber()) throw new Exception("The house number must be set");
            if (!address.ValidZip()) throw new Exception("The zip must be greater than 5 and must contains a -");
            this.Address = address;
        }
    }
}
