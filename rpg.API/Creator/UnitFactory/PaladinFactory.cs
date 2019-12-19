using rpg.Components.Models;
using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Models;
using rpg.Entities.Interfaces;
using rpg.Entities.Models;

namespace rpg.API.Creator.UnitFactory
{
    public class PaladinFactory : IUnitFactory
    {
        public Paladin Unit { get; set; }
        public IUnit CreateUnit()
        {
            Unit = new Paladin(0, new AttackComponent(40, 50),
                                  new HealthComponent(700),
                                  new ManaComponent(300),
                                  new ArmorComponent(5),
                                  new SkillComponent());
            Unit.SkillComponent.PassiveSkills.Add(PassiveSkill.CRITICAL_STRIKE, new CriticalStrike(0.3, 3));
            Unit.SkillComponent.ActiveSkills.Add(ActiveSkill.HEAL, new Heal(100, 100));
            return Unit;
        }
    }
}
