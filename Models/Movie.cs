using System.ComponentModel.DataAnnotations;

namespace Farneti.MIchele._5H.webCRUD.Models
{
    public class Movie
    {
    public int Id { get; set; }

    [Display(Name = "Titolo", Prompt = "Inserire il titolo...", Description = "Inserisci una descrizione" )]
    public string? Title { get; set; }

    [Display(Name = "Data d'uscita", Prompt = "Inserire la data d'uscita...", Description = "Inserisci la data d'uscita" )]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Display(Name = "Genere", Prompt = "Inserire il genere...", Description = "Inserisci il genere" )]
    public string? Genre { get; set; }

    [Display(Name = "Prezzo", Prompt = "Inserire il prezzo...", Description = "Inserisci il prezzo" )]
    public decimal Price { get; set; }

    }
}