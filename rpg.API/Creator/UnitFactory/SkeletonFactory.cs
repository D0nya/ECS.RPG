using rpg.Components.Models;
using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Models;
using rpg.Entities.Interfaces;
using rpg.Entities.Models;

namespace rpg.API.Creator.UnitFactory
{
    public class SkeletonFactory : IUnitFactory
    {
        public Skeleton Unit { get; set; }
        public IUnit CreateUnit()
        {
            Unit = new Skeleton(0, new AttackComponent(5, 8),
                                   new HealthComponent(180),
                                   new ManaComponent(0),
                                   new ArmorComponent(1),
                                   new SkillComponent());
            Unit.SkillComponent.PassiveSkills.Add(PassiveSkill.CRITICAL_STRIKE, new CriticalStrike(0.2, 2));
            return Unit;
        }
    }
}
