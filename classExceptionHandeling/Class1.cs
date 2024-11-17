using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classExceptionHandeling
{
    public class Exceptiohandeling
    {
        public void AddData()
        {
            try
            {
                int[] numbers = new int[] { 1, 2, 3, 4 };

                int finaloutput = numbers[0] + numbers[5];

                


            }
            catch (Exception objEx)
            {

                Console.WriteLine(objEx.ToString());
            }
            finally
            {
                int finaloutput1 = 10+20;//mandatory
            }
        }

        public void DifferencebetweenThedata()
        {
            try
            {
                int[] numbers = new int[] { 1, 2, 3, 4 };

                int finaloutput = numbers[0] - numbers[5];

            }
            catch (Exception objEx)
            {

                Console.WriteLine(objEx.ToString());
            }

        }

        public void displayData()
        {
            try
            {
                int[] numbers = new int[] { 1, 2, 3, 4 };

                int finaloutput = numbers[0] + numbers[3];

                Console.WriteLine("finaloutput : " + finaloutput);
            }
            catch (Exception objEx)
            {

                Console.WriteLine(objEx.ToString());
            }


        }


    }

    class Customexception : Exception
    {

    }
}
