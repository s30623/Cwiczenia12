using System.ComponentModel.DataAnnotations;

namespace Cwiczenia12.Models;

public class Country
{
    [Key]
    private int IdCountry { get; set; }
    [MaxLength(120)]
    private string Name { get; set; }
}