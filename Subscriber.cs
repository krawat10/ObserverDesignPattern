using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Subscriber : ISubscriber
    {
        public Subscriber(string name)
        {
            this.name = name;
        }
        string name;
        int cost;
        int amount;
        public void updateData(int amount, int cost)
        {
            this.amount = amount;
            this.cost = cost;
            show();
        }

        public void show()
        {
            Console.WriteLine("name: " + name + ", amount: " + amount + ", cost: " + cost);
        }
    }
}
