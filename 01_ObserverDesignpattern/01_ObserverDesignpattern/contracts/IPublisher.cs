using System;

namespace _01_ObserverDesignpattern.contracts
{
    interface IPublisher
    {
        public void registerSubscriber(Isubscriber s);
        public void removeSbscriber(Isubscriber s);
        public void notifySubScriber();
    }
}
