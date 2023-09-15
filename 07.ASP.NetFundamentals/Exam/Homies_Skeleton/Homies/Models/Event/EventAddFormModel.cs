using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using static Homies.Common.EntityValidations.Event;

namespace Homies.Models.Event
{
    public class EventAddFormModel
    {
        public EventAddFormModel()
        {
            Types = new List<EventTypeModel>();
        }

        [Required]
        [StringLength(NameMaxLength, ErrorMessage = "{0} must be at least {2} charachters and at most {1}", MinimumLength = NameMinLength)]
        public string Name { get; set; }
        [Required]
        [StringLength(DescriptionMaxLength, ErrorMessage = "{0} must be at least {2} charachters and at most {1}", MinimumLength = DescriptionMinLength)]
        public string Description { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime End { get; set; }
        [Required]
        public int TypeId { get; set; }

        public ICollection<EventTypeModel> Types { get; set; }
    }
}
