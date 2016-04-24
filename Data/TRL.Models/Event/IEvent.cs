namespace TRL.Models.Event
{
    using TRL.Models;

    public interface IEvent
    {
        int Id { get; set; }

        string Header { get; set; }

        string Content { get; set; }

        User Author { get; set; }
    }
}
