using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Cwiczenia12.Models;

[Table("Client_Trip")]
[PrimaryKey(nameof(IdClient),nameof(IdTrip))]
public class Client_Trip
{
    [ForeignKey(nameof(Client))]
    public int IdClient { get; set; }
    [ForeignKey(nameof(Trip))]
    public int IdTrip { get; set; }
    public int RegisteredAt { get; set; }
    public int? PaymentDate { get; set; }
}