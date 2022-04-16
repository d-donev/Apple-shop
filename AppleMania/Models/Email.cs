using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppleMania.Models
{
    public class Email
    {
        public string Subject { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Message")]
        public string Body { get; set; }
        [Required(ErrorMessage = "Please enter your Email.")]
        [Display(Name = "Email")]
        public string UserEmail { get; set; }
        public string Password { get; set; }

    }
}