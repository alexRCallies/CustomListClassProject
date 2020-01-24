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
        public void CustomRemove(T value)
        {
           for(int i = 0; i < count; i++)
           {
                if (customLists[i].Equals(value))
                {
                    for(int j = i; j < count; j++)
                    {
                        customLists[j] = customLists[j + 1];
                        if(customLists[j+1].Equals(default(T)))
                        {
                            break;
                        }
                    }
                    break;
                }
           }
            count--;
        }
    }
}
