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
}