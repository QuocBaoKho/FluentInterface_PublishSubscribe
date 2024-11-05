using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fluent Interface
            FluentHuman fluent = new FluentHuman();
            fluent.TheirNameIs("Mike Patton").AgeOfThem(56).LivesIn("California");
            fluent.ShowDetails();

            //Publish-Subscribe
            EventBroker broker = new EventBroker();
            Publisher pb = new Publisher(broker);

            Subscriber s1 = new Subscriber("Adam Vinler", broker);
            Subscriber s2 = new Subscriber("Alex Theory", broker);
            Subscriber s3 = new Subscriber("TamaraSubtract", broker);

            pb.PublishMessage("I want to show you guys something");

            EventBroker broker2 = new EventBroker();
        }
    }
}
