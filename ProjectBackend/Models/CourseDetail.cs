using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class CourseDetail
    {
        public int CourseDetailId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public string Type3 { get; set; }
        public string Subtitle1 { get; set; }
        public string Subtitle2 { get; set; }
        public string Subtitle3 { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        [ForeignKey("CourseFeature")]
        public int CourseFeature { get; set; }
        public virtual CourseFeaturen CourseFeature { get; set; }
        public ICollection<CoursesCategory> CoursesCategories{ get; set; }


    }
}
