using rpg.Components.Skills.Enums;
using rpg.Entities.Interfaces;
using rpg.Systems.Interfaces.Actions;
using rpg.Systems.Manager;
using rpg.Systems.Models.Actions;

namespace rpg.Systems.Extentions
{
    public static class UnitUseSkill
    {
        /// <summary>
        /// Creates and processes skill cast action
        /// </summary>
        /// <param name="source">Unit which uses skill</param>
        /// <param name="target">Unit affected by skill</param>
        /// <param name="skill">Casted skill name</param>
        public static void UseSkill(this IUnit source, IUnit target, ActiveSkill skill)
        {
            ISkillAction skillAction = new SkillAction(source, target, skill);
            SystemHandler.Execute(skillAction);
        }
    }
}
