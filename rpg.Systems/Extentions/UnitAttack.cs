using rpg.Entities.Interfaces;
using rpg.Systems.Interfaces.Events;
using rpg.Systems.Models;
using rpg.Systems.Models.Events;

namespace rpg.Systems.Extentions
{
    public static class UnitAttack
    {
        public static void Attack(this IUnit attacker, IUnit target)
        {
            IAttackEvent attackEvent = new AttackEvent(attacker.AttackComponent, target);
            AttackSystem attackSystem = new AttackSystem(attackEvent);

            attackSystem.Execute();
        }
    }
}
