using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class ContactBase
    {
        public List<IContact> Base { get; } = new List<IContact>
        {
            new Contact { FirstName = "Ваня", LastName = "Дуров", Phones = new string[] { "+380675556677" } },
            new Contact { FirstName = "Петя", LastName = "Иванов", Phones = new string[] { "+380671111111" } },
            new Contact { FirstName = "Соня", LastName = "Ручка", Phones = new string[] { "+380672222222" } },
            new Contact { FirstName = "Jordg", LastName = "Washington", Phones = new string[] { "+380673333333" } },
            new Contact { FirstName = "Jon", LastName = "Vain", Phones = new string[] { "+380674444444" } },
            new Contact { FirstName = "Fam", LastName = "Thu", Phones = new string[] { "+380675555555" } },
            new Contact { FirstName = "Oliver", LastName = "Twist", Phones = new string[] { "+380676666666" } }
        };
    }
}
