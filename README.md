# CustomListClassProject
Overloading Operator -
Overloading the c# operator - to have it subtract one list from another to create a smaller list with the the remaining
values of the first list minus the second list.

Parameters
CustomList<T> b
CustomList<T> c

Returns
CustomList<T> a
The return of this overload is the subtraction of "b" list minus "c" list
if "b" list has any values that "c" list doesnt have. it will created to "a" list
otberwise it will not

Syntax
 public static CustomList<T> operator - (CustomList<T> b, CustomList<T> c)

EXAMPLE
            List<int> customList = new List<int>();
            List<int> custom = new List<int>();
            List<int> list = new List<int>();
           
            
            custom.Add(1);
            custom.Add(3);
            custom.Add(5);
            list.Add(2);
            list.Add(1);
            list.Add(6);
            customList = custom - list;
           froeach(int numbers in customList)
           {
            Console.WriteLine(numbers);
           }
OUTPUT

3
5
            