using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Publisher
    {
        private EventBroker broker;
        public Publisher(EventBroker broker)
        {
            this.broker = broker;
        }

        public void PublishMessage(string message)
        {
            Console.WriteLine($"Publisher published message {message}");
            broker.Publish(message);
        }
    }
}
