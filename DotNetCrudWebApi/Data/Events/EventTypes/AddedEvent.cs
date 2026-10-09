namespace DotNetCrudWebApi.Data.Events.EventTypes;

public class AddedEvent<T>(T entity) : EventBase
{
    private T Entity { get; set; } = entity;
    
    public event EventHandler<OnCreatedEventArgs>? Created;
    public virtual void OnCreated(T entity, OnCreatedEventArgs e)
    {
        Created?.Invoke(entity, e); 
    }
}