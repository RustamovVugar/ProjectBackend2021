using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FullName { get; set; }
        public string Profession { get; set; }
        public string Photo { get; set; }
        public int TeacherDetailId { get; set; }
        public virtual TeacherDetail TeacherDetail { get; set; }
    }
}
