using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreetUp.Models
{
    public class CodeEvent
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
    }
}