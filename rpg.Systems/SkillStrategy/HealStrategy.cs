using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Models;
using rpg.Entities.Interfaces;
using rpg.Systems.Interfaces.Actions;

namespace rpg.Systems.SkillStrategy
{
    public class HealStrategy : ISkillStrategy
    {
        public ActiveSkill Name => ActiveSkill.HEAL;
        public ISkillAction SkillAction { get; set; }

        public HealStrategy(ISkillAction skillAction)
        {
            SkillAction = skillAction;
        }

        public void Cast()
        {
            IUnit source = SkillAction.Source;
            IUnit target = SkillAction.Target;
            Heal heal = (Heal)source.SkillComponent.ActiveSkills[Name];

            if(source.ManaComponent.MP < heal.ManaCost)
            {
                System.Console.WriteLine("Not enough mana");
                return;
            }

            target.HealthComponent.HP += heal.HealAmount;
        }
    }
}
