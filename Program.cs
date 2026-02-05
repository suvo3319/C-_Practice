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

            string name = "Subhajit";
            int age = 24;
            double height = 5.5;
            double salary = 20500.50;

            //for Indian rupees

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-IN");

            Console.WriteLine("Name: {0}, age: {1}, height: {2}",name,age,height);
            Console.WriteLine("Salary in currency: {0:C}",salary);
            Console.WriteLine("Salary in one digit: {0:F3}",salary);
        }
    }
}
