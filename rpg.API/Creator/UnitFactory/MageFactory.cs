using System;
using rpg.Components.Models;
using rpg.Components.Skills.Enums;
using rpg.Components.Skills.Models;
using rpg.Entities.Interfaces;
using rpg.Entities.Models;

namespace rpg.API.Creator.UnitFactory
{
    public class MageFactory : IUnitFactory
    {
        public Mage Unit { get; set; }
        public IUnit CreateUnit()
        {
            Unit = new Mage(0, new AttackComponent(10, 15),
                                new HealthComponent(250),
                                new ManaComponent(500),
                                new ArmorComponent(0),
                                new SkillComponent());
            Unit.SkillComponent.ActiveSkills.Add(ActiveSkill.HEAL, new Heal(80, 70));
            Unit.SkillComponent.ActiveSkills.Add(ActiveSkill.FIREBALL, new FireBall(90, 150));
            return Unit;
        }
    }
}
