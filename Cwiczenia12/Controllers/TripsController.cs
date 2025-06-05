using Cwiczenia12.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia12.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TripsController : ControllerBase
{
    private readonly ITripService _tripsService;

    public TripsController(ITripService tripsService)
    {
        _tripsService = tripsService;
    }

    [HttpGet]
    public async Task<IActionResult> GetTrips()
    {
        var trips = await _tripsService.GetTrips();
        return Ok(trips);
    }
}