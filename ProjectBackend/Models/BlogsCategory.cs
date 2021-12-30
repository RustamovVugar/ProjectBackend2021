using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class BlogsCategory
    {
        public int BlogsCategoryId { get; set; }
        public int BlogDetailId { get; set; }
        public BlogDetail Blogdetail { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
