using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class EventsPost
    {
        public int EventsPostId { get; set; }
        public int EventDetailId { get; set; }
        public EventDetail EventDetail { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
