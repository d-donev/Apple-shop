using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppleMania.Models
{
    public class Rate
    {
        [Key]
        public int Id { get; set; }
        public string User { get; set; }
        public string Date { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
    }
}