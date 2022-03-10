using System.ComponentModel.DataAnnotations;

namespace eMovieTicket.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        public string LogoURL { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships
        
        public List<Movie> Movies { get; set; }
        

    }
}