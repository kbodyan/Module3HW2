using System.Collections.Generic;

namespace PhoneBook
{
    public interface IPhoneCollectionService
    {
        int Count { get; }
        bool IsReadOnly { get; }
        LocaleEnum TempLocale { get; set; }

        void Add(IContact item);
        void Clear();
        bool Contains(IContact item);
        void CopyTo(IContact[] array, int arrayIndex);
        public void Display();
        IEnumerator<IContact> GetEnumerator();
        char? GetUpperKey(IContact item);
        bool Remove(IContact item);
    }
}