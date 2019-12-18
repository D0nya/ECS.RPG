using rpg.Components.Interfaces;

namespace rpg.Entities.Interfaces
{
    public interface IUnit : IEntity
    {
        string Name { get; }
        IAttackComponent AttackComponent { get; set; }
        IHealthComponent HealthComponent { get; set; }
        IManaComponent ManaComponent { get; set; }
        IArmorComponent ArmorComponent { get; set; }
        ISkillComponent SkillComponent { get; set; }
        bool IsDead { get; set; }
    }
}
