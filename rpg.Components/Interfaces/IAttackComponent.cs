using rpg.Components.Skills.Interfaces;
using System.Collections.Generic;

namespace rpg.Components.Interfaces
{
    /// <summary>
    /// Contains unit damage and attack modifiers
    /// </summary>
    public interface IAttackComponent : IComponent
    {
        int MinDamage { get; set; }
        int MaxDamage { get; set; }
        IEnumerable<IAttackModifier> Modifiers { get; set; }
    }
}
