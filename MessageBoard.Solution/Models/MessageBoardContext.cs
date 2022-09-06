using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Models
{
  public class MessageBoardContext : DbContext
  {
    public DbSet<Category> Categories { get; set; }
    public DbSet<Message> Messages { get; set; }

     public MessageBoardContext(DbContextOptions<MessageBoardContext> options)
            : base(options)
        {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Message>()
          .HasData(
              new Message { MessageId = 1, Description = "Go for a walk outside", CategoryId = 3 },
              new Message { MessageId = 2, Description = "Walk with dog", CategoryId = 3 },
              new Message { MessageId = 3, Description = "Clean the room", CategoryId = 2 },
              new Message { MessageId = 4, Description = "Read the book", CategoryId  = 4},
              new Message { MessageId = 5, Description = "Wash the dishes", CategoryId  = 2},
              new Message { MessageId = 6, Description = "Prepare the dinner", CategoryId  = 1}
      );
      builder.Entity<Category>()
          .HasData(
              new Category { CategoryId = 1, CategoryName = "Home" },
              new Category { CategoryId = 2, CategoryName = "Work" },
              new Category { CategoryId = 3, CategoryName = "Before work" },
              new Category { CategoryId = 4, CategoryName = "After work"},
              new Category { CategoryId = 5, CategoryName = "Before school"},
              new Category { CategoryId = 6, CategoryName = "After school"}
      );
    }
  }
}