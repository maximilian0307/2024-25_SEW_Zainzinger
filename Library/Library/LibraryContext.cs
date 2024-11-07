using Microsoft.EntityFrameworkCore;

namespace Library;

public class LibraryContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder builder) {
        if (!builder.IsConfigured) {
            builder.UseMySql($"Server=localhost;Database=library;User=root;Password=123mysql;",
                new MySqlServerVersion(new Version(8, 0, 26)));
        }
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Librarian> Librarians { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasDiscriminator<string>("BookType")
            .HasValue<NonFiction>("NonFiction")
            .HasValue<Novel>("Novel")
            .HasValue<Textbook>("Textbook")
            .HasValue<Biography>("Biography")
            .HasValue<ScienceFiction>("ScienceFiction")
            .HasValue<Fantasy>("Fantasy")
            .HasValue<Mystery>("Mystery");
        modelBuilder.Entity<Person>().ToTable("Persons");
        modelBuilder.Entity<Author>().ToTable("Authors");
        modelBuilder.Entity<Customer>().ToTable("Customers");
        modelBuilder.Entity<Librarian>().ToTable("Librarians");
    }
}