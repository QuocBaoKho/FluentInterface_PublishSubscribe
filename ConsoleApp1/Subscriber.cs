using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Subscriber
    {
        string subscriberName;
        EventBroker broker;
        public Subscriber(string name, EventBroker broker)
        {
            subscriberName = name;
            this.broker = broker;
            Subscribe();
        }
        public void Subscribe()
        {
            broker.Subscribe(ReceiveMessage);
        }
        public void Unsubscribe()
        {
            broker.Unsubscribe(ReceiveMessage);
        }
        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{subscriberName} receives message \"{message}\"");
        }
    }

}
