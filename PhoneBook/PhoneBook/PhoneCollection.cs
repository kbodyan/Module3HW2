using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneCollection : ICollection<Contact>
    {
        private SortedDictionary<char, SortedDictionary<string, Contact>> _book = new SortedDictionary<char, SortedDictionary<string, Contact>>();
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Contact item)
        {
            if (item != null && string.IsNullOrEmpty(item.FullName))
            {
                var letter = item.FullName[0];
                if (!_book.ContainsKey(letter))
                {
                    _book.Add(letter, new SortedDictionary<string, Contact>());
                }

                _book[letter].Add(item.FullName, item);
                else if (item != null && !_book.ContainsKey('#'))
                {
                    _book.Add('#', new SortedDictionary<string, Contact>());
                }
            }
            
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
