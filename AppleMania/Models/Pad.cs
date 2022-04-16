using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppleMania.Models
{
    public class Pad
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Display(Name = "Image")]
        public string ImageURL { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public string ReleaseDate { get; set; }
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "You must enter a valid value!")]
        [Display(Name = "Price")]
        public double Price { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Weigth { get; set; }
        public string Memory { get; set; }
        public string Camera { get; set; }
        public string Speakers { get; set; }
        [Display(Name = "OS")]
        public string Os { get; set; }
        public string Chip { get; set; }

    }
}