using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTrainig
{
    public delegate void SampleDelegate(string message);//created a delegete

    public class DelegatesNew
    {
        public static event SampleDelegate evntSampleDelegate;

        public void increasecount()
        {
            for(int count = 0; count < 3; count++)
            {
                if(count == 2)
                {
                    validateevent("Event Sucessfully triggered");
                }
            }
        }

        public void validateevent(string message)
        {
            if(evntSampleDelegate != null)
            {
                evntSampleDelegate.Invoke(message);
            }
        }
    }
}
