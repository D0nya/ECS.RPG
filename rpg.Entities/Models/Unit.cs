using rpg.Components.Interfaces;
using rpg.Components.Skills.Interfaces;
using rpg.Entities.Interfaces;
using rpg.Entities.Models.Enums;
using System.Linq;

namespace rpg.Entities.Models
{
    /// <summary>
    /// Unit with components
    /// </summary>
    public abstract class Unit : IUnit
    {
        public abstract Units Name { get; }

        public IAttackComponent AttackComponent { get; set; }
        public IHealthComponent HealthComponent { get; set; }
        public IManaComponent ManaComponent { get; set; }
        public IArmorComponent ArmorComponent { get; set; }
        public ISkillComponent SkillComponent { get; set; }
        public bool IsDead 
        {
            get { return HealthComponent.HP <= 0; }
        }
        public int ID { get; set; }

        public Unit(int id, IAttackComponent attackComponent,
                                 IHealthComponent healthComponent,
                                 IManaComponent manaComponent,
                                 IArmorComponent armorComponent,
                                 ISkillComponent skillComponent)
        {
            ID = id;
            AttackComponent = attackComponent;
            HealthComponent = healthComponent;
            ManaComponent = manaComponent;
            ArmorComponent = armorComponent;
            SkillComponent = skillComponent;

            AttackComponent.Modifiers = SkillComponent.PassiveSkills
                                                 .Select(d => d.Value)
                                                 .Where(s => s is IAttackModifier)
                                                 .Cast<IAttackModifier>();
        }

        public override string ToString()
        {
            if (IsDead)
                return $"[{Name}] is dead.";
            return $"[{Name}]\t\t(Health: {HealthComponent.HP} Attack: {AttackComponent.MinDamage} - {AttackComponent.MaxDamage} MP: {ManaComponent.MP}" +
                   $" Armor: {ArmorComponent.Armor})";
        }
    }
}
