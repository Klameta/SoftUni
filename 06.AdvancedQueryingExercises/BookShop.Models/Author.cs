using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Models
{
    using System.Collections.Generic;

    public class Author
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }

        public int AuthorId { get; set; }
        [Unicode(true)]
        [MaxLength(50)]
        public string? FirstName { get; set; }
        [MaxLength(50)]
        [Unicode(true)]
        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}