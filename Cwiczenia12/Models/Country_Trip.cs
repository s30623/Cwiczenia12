using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Cwiczenia12.Models;

[Table("Country_Trip")]
[PrimaryKey(nameof(IdCountry), nameof(IdTrip))]
public class Country_Trip
{
    [ForeignKey(nameof(Country))]
    private int IdCountry { get; set; }
    [ForeignKey(nameof(Trip))]
    private int IdTrip { get; set; }
}