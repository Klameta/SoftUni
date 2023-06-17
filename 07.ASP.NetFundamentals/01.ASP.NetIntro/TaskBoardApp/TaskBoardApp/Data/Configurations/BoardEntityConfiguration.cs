using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskBoardApp.Data.Configurations
{
    public class BoardEntityConfiguration : IEntityTypeConfiguration<Board>
    {
        public void Configure(EntityTypeBuilder<Board> builder)
        {
            ICollection<Board> boards = this.GenerateBoards();

            builder
                .HasData(boards);
        }

        private ICollection<Board> GenerateBoards()
        {
            var boards = new HashSet<Board>();

            var board = new Board()
            {
                Id = 1,
                Name = "Open",
            };
            boards.Add(board);

            board = new Board()
            {
                Id = 2,
                Name = "In Progress"
            };
            boards.Add(board);

            board = new Board()
            {
                Id = 3,
                Name = "Done"
            };
            boards.Add(board);

            return boards;
        }
    }
}
