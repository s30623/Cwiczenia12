using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Cwiczenia12.Models;

[Table("Client")]
[PrimaryKey(nameof(IdClient))]
public class Client
{
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