using rpg.Components.Interfaces;
using rpg.Entities.Interfaces;

namespace rpg.Systems.Interfaces.Actions
{
    /// <summary>
    /// Contains information about attacker and target
    /// </summary>
    public interface IAttackAction
    {
        IUnit Attacker { get; set; }
        IUnit Target { get; set; }
    }
}
