using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Date { get; set; }
        public string Image { get; set; }
        public ICollection<CoursesPost> CoursesPosts { get; set; }
        public ICollection<BlogsPost> BlogsPosts { get; set; }
        public ICollection<EventsPost> EventsPosts { get; set; }
    }
}
