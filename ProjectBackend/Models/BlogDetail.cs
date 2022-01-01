using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class BlogDetail
    {
        public int BlogDetailId { get; set; }
        public string Detail { get; set; }

        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
        public ICollection<BlogsCategory> BlogsCategories { get; set; }
        public ICollection<BlogsPost> BlogsPosts { get; set; }
    }
}
