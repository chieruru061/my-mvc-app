using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleMVCApp.Models;

public class Movie
{
    // Validation 書式設定属性について
    // [Required] 及び [MinimunLength] プロパティに値が必要であること
    // [RegularExpression] 入力できる文字を制限する
    // [Range] 指定した範囲内に値を制限する
    // [StringLength] 文字列の最大長を設定する

    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    [Display(Name = "タイトル")]
    public string? Title { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "リリース日")]
    public DateTime ReleaseDate { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]
    [Display(Name = "ジャンル")]
    public string? Genre { get; set; }

    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Display(Name = "値段")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [StringLength(5)]
    [Required]
    public string? Rating { get; set; }
}