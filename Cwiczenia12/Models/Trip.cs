using System.ComponentModel.DataAnnotations;

namespace Cwiczenia12.Models;

public class Trip
{
    [Key]
    private int IdTrip { get; set; }
    [MaxLength(120)]
    private string Name { get; set; }
    [MaxLength(220)]
    private string Description { get; set; }
    private DateTime DateFrom { get; set; }
    private DateTime DateTo { get; set; }
    private int MaxPeople { get; set; }
}