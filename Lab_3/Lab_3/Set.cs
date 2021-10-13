using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Lab_3
{
    class Set<T> : IEnumerable<T>
    {
        private readonly List<T> _list = new List<T>();

        public Owner Me = new Owner(1, "Anton", "BELSTU");
        public Owner.Date MeDate = new Owner.Date(4);


        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            if (!_list.Contains(item))
            {
                _list.Add(item);
            }
        }

        public bool Delete(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            if (_list.Contains(item))
            {
                _list.Remove(item);
                return true;
            }
            else
            {
                return false;
            }
        }
        public T Max()
        {
            return _list.Max<T>();
        }

        public T Min()
        {
            return _list.Min<T>();
        }

        public T this[int index]
        {
            get
            {
                return _list[index];
            }
            set
            {
                _list[index] = value;
            }
        }

        public static bool operator >(Set<T> set1, Set<T> set2)
        {
            foreach (var elem in set1)
            {
                if (!set2.Has(elem))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool operator <(Set<T> set1, Set<T> set2)
        {
            return (set1 > set2) && (set1.Size() != set2.Size());
        }

        public static Set<T> operator *(Set<T> set1, Set<T> set2)
        {
            var intersection = new Set<T>();
            foreach (var elem in set1)
            {
                if (set2.Has(elem))
                {
                    intersection.Add(elem);
                }
            }
            return intersection;
        }

        public static explicit operator Owner.Date(Set<T> set)
        {
            return new Owner.Date(set.Size());
        }

        public bool Has(T item) => _list.Contains(item);

        public void Clear() => _list.Clear();

        public int Size() => _list.Count;

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }

    class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }

        public class Date
        {
            public DateTime DateOfSeptember;
            public Date(int day)
            {
                DateOfSeptember = new DateTime(2021, 9, day);
            }

        }

        public Owner(int id, string name, string company)
        {
            Id = id;
            Name = name;
            Company = company;
        }
    }
}