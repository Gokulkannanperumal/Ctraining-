using System;

class StudentInformationSystem
{
    // Enum for student grades
    enum GradeLevel { Freshman, Sophomore, Junior, Senior }

    // Main method where we include various data types
    static void Main()
    {
        // Value Types
        int studentId = 12345;                        // Integer (int)
        float attendancePercentage = 85.6f;           // Float (single-precision)
        double fees = 15000.50;                       // Double (double-precision)
        char gender = 'M';                            // Character (char)
        bool isScholarshipGranted = true;             // Boolean (bool)

        // Reference Types
        string studentName = "Alice Johnson";         // String
        object miscellaneousInfo = "Participates in Sports"; // Object (can hold any data type)

        // Nullable Types
        int? optionalCourseCredits = null;            // Nullable integer
        double? examScore = 78.5;                     // Nullable double

        // Enum
        GradeLevel grade = GradeLevel.Sophomore;      // Enum for student's grade level

        // Arrays
        int[] subjectMarks = { 85, 90, 78, 92, 88 };  // Integer array to store subject marks
        string[] subjects = { "Math", "Science", "English", "History", "Art" }; // String array for subjects

        // Print student information using various data types
        Console.WriteLine("Student Information System");
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Student ID: {studentId}");          // Integer
        Console.WriteLine($"Name: {studentName}");              // String
        Console.WriteLine($"Gender: {gender}");                 // Char
        Console.WriteLine($"Grade Level: {grade}");             // Enum
        Console.WriteLine($"Attendance Percentage: {attendancePercentage}%");  // Float
        Console.WriteLine($"Fees: ${fees}");                    // Double
        Console.WriteLine($"Scholarship Granted: {isScholarshipGranted}");     // Boolean
        Console.WriteLine($"Optional Course Credits: {(optionalCourseCredits.HasValue ? optionalCourseCredits.ToString() : "Not Taken")}"); // Nullable Type
        Console.WriteLine($"Exam Score: {examScore ?? 0}");     // Nullable double with null-coalescing
        Console.WriteLine($"Miscellaneous Info: {miscellaneousInfo}"); // Object

        // Display subject marks using an array
        Console.WriteLine("\nSubject Marks:");
        for (int i = 0; i < subjects.Length; i++)
        {
            Console.WriteLine($"{subjects[i]}: {subjectMarks[i]}");
        }
    }
}
