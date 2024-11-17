using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class arrays
    {

        //multidimenssional array

        int[] array = new int[3] { 10, 12, 15 };

        int[,] mularray = new int[3, 3]
        {   { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Declare a jagged array with 3 inner arrays
        int[][] jaggedArray = new int[3][];

        
        public void jaggarr()
        {
            jaggedArray[0] = new int[]{10,20};
            jaggedArray[1] = new int[] {20,31,40};
            jaggedArray[2] = new int[] { 45, 25, 37,85 };

            for (int i = 0; i < 3; i++)//row
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)//column
                {
                    Console.Write(jaggedArray[i][j]);
                }
                Console.Write("\n");
            }


        }


        public void looparray()
        {
            int newvar = mularray[1, 1];


            for (int i = 0; i < 3; i++)//row
            {
                for (int j = 0; j < 3; j++)//column
                {
                    Console.Write(mularray[i, j]);
                }
                Console.Write("\n");
            }
        }



    }
}
