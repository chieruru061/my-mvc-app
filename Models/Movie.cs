using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [Display(Name = "タイトル")]
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    [Display(Name = "リリース日")]
    public DateTime ReleaseDate { get; set; }
    [Display(Name = "ジャンル")]
    public string? Genre { get; set; }
    [Display(Name = "値段")]
    public decimal Price { get; set; }
}