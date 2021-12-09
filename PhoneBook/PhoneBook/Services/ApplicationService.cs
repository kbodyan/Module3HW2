using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class ApplicationService
    {
        private ContactBase _contactBase;
        private IPhoneCollectionService _phoneCollectionService;
        public ApplicationService(IPhoneCollectionService phoneCollectionService, ContactBase contactBase)
        {
            _phoneCollectionService = phoneCollectionService;
            _contactBase = contactBase;
        }

        public void Run()
        {
            var contacts = _contactBase.Base;
            foreach (var item in contacts)
            {
                _phoneCollectionService.Add(item);
            }

            _phoneCollectionService.Display();
            _phoneCollectionService.TempLocale = LocaleEnum.RU;
            Console.WriteLine("Locale changed to Russian");
            _phoneCollectionService.Display();
        }
    }
}
