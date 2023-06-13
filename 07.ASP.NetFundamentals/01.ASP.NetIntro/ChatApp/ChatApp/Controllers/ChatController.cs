
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    public class ChatController : Controller
    {
        private  List<KeyValuePair<string, string>> _messages =
             new List<KeyValuePair<string, string>>();

        public IActionResult Show()
        {
            if (_messages.Count() < 1)
            {
                return View(new ChatViewModel());
            }

            var chatModel = new ChatViewModel()
            {
                Messages = _messages
                    .Select(m => new MessageViewModel()
                    {
                        Sender = m.Key,
                        MessageText = m.Value
                    })
                    .ToList()
            };

            return View(chatModel);
        }

        [HttpPost]
        public IActionResult Send(ChatViewModel chat)
        {
            _messages.Add(new(chat.CurrentMessage.Sender, chat.CurrentMessage.MessageText));
            return RedirectToAction(nameof(Show));
        }
    }
}
