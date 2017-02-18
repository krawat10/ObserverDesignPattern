using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            Subscriber firstsubscriber = new Subscriber("FirstSub");
            Subscriber secondsubscriber = new Subscriber("SecondSub");
            subject.AddSubscriber(firstsubscriber);
            subject.AddSubscriber(secondsubscriber);
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                subject.GetNewData(rand.Next(0, 100), rand.Next(0, 100));
                Thread.Sleep(200);
            }
        }
    }
}
