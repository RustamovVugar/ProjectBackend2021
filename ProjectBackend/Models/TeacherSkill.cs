using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class TeacherSkill
    {
        public int TeacherSkillId { get; set; }
        public int TeacherDetailId { get; set; }
        public TeacherDetail TeacherDetail { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
