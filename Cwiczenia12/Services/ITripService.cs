using Cwiczenia12.DTOs;
using Cwiczenia12.Models;

namespace Cwiczenia12.Services;

public interface ITripService
{
    Task<TripResultDTO> GetTrips();
    Task<bool> checkClientNoTrips(int clientId);
    Task<bool> deleteClient(int clientId);
    Task<bool> tripExists(int tripId);
    Task<bool> checkClientExists(AddClientDTO client);
    Task<bool> clientRegisteredToTrip(AddClientDTO client, int tripId);
    Task<bool> addClientToTrip(AddClientDTO client, int tripId);
}