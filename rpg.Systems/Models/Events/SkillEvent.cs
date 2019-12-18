using rpg.Components.Interfaces;
using rpg.Components.Skills.Enums;
using rpg.Entities.Interfaces;
using rpg.Systems.Interfaces.Events;

namespace rpg.Systems.Models.Events
{
    public class SkillEvent : ISkillEvent
    {
        public ISkillComponent SkillComponent { get; set; }
        public IUnit Target { get; set; }
        public SkillEnum Skill { get; set; }

        public SkillEvent(ISkillComponent skillComponent, IUnit target, SkillEnum skill)
        {
            SkillComponent = skillComponent;
            Target = target;
            Skill = skill;
        }
    }
}
