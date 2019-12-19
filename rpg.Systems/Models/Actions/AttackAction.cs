using rpg.Entities.Interfaces;
using rpg.Systems.Interfaces.Actions;

namespace rpg.Systems.Models.Actions
{
    public class AttackAction : IAttackAction
    {
        public IUnit Attacker { get; set; }
        public IUnit Target { get; set; }

        public AttackAction(IUnit attacker, IUnit target)
        {
            Attacker = attacker;
            Target = target;
        }
    }
}
