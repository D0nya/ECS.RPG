using System;
using rpg.Components.Skills.Enums;
using rpg.Systems.Interfaces;
using rpg.Systems.Interfaces.Actions;
using rpg.Systems.SkillStrategy;

namespace rpg.Systems.Models
{
    public class SkillSystem : ISkillSystem
    {

        private ISkillAction skillAction;

        /// <summary>
        /// Concrete class that will process action
        /// </summary>
        public ISkillStrategy SkillStrategy { get; set; } = null;
        /// <summary>
        /// Action to be processed
        /// </summary>
        public ISkillAction SkillAction 
        {
            get => skillAction;
            set
            {
                skillAction = value;
                switch (skillAction.Skill)
                {
                    case ActiveSkill.SHOT:
                        SkillStrategy = new ShotStrategy(skillAction);
                        break;
                    case ActiveSkill.HEAL:
                        SkillStrategy = new HealStrategy(skillAction);
                        break;
                    case ActiveSkill.FIREBALL:
                        SkillStrategy = new FireballStrategy(skillAction);
                        break;
                    default:
                        SkillStrategy = null;
                        break;
                }
            }
        }

        public SkillSystem()
        {
        }
        public SkillSystem(ISkillAction skillAction)
        {
            SkillAction = skillAction;
        }

        public void Execute()
        {
            if(SkillStrategy != null)
                SkillStrategy.Cast();
        }
    }
}
