using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string UserName { get; set; }
        public string Date { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public int BlogDetailId { get; set; }
        public virtual BlogDetail BlogDetail { get; set; }
    }
}
