using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<CoursesCategory> CoursesCategories { get; set; }
        public ICollection<EventsCategory> EventCategories { get; set; }
        public ICollection<BlogtsCategory> BlogCategories { get; set; }
    }
}
