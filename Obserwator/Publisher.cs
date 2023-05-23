using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    public class Publisher
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();

        public void Notify(string context)
        {
            foreach (ISubscriber subscriber in _subscribers)
            {
                subscriber.Update(context);
            }
        }
        public void Unsubscribe(ISubscriber subscriber)
        {
            if (subscriber != null) _subscribers.Remove(subscriber);
            else throw new NullReferenceException();
        }
        public void Subscribe(ISubscriber subscriber)
        {
            if (subscriber != null) _subscribers.Add(subscriber);
            else throw new NullReferenceException();
        }
    }
}
