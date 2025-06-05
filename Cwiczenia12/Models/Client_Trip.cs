using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Cwiczenia12.Models;

[Table("Client_Trip")]
[PrimaryKey(nameof(IdClient),nameof(IdTrip))]
public class Client_Trip
{
    [ForeignKey(nameof(Client))]
    private int IdClient { get; set; }
    [ForeignKey(nameof(Trip))]
    private int IdTrip { get; set; }
    private int RegisteredAt { get; set; }
    private int? PaymentDate { get; set; }
}