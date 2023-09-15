using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homies.Data.Models
{
    [Comment("EventParticipants are the connection between the events and the users. They have a helper and an event.")]
    public class EventParticipant
    {
        [ForeignKey(nameof(Helper))]
        public string HelperId { get; set; } = null!;
        public IdentityUser Helper { get; set; } = null!;
        [ForeignKey(nameof(Event))]
        public int EventId { get; set; }
        public Event Event { get; set; } = null!;
    }
    /*•	HelperId – a  string, Primary Key, foreign key (required)
•	Helper – IdentityUser
•	EventId – an integer, Primary Key, foreign key (required)
•	Event – Event
*/
}