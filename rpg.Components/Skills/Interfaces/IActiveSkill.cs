using rpg.Components.Skills.Enums;

namespace rpg.Components.Skills.Interfaces
{
    /// <summary>
    /// Skill that can be used
    /// </summary>
    public interface IActiveSkill
    {
        ActiveSkill Name { get; }
        int ManaCost { get; set; }
    }
}
