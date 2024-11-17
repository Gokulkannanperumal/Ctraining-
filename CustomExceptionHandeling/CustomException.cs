using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionHandeling
{
    public class CustomException
    {

        public void HandelingException()
        {
            Console.WriteLine("Enter your age: ");
            string age;

            try
            {
                // Parse the user input
                age = Console.ReadLine();

                // Validate the age
                ValidateAge(age);

                Console.WriteLine("Age is valid.");
            }
            catch (InvalidAgeException ex)
            {
                // Handle the custom InvalidAgeException
                Console.WriteLine("InvalidAgeException caught: " + ex.Message);
            }
            catch(InvalidDataException EX)
            {
                Console.WriteLine("InvalidDataException caught: " + EX.Message);
            }
            catch (Exception ex)
            {
                // Handle any other general exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Validation complete.");
            }
        }

        // Method to validate age and throw a custom exception if invalid
        static void ValidateAge(string age)
        {

            int Age = int.Parse(age);
            if (Age > 80)
            {
                throw new InvalidDataException("you are enter data greatr than 80");
            }
            else if (Age < 0)
            {
                //throw new Exception("invalid age");
                throw new InvalidAgeException("you are entered less than 0");
            }
        }
    }
}
// Custom exception for invalid age
public class InvalidAgeException : Exception
{
    public InvalidAgeException() { }//default constructor

    public InvalidAgeException(string message) : base(message) { }

    public InvalidAgeException(string message, Exception innerException)
        : base(message, innerException) { }
}
public class InvalidDataException : Exception
{
    public InvalidDataException() { }//default constructor

    public InvalidDataException(string message) : base(message) { }

    public InvalidDataException(string message, Exception innerException)
        : base(message, innerException) { }
}


