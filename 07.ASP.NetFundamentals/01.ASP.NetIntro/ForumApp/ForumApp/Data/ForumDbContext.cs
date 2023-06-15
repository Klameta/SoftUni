
using ForumApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Data
{
    public class ForumDbContext : DbContext
    {
        public Post FirstPost { get; set; }
        public Post SecondPost { get; set; }
        public Post ThirdPost { get; set; }

        public ForumDbContext(DbContextOptions<ForumDbContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<Post> Posts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedPosts();

            modelBuilder.Entity<Post>()
                .HasData(this.FirstPost,
                         this.SecondPost,
                         this.ThirdPost);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedPosts()
        {
            FirstPost = new Post()
            {
                Id = Guid.NewGuid(),
                Title = "This is my first post! Wooo!",
                Content = "Hello world! I am using this website for the first time and im hoping that i can make some friendse here! :D"
            };

            SecondPost = new Post()
            {
                Id = Guid.NewGuid(),
                Title = "Hello there!",
                Content = "Hello friends! I am asking for some help on a problme I have been having for the past couple of days because i just can't seem to find a suitable solution..."
            };

            ThirdPost = new Post()
            {
                Id = Guid.NewGuid(),
                Title = "Thanks!",
                Content = "Thank you guys! What you've all said has really helped me overcome my problem and im so grateful to be on this site with such amazing people!"
            };
        }
    }
}
