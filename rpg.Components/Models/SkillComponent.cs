using System.Collections.Generic;
using rpg.Components.Interfaces;
using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Interfaces;

namespace rpg.Components.Models
{
    public class SkillComponent : ISkillComponent
    {
        public Dictionary<SkillEnum, ISkill> Skills { get; set; }

        public SkillComponent()
        {
            Skills = new Dictionary<SkillEnum, ISkill>();
        }
    }
}
