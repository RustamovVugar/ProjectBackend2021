using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class EventsCategory
    {
        public int EventsCategoryId { get; set; }
        public int EventsDetailId { get; set; }
        public EventDetail EventDetail { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
