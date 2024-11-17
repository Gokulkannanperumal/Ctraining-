
using System;
using static System.Formats.Asn1.AsnWriter;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace C_Basic
{

    public class C_Basics
    {


        class ScopeOfVariable
        {
            // 1) Local Variable
            //2) Global Variable

        }

        class Student
        {
            //access modifiers
            public string Name ="Peter"; //Global Variable
            public int ID;
            public string Contact;

            private int Value1 = 10;
            public int Value2 = 20;

            //local variable
            //global variable

            private void studentMarkCalc()
            {
                string Name = "Alice"; //Local Variable

                int value3 = 30;//local variable

                Console.WriteLine("sum of values "+ Name + (Value1 + Value2 + value3));//60

            }

            public void Method2()
            {
                //string Name = "jhon";
                Console.WriteLine("sum of values "+ Name + (Value1 + Value2 ));//60
            }
        }

        static void Main()
        {
            //Data Types 
            //single comment line
            /*multiple comment line
              .....*/


            //Data Types 

            //value types
            //reference types
            // pointers
            // nullable types


            //1. value types

            // Example of Value Type (int)
            //int valueTypeA = 10;
            //int valueTypeB = valueTypeA; // Copying valueTypeA to valueTypeB

            //// Changing value of valueTypeB does not affect valueTypeA
            //valueTypeB = 20;
            //Console.WriteLine("Value Types:");
            //Console.WriteLine($"valueTypeA: {valueTypeA}"); // Output: 10
            //Console.WriteLine($"valueTypeB: {valueTypeB}"); // Output: 20

            //// Example of Reference Type (Student class)
            //Student studentA = new Student();
            //studentA.Name = "Alice";
            //studentA.ID = 1;
            //studentA.Contact = "123456789";
            //// Copying studentA to studentB (both reference the same object)
            //Student studentB = new Student();
            //studentB.Name = "Alice";
            //studentB.ID = 1;
            //studentB.Contact = "123456789";

            //Student studentc = new Student();
            //studentc.Name = "Alice";
            //studentc.ID = 1;
            //studentc.Contact = "123456789";

            //Student studentd = new Student();
            //Student studente = new Student();
            //Student studentf = new Student();
            ////studentB .Name=;

            //// Changing the name through studentB also affects studentA
            //studentB.Name = "Bob";
            //Console.WriteLine("\nReference Types:");
            //Console.WriteLine($"studentA.Name: {studentA.Name}"); // Output: Bob
            //Console.WriteLine($"studentB.Name: {studentB.Name}"); // Output: Bob

            //Student[] Classes =  { studentA, studentA };


            //// types of value types   1 byte = 16 bit
            //// int -> intiger      int age = 25;             4 bytes    -2,147,483,648 to 2,147,483,647                
            ////float               float distance = 3.14f;     4 bytes   ±5.0 × 10⁻³²⁴ to ±1.7 × 10³⁰⁸
            //// double              double salary = 55000.75; 8 bytes    ±1.5 × 10⁻⁴⁵ to ±3.4 × 10³⁸
            ////decimal               decimal price = 199.99m;  16 bytes   ±1.0 × 10⁻²⁸ to ±7.9 × 10²⁸
            ////char -> character      char letter = 'A';      2 bytes    Unicode characters (0 to 65535)
            ////bool -> boolean        bool isValid = true;    1 byte   
            ////0  -> false
            ////1   -> true


            ////refernce type
            ////string welcomeWord = "Hello World";
            ////object 
            ////dynamic
            ////Class

            //object NumData = 50;   //compile time
            //object name = "Alice";
            //object salary = 50.001;

            //dynamic NumData1 = "i am getting data from third party"; //runtime
            //dynamic name1 = "Alice";
            //dynamic salary1 = 50.001;



            ////pointers
            ////Pointer types store the memory address of another type.

            ////unsafe
            ////{
            ////    int* p = &myVariable;  // Pointer to a variable
            ////}

            //int? nullableInt = null;  // Nullable integer
            //bool? isComplete = null;  // Nullable boolean

            //nullableInt = 100;

            //if (nullableInt.HasValue)
            //{
            //    Console.WriteLine(nullableInt.Value);
            //}
            //else
            //{
            //    Console.WriteLine("No value");
            //}

            //if (isComplete.HasValue)
            //{
            //    Console.WriteLine(nullableInt.Value);
            //}
            //else
            //{
            //    Console.WriteLine("No value");
            //}



            //Multiple Declarations:

            //int var1 = 10;
            //int var2 = 20;
            //int Var3 = 30;


            const double Bonus = 5000.00;

            //C_Basics Obj = new C_Basics();

            //Obj.EmpSalary(1000, Bonus);
            //Obj.EmpSalary(11000, Bonus);
            //Obj.EmpSalary(15000, Bonus);
            //Obj.EmpSalary(20000, Bonus);


            Student studentA = new Student();
            studentA.studentMarkCalc();
            studentA.Method2();

            studentA.Value1 = 10;

        }

        public void EmpSalary(double salary, double bonus)
        {
            Console.WriteLine("Emp salary =>" + (salary + bonus));
        }

}


}
