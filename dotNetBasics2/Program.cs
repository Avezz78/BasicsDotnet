using System;

namespace dotNetBasics2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*functions

                   1.Built -in-Functions
                   2.user defined

                   syntax for user defined function:< Access specifier >< Return type >< function name > (parameter list)
                    {
                   function body
                    }
                   Method signature - consisting of two things i.e method name and parameter list
                   Return statement - terminates the execution and returns the control to the calling statement.*/

            //example for call by value

            int a1 = 10;
            int b1 = a1;

            b1 = 30;
            Console.WriteLine(a1); //10
            Console.ReadLine();

            //example for call by refrence
            Employee Emp1 = new Employee();
            Emp1.EmployeeID = 72001;
            Emp1.Name = "joy";
            Employee Emp2 = Emp1;
            Emp1.Name = "Smith";
            Console.WriteLine($"Emp1 Name = {Emp1.Name}");
            Console.WriteLine($"Emp2 Name = {Emp2.Name}");
            Console.ReadLine();
        }
    }
    public class Employee
    {
        public int EmployeeID;
        public string Name;
    }

    /*strings are immutable in c#
          immutable means - cannot b changed
          mutable means - can b changed 

          overriding toString syntax
         Public override string ToString()
           {
              return Statement;
           } 

          equals() - compare the content of two objects n return bolean value
          syntax- public virtual bool equals(object obj)
          {
              ------
          } */

    /*Example code for ToString()
             student st1 = new student();
    st1.FirstName = "mohammed";
             st1.LastName = "Avez";
             Console.WriteLine(st1.ToString());
             Console.ReadLine();
     }

    public class student
    {
    public string FirstName;
    public string LastName;
    //Overriding the Virtual ToString method of Object class
    //Overriding the Virtual method using override modifier
    public override string ToString()
    {
        return FirstName + ", " + LastName;

    }
    }*/

    /*Example for equals method
     userName C1 = new userName();
     C1.FirstName = "sahil";
             C1.LastName = "khan";
             userName C2 = C1;
     Console.WriteLine($"C1 == C2: {C1 == C2}");
             Console.WriteLine($"C1.Equals(C2): {C1.Equals(C2)}");
             Console.ReadLine();
         }
     }
     public class userName
    {
     public string FirstName { get; set; }
     public string LastName { get; set; }
    } */
}
