using Cwiczenia12.Models;

namespace Cwiczenia12.Services;

public class TripService : ITripService
{
    public async Task<List<Trip>> GetTrips()
    {
        var trips = new List<Trip>();
        return trips;
    }
}