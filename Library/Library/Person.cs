using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library;

public class Person
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }

    [Column(TypeName = "date")]
    public DateTime DateOfBirth { get; set; }
}

public class Author : Person
{
    [MaxLength(1000)]
    public string Biography { get; set; }
}

public class Customer : Person
{
    [Column(TypeName = "date")]
    public DateTime MembershipDate { get; set; }
}

public class Librarian : Person
{
    [Required]
    [MaxLength(10)]
    public string EmployeeId { get; set; }
}