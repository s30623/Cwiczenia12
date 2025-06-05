using Cwiczenia12.Data;
using Cwiczenia12.DTOs;
using Cwiczenia12.Models;

namespace Cwiczenia12.Services;

public class TripService : ITripService
{
    private readonly DatabaseContext _context;

    public TripService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<TripResultDTO> GetTrips()
    {
        var temp = new TripResultDTO();
        return temp;
    }
}