using DotNetCrudWebApi.Data.Events;
using DotNetCrudWebApi.Data.Events.EventTypes;

namespace DotNetCrudWebApi.Events;

public class EventCreator(EventSubscriber eventSubscriber)
{
    public void CreateAddedEvent<T>(T entity)
    {
        if (entity is null)
            throw new ArgumentNullException(nameof(entity));
        var addedEvent = new AddedEvent<T>(entity);
        eventSubscriber.SubscribeToAddedEvent(addedEvent);
        
        addedEvent.OnCreated(entity, new EventBase.OnCreatedEventArgs());
    }
}