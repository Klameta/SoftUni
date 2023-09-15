using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homies.Data.Models
{
    [Comment("Events are the main part of the application. They are created by users and can be joined by other users. They have a name, description, organiser, start and end date, type and participants.")]
    public class Event
    {
        public Event()
        {
            this.EventParticipants = new HashSet<EventParticipant>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(Common.EntityValidations.Event.NameMaxLength)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(Common.EntityValidations.Event.DescriptionMaxLength)]
        public string Description { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(Organiser))]
        public string OrganiserId { get; set; }
        public IdentityUser Organiser { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime End { get; set; }
        [Required]
        [ForeignKey(nameof(Type))]
        public int TypeId { get; set; }
        public Data.Models.Type Type { get; set; } = null!;

        public ICollection<EventParticipant> EventParticipants { get; set; }

    }
    /*•	Has Id – a unique integer, Primary Key
    •	Has Name – a string with min length 5 and max length 20 (required)
    •	Has Description – a string with min length 15 and max length 150 (required)
    •	Has OrganiserId – an string (required)
    •	Has Organiser – an IdentityUser (required)
    •	Has CreatedOn – a DateTime with format "yyyy-MM-dd H:mm" (required) (the DateTime format is recommended, if you are having troubles with this one, you are free to use another one)
    •	Has Start – a DateTime with format "yyyy-MM-dd H:mm" (required) (the DateTime format is recommended, if you are having troubles with this one, you are free to use another one)
    •	Has End – a DateTime with format "yyyy-MM-dd H:mm" (required) (the DateTime format is recommended, if you are having troubles with this one, you are free to use another one)
    •	Has TypeId – an integer, foreign key (required)
    •	Has Type – a Type (required)
    •	Has EventsParticipants – a collection of type EventParticipant

    */
}
