using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public string FacebookLink { get; set; }
        public string PinterestLink { get; set; }
        public string VContactLink { get; set; }
        public int TeacherDetailId { get; set; }
        public TeacherDetail TeacherDetail { get; set; }
    }
}
