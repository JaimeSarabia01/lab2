namespace Software.Design.Models;

public class Product
{
    public Product()
    {
    }

    public Product(ProductDTO productDTO)
    {
        tvshowid = productDTO.tvshowid;
        tvshowname = productDTO.Name;
        tvshowlength = productDTO.Length;
        tvshowdate = productDTO.TVShowDate;
        Director = productDTO.Director;
    }

    public int tvshowid { get; private set; }
    public string tvshowname { get; private set; } = default!;
    public int tvshowlength { get; private set; }
    public DateTime tvshowdate { get; private set; }

    public String Director {get; private set; } = default!;
}