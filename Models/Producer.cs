using System.ComponentModel.DataAnnotations;

namespace Movie_Ticket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string? ProfileUrl { get; set; }

        public string? FullName { get; set; }

        public string? Bio { get; set; }

        //RelationShip 

        public List<Movie>? Movies { get; set; }
    }
}
