using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleMVCApp.Models;

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
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    public string? Rating { get; set; }
}