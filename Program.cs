using System;
using System.Globalization;
using System.IO.Pipes;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            // int score = 80;
            // float avg = 65.5f;
            // double digit = 35.8;
            // decimal label = 23.0m;
            // string greet = "Hello";
            // char person = 'A';
            // bool isAdmit = true;

            // //implicit Type conversion

            // //explicit Type conversion

            // string digitStr = score.ToString();

            // //Constant

            // const double PI = 3.14;

            // //var

            // var name = "Subhajit";

            // //arithmatic operators

            // int a = 15;
            // int b = 4;
            // int sum = a + b;
            // int diff = a - b;
            // int mult = a * b;
            // int div = a / b;
            // int rem = a % b;
            // Console.WriteLine(sum + " " + diff + " " + mult + " " + div + " " + rem);

            // //comparison operator

            // bool isEqual = a == b;
            // bool isBigger = a > b;
            // bool isBigOrEqual = a >= b;
            // bool isSmaller = a < b;
            // bool isSmallerOrEqual = a <= b;
            // bool isNotEqual = a != b;

            // Console.WriteLine(isEqual + " " + isBigger + " " + isBigOrEqual + " " + isSmaller + " " + isSmallerOrEqual + " " + isNotEqual);

            // //logical operator

            // bool check1 = isBigger && isSmaller;
            // bool check2 = isBigger || isSmaller;
            // bool check3 = !isEqual;

            // Console.WriteLine(check1 + " " + check2 + " " + check3);

            // //Assignment Operators 

            // score += 10;
            // Console.WriteLine(score);
            // score -= 10;
            // Console.WriteLine(score);
            // score *= 10;
            // Console.WriteLine(score);
            // score /= 10;
            // Console.WriteLine(score);
            // score %= 10;
            // Console.WriteLine(score);

            // //Operation precedence PEMDAS

            //ReadLine() Method

            // Console.WriteLine("What is Your name?");
            // string userName = Console.ReadLine();
            // Console.WriteLine("What is your Age?");
            // if (int.TryParse(Console.ReadLine(), out int age))
            // {
            //     //string interpolation
            //     Console.WriteLine($"{userName} is {age} years old");
            // }
            // else
            // {
            //     Console.WriteLine("That's not a valid number");
            // }

            // String Formatting 

            // string name = "Subhajit";
            // int age = 24;
            // double height = 5.5;
            // double salary = 20500.50;

            // //for Indian rupees

            // Thread.CurrentThread.CurrentCulture = new CultureInfo("en-IN");

            // Console.WriteLine("Name: {0}, age: {1}, height: {2}",name,age,height);
            // Console.WriteLine("Salary in currency: {0:C}",salary);
            // Console.WriteLine("Salary in one digit: {0:F3}",salary);

            // conditional statements if-else

            // Console.WriteLine("Enter the score");
            // if(int.TryParse(Console.ReadLine(),out int score))
            // {
            //     Console.WriteLine($"Your Entered Number is {score}");
            // } else
            // {
            //     Console.WriteLine("Please enter a valid Number!");
            // }

            // if(score >= 80)
            // {
            //     Console.WriteLine("A");
            // } else if(score < 80 && score >= 60)
            // {
            //     Console.WriteLine("B");
            // } else if(score < 60 && score >= 40)
            // {
            //     Console.WriteLine("C");
            // } else
            // {
            //     Console.WriteLine("D");
            // }

            //Switch case

            // int day = 5;

            // switch (day)
            // {
            //     case 1:
            //         Console.WriteLine("Monday");
            //         break;
            //     case 2:
            //         Console.WriteLine("Tuesday");
            //         break;
            //     case 3:
            //         Console.WriteLine("Wednesday");
            //         break;
            //     case 4:
            //         Console.WriteLine("Thursday");
            //         break;
            //     case 5:
            //         Console.WriteLine("Friday");
            //         break;
            //     default:
            //         Console.WriteLine("Weekend");
            //         break;
            // }

            //Modern day approach

            // string dayName = day switch
            // {
            //     1 => "Monday",
            //     2 => "Tuesday",
            //     3 => "Wednesday",
            //     4 => "Thursday",
            //     5 => "Friday",
            //     _ => "Weekend"
            // };

            // Console.WriteLine(dayName);


            //loops

            //for loop 

            // for(int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine($"The Number is {i}");
            // }

            // int number = 0;
            // while(number < 5)
            // {
            //     Console.WriteLine($"The Number is {number}");
            //     number++;
            // }

            // do
            // {
            //     Console.WriteLine($"The Number is {number}");
            //     number++;
            // }while(number < 5);

            // int[] numbers = {10,20,30,40};

            // foreach(int n in numbers)
            // {
            //     Console.WriteLine($"The Number is {n}");
            // }

            //local methods

            // static void Greet(string name)
            // {
            //     Console.WriteLine($"Hello {name}");
            // }

            // Greet("Subhajit");

            // int firstM = Add(5,6);
            // double secondM = Add(2.3,3.4);
            // string thirdM = Add("10","20");

            // Console.WriteLine(firstM + " " + secondM + " " + thirdM);

            // Optional parameters

            // static void DisplayMessage(string message, string prefix = "Info", bool addTimeStamp = false)
            // {
            //     if (addTimeStamp)
            //     {
            //         Console.WriteLine($"{prefix}: {message} on [{DateTime.Now.Year}]");
            //     }
            //     else
            //     {
            //         Console.WriteLine($"{prefix}: {message}");
            //     }
            // }

            // DisplayMessage("Hello");
            // DisplayMessage("Warning","Alert");
            // DisplayMessage("Error","Error",true);

            //Named Parameters: It helps us to change the order in the arguments & send clear arguments to Methods

            // static void DispayDetails(string name, int age, string email)
            // {
            //     Console.WriteLine($"Name: {name}, age: {age}, email: {email}");
            // }

            // DispayDetails(name: "Subhajit Malick", age: 24, email: "subhajitmalick64@gmail.com");
            // DispayDetails(email: "doejohn@gmail.com", name: "John Doe", age: 7);

            // Arrays: arrays in c# non-mutable if we want to add or remove any element we need to create a new array.
            //single dimension array GetLength() --> for length

            // int[] numbers = {10,20,30,40};

            // foreach(var n in numbers)
            // {
            //     Console.Write(n + "\t");
            // }

            // multi dimentional array

            //declare size 

            // int[,] matrix1 = new int[3, 3]
            // {
            //     {1,2,3},
            //     {4,5,6},
            //     {7,8,9}
            // };

            // //shorthand
            // int[,] matrix2 =
            // {
            //     {1,2,3},
            //     {4,5,6}
            // };

            // foreach (var n in matrix1)
            // {
            //     Console.WriteLine($"Number iin matrix is: {n}");
            // }

            // for (int i = 0; i < matrix2.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matrix2.GetLength(1); j++)
            //     {
            //         Console.WriteLine($"The numbers in matrix 2 is {matrix2[i, j]}");
            //     }
            // }

            // int[] numbers = { 4, 1, 5, 3, 7, 2, 9 };
            // Array.Sort(numbers);
            // Console.Write("Sorted Array:\t");
            // foreach (var n in numbers)
            // {
            //     Console.Write(n + "\t");
            // }
            // Console.WriteLine();
            // Console.Write("Reversed Array:\t");
            // Array.Reverse(numbers);
            // foreach (var n in numbers)
            // {
            //     Console.Write(n + "\t");
            // }
            // Console.WriteLine();
            // int index = Array.IndexOf(numbers, 9);
            // Console.WriteLine($"Index of 9 is {index}");

            // Collections

            // list: list we can think as dynamic array

            // List<string> mylist = new List<String>()
            // {
            //     "John",
            //     "Doe",
            //     "Alex"
            // };

            // foreach(string name in mylist)
            // {
            //     Console.WriteLine($"forEach normal: {name}");
            // }

            // //.count used for length if the list

            // for(int i = 0; i < mylist.Count; i++)
            // {
            //     Console.WriteLine($"for normal: {mylist[i]}");
            // }

            // mylist.Add("Harry");

            // foreach(string name in mylist)
            // {
            //     Console.WriteLine($"forEach add: {name}");
            // }
            // mylist.Insert(0,"Henry");

            // foreach(string name in mylist)
            // {
            //     Console.WriteLine($"forEach insert: {name}");
            // }
            // mylist.Remove("Doe");
            // foreach(string name in mylist)
            // {
            //     Console.WriteLine($"forEach remove: {name}");
            // }
            // mylist.RemoveAt(0);
            // foreach(string name in mylist)
            // {
            //     Console.WriteLine($"forEach removeAt: {name}");
            // }

            // bool isMember = mylist.Contains("Harry");
            // int pos = mylist.IndexOf("Harry");

            // Console.WriteLine($"Harry is {isMember}, at {pos}");

            // Dictionary: dictionary is somethimg like object in JS it has key-value pair & every key must be unique

            // Dictionary<int,string> mydict = new Dictionary<int, string>
            // {
            //     {1,"John"},
            //     {2,"Alex"},
            //     {3,"Henry"}
            // };
            // mydict.Add(4,"Harry"); //add a new
            // foreach(var name in mydict)
            // {
            //     Console.WriteLine($"Name in dict: {name}");
            // }
            // mydict[4] = "Harry got replaced"; //changing value in a key
            // foreach(var name in mydict)
            // {
            //     Console.WriteLine($"Name in dict after replace: {name}");
            // }

            // mydict[5] = "George"; //if key is't present it will create instead of update
            // foreach(var name in mydict)
            // {
            //     Console.WriteLine($"Name in dict after new: {name}");
            // }

            // //access a value based on key safest way
            // if(mydict.TryGetValue(6, out string stud))
            // {
            //     Console.WriteLine($"Name at {6} is {stud}");
            // } else
            // {
            //     Console.WriteLine("Key not found");
            // }

            // mydict.Remove(5);
            // foreach(var name in mydict)
            // {
            //     Console.WriteLine($"Name in dict after remove: {name}");
            // }

            // List<int> allKeys = mydict.Keys.ToList();   //list of all keys
            // List<string> allValues = mydict.Values.ToList();   //List of all values

            // foreach(var n in allKeys)
            // {
            //     Console.WriteLine(n);
            // }

            // foreach(var n in allValues)
            // {
            //     Console.WriteLine(n);
            // }

            // HashSet: it's used for unordered unique items, & set operations like unique interactions, etc

            HashSet<int> prime = new HashSet<int>
            {
                2,3,5,7
            };
            HashSet<int> odd = new HashSet<int>
            {
                1,3,5,7
            };

            bool result = prime.Add(11);
            Console.WriteLine($"Added 11: {result}");
            result = prime.Add(7);
            Console.WriteLine($"Added 7: {result}");
            foreach(var n in prime)
            {
                Console.WriteLine(n);
            }

            result = prime.Remove(11);
            Console.WriteLine($"Removed 11: {result}");
            result = prime.Remove(11);
            Console.WriteLine($"Removed 11: {result}");

            // prime.UnionWith(odd);  //a union b
            // prime.IntersectWith(odd);  //a Intersection b
            prime.ExceptWith(odd);  //a Minus b or a Intersection b complement
            foreach(var n in prime)
            {
                Console.WriteLine(n);
            }

        }

        //Method Overloading: Usually if we want to directly call a method inside Main function we need to make the function static otherwise we need to create an Object then need to call. C# does not allow overloaded functions inside Main method

        // static int Add(int a, int b)
        // {
        //     return a + b;
        // }

        // static double Add(double a, double b)
        // {
        //     return a + b;
        // }

        // static string Add(string a, string b)
        // {
        //     return a + b;
        // }
    }
}
