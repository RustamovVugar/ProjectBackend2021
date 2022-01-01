using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class NoticeBoard
    {
        public int NoticeBoardId { get; set; }
        public string Date { get; set; }
        public string Text { get; set; }
    }
}
