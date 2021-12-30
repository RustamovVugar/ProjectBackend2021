using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Spiker
    {
        public int SpikerId { get; set; }
        public string Image { get; set; }
        public string FullName { get; set; }
        public ICollection<EventsSpiker> EventsSpikers { get; set; }
    }
}
