using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Unit2Project.Models
{
    public class Videogame 
    {
        //validation and errors
        public int VideogameID { get; set; }

        [Required(ErrorMessage = "Please Enter a Name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter a Year.")]
        [Range(1972, 2999, ErrorMessage = "Year Must be After 1972.")]
        public int? YearReleased { get; set; }

        [Required(ErrorMessage = "Please Enter a Rating.")]
        [Range(1, 5, ErrorMessage = "Rating Must be Between 1 and 5.")]
        public int? Rating { get; set; }
    }
}
