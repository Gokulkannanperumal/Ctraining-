using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class collections
    {
        //
        string[] Cars = { "hyundai", "Honda", "BMW" };


        //Collections
        /*Collections standardize the way of which the objects are handled by your program. 
        In other words, it contains a set of classes to contain elements in a generalized manner. 
        With the help of collections, the user can perform several operations on objects like the
        store, update, delete, retrieve, search, sort etc.*/

        //Types of Collections
        // Generic Collections => {System.Collections.Generic}

        List<string> newlist = new List<string>();
        Dictionary<string, List<string>> CARS = new Dictionary<string, List<string>>();
        // Non Generic Collections
        ArrayList newarraylist = new ArrayList();

        WorkingOnFiles obj = new WorkingOnFiles();
        public void CollectionExample()
        {
            newlist.Add("Honda");
            newlist.Add("BMW");
            newlist.Add("AUDI");
            newlist.Add("BENZ");

            int value = newlist.IndexOf("Honda");


            CARS.Add("Honda", new List<string> { "CITY", "AMAZE", "I10" });
            CARS.Add("BMW", new List<string> { "BMW1", "BMW2", "BMW3" });


            foreach(string listvalue in newlist)
            {
                Console.WriteLine(listvalue + "\n");
            }

            newlist.Clear();//clear all the values
            bool isavailable = newlist.Contains("BMW");
            bool isequal= newlist.Equals("BMW");


            //
            foreach(KeyValuePair<string,List<string>> KVP in CARS)
            {
                Console.WriteLine("The car make is :"+ KVP.Key);

                foreach(string car in KVP.Value)
                {
                    Console.WriteLine($"The car {KVP.Key} list is : {car}");
                }

            }

            //Queue
            //A Queue<T> represents a first-in, first -out (FIFO)collection.
            Queue<string> line = new Queue<string>();
            line.Enqueue("Packect1");//to add the data
            line.Enqueue("Packect2");
            line.Enqueue("Packect3");

            //line.Dequeue() // to read the data


            //

        }




    }
}
