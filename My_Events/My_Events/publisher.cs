using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Events
{
    class publisher
    {
        public delegate void AlarmDelegate(string message);
        public event AlarmDelegate AlarmEvent;
        public void RaiseAlarm()
        {
            AlarmEvent("Latest News");//AlarmEvent.Invoke("Latest News") can also be used
        }
    }
    class Subscriber
    {
        public void EventHandler(string message)
        {
           MessageBox.Show(message);

        }
    }
}
