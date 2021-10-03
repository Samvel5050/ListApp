using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ll = new List<int>(4);
            _List ll1 = new _List(4);
            ll1.Add(12);
            ll1.Add(13);
            ll1.Add(15);
            ll1.Add(16);
            ll1.Add(17);

            ll1[0] = 24;
            int b = ll1[0];
           

        }
        public class _List
        {
            private const int _defaultCapacity = 4;
            private int[] _items;
            private int _size;
            private int _version;

            static readonly int[] _emptyArray = new int[0];

            public _List()
            {
                _items = _emptyArray;
            }

            public _List(int capacity)
            {


                if (capacity == 0)
                    _items = _emptyArray;
                else
                    _items = new int[capacity];
            }

            public int this[int i]
            {
                get
                {
                    return _items[i];
                }
                set
                {
                    _items[i] = value;
                }
            }


            public int Capacity
            {
                get
                {
                    return _items.Length;
                }
                set
                {

                    if (value != _items.Length)
                    {
                        if (value > 0)
                        {
                            int[] newItems = new int[value];
                            if (_size > 0)
                            {
                                Array.Copy(_items, 0, newItems, 0, _size);
                            }
                            _items = newItems;
                        }
                        else
                        {
                            _items = _emptyArray;
                        }
                    }
                }
            }

            public int Count
            {
                get
                {
                    return _size;
                }
            }
            public void Add(int item)
            {
                if (_size == _items.Length)
                {
                    EnsureCapacity(_size + 1);
                }
                _items[_size++] = item;
                _version++;
            }
            private void EnsureCapacity(int min)
            {
                if (_items.Length < min)
                {
                    int newCapacity = _items.Length == 0 ? _defaultCapacity : _items.Length * 2;
                    if ((uint)newCapacity > 0X7FEFFFFF)
                    {
                        newCapacity = 0X7FEFFFFF;
                    }
                    if (newCapacity < min)
                    {
                        newCapacity = min;
                    }
                    Capacity = newCapacity;
                }
            }
            public List<int> GetRange(int index, int count)
            {
                if (index < 0)
                {
                    
                }

                if (count < 0)
                {
                    
                }

                if (_size - index < count)
                {
                    
                }
                int[] newItems = new int[count];


                List<int> list = new List<int>(count);
                Array.Copy(_items,0,newItems,0,count);
                list.Add(count);
                return list;
            }
            public int IndexOf(int item)
            {
                
                return Array.IndexOf(_items, item, 0, _size);
            }
            public void Insert(int index, int item)
            {
                
                if ((uint)index > (uint)_size)
                {
                    
                }
                
                if (_size == _items.Length) EnsureCapacity(_size + 1);
                if (index < _size)
                {
                    Array.Copy(_items, index, _items, index + 1, _size - index);
                }
                _items[index] = item;
                _size++;
                _version++;
            }
            public int LastIndexOf(int item)
            {
                
                if (_size == 0)
                {  
                    return -1;
                }
                else
                {
                    return LastIndexOf(item);
                }
            }
            public bool Remove(int item)
            {
                int index = IndexOf(item);
                if (index >= 0)
                {
                    Remove(index);
                    return true;
                }

                return false;
            }
            public void RemoveAt(int index)
            {
                if ((uint)index >= (uint)_size)
                {
                    
                }
                
                _size--;
                if (index < _size)
                {
                    Array.Copy(_items, index + 1, _items, index, _size - index);
                }
                _items[_size] = default(int);
                _version++;
            }

            public void RemoveRange(int index, int count)
            {
                if (index < 0)
                {
                }

                if (count < 0)
                {
                }

                if (_size - index < count)

                if (count > 0)
                {
                    int i = _size;
                    _size -= count;
                    if (index < _size)
                    {
                        Array.Copy(_items, index + count, _items, index, _size - index);
                    }
                    Array.Clear(_items, _size, count);
                    _version++;
                }
            }
            public void Reverse(int Count)
            {
                Reverse(Count);
            }
        }
        
    }
}
