using Cwiczenia12.DTOs;
using Cwiczenia12.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia12.Controllers;


[ApiController]
public class TripsController : ControllerBase
{
    private readonly ITripService _tripsService;

    public TripsController(ITripService tripsService)
    {
        _tripsService = tripsService;
    }

    [HttpGet]
    [Route("api/trips")]
    public async Task<IActionResult> GetTrips()
    {
        var trips = await _tripsService.GetTrips();
        return Ok(trips);
    }

    [HttpDelete]
    [Route("api/clients/{clientId}")]
    public async Task<IActionResult> DeleteClient(int clientId)
    {
        if (await _tripsService.checkClientNoTrips(clientId))
        {
            return BadRequest("Klient posiada przypisane wycieczki");
        }
        await _tripsService.deleteClient(clientId);
        return Ok($"Usunieto klienta {clientId}");
    }

    [HttpPost]
    [Route("api/trips/{idTrip}/clients")]
    public async Task<IActionResult> AddClient(int idTrip, AddClientDTO client)
    {
        if (await _tripsService.checkClientExists(client))
        {
            return BadRequest("Klient istnieje");
        }

        if (await _tripsService.clientRegisteredToTrip(client,idTrip))
        {
            return BadRequest($"Klient o nr pesel: {client.Pesel} jest juz przypisany do wycieczki");
        }

        if (await _tripsService.tripExists(idTrip))
        {
            return BadRequest("Wycieczka nie istnieje");
        }
        await _tripsService.addClientToTrip(idTrip, client);
        return Ok("Dodano klienta");
    }
}