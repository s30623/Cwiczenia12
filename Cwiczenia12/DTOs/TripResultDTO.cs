

namespace Cwiczenia12.DTOs;

public class TripResultDTO
{
    public int pageNum {get; set;}
    public int pageSize {get; set;}
    public int allPages {get; set;}
    public List<TripDTO> trips {get; set;}
    public List<ClientDTO> Clients {get; set;}
}