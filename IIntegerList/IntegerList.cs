using System;

namespace Zad1
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int capacity;
        private int count;

        public IntegerList()
        {
            capacity = 4;
            count = 0;
            _internalStorage = new int[4];
        }

        public IntegerList(int initialSize)
        {
            if (initialSize < 1)
            {
                throw new ArgumentException("Početni kapacitet mora biti veći od 0.");
            }
            capacity = initialSize;
            count = 0;
            _internalStorage = new int[initialSize];
        }

        public void Add(int item)
        {
            if (count == capacity)
            {
                capacity = capacity * 2;
                int[] pom = new int[capacity];
                for (int i = 0; i < count; ++i)
                {
                    pom[i] = _internalStorage[i];
                }
                _internalStorage = pom;
            }

            _internalStorage[count] = item;
            count++;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                return false;
            }

            for (int i = index; i < count - 1; ++i)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            count--;
            return true;
        }

        public bool Remove(int item)
        {
            for (int i = 0; i < count; ++i)
            {
                if (_internalStorage[i] == item)
                {
                    RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public int GetElement(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            return _internalStorage[index];
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < count; ++i)
            {
                if (_internalStorage[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Clear()
        {
            _internalStorage = new int[capacity];
            count = 0;
        }

        public bool Contains(int item)
        {
            if (IndexOf(item) != -1)
            {
                return true;
            }
            return false;
        }

    }

}

