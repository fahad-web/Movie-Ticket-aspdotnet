using System.ComponentModel.DataAnnotations;

namespace Movie_Ticket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string? ProfileUrl { get; set; }

        public string? FullName { get; set; }

        public string? Bio { get; set; }

        //Relationships

        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
