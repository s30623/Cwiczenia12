using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Cwiczenia12.Models;

[Table("Country_Trip")]
[PrimaryKey(nameof(IdCountry), nameof(IdTrip))]
public class Country_Trip
{
    [ForeignKey(nameof(Country))]
    public int IdCountry { get; set; }
    [ForeignKey(nameof(Trip))]
    public int IdTrip { get; set; }
}