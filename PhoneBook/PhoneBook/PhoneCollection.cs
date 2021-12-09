using System;
using System.Collections;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneCollection : ICollection<IContact>, IEnumerable<IContact>
    {
        private SortedDictionary<char, SortedDictionary<string, IContact>> _book = new SortedDictionary<char, SortedDictionary<string, IContact>>();

        private AlphabetSet _alphabet = new AlphabetSet();
        public LocaleEnum TempLocale { get; set; }
        public int Count
        {
            get
            {
                return ToList.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        private List<IContact> ToList
        {
            get
            {
                var result = new List<IContact>();
                foreach (var item in _book.Keys)
                {
                    result.AddRange(_book[item].Values);
                }

                return result;
            }
        }

        public void Add(IContact item)
        {
            char? upperKey = GetUpperKey(item);
            if (item == null || upperKey == null || Contains(item))
            {
                return;
            }

            if (!_book.ContainsKey((char)upperKey))
            {
                _book.Add((char)upperKey, new SortedDictionary<string, IContact>());
            }

            _book[(char)upperKey].Add(item.FullName, item);
        }

        public void Clear()
        {
            _book.Clear();
        }

        public bool Contains(IContact item)
        {
            var key = GetUpperKey(item);
            if (key != null && _book.ContainsKey((char)key) && _book[(char)key].ContainsKey(item.FullName))
            {
                return true;
            }

            return false;
        }

        public char? GetUpperKey(IContact item)
        {
            if (item == null)
            {
                return null;
            }

            if (item.FirstLetter != null)
            {
                var letter = (char)item.FirstLetter;
                if (_alphabet.Alphabet[TempLocale].Contains(letter))
                {
                    return letter;
                }
                else if (char.IsDigit(letter))
                {
                    return '0';
                }
            }

            return '#';
        }

        public SortedDictionary<string, IContact> GetLink(IContact item)
        {
            if (Contains(item))
            {
                var firstLetter = (char)item.FirstLetter;
                if (_alphabet.Alphabet[TempLocale].Contains(firstLetter))
                {
                    return _book[firstLetter];
                }
                else if (char.IsDigit(firstLetter))
                {
                    return _book['0'];
                }
                else
                {
                    return _book['#'];
                }
            }

            return null;
        }

        public bool Remove(IContact item)
        {
            if (item == null && !Contains(item))
            {
                return false;
            }

            var upperKey = GetUpperKey(item);
            _book[(char)upperKey].Remove(item.FullName);
            if (_book[(char)upperKey].Count == 0)
            {
                _book.Remove((char)upperKey);
            }

            return true;
        }

        public IEnumerator<IContact> GetEnumerator()
        {
            foreach (var upperKey in _book.Keys)
            {
                foreach (var contact in _book[upperKey].Values)
                {
                    yield return contact;
                }
            }
        }

        public void CopyTo(IContact[] array, int arrayIndex)
        {
            ToList.CopyTo(array, arrayIndex);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}