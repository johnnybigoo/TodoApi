namespace TodoApi.Models
{
  public class TodoContext : DbContext
  {
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; }
  }

  public class DbSet<T>
  {
  }

  public class DbContextOptions<T>
  {
  }

  public class DbContext
  {
    public DbContext(DbContextOptions<TodoContext> options)
    {
    }
  }
}