namespace DotNetCrudWebApi.Data.Events;

public class EventBase
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public class OnCreatedEventArgs : EventArgs
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}