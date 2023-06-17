using Task = Data.Models.Task;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskBoardApp.Data.Configurations
{
    public class TaskEntityConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder
                .HasOne(t => t.Board)
                .WithMany(b => b.Tasks)
                .HasForeignKey(t => t.BoardId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasData(this.GenerateTask());
        }

        private ICollection<Task> GenerateTask()
        {
            var tasks = new HashSet<Task>();

            var task = new Task()
            {
                Id = 1,
                Title = "Improve CSS styles",
                Description = "Implement better styling for all public sites",
                CreatedOn = DateTime.Now.AddDays(-200),
                OwnerId = "7fa3e841-b5eb-4b08-893c-c197d4823e33",
                BoardId = 1
            };
            tasks.Add(task);

            task = new Task()
            {
                Id = 2,
                Title = "Android Client App",
                Description = "Create Android client app for the TaskBoard RESTful API",
                CreatedOn = DateTime.Now.AddMonths(-2),
                OwnerId = "7fa3e841-b5eb-4b08-893c-c197d4823e33",
                BoardId = 2
            };
            tasks.Add(task);

            task = new Task()
            {
                Id = 3,
                Title = "Desktop Client App",
                Description = "Create Windows Forms desktop app client for the TaskBoard RESTful API",
                CreatedOn = DateTime.Now.AddMonths(-1),
                OwnerId = "1f78b039-c7e4-475e-aad4-f9934f9c87a6",
                BoardId = 2
            };
            tasks.Add(task);

            task = new Task()
            {
                Id = 4,
                Title = "Create Tasks",
                Description = "Implement [Create Task] page for adding new tasks",
                CreatedOn = DateTime.Now.AddYears(-2),
                OwnerId = "8b772687-2282-4359-a1c1-b76279ef6def",
                BoardId = 3
            };
            tasks.Add(task);

            return tasks;
        }
    }
}
