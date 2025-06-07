using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Cwiczenia12.Models;

[Table("Country")]
[PrimaryKey(nameof(IdCountry))]
public class Country
{
    
    public int IdCountry { get; set; }
    [MaxLength(120)]
    public string Name { get; set; }
}