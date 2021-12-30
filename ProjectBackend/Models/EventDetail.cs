using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class EventDetail
    {
        public int EventDetailId { get; set; }
        public string Detail { get; set; }
        [ForeignKey("Event")]
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
        public ICollection<EventsCategory> EventsCategories { get; set; }
        public ICollection<EventsSpiker> EventsSpikers { get; set; }
    }
}
