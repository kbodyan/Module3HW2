using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Contact : ICloneable, IContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string[] Phones { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public char? FirstLetter
        {
            get
            {
                return string.IsNullOrEmpty(FullName) ? null : FullName[0];
            }
        }

        public object Clone()
        {
            return new Contact { FirstName = FirstName, LastName = LastName };
        }
    }
}
