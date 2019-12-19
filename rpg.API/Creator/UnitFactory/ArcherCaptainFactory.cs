using rpg.Components.Models;
using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Models;
using rpg.Entities.Interfaces;
using rpg.Entities.Models;

namespace rpg.API.Creator.UnitFactory
{
    public class ArcherCaptainFactory : IUnitFactory
    {
        public ArcherCaptain Unit { get; set; }
        public IUnit CreateUnit()
        {
            Unit = new ArcherCaptain(0, new AttackComponent(30, 35),
                                        new HealthComponent(600),
                                        new ManaComponent(200),
                                        new ArmorComponent(1),
                                        new SkillComponent());
            Unit.SkillComponent.ActiveSkills.Add(ActiveSkill.SHOT, new Shot(50, 150));
            return Unit;
        }
    }
}
