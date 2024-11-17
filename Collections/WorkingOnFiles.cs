using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collections
{
    public class WorkingOnFiles
    {

        //path

        string filepath = Path.Combine(@"F:\15092024 Sample app\ConsoleApp1\Files\Log.txt");

        
        
        //read the data from files

        public void writetext(string content)
        {

            File.AppendAllText(filepath,content);
        }

        public void readtext()
        {
            string Content = File.ReadAllText(filepath);
            Console.WriteLine(Content);
        }
    }
}
