using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Interfaces;
using System.Collections.Generic;

namespace rpg.Components.Interfaces
{
    public interface ISkillComponent : IComponent
    {
        Dictionary<SkillEnum, ISkill> Skills { get; set; }
    }
}
