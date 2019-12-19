using rpg.Components.Skills.Enums;
using rpg.Entities.Interfaces;

namespace rpg.Systems.Interfaces.Actions
{
    /// <summary>
    /// Contains information about skill using
    /// </summary>
    public interface ISkillAction
    {
        IUnit Source { get; set; }
        IUnit Target { get; set; }
        ActiveSkill Skill { get; set; }
    }
}
