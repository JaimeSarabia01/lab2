namespace Software.Design.Models;

public class TVShow
{
    public TVShow()
    {
    }

    public TVShow(TVShowDTO TVShowDTO)
    {
        tvshowid = TVShowDTO.tvshowid;
        tvshowname = TVShowDTO.Name;
        tvshowlength = TVShowDTO.Length;
        tvshowdate = TVShowDTO.TVShowDate;
        Director = TVShowDTO.Director;
    }

    public int tvshowid { get; private set; }
    public string tvshowname { get; private set; } = default!;
    public int tvshowlength { get; private set; }
    public DateTime tvshowdate { get; private set; }

    public String Director {get; private set; } = default!;
}