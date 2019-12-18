using rpg.Components.Interfaces;
using rpg.Entities.Interfaces;

namespace rpg.Systems.Interfaces.Events
{
    public interface IAttackEvent
    {
        IAttackComponent Attack { get; set; }
        IUnit Target { get; set; }
    }
}
