using System;

namespace dotNetBasics
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //variables

            //static int x = 10; -static variable
            // int y = 20;- instance variable
            //const float PI = 3.14f-constant variable we cant change
            //readonly int z; - readonly variable

            // program for printing 1 to 10 numbers using for loop

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(j);
            }

            // factorial of a number 

            int i;
            int fact = 1;
            int number;

            Console.WriteLine("Enter any number:");
            number = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);



            // program for lrgest among to numbers using if else

            int num1 = 10;
            int num2 = 20;

            if (num2 > num1)
            {
                Console.WriteLine("num2 is largest");
            }
            else
            {
                Console.WriteLine("num1 is largest");
            }

            // program using while loop to check if two values are same 

            int d = 1;
            int e = 2;

            while (d == e)
            {
                Console.WriteLine("different");
            }

            //using switch statement

            int marks = 90;

            switch (marks)
            {
                case 1:
                    Console.WriteLine(60);
                    break;

                case 2:
                    Console.WriteLine(70);
                    break;

                case 3:
                    Console.WriteLine(80);
                    break;

                case 4:
                    Console.WriteLine(90);
                    break;
                default:
                    Console.WriteLine("Invalid marks");
                    break;

                    //Type casting

                    //explicit data loss
                    double x = 10.23;
                    int y = (int)x; //converting double to integer

                    string s1 = "100";
                    int i1 = Convert.ToInt32(s1);// converting string to integer

                    double d1 = 2.12;
                    int i2 = Convert.ToInt32(d1);    //converting double to integer



                    //Example to take String input from user
                    string str;
                    Console.Write("Enter a string:");
                    str = Console.ReadLine();
                    Console.WriteLine("your entered {str}");

                    //BOXING-UNBOXING

                    int a = 10;
                    object b = a;//boxing
                    int c = (int)b;//unboxing

            }
        }
    }
}
