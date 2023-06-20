using Humanizer;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }
    //The Display attribute specifies what to display for the name of a field
    //(in this case "Release Date" instead of "ReleaseDate")
    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    //required so Entity Framework Core can correctly map Price to currency in the database
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}