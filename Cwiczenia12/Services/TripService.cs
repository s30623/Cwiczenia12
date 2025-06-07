using Cwiczenia12.Data;
using Cwiczenia12.DTOs;
using Cwiczenia12.Models;
using Microsoft.EntityFrameworkCore;

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
        var temp = new TripResultDTO
        {
            pageNum=1,
            allPages = 1,
            Clients = new List<ClientDTO>(_context.Clients.Select(e => new ClientDTO
            {
                FirstName = e.FirstName,
                LastName = e.LastName
            }).ToList()),
            trips = new List<TripDTO>(_context.Trip.Select(e => new TripDTO
            {
                name = e.Name,
                description = e.Description,
                DateFrom = e.DateFrom,
                DateTo = e.DateTo,
                MaxPeople = e.MaxPeople,
                Countries = new List<CountryDTO>(_context.Trip.Select(e => new CountryDTO
                {
                    Name = e.Name
                }).ToList())
            }).OrderBy(a => a.DateFrom).ToList())
        };
        return temp;
    }

    public async Task<bool> checkClientNoTrips(int clientId)
    {
        return await _context.Clients_Trip.Where(p => p.IdClient == clientId).AnyAsync();
    }

    public async Task<bool> deleteClient(int clientId)
    {
        var client = await _context.Clients_Trip.Where(p => p.IdClient == clientId).FirstOrDefaultAsync();
        if (client != null)
        {
            _context.Clients_Trip.Remove(client);
            return await _context.SaveChangesAsync() > 0;
        }
        return false;
    }

    public async Task<bool> tripExists(int tripId)
    {
        return await _context.Trip.AnyAsync(e => e.IdTrip == tripId);
    }

    public async Task<bool> checkClientExists(AddClientDTO client)
    {
        return await _context.Clients.AnyAsync(e => e.Pesel == client.Pesel); 
    }

    public async Task<bool> clientRegisteredToTrip(AddClientDTO client, int tripId)
    {
        var IdClient = await _context.Clients.FirstOrDefaultAsync(e => e.Pesel == client.Pesel);
        if (IdClient != null)
        {
            return await _context.Clients_Trip.AnyAsync(e => e.IdTrip == tripId && e.IdClient == IdClient.IdClient);
        }
        return false;
    }

    public async Task<bool> addClientToTrip(AddClientDTO client, int tripId)
    {
        var max_index = await _context.Clients.OrderByDescending(e => e.IdClient).FirstOrDefaultAsync();
        if (max_index == null)
        {
            max_index.IdClient = 0;
        }
        var _client = new Client
        {
            Email = client.Email,
            FirstName = client.FirstName,
            LastName = client.LastName,
            Pesel = client.Pesel,
            IdClient = max_index.IdClient,
            Telephone = client.Telephone,
        };
        await _context.Clients.AddAsync(_client);
        return await _context.SaveChangesAsync() > 0;
    }
}