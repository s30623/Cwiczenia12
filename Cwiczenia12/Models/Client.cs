using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Cwiczenia12.Models;

[Table("Client")]
[PrimaryKey(nameof(IdClient))]
public class Client
{
    public int IdClient { get; set; }
    
    [MaxLength(120)]
    public string FirstName { get; set; }
    
    [MaxLength(120)]
    public string LastName { get; set; }
    [MaxLength(120)]
    public string Email { get; set; }
    [MaxLength(120)]
    public string Telephone { get; set; }
    [MaxLength(120)]
    public string Pesel { get; set; }
    
}