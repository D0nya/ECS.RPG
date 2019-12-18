using rpg.Components.Models;
using rpg.Entities.Interfaces;
using rpg.Entities.Models;

namespace rpg.API.Creator.UnitFactory
{
    public class SwordsManFactory : IUnitFactory
    {
        public SwordsMan Unit { get; set; }

        public IUnit CreateUnit()
        {
            Unit = new SwordsMan(0, new AttackComponent(20, 30),
                                    new HealthComponent(500),
                                    new ManaComponent(0),
                                    new ArmorComponent(2),
                                    new SkillComponent());
            return Unit;
        }
    }
}
