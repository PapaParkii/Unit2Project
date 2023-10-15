using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Unit2Project.Models
{
    public class Videogame 
    {
        public int VideogameID { get; set; }

        [Required(ErrorMessage = "Please Enter a Name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter a Year.")]
        [Range(1889, 2999, ErrorMessage = "Year Must be After 1899.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please Enter a Rating.")]
        [Range(1, 5, ErrorMessage = "Rating Must be Between 1 and 5.")]
        public int? Rating { get; set; }
    }
}
