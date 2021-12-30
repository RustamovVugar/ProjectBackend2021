using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class EventsSpiker
    {
        public int EventsSpikerId { get; set; }
        public int EventDetailId { get; set; }
        public EventDetail EventDetail { get; set; }
        public int SpikerId { get; set; }
        public Spiker Spiker { get; set; }
    }
}
