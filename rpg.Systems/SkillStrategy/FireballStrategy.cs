using System;
using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Models;
using rpg.Entities.Interfaces;
using rpg.Systems.Interfaces.Actions;

namespace rpg.Systems.SkillStrategy
{
    public class FireballStrategy : ISkillStrategy
    {
        public ActiveSkill Name => ActiveSkill.FIREBALL;

        public ISkillAction SkillAction { get; set; }

        public FireballStrategy(ISkillAction skillAction)
        {
            SkillAction = skillAction;
        }

        public void Cast()
        {
            IUnit source = SkillAction.Source;
            IUnit target = SkillAction.Target;
            FireBall fireball = (FireBall)source.SkillComponent.ActiveSkills[Name];

            if(source.ManaComponent.MP < fireball.ManaCost)
            {
                Console.WriteLine("Not enough mana");
                return;
            }

            int damage = fireball.Damage;
            int armor = target.ArmorComponent.Armor;
            int finalDamage = damage - armor;

            target.HealthComponent.HP -= finalDamage;
            source.ManaComponent.MP -= fireball.ManaCost;
        }
    }
}
