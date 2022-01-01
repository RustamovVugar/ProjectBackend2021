using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class BlogsPost
    {
        public int BlogsPostId { get; set; }
        public int BlogDetailId { get; set; }
        public BlogDetail BlogDetail { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }

}
