using Cwiczenia12.Models;

namespace Cwiczenia12.Services;

public interface ITripService
{
    Task<List<Trip>> GetTrips();
}