using Cwiczenia12.Models;
using Microsoft.EntityFrameworkCore;

namespace Cwiczenia12.Data;

public class DatabaseContext : DbContext
{
    public  DbSet<Client> Clients { get; set; }
    public  DbSet<Client_Trip> Clients_Trip { get; set; }
    public  DbSet<Country> Country { get; set; }
    public  DbSet<Country_Trip> Country_Trip { get; set; }
    public  DbSet<Trip> Trip{ get; set; }
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
}