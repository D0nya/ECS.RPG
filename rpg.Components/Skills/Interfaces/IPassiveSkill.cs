using rpg.Components.Skills.Enums;

namespace rpg.Components.Skills.Interfaces
{
    /// <summary>
    /// Skill that can't be used. Has a constant effect.
    /// </summary>
    public interface IPassiveSkill
    {
        PassiveSkill Name { get; }
    }
}
