using Microsoft.EntityFrameworkCore;

namespace Cwiczenia12.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
}