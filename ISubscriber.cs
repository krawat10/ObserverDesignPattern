using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    interface ISubscriber
    {
        void updateData(int amount, int cost);
        void show();
    }
}
