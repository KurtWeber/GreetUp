﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GreetUp.Models
{
    public class RSVP
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Response { get; set; }
        [Display(Name = "Number of Guests")]
        public int GuestNum { get; set; }
        [Display(Name = "Email Address")]
        public string Email { get; set; }
            
        [ForeignKey ("CodeEvent") ]
        public int EventID { get; set; }
        public virtual CodeEvent CodeEvent { get; set; }
    }
}