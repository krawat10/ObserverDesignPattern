using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Subject : ISubject
    {
        int cost;
        int amount;
        List<ISubscriber> Subscribers;
        public Subject()
        {
            Subscribers = new List<ISubscriber>();
        }
        public void AddSubscriber(ISubscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            int index = Subscribers.IndexOf(subscriber);
            Subscribers.RemoveAt(index);
        }

        public void CallbackSubscribers()
        {
            foreach(var subscriber in Subscribers)
            {
                subscriber.updateData(amount, cost);
            }
        }
        public void GetNewData(int newamount, int newcost)
        {
            this.cost = newcost;
            this.amount = newamount;
            CallbackSubscribers();
        }
    }
}
