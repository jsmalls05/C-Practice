using System.ComponentModel.DataAnnotations;
using System;
namespace DojoSurvey.Models
{
    public class Survey
    {
        [Required(ErrorMessage = "Must have 2 characters")]
        [MinLength(2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Must select Location")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Must select Language")]
        public string FavLanguage { get; set; }

        [Required(ErrorMessage = "Comment no longer than 20 characters")]
        [MaxLength(20)]
        public string Comment { get; set; } 
    }
}