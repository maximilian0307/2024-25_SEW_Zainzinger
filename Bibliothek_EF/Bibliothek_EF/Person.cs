using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bibliothek_EF;

[Table("PERSONS")]
public class Person {
    [Key]
    [Column("ID")]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    [Column("FIRSTNAME")]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(50)]
    [Column("LASTNAME")]
    public string LastName { get; set; }
    [Column("DATEOFBIRTH")]
    public DateTime DateOfBirth { get; set; }
}
[Table("AUTHORS")]
public class Author : Person {
    [Column("BIOGRAPHY")]
    [MaxLength(1000)]
    public string Biography { get; set; }
    public virtual ICollection<Book> Books { get; set; }

}
[Table("CUSTOMERS")]
public class Customer : Person {
    [Column("MEMBERSHIPDATE")]
    public DateTime MembershipDate { get; set; }
    public virtual ICollection<BookLoan> BookLoans { get; set; }

}
[Table("LIBRARIANS")]
public class Librarian : Person {
    [Required]
    [MaxLength(10)]
    [Column("EMPLOYEEID")]
    public string EmployeeId { get; set; }
}
