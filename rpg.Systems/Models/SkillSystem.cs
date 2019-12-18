using System;
using rpg.Components.Skills.Enums;
using rpg.Systems.Interfaces;
using rpg.Systems.Interfaces.Events;
using rpg.Systems.Interfaces.SkillStrategy;

namespace rpg.Systems.Models
{
    public class SkillSystem : ISkillSystem
    {
        public event Action SkillCasts;
        public ISkillEvent SkillEvent { get; set; }
        public ISkillStrategy skillStrategy { get; set; } = null;
        
        public SkillSystem(ISkillEvent skillEvent)
        {

            SkillEvent = skillEvent;
            switch(skillEvent.Skill)
            {
                case SkillEnum.SHOT:
                    skillStrategy = new ShotStrategy(skillEvent);
                    break;
            }
        }

        public void Execute()
        {
            if(SkillCasts != null)
                SkillCasts.Invoke();
            skillStrategy.Cast();
        }
    }
}
