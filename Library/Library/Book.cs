namespace Library;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Book
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Title { get; set; }

    [Required]
    [MaxLength(100)]
    public string Author { get; set; }

    [Column(TypeName = "date")]
    public DateTime PublishedDate { get; set; }

    [Required]
    [MaxLength(20)]
    public string ISBN { get; set; }
}

public class NonFiction : Book { }
public class Novel : Book { }
public class Textbook : Book { }
public class Biography : Book { }
public class ScienceFiction : Book { }
public class Fantasy : Book { }
public class Mystery : Book { }
