

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Homies.Data.Models
{
    [Comment("Types are the categories of the events. They have a name and a collection of events.")]
    public class Type
    {
        public Type()
        {
            this.Events = new HashSet<Event>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(Common.EntityValidations.Type.NameMaxLength)]
        public string Name { get; set; } = null!;
        public ICollection<Event> Events { get; set; }
    }
    /*•	Has Id – a unique integer, Primary Key
•	Has Name – a string with min length 5 and max length 15 (required)
•	Has Events – a collection of type Event
*/
}
