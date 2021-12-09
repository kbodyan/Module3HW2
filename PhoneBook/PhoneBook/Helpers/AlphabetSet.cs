using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class AlphabetSet
    {
        public Dictionary<LocaleEnum, string> Alphabet { get; } = new Dictionary<LocaleEnum, string>()
        {
            [LocaleEnum.EN] = "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            [LocaleEnum.RU] = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"
        };
    }
}
