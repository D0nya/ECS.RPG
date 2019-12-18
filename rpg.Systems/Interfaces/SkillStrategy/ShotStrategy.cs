using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Models;
using rpg.Entities.Interfaces;
using rpg.Systems.Interfaces.Events;

namespace rpg.Systems.Interfaces.SkillStrategy
{
    public class ShotStrategy : ISkillStrategy
    {
        public SkillEnum Name => SkillEnum.SHOT;
        public ISkillEvent SkillEvent { get; set; }
        public ShotStrategy(ISkillEvent skillEvent)
        {
            SkillEvent = skillEvent;
        }

        public void Cast()
        {
            IUnit target = SkillEvent.Target;
            Shot shot = (Shot)SkillEvent.SkillComponent.Skills[Name];

            int damage = shot.Damage;
            int armor = target.ArmorComponent.Armor;
            int finalDamage = damage - armor;

            target.HealthComponent.HP -= finalDamage;
        }
    }
}
