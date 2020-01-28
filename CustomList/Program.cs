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
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> custom = new CustomList<int>();
            CustomList<int> list = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            string expected;
            string actual;
            expectedList.CustomAdd(1);
            expectedList.CustomAdd(2);
            expectedList.CustomAdd(3);
            expectedList.CustomAdd(4);
            expectedList.CustomAdd(5);
            expectedList.CustomAdd(6);
            //Act
            custom.CustomAdd(1);
            custom.CustomAdd(3);
            custom.CustomAdd(5);
            list.CustomAdd(2);
            list.CustomAdd(4);
            list.CustomAdd(6);
            customList.CustomZip(custom, list);
            expected = expectedList.ToString();
            actual = customList.ToString();
            Console.WriteLine(actual);
            Console.WriteLine(expected);
            Console.ReadLine();
        }
    }
}
