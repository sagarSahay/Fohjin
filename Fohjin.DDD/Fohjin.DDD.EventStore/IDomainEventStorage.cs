using System;
using System.Collections.Generic;
using Fohjin.DDD.Events;

namespace Fohjin.DDD.EventStore
{
    public interface IDomainEventStorage
    {
        IEnumerable<IDomainEvent> GetAllEvents(Guid eventProviderId);
        IEnumerable<IDomainEvent> GetEventsSinceLastSnapShot(Guid eventProviderId);
        int GetEventCountSinceLastSnapShot(Guid eventProviderId);
        void Save(IEventProvider eventProvider);
    }
}