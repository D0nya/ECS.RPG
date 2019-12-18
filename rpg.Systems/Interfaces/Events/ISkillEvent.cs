using rpg.Components.Interfaces;
using rpg.Components.Skills.Enums;
using rpg.Entities.Interfaces;

namespace rpg.Systems.Interfaces.Events
{
    public interface ISkillEvent
    {
        ISkillComponent SkillComponent { get; set; }
        IUnit Target { get; set; }
        SkillEnum Skill { get; set; }
    }
}
