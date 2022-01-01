using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Image { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public string Venue { get; set; }
        public int EventDetailId { get; set; }
        public virtual EventDetail EventDetail { get; set; }
    }
}
