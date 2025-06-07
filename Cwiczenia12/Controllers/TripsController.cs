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
        return Ok();
    }

    [HttpPost]
    [Route("api/trips/{idTrip}/clients")]
    public async Task<IActionResult> AddClient(int idTrip, ClientDTO client)
    {
        return Ok();
    }
}