using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Software.Design.Services;

namespace Software.Design.Models.Controllers;

[ApiController]
[Route("api/TVShows")]
public class TVShowController : ControllerBase
{
    private readonly ILogger<TVShowController> _logger;
    private readonly TVShowService _tvshowService;


    public TVShowController(
        ILogger<TVShowController> logger,
        TVShowService tvshowService)
    {
        _logger = logger;
        _tvshowService = tvshowService;
    }

    [HttpGet]
    public async Task<ActionResult<List<TVShow>>> GetTVShows()
    {
        var tvshows = await _tvshowService.GetTVShows();
        return Ok(tvshows);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<object>> GetTVShow(Guid id)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<ActionResult<object>> CreateTVShow(TVShowDTO tvshowDTO)
    {
        var tvshow = await _tvshowService.Create(tvshowDTO);
        return Created(tvshow);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<object>> UpdateTVShow(Guid id)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<object>> DeleteTVShow(Guid id)
    {
        return NoContent();
    }


    private ObjectResult Created(object value)
    {
        return StatusCode(201, value);
    }
}
