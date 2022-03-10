using System.ComponentModel.DataAnnotations;

namespace eMovieTicket.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string LogoURL { get; set; }
        public string Name { get; set; }
        public string Discrption { get; set; }

        //Relationships
        
        public List<Movie> Movies { get; set; }
        

    }
}