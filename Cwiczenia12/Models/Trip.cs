﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Cwiczenia12.Models;
[Table("Trip")]
[PrimaryKey(nameof(IdTrip))]
public class Trip
{
    
    public int IdTrip { get; set; }
    [MaxLength(120)]
    public string Name { get; set; }
    [MaxLength(220)]
    public string Description { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
    public int MaxPeople { get; set; }
}