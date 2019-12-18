using rpg.Components.Models;
using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Models;
using rpg.Entities.Interfaces;
using rpg.Entities.Models;

namespace rpg.API.Creator.UnitFactory
{
    public class ArcherFactory : IUnitFactory
    {
        public Archer Unit { get; set; }

        public IUnit CreateUnit()
        {
            Unit = new Archer(0, new AttackComponent(15, 20),
                                 new HealthComponent(300),
                                 new ManaComponent(200),
                                 new ArmorComponent(1),
                                 new SkillComponent());
            Unit.SkillComponent.Skills.Add(SkillEnum.SHOT, new Shot(50, 100));
            return Unit;
        }
    }
}
