using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private int count = 0;
        public int Count
        {
            get
            {
                return count;
            }
        }
        private int capacity = 4;
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public T[] customLists;
        public T[] tempArray;
        public CustomList()
        {
            this.customLists = new T[capacity];
        }

        public void CustomAdd(T value)
        {
            customLists[Count] = value;
            count++;
            if(count == capacity)
            {
                IncreaseCount();
            }
        }
        public void IncreaseCount()
        {
            capacity *= 2;
            tempArray = new T[capacity];
            customLists = tempArray;
            tempArray = customLists;
        }
    }
}
