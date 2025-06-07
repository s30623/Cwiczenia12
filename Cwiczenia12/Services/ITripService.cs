using Cwiczenia12.DTOs;
using Cwiczenia12.Models;

namespace Cwiczenia12.Services;

public interface ITripService
{
    Task<TripResultDTO> GetTrips();
    Task<bool> checkClientNoTrips(int clientId);
    Task<bool> deleteClient(int clientId);
}