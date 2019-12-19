using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Models;
using rpg.Entities.Interfaces;
using rpg.Systems.Interfaces.Actions;

namespace rpg.Systems.SkillStrategy
{
    public class ShotStrategy : ISkillStrategy
    {
        public ActiveSkill Name => ActiveSkill.SHOT;
        public ISkillAction SkillAction { get; set; }
        public ShotStrategy(ISkillAction skillAction)
        {
            SkillAction = skillAction;
        }

        public void Cast()
        {
            IUnit source = SkillAction.Source;
            IUnit target = SkillAction.Target;
            Shot shot = (Shot)source.SkillComponent.ActiveSkills[Name];

            if(source.ManaComponent.MP < shot.ManaCost)
            {
                System.Console.WriteLine("Not enough mana");
                return;
            }

            int damage = shot.Damage;
            int armor = target.ArmorComponent.Armor;
            int finalDamage = damage - armor;

            target.HealthComponent.HP -= finalDamage;
            source.ManaComponent.MP -= shot.ManaCost;
        }
    }
}
