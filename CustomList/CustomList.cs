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
        private int capacity = 1;
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public T[] customLists;
        public CustomList()
        {
            this.customLists = new T[4];
        }

        public void CustomAdd(T value)
        {
            customLists[Count] = value;
            count++;
           
        }
    }
}
