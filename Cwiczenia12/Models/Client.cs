using System.ComponentModel.DataAnnotations;

namespace Cwiczenia12.Models;

public class Client
{
    [Key]
    private int IdClient { get; set; }
    
    [MaxLength(120)]
    private string FirstName { get; set; }
    
    [MaxLength(120)]
    private string LastName { get; set; }
    [MaxLength(120)]
    private string Email { get; set; }
    [MaxLength(120)]
    private string Telephone { get; set; }
    [MaxLength(120)]
    private string Pesel { get; set; }
    
}