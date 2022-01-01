using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public int BlogDetailId { get; set; }
        public virtual BlogDetail BlogDetail { get; set; }
    }
}
