using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class CoursesCategory
    {
        public int CoursesCategoryId { get; set; }
        public int CourseDetailId { get; set; }
        public CourseDetail CourseDetail { get; set; }
        public int CategoryId { get; set; }
        public Category Category{ get; set; }
    }
}
