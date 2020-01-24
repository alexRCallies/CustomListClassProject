using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 1;
            int secondValue = 2;
            int thirdValue = 3;
            //Act
            customList.CustomAdd(firstValue);
            customList.CustomAdd(secondValue);
            customList.CustomAdd(thirdValue);
            customList.CustomRemove(thirdValue);
            customList.CheckIndex(100000);
            Console.WriteLine(customList[100000]);
            Console.ReadLine();
        }
    }
}
