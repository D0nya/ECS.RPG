using System.Collections.Generic;
using rpg.Components.Interfaces;
using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Interfaces;

namespace rpg.Components.Models
{
    public class SkillComponent : ISkillComponent
    {
        public Dictionary<ActiveSkill, IActiveSkill> ActiveSkills { get; set; }
        public Dictionary<PassiveSkill, IPassiveSkill> PassiveSkills { get; set; }

        public SkillComponent()
        {
            ActiveSkills = new Dictionary<ActiveSkill, IActiveSkill>();
            PassiveSkills = new Dictionary<PassiveSkill, IPassiveSkill>();
        }
    }
}
