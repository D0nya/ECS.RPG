namespace rpg.Components.Interfaces
{
    public interface IAttackComponent : IComponent
    {
        int MinDamage { get; set; }
        int MaxDamage { get; set; }
    }
}
