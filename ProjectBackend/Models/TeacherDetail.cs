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
        public int SkillId { get; set; }
        public virtual Skill Skill { get; set; }
        [ForeignKey("SocialMedia")]
        public int SocialMediId { get; set; }
        public virtual SocialMedia SocialMedia { get; set; }
        public int TeachersSkillId { get; set; }
        
    }
}
