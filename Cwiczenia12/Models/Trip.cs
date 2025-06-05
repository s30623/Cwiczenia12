using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Cwiczenia12.Models;
[Table("Trip")]
[PrimaryKey(nameof(IdTrip))]
public class Trip
{
    
    private int IdTrip { get; set; }
    [MaxLength(120)]
    private string Name { get; set; }
    [MaxLength(220)]
    private string Description { get; set; }
    private DateTime DateFrom { get; set; }
    private DateTime DateTo { get; set; }
    private int MaxPeople { get; set; }
}