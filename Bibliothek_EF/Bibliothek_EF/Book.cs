using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bibliothek_EF;

[Table("BOOKS")]
public class Book {
    [Column("ID")]
    [Key]
    public int Id { get; set; }
    [Column("TITLE")]
    public string Title { get; set; }
    [Column("PUBLISHED_DATE")]
    public DateTime PublishedDate { get; set; }
    [Column("ISBN")]
    public string ISBN { get; set; }
    [Required]
    [ForeignKey("Author")]
    public int AuthorId { get; set; }
    public virtual Author Author { get; set; }
    public virtual BookDetails BookDetails { get; set; }
    public virtual ICollection<BookLoan> BookLoans { get; set; }
}
[Table("BOOK_DETAILS")]
public class BookDetails
{
    [Key]
    [ForeignKey("Book")]
    [Column("ID")]
    public int Id { get; set; } 

    [Required]
    [Column("TOTAL_COPIES")]
    public int TotalCopies { get; set; }

    [Required]
    [Column("BORROWED_COPIES")]
    public int BorrowedCopies { get; set; }

    [Required]
    [Column("AVAILABLE_COPIES")]
    public int AvailableCopies { get; set; }

    public virtual Book Book { get; set; }
}

[Table("BOOK_LOANS")]
public class BookLoan
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("Customer")]
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }

    [Required]
    [ForeignKey("Book")]
    public int BookId { get; set; }
    public virtual Book Book { get; set; }

    [Required]
    [Column("LOAN_DATE")]
    public DateTime LoanDate { get; set; }

    [Required]
    [Column("DUE_DATE")]
    public DateTime DueDate { get; set; }

    [Required]
    [ForeignKey("Librarian")]
    public int LibrarianId { get; set; }
    public virtual Librarian Librarian { get; set; }

    [Column("RETURN_DATE")]
    public DateTime? ReturnDate { get; set; }

    [ForeignKey("ReturnLibrarian")]
    public int? ReturnLibrarianId { get; set; }
    public virtual Librarian? ReturnLibrarian { get; set; }
}

public class NonFiction : Book { }
public class Novel : Book { }
public class Textbook : Book { }
public class Biography : Book { }
public class ScienceFiction : Book { }
public class Fantasy : Book { }
public class Mystery : Book { }

