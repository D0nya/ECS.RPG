namespace rpg.Components.Skills.Interfaces
{
    /// <summary>
    /// Modifer that applies to damage on attack
    /// </summary>
    public interface IAttackModifier
    {
        void Modify(ref int damage);
    }
}
