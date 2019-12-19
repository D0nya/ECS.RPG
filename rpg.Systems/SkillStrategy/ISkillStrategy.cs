using rpg.Components.Skills.Enums;
using rpg.Systems.Interfaces.Actions;

namespace rpg.Systems.SkillStrategy
{
    /// <summary>
    /// Strategy of <see cref="ISkillAction"/>s processing
    /// </summary>
    public interface ISkillStrategy
    {
        ActiveSkill Name { get; }
        ISkillAction SkillAction { get; set; }
        /// <summary>
        /// Method that contains logic of skill
        /// </summary>
        void Cast();
    }
}
