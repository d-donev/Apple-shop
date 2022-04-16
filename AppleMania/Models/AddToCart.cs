using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppleMania.Models
{
    public class AddToCart
    {

            public int PhoneId { get; set; }
            public List<Phone> Phones { get; set; }
            public AddToCart()
            {
                Phones = new List<Phone>();
            }


    }
}