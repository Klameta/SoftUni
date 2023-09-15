using Homies.Data;
using Homies.Data.Models;
using Homies.Models;
using Homies.Models.Event;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Homies.Controllers
{
    public class EventController : Controller
    {
        private readonly HomiesDbContext _data;
        public EventController(HomiesDbContext context)
        {
            _data = context;
        }


        [HttpGet]
        public async Task<IActionResult> All()
        {
            var events = await _data
                .Events
                .Select(e => new EventAllViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Start = e.Start.ToString("dd-MM-yyyy HH:mm"),
                    Type = e.Type.Name.ToString(),
                    Organiser = e.Organiser.UserName
                })
                .ToListAsync();

            return View(events);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            EventAddFormModel formModel = new()
            {
                Types = await _data
                    .Types
                    .Select(t => new EventTypeModel
                    {
                        Id = t.Id,
                        Name = t.Name
                    })
                    .ToListAsync()
            };

            return View(formModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(EventAddFormModel model)
        {

            if (!ModelState.IsValid)
            {
                model.Types = await _data
                    .Types
                    .Select(t => new EventTypeModel
                    {
                        Id = t.Id,
                        Name = t.Name
                    })
                    .ToListAsync();
                return View(model);
            }

            var type = await _data.Types.FindAsync(model.TypeId);

            if (type == null)
            {
                ModelState.AddModelError(nameof(EventAddFormModel.TypeId), "Type does not exist.");
                model.Types = await _data
                    .Types
                    .Select(t => new EventTypeModel
                    {
                        Id = t.Id,
                        Name = t.Name
                    })
                    .ToListAsync();
                return View(model);
            }

            
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            IdentityUser user = await _data.Users.FindAsync(userId);

            var eventToAdd = new Event()
            {
                Name = model.Name,
                Description = model.Description,
                Start = model.Start,
                End = model.End,
                CreatedOn = DateTime.UtcNow,
                OrganiserId = userId,
                Organiser = user,
                TypeId = model.TypeId
            };



            _data.Events.Add(eventToAdd);
            await _data.SaveChangesAsync();

            return RedirectToAction("All", "Event");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var eventToEdit = await _data.Events.FindAsync(id);

            if (eventToEdit == null)
            {
                return NotFound();
            }

            var formModel = new EventEditFormModel
            {
                Name = eventToEdit.Name,
                Description = eventToEdit.Description,
                Start = eventToEdit.Start.ToString("dd-MM-yyyy h:mm"),
                End = eventToEdit.End.ToString("dd-MM-yyyy h:mm"),
                TypeId = eventToEdit.TypeId,
                Types = await _data
                    .Types
                    .Select(t => new EventTypeModel
                    {
                        Id = t.Id,
                        Name = t.Name
                    })
                    .ToListAsync()
            };

            return View(formModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EventEditFormModel model)
        {
            var eventToEdit = await _data.Events.FindAsync(id);

            if (eventToEdit == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                model.Types = await _data
                    .Types
                    .Select(t => new EventTypeModel
                    {
                        Id = t.Id,
                        Name = t.Name
                    })
                    .ToListAsync();
                return View(model);
            }

            var type = await _data.Types.FindAsync(model.TypeId);

            if (type == null)
            {
                ModelState.AddModelError(nameof(EventAddFormModel.TypeId), "Type does not exist.");
                model.Types = await _data
                    .Types
                    .Select(t => new EventTypeModel
                    {
                        Id = t.Id,
                        Name = t.Name
                    })
                    .ToListAsync();
                return View(model);
            }

            eventToEdit.Name = model.Name;
            eventToEdit.Description = model.Description;
            eventToEdit.Start = DateTime.Parse(model.Start);
            eventToEdit.End = DateTime.Parse(model.End);
            eventToEdit.TypeId = model.TypeId;

            await _data.SaveChangesAsync();

            return RedirectToAction("All", "Event");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var eventToView = await _data
                               .Events
                               .Include(e => e.Type)
                               .FirstOrDefaultAsync(e => e.Id == id);

            if (eventToView == null)
            {
                return NotFound();
            }

            var viewModel = new EventDetailsViewModel
            {
                Id = eventToView.Id,
                Name = eventToView.Name,
                Description = eventToView.Description,
                Start = eventToView.Start.ToString("dd-MM-yyyy h:mm"),
                End = eventToView.End.ToString("dd-MM-yyyy h:mm"),
                Type = eventToView.Type.Name,
                CreatedOn = eventToView.CreatedOn.ToString("dd-MM-yyyy h:mm")
            };

            return View(viewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Joined()
        {
            IdentityUser? user = await _data.Users.FindAsync(this.User.FindFirstValue(ClaimTypes.NameIdentifier));

            if (user == null)
            {
                return NotFound();
            }

            var events = await _data
                .Events
                .Where(e => e.EventParticipants
                    .Select(ep => ep.HelperId)
                    .Contains(user.Id))
                .Select(e => new EventAllViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Start = e.Start.ToString("dd-MM-yyyy HH:mm"),
                    Type = e.Type.Name.ToString(),
                    Organiser = e.Organiser.UserName
                })
                .ToListAsync();

            return View(events);
        }
        [HttpPost]
        public async Task<IActionResult> Join(int id)
        {
            var eventToJoin = await _data.Events.FindAsync(id);

            if (eventToJoin == null)
            {
                return NotFound();
            }

            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            IdentityUser user = await _data.Users.FindAsync(userId);

            if (eventToJoin.EventParticipants.Any(p => p.HelperId == userId))
            {
                return BadRequest();
            }

            var eventParticipant = new EventParticipant
            {
                EventId = id,
                HelperId = userId,
                Event = eventToJoin,
                Helper = user
            };

            eventToJoin.EventParticipants.Add(eventParticipant);
            _data.EventParticipants.Add(eventParticipant);
            await _data.SaveChangesAsync();

            return RedirectToAction("Details", "Event", new { id = id });
        }
        [HttpPost]
        public async Task<IActionResult> Leave(int id)
        {
            var eventToLeave = await _data.Events.FindAsync(id);

            if (eventToLeave == null)
            {
                return NotFound();
            }

            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if(!eventToLeave.EventParticipants.Any(p => p.HelperId == userId))
            {
                return BadRequest();
            }

            var eventParticipant = eventToLeave.EventParticipants.FirstOrDefault(p => p.HelperId == userId);
            _data.Remove(eventParticipant);
            await _data.SaveChangesAsync();

            return RedirectToAction("Details", "Event", new { id = id });
        }

    }
}
