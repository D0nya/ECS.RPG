using rpg.Components.Models;
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
            return Unit;
        }
    }
}
