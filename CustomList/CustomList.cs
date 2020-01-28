using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
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
        private T[] customLists;


        public T this[int index]
        {
            get
            {
                return customLists[index];
            }
            set
            {
                if (value.Equals(default(T)))
                {
                    //try
                   // {
                        CheckIndex(-1);
                    //}
                   // catch (IndexOutOfRangeException)
                   // {
                   //     Console.WriteLine("Index is out of range please try again");
                   // }
                }
                customLists[index] = value;
            }
        }
        public int index;
        private T[] tempArray;


        public CustomList()
        {
            customLists = new T[capacity];
        }

        public void CustomAdd(T value)
        {
            customLists[Count] = value;
            count++;
            if (count == capacity)
            {
                IncreaseCapacity();
            }
        }
        public void IncreaseCapacity()
        {
            capacity = capacity * 2;
            tempArray = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                tempArray[i] = customLists[i];
            }
            customLists = tempArray;
            //for (int i = 0; i < count; i++)
            //{
            //    a.CustomAdd(c[i]);
            //}
        }
        public void CustomRemove(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (customLists[i].Equals(value))
                {
                    for (int j = i; j < count; j++)
                    {
                        customLists[j] = customLists[j + 1];
                        if (customLists[j + 1].Equals(default(T)))
                        {
                            count--;
                            break;
                        }
                    }
                    break;
                }
            }
        }
        //public void DecreaseIndex();
        public void CheckIndex(int index1)
        {

            if (customLists[index1].Equals(default(T)))
            //{
            //    try
            //    {
                    CheckIndex(-1);
            //    }
            //    catch (IndexOutOfRangeException)
            //    {
            //        Console.WriteLine("Index Out Of Range");
            //    }
            //}
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return customLists[i];
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string value;
            for(int i = 0; i<count; i++)
            {
                
              stringBuilder.Append(customLists[i]);
                
            }
            value = stringBuilder.ToString();
            return value;
        }
       public static CustomList<T> operator + (CustomList<T> b, CustomList<T> c)
        {
            CustomList<T> a = new CustomList<T>();
            for(int i = 0; i < b.count; i++)
            {
                a.CustomAdd(b[i]);
            }
            for(int i = 0; i < c.count; i++)
            {
                a.CustomAdd(c[i]);
            }
            return a;
        }
        public static CustomList<T> operator - (CustomList<T> b, CustomList<T> c)
        {
            CustomList<T> a = new CustomList<T>();
            for(int i = 0; i < b.count; i ++)
            {
                a.CustomAdd(b[i]);
            }
            for(int i = 0; i < b.count; i++)
            {
                a.CustomRemove(c[i]);
            }
            return a;
        }
        public void CustomZip(CustomList<T> a, CustomList<T> b)
        {
            for(int i = 0; i < a.count; i++)
            {
                CustomAdd(a[i]);
                for (int j = i; j < b.count; j++)
                {
                    CustomAdd(b[j]);
                    
                    break;
                }
            }
            if (b.count > a.count)
            {
                for (int k = a.count; k < b.count; k++)
                {
                    CustomAdd(b[k]);
                }
            }
        }
    }
}
