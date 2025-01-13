using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FixedSizeList<T>
    {
        private T[] items;
        private int count = 0;

        public int Capacity { get; private set; }

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero.");

            Capacity = capacity;
            items = new T[capacity];
        }

        public void Add(T item)
        {
            if (count >= Capacity)
                throw new InvalidOperationException("List is full!");

            items[count++] = item;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException("Invalid index!");

            return items[index];
        }
    }

}

