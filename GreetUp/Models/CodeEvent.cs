using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreetUp.Models
{
    public class CodeEvent
    {
        public int Id { get; set; }
        [Display(Name = "Event")]
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
    }
}