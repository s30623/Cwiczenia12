using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Cwiczenia12.Models;

[Table("Country")]
[PrimaryKey(nameof(IdCountry))]
public class Country
{
    
    private int IdCountry { get; set; }
    [MaxLength(120)]
    private string Name { get; set; }
}