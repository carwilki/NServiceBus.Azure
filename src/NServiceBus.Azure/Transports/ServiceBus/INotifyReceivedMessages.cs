using System;
using Microsoft.ServiceBus.Messaging;

namespace NServiceBus.Unicast.Queuing.Azure.ServiceBus
{
    public interface INotifyReceivedMessages
    {
        void Start(Address address, Action<BrokeredMessage> tryProcessMessage);
        void Stop();
    }
}