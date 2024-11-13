using Microsoft.EntityFrameworkCore;

namespace Bibliothek_EF;

public class LibraryContext :DbContext {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookDetails> BookDetails { get; set; }
        public DbSet<BookLoan> BookLoans { get; set; }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Librarian> Librarians { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "Server=localhost;Database=library;User=root;Password=123mysql",
                new MySqlServerVersion(new Version(8, 0, 26))
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("PERSONS");
            modelBuilder.Entity<Author>().ToTable("AUTHORS");
            modelBuilder.Entity<Customer>().ToTable("CUSTOMERS");
            modelBuilder.Entity<Librarian>().ToTable("LIBRARIANS");

            modelBuilder.Entity<Book>()
                .HasDiscriminator<string>("ItemType") 
                .HasValue<NonFiction>("NonFiction")
                .HasValue<Novel>("Novel")
                .HasValue<Textbook>("Textbook")
                .HasValue<Biography>("Biography")
                .HasValue<ScienceFiction>("ScienceFiction")
                .HasValue<Fantasy>("Fantasy")
                .HasValue<Mystery>("Mystery");

            modelBuilder.Entity<Book>()
                .HasOne(b => b.BookDetails)
                .WithOne(bd => bd.Book)
                .HasForeignKey<BookDetails>(bd => bd.Id); 

            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorId);

            modelBuilder.Entity<BookLoan>()
                .HasOne(bl => bl.Customer)
                .WithMany(c => c.BookLoans)
                .HasForeignKey(bl => bl.CustomerId);

            modelBuilder.Entity<BookLoan>()
                .HasOne(bl => bl.Book)
                .WithMany(b => b.BookLoans)
                .HasForeignKey(bl => bl.BookId);

            modelBuilder.Entity<BookLoan>()
                .HasOne(bl => bl.Librarian)
                .WithMany() 
                .HasForeignKey(bl => bl.LibrarianId);

            modelBuilder.Entity<BookLoan>()
                .HasOne(bl => bl.ReturnLibrarian)
                .WithMany() 
                .HasForeignKey(bl => bl.ReturnLibrarianId)
                .IsRequired(false); 
        }
}