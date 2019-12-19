using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Interfaces;
using System.Collections.Generic;

namespace rpg.Components.Interfaces
{
    /// <summary>
    /// Contains units active and passive skills
    /// </summary>
    public interface ISkillComponent : IComponent
    {
        Dictionary<ActiveSkill, IActiveSkill> ActiveSkills { get; set; }
        Dictionary<PassiveSkill, IPassiveSkill> PassiveSkills { get; set; }
    }
}
