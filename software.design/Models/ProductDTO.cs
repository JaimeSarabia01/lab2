namespace Software.Design.Models;

public class ProductDTO
{
    public int tvshowid {get; set;}
    public string Name { get; set; } = default!;
    public int Length { get; set; }
    public DateTime TVShowDate { get; set; }

    public string Director {get; set; } =default!;
}