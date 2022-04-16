using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppleMania.Models
{
    public class Phone
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
        [Range(0,Int32.MaxValue, ErrorMessage ="You must enter a valid value!")]
        [Display(Name = "Price")]
        public double Price { get; set; }

        public string Dimensions { get; set; }
        [Display(Name ="Dispay Size")]
        public string DisplaySize { get; set; }
        public string Sim { get; set; }
        [Display(Name = "OS")]
        public string Os { get; set; }
        public string Memory { get; set; }
        [Display(Name = "Back Camera")]
        public string BackCamera { get; set; }
        [Display(Name = "Front Camera")]
        public string FrontCamera { get; set; }
        public string Battery { get; set; }

    }
}