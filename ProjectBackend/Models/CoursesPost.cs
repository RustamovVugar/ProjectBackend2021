using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class CoursesPost
    {
        public int CoursesPostId { get; set; }
        public int CourseDetailId { get; set; }
        public CourseDetail CourseDetail { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
