
using System.ComponentModel.DataAnnotations;

namespace eMovieTicket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfileURL { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }

        //Relationships

        public List<Movie> Movies { get; set; }
        
    }
}