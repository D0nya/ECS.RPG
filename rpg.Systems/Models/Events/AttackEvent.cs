using rpg.Components.Interfaces;
using rpg.Entities.Interfaces;
using rpg.Systems.Interfaces.Events;

namespace rpg.Systems.Models.Events
{
    public class AttackEvent : IAttackEvent
    {
        public IAttackComponent Attack { get; set; }
        public IUnit Target { get; set; }

        public AttackEvent(IAttackComponent attackComponent, IUnit target)
        {
            Attack = attackComponent;
            Target = target;
        }
    }
}
