using rpg.Components.Interfaces;
using rpg.Entities.Interfaces;

namespace rpg.Entities.Models
{
    public class Archer : IUnit
    {
        public int ID { get; set; }
        public IAttackComponent AttackComponent { get; set; }
        public IHealthComponent HealthComponent { get; set; }
        public IManaComponent ManaComponent { get; set; }
        public IArmorComponent ArmorComponent { get; set; }
        public ISkillComponent SkillComponent { get; set; }
        public bool IsDead { get; set; } = false;
        public string Name => "Archer";

        public Archer(int id, IAttackComponent attackComponent,
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
