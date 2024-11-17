using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligatesAndEvents
{

    public delegate void ProcessNotifier(string Message);
    public class Deligates
    {
        public static event ProcessNotifier evtProcessNotifier;
        public void NotifyMessage(string Message)
        {
            Console.WriteLine(Message);
        }
        public void NotifyNewMessage(string Message)
        {
            Console.WriteLine(Message);
        }

        int count = 0;

        public void increasecount()
        {
            for(count = 0; count < 3; count++)
            {
                if (count==2)
                {
                    invokeevent("the count is :" + count.ToString());
                }
            }
        }//call back

       
        public void invokeevent(string message)
        {
            if (evtProcessNotifier != null)
            {
                evtProcessNotifier.Invoke(message);
            }
        }
    }
}
