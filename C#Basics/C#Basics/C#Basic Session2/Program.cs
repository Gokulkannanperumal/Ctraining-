

using Microsoft.VisualBasic;
using System;
using System.IO;

namespace C_Basic_Session
{

    public enum DaysOfWeek   //
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class DataTypeConversion
    {

        static void Main()
        {
            //Data Type conversion
            // Implicit Conversion
            // Explicit Conversion

            //implicit Conversion
            // Implicit type conversion − These conversions are performed by C# in a type-safe manner. 
            //For example, are conversions from smaller to larger integral types and conversions from derived classes to base classes.

            int num = 10;
            double convertedNum = num; // Implicit conversion from int to double


            Console.WriteLine("output is " + convertedNum);


            //Explicit Conversion (Casting):
            // Description: This is required when there is a possibility of data loss or when converting between
            //incompatible types.The developer explicitly tells the compiler how to convert the types.

            //double convertedNum1 = 10.5;
            //int num1 = (int)convertedNum1;

            //int number = 12345;

            //object objnumber = 7894568;

            //string stringnum = (string)objnumber; //numbers.ToString();

            //string numbers = "ABC";

            //bool success = int.TryParse(numbers, out int result);

            ////TryParse

            //if (success)
            //{
            //    Console.WriteLine("output is " + result);

            //}
            //else
            //{
            //    Console.WriteLine("INPUT is INVALID");
            //}


            //Enunumeration Objenunumeration = new Enunumeration();
            // string returndata =   Objenunumeration.class8std();

            decissionMakingStructure decissionMakingStructure = new decissionMakingStructure();
            decissionMakingStructure.ifcondition();
        }


        class Enunumeration
        {
            //Enum => its one of the value type
            /*Purpose: An enum is a value type that defines a set of named constants. It is used when you want to represent a collection of 
            related values that are integral in nature. */
            //Usage: Used to give meaningful names to integer values to make the code more readable.

            const double pi = 3.14;

            public string class8std()
            {
                int day1 = (int)DaysOfWeek.Sunday;
                string day2 = "monday";
                string day7 = "saturday";

                return "monday";

            }
            public void class9std()
            {
                int day1 = (int)DaysOfWeek.Sunday;
                string day2 = "moday";
                string day7 = "saturday";
            }

            public void class10std()
            {
                string day1 = "sunday";
                string day2 = "monday";
                string day7 = "saturday";

            }



        }


        class decissionMakingStructure
        {
            //In C#, decision-making structures allow a program to execute specific blocks of code based on conditions. The most common decision-making structures in C# are:
            //if statement
            //if-else statement
            //else-if ladder
            //switch statement


            /*1. if statement
                The if statement checks a condition, and if it evaluates to true, the block of code inside the if 
             statement is executed.*/

            /*operators:
            
            Arithmetic Operators
            Relational Operators
            Logical Operators
            Bitwise Operators
            Assignment Operators
            Unary Operators
            Ternary Operators
            Misc Operators */

            public void ifcondition()
            {
                int age;

                //Console.WriteLine("Enter your age:");
                //age = 17;

                //if (age >= 18)
                //{
                //    Console.WriteLine("You are eligible to vote.");
                //}
                //else
                //{
                //    Console.WriteLine("You are not eligible to vote.");
                //}

                //if else ladder
                Console.WriteLine("Enter your score:");
                int score = 76;

                if (score >= 90)
                {
                    Console.WriteLine("Grade: A");
                }
                else if (score >= 80)
                {
                    Console.WriteLine("Grade: B");
                }
                else if (score >= 70)
                {
                    Console.WriteLine("Grade: C");
                }
                else if (score >= 60)
                {
                    Console.WriteLine("Grade: D");
                }
                else
                {
                    Console.WriteLine("Grade: F");
                }




                //switch
                /*The switch statement evaluates a single expression and matches its result against different cases. 
                It’s a cleaner way to handle multiple conditions when working with a single variable.
                */
                int day = 5;
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    default:
                        Console.WriteLine("Other day");
                        break;

                }

                // example 
                DaysOfWeek today = (DaysOfWeek)2;
                int num = 10;
                switch (today)
                {
                    case DaysOfWeek.Sunday:
                        Console.WriteLine("It's Sunday! Time to relax.");
                        break;
                    case DaysOfWeek.Monday:
                        Console.WriteLine("It's Monday! Start of the work week.");
                        break;
                    case DaysOfWeek.Tuesday:
                        Console.WriteLine("It's Tuesday! Keep the momentum going.");
                        break;
                    case DaysOfWeek.Wednesday:
                        Console.WriteLine("It's Wednesday! Halfway through the week.");
                        break;
                    case DaysOfWeek.Thursday:
                        Console.WriteLine("It's Thursday! Almost the weekend.");
                        break;
                    case DaysOfWeek.Friday:
                        Console.WriteLine("It's Friday! Weekend is here.");
                        break;
                    case DaysOfWeek.Saturday:
                        Console.WriteLine("It's Saturday! Enjoy your weekend.");
                        break;
                    default:
                        Console.WriteLine("Invalid day.");
                        break;
                }


        }

        }
    }
}

