using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EventBroker
    {
        public delegate void Notify(string message);
        public event Notify onNotify;
        public void Subscribe (Notify notify)
        {
            this.onNotify += notify;
        }
        public void Unsubscribe (Notify notify)
        {
            this.onNotify -= notify;
        }
        public void Publish(string message)
        {
            onNotify.Invoke(message);
        }
    }
}
