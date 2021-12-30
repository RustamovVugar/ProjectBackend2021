using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class TeacherDetail
    {
        public int TeacherDetailId { get; set; }
        public string Title { get; set; }
        public string Degree { get; set; }
        public string Experience { get; set; }
        public string Hobbies { get; set; }
        public string Faculty { get; set; }
        public string About { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Skype { get; set; }

        [ForeignKey("Teacher")]

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public ICollection <SocialMedia>SociaMedias { get; set; }
        public ICollection <TeacherSkill> TeacherSkills { get; set; }
    }
}
