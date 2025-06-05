namespace Cwiczenia12.DTOs;

public class TripDTO
{
    public string name {get; set;}
    public string description {get; set;}
    public DateTime DateFrom {get; set;}
    public DateTime DateTo {get; set;}
    public int MaxPeople {get; set;}
    public List<CountryDTO> Countries {get; set;}
    public List<ClientDTO> Clients {get; set;}
}