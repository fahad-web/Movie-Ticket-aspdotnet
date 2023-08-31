using Movie_Ticket.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie_Ticket.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public  string? Description { get; set; }

        public string? Price { get; set; }

        public string? ImageUrl  { get; set; }

        public DateTime EndDate { get; set; }

        public Moviecategory MovieCategory { get; set; }

        //Relationships

        public List<Actor_Movie>? Actors_Movies { get; set; }

        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]

        public Cinema? Cinema { get; set; }

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]

        public Producer? Producer { get; set; }
    }
}
