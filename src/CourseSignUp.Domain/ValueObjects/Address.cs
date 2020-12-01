using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.ValueObjects
{
    public class Address : AValueObject
    {
        public string Street { get; set; }
        public string Zip { get; set; }
        public int Number { get; set; }

        public bool ValidNumber()
        {
            return this.Number > 0;
        }
        public bool ValidZip()
        {
            return this.Zip.Length>=5 && this.Zip.Contains("-");
        }
    }
}
