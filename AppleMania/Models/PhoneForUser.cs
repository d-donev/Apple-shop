using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppleMania.Models
{
    public class PhoneForUser
    {

            [Key]
            public int Id { get; set; }
            public string PhoneName { get; set; }
            public int PhoneId { get; set; }
            public string UserId { get; set; }

    }
}