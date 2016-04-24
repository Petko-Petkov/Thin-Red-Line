namespace TRL.Models.Event
{
    using System.ComponentModel.DataAnnotations;
    using TRL.Contracts.Models;
    using TRL.Models;

    public class Event : BaseModel, IEvent
    {
        [Key]
        public int Id { get; set; }
        
        public string AuthorId { get; set; }

        public User Author { get; set; }

        public string Content { get; set; }

        public string Header { get; set; }
    }
}
