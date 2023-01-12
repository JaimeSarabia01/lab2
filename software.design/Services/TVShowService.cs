using Microsoft.EntityFrameworkCore;
using Software.Design.DataModels;
using Software.Design.Models;

namespace Software.Design.Services;

public class TVShowService
{
    private readonly TVShowContext _dbContext;

    public TVShowService(TVShowContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<TVShow>> GetTVShows()
    {
        var tvshows = await _dbContext.TVShows.ToListAsync();
        return tvshows;
    }

    public async Task<TVShow> Create(TVShowDTO tvshowDTO)
    {
        var tvshow = new TVShow(tvshowDTO);

        await _dbContext.TVShows.AddAsync(tvshow);
        await _dbContext.SaveChangesAsync();
        return tvshow;
    }
}