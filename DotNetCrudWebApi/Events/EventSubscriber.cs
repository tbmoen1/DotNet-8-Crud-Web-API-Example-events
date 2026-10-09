using DotNetCrudWebApi.Data.Events.EventTypes;

namespace DotNetCrudWebApi.Events;

public class EventSubscriber
{
    public void SubscribeToAddedEvent<T>(
        AddedEvent<T> addedEvent)
    {
        addedEvent.Created += (entity, args) =>
        {
            Console.WriteLine("test");
        };
    }
}