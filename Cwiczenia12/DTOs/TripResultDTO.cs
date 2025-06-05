using Cwiczenia12.Models;

namespace Cwiczenia12.DTOs;

public class TripResultDTO
{
    public int pageNum {get; set;}
    public int pageSize {get; set;}
    public int allPages {get; set;}
    public List<Trip> trips {get; set;}
    public List<Client> Clients {get; set;}
}