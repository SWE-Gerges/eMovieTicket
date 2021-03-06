using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eMovieTicket.Data;

namespace eMovieTicket.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public double Price { get; set; }
        public string ImgURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships

        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        public int CinemaID { get; set; }
        [ForeignKey("CinemaID")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerID { get; set; }
        [ForeignKey("ProducerID")]
        public Producer Producer { get; set; }

    }
}