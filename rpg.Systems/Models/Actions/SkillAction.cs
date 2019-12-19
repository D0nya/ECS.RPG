using rpg.Components.Skills.Enums;
using rpg.Entities.Interfaces;
using rpg.Systems.Interfaces.Actions;

namespace rpg.Systems.Models.Actions
{
    public class SkillAction : ISkillAction
    {
        public IUnit Source { get; set; }
        public IUnit Target { get; set; }
        public ActiveSkill Skill { get; set; }

        public SkillAction(IUnit source, IUnit target, ActiveSkill skill)
        {
            Source = source;
            Target = target;
            Skill = skill;
        }
    }
}
