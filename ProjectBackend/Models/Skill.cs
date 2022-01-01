using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string Name { get; set; }
        public string Percent { get; set; }
        public ICollection<TeachersSkill> TeacherSkills{ get; set; }
    }
}
